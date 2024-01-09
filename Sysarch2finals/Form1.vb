Imports MySql.Data.MySqlClient
Public Class Form1
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=db_advisng;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    '--------------------------------------------Public SUBS OF System Form 1-----------------------------------------------------------'

    Public Sub clearText()
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
    End Sub
    Public Sub Log() 'Code sa pag Log in

        connection.Open()
        command = New MySqlCommand("select * from tbl_adviser where col_Username='" & TextBox1.Text & "' and col_pass='" & TextBox2.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim Login As Integer
        Login = 0
        While dataReader.Read
            Login = Login + 1
        End While

        If Login = 1 Then
            Me.Hide()
            Form2.ShowDialog()

        Else
            MessageBox.Show("Username and Password don't Match!")
            clearText()
        End If
        connection.Close()
    End Sub


    Public Sub Need() 'Pag walang nilagay sa textbox
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Please input your Usename")
        ElseIf TextBox2.Text = Nothing Then
            MessageBox.Show("Please input your Password")
        Else Log()
        End If
    End Sub

    '--------------------------------------------Private SUBS OF System Form 1-----------------------------------------------------------'

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form8.ShowDialog()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        Form9.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Need()
    End Sub


    '--------------------------------------------User Interface design-----------------------------------------------------------'
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
