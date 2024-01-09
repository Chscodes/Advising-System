Imports MySql.Data.MySqlClient
Imports System.Net.Mail ' email verificatrion message
Public Class Form10
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=db_advisng;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Dim auto As String = "" 'for auto generate code
    Dim rndm As Random = New Random() 'for auto generate code

    Dim cd As New TimeSpan() 'automatic cooldown time
    Dim cd2 As New TimeSpan() 'automatic cooldown time for resendcode
    '--------------------------------------------Public SUBS OF System Form 10-----------------------------------------------------------'
    Public Sub check()
        'Dim frm8 As New Form8  'para sa pag tawag ng public sub mula sa form8 (Not Done)
        connection.Open()
        command = New MySqlCommand("select * from tbl_verification where code='" & TextBox1.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim Vcode As Integer
        Vcode = 0
        While dataReader.Read
            Vcode = Vcode + 1
        End While
        If Vcode = 1 Then
            TextBox1.Clear()
            Me.Hide()
            Form1.Show()
            MessageBox.Show("Your Registration is Successfully Saved!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please Check your Verication Code", "Invalid!!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        connection.Close()
        connection.Open()
        command = New MySqlCommand("Delete from tbl_verification where Code ='" & TextBox1.Text & "'", connection)
        dataReader = command.ExecuteReader
        connection.Close()

    End Sub

    Public Sub intrnt() ' if no internet
        If System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable = False Then
            MessageBox.Show("You Dont Have an Internet Connection!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Email()
        End If
    End Sub
    Public Sub Email() ' send adviser email verification and save to database vefication code

        Dim mail As New MailMessage
        Dim smtpServer As New SmtpClient("smtp.gmail.com")
        mail.From = New MailAddress(txtfrom.Text)
        mail.To.Add(txtemail.Text)
        mail.Subject = txtsubject.Text
        mail.Body = txtbody.Text & txtcode.Text

        smtpServer.Port = 587
        smtpServer.Credentials = New System.Net.NetworkCredential(txtfrom.Text, txtpass.Text)
        smtpServer.EnableSsl = True
        smtpServer.Send(mail)

        connection.Open()
        command = New MySqlCommand("Insert into tbl_verification (code) values (@vCode)", connection)
        command.Parameters.Add(New MySqlParameter("@vCode", MySqlDbType.VarChar, 50)).Value = txtcode.Text
        command.ExecuteNonQuery()
        connection.Close()

        MessageBox.Show("Verification Code Sent", "Check your Email", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Public Sub Code() 'generate code
        For Code As Integer = 1 To 4
            auto = Date.Now.Year
            If Code = 4 Then
                auto += "_"
            End If
        Next
        For Code As Integer = 1 To 4
            auto += Convert.ToString(rndm.Next(0, 9))
        Next

        txtcode.Text = auto
        If txtcode.Text = auto Then
            auto = Nothing
        End If
    End Sub

    '--------------------------------------------Private SUBS OF System Form 10-----------------------------------------------------------'

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        check()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        intrnt()
        lblRC.Visible = True
        Button2.Enabled = False
        If Timer2.Enabled = False Then 'para sa resend code activation
            Timer2.Start()
            cd2 = New TimeSpan(0, CInt("1"), 0)
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cd = cd.Subtract(New TimeSpan(0, 0, 1))
        lbltimecode.Text = String.Format("{0} mins : {1} Secs", cd.Minutes, cd.Seconds)
        If cd.Minutes = 0 AndAlso cd.Seconds = 0 Then
            cd = New TimeSpan(0, CInt("1"), 0)
            Code()
        End If
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtemail.Text = Form8.txtemail.Text 'para mapasa ang text sa texbox galing form8
        Code()
        Timer1.Start()
        cd = New TimeSpan(0, CInt("1"), 0)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        cd2 = cd2.Subtract(New TimeSpan(0, 0, 1))
        lblRC.Text = String.Format("{0} Secs", cd2.Seconds)
        If cd2.Seconds = 0 Then
            cd2 = New TimeSpan(0, CInt("1"), 0)
            Timer2.Stop()
            lblRC.Visible = False
            Button2.Enabled = True
        End If
    End Sub

End Class