Imports MySql.Data.MySqlClient 'mysql datbase
Imports System.Net.Mail ' email verificatrion message
Public Class Form8
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=db_advisng;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Dim auto As String = "" 'for auto generate code
    Dim rndm As Random = New Random() 'for auto generate code

    Dim cd As New TimeSpan() 'automatic cooldown time



    '--------------------------------------------Public SUBS OF System Form 8-----------------------------------------------------------'
    Public Sub Register_AD()
        connection.Open()
        command = New MySqlCommand("Insert into tbl_adviser (col_Username, col_Pass, col_Name, col_Birthday, col_Age, col_Gender, col_coreP1, col_verCode, col_email) values (@US, @Pass, @Name, @Birthdate, @Age, @Gender,@coreP1, @vC, @email)", connection)
        command.Parameters.Add(New MySqlParameter("@US", MySqlDbType.VarChar, 50)).Value = TextBox1.Text
        command.Parameters.Add(New MySqlParameter("@Pass", MySqlDbType.VarChar, 50)).Value = TextBox2.Text
        command.Parameters.Add(New MySqlParameter("@Name", MySqlDbType.VarChar, 50)).Value = TextBox3.Text
        command.Parameters.Add(New MySqlParameter("@Birthdate", DateTimePicker1.Value.Date))
        command.Parameters.Add(New MySqlParameter("@Age", MySqlDbType.VarChar, 50)).Value = TextBox4.Text
        command.Parameters.Add(New MySqlParameter("@Gender", MySqlDbType.VarChar, 50)).Value = ComboBox1.Text
        command.Parameters.Add(New MySqlParameter("@coreP1", MySqlDbType.VarChar, 50)).Value = TextBox5.Text
        command.Parameters.Add(New MySqlParameter("@vC", MySqlDbType.VarChar, 50)).Value = TextBox7.Text
        command.Parameters.Add(New MySqlParameter("@email", MySqlDbType.VarChar, 50)).Value = txtemail.Text
        command.ExecuteNonQuery()
        connection.Close()
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

        TextBox7.Text = auto
        If TextBox7.Text = auto Then
            auto = Nothing
        End If
    End Sub
    Public Sub Email() ' send adviser email verification and save to database vefication code
        Try
            Dim mail As New MailMessage
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress(TextBox8.Text)
            mail.To.Add(txtemail.Text)
            mail.Subject = TextBox11.Text
            mail.Body = TextBox12.Text & TextBox7.Text

            smtpServer.Port = 587
            smtpServer.Credentials = New System.Net.NetworkCredential(TextBox8.Text, TextBox9.Text)
            smtpServer.EnableSsl = True
            smtpServer.Send(mail)

            connection.Open()
            command = New MySqlCommand("Insert into tbl_verification (code) values (@vCode)", connection)
            command.Parameters.Add(New MySqlParameter("@vCode", MySqlDbType.VarChar, 50)).Value = TextBox7.Text
            command.ExecuteNonQuery()
            connection.Close()

            MessageBox.Show("Verification Code Sent", "Check your Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form10.ShowDialog()
            Register_AD()
            clear()
            Me.Hide()

        Catch
            MessageBox.Show("Please Check the input Gmail properly!")
        End Try
    End Sub
    Public Sub intrnt() ' if no internet
        If System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable = False Then
            MessageBox.Show("You Dont Have an Internet Connection!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Email()

        End If
    End Sub

    '--------------------------------------------Private SUBS OF System Form 8-----------------------------------------------------------'

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
        Dim myage As New Integer

        myage = DateTime.Today.Year - DateTimePicker1.Value.Year
        TextBox4.Text = myage.ToString()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cd = cd.Subtract(New TimeSpan(0, 0, 1))
        Label9.Text = String.Format("{0} mins : {1} Secs", cd.Minutes, cd.Seconds)
        If cd.Minutes = 0 AndAlso cd.Seconds = 0 Then
            cd = New TimeSpan(0, CInt("1"), 0)
            Code()
        End If
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Code()
        Timer1.Start()
        cd = New TimeSpan(0, CInt("1"), 0)

    End Sub
    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim myage As New Integer

        myage = DateTime.Today.Year - DateTimePicker1.Value.Year
        TextBox4.Text = myage.ToString()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox2.Text <> TextBox10.Text Then
            MessageBox.Show("Please Input same Passwords", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf textbox5.Text <> TextBox6.Text Then
            MessageBox.Show("Please Input same Recovery Code", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Label15.Visible = True Then
            MessageBox.Show("This Username is Already Taken", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Or textbox5.text = Nothing Or Textbox6.Text = Nothing Or TextBox10.Text = Nothing Or txtemail.Text = Nothing Then
            MessageBox.Show("Please fill the empty textboxes!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            intrnt()
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'For Unique username
        connection.Open()
        command = New MySqlCommand("select * from tbl_adviser where col_Username='" & TextBox1.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim username As Integer
        username = 0
        While dataReader.Read
            username = username + 1
        End While

        If username = 1 Then
            Label15.Visible = True
        Else
            Label15.Visible = False
            connection.Close()
            connection.Close()
        End If
        connection.Close()
    End Sub
    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox10.Clear()
        TextBox5.Clear()
        ComboBox1.Text = Nothing
        txtemail.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        clear()
        Form1.Show()
    End Sub

    Private Sub txtemail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtemail.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allownum As String = "0123456789"
            Dim allowletter As String = "abcdefghijklmnopqrstuvwxyz"
            Dim allowsym As String = "@."

            If Not allownum.Contains(e.KeyChar.ToString) And Not allowletter.Contains(e.KeyChar.ToString) And Not allowsym.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please enter valid email", "VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class