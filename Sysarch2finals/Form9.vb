Imports MySql.Data.MySqlClient
Imports System.Net.Mail ' email verificatrion message
Public Class Form9
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=db_advisng;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Dim auto As String = "" 'for auto generate code
    Dim rndm As Random = New Random() 'for auto generate code

    Dim cd As New TimeSpan() 'automatic cooldown time
    Dim cd2 As New TimeSpan() 'automatic cooldown time for resendcode

    '--------------------------------------------Public SUBS OF System Form 1-----------------------------------------------------------'
    Public Sub recover() 'Code sa pag recover

        connection.Open()
        command = New MySqlCommand("select * from tbl_adviser where col_Name='" & TextBox1.Text & "' and col_Birthday='" & DateTimePicker1.Text & "'
            and col_Gender='" & ComboBox1.Text & "'and col_coreP1='" & txtRcode1.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim ACC As Integer
        ACC = 0
        While dataReader.Read
            ACC = ACC + 1
        End While

        If ACC = 1 Then
            txtemaili.Text = dataReader.GetString("col_email")
            TextBox3.Text = dataReader.GetString("col_Username")
            TextBox2.Text = dataReader.GetString("col_Pass")
            MessageBox.Show("Username: " + TextBox3.Text + vbNewLine + "Password: " + TextBox2.Text, "Your Username and Password is", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim Quest As Integer = MessageBox.Show("Do you Want to change your username and password?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Quest = DialogResult.Yes Then
                grpboxfill.Visible = False
                grpboxupdt.Visible = True
            Else
                Dim wish As Integer = MessageBox.Show("Do you Wish to back to Logging in?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If wish = DialogResult.Yes Then
                    Me.Close()
                    Form1.Show()
                End If
            End If

        Else
            MessageBox.Show("This Profile never Exist")
        End If
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

        TextBox10.Text = auto
        If TextBox10.Text = auto Then
            auto = Nothing
        End If
    End Sub
    Public Sub Email() ' send adviser email verification and save to database vefication code

        Dim mail As New MailMessage
        Dim smtpServer As New SmtpClient("smtp.gmail.com")
        mail.From = New MailAddress(TextBox8.Text)
        mail.To.Add(txtemaili.Text)
        mail.Subject = TextBox11.Text
        mail.Body = TextBox12.Text & TextBox10.Text

        smtpServer.Port = 587
        smtpServer.Credentials = New System.Net.NetworkCredential(TextBox8.Text, TextBox9.Text)
        smtpServer.EnableSsl = True
        smtpServer.Send(mail)

        connection.Open()
        command = New MySqlCommand("Insert into tbl_verification (code) values (@vCode)", connection)
        command.Parameters.Add(New MySqlParameter("@vCode", MySqlDbType.VarChar, 50)).Value = TextBox10.Text
        command.ExecuteNonQuery()
        connection.Close()

        MessageBox.Show("Verification Code Sent", "Check your Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub intrnt() ' if no internet
        If System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable = False Then
            MessageBox.Show("You Dont Have an Internet Connection!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Email()
        End If
    End Sub
    Public Sub updt()  'for updating username pass NASA SUB na check
        Dim update As Integer = MessageBox.Show("Are you sure want to Change your Username and Password? ", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If update = DialogResult.Yes Then
            connection.Close()
            connection.Open()
            command = New MySqlCommand("UPDATE tbl_adviser SET col_Username='" & txtUS.Text & "', col_Pass='" & txtpass.Text & "' where col_Name='" & TextBox1.Text & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Your UserName and PassWord is Just Updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear()
            Me.Close()
            Form1.Show()

        ElseIf update = DialogResult.No Then

        End If
        connection.Close()
    End Sub

    Public Sub Need() 'pag wala nilagay sa textboxes
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf txtRcode1.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        Else recover()
        End If
    End Sub
    Public Sub check()
        connection.Open()
        command = New MySqlCommand("select * from tbl_verification where code='" & TextBox14.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim Vcode As Integer
        Vcode = 0
        While dataReader.Read
            Vcode = Vcode + 1
        End While
        If Vcode = 1 Then
            grpboxupdt.Enabled = True
            grpboxupdt.Visible = False
            grpboxVer.Visible = False
            grpboxfill.Visible = True
            updt()
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Delete from tbl_verification where Code ='" & TextBox14.Text & "'", connection)
            dataReader = command.ExecuteReader
            connection.Close()
            connection.Open()
            command = New MySqlCommand("UPDATE tbl_adviser SET col_verCode='" & TextBox14.Text & "' where col_Name='" & TextBox1.Text & "'", connection)
            dataReader = command.ExecuteReader

        Else
            MessageBox.Show("Please input the correct verification code!")
        End If
        connection.Close()
    End Sub


    '--------------------------------------------Private SUBS OF System Form 1-----------------------------------------------------------'
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Code()
        Timer1.Start() 'timer sa code
        cd = New TimeSpan(0, CInt("1"), 0)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cd = cd.Subtract(New TimeSpan(0, 0, 1))
        Label12.Text = String.Format("{0} mins : {1} Secs", cd.Minutes, cd.Seconds)
        If cd.Minutes = 0 AndAlso cd.Seconds = 0 Then
            cd = New TimeSpan(0, CInt("1"), 0)
            Code()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        cd2 = cd2.Subtract(New TimeSpan(0, 0, 1))
        lblRC.Text = String.Format("{0} Secs", cd2.Seconds)
        If cd2.Seconds = 0 Then
            cd2 = New TimeSpan(0, CInt("1"), 0)
            Timer2.Stop()
            lblRC.Visible = False
            Button6.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Need()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If lblnotif.Visible = True Then
            MessageBox.Show("This Username is Already Taken", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf textbox1.Text = Nothing Or txtRcode1.Text = Nothing Or ComboBox1.Text = Nothing Then
            MessageBox.Show("Please fill the empty Textbox!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            intrnt()
            grpboxupdt.Enabled = False
            grpboxVer.Visible = True
        End If

    End Sub
    Public Sub clear()
        TextBox1.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox14.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        txtemaili.Clear()
        txtpass.Clear()
        txtRcode1.Clear()
        txtUS.Clear()
        ComboBox1.Text = Nothing
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox10.Text = Nothing Then
            MessageBox.Show("Please fill the empty Textbox!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            check()
        End If


    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        intrnt()
        lblRC.Visible = True
        Button6.Enabled = False
        If Timer2.Enabled = False Then 'para sa resend code activation
            Timer2.Start()
            cd2 = New TimeSpan(0, CInt("1"), 0)
        End If
    End Sub

    Private Sub txtUS_TextChanged(sender As Object, e As EventArgs) Handles txtUS.TextChanged   'for unique username
        connection.Close()
        connection.Open()
        command = New MySqlCommand("select * from tbl_adviser where col_Username='" & txtUS.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim username As Integer
        username = 0
        While dataReader.Read
            username = username + 1
        End While

        If username = 1 Then
            lblnotif.Visible = True
        Else
            lblnotif.Visible = False
            connection.Close()
            connection.Close()
        End If
        connection.Close()
    End Sub
End Class