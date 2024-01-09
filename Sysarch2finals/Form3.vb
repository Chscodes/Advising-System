Imports MySql.Data.MySqlClient 'mysql datbase
Public Class Form3
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=db_advisng;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox1.Text = Nothing
        cmbType.Text = Nothing
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Or TextBox5.Text = Nothing Then
            MessageBox.Show("Please input the needed", "VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If cmbType.Text = "Transferee" Then
            If dgvCEF.RowCount > 1 = False Then
                MessageBox.Show("Please enter the needed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            Else
                Dim i1 As Integer
                For i1 = 0 To dgvCEF.RowCount - 2
                    connection.Close()
                    connection.Open()
                    command = New MySqlCommand("Insert into tbl_grades (col_grades, col_studentID, col_subcode) values (@grades, @sID, @subject)", connection)
                    command.Parameters.Add(New MySqlParameter("@sID", MySqlDbType.VarChar, 50)).Value = TextBox1.Text
                    command.Parameters.AddWithValue("@grades", dgvCEF.Rows(i1).Cells(0).Value.ToString)
                    command.Parameters.AddWithValue("@subject", dgvCEF.Rows(i1).Cells(1).Value.ToString.ToUpper)
                    command.ExecuteNonQuery()
                    connection.Close()
                Next
                connection.Open()
                command = New MySqlCommand("Insert into tbl_student (col_StudID, col_Fname, col_Lname, col_MN, col_cNum, col_add, col_sex, col_type) values (@id, @fn, @ln, @mn, @n, @add, @sex, @type)", connection)
                command.Parameters.Add(New MySqlParameter("@id", MySqlDbType.VarChar, 50)).Value = TextBox1.Text
                command.Parameters.Add(New MySqlParameter("@fn", MySqlDbType.VarChar, 50)).Value = TextBox2.Text
                command.Parameters.Add(New MySqlParameter("@ln", MySqlDbType.VarChar, 50)).Value = TextBox3.Text
                command.Parameters.Add(New MySqlParameter("@mn", MySqlDbType.VarChar, 50)).Value = TextBox4.Text
                command.Parameters.Add(New MySqlParameter("@n", MySqlDbType.VarChar, 50)).Value = TextBox5.Text
                command.Parameters.Add(New MySqlParameter("@add", MySqlDbType.VarChar, 50)).Value = TextBox6.Text
                command.Parameters.Add(New MySqlParameter("@sex", MySqlDbType.VarChar, 50)).Value = ComboBox1.Text
                command.Parameters.Add(New MySqlParameter("@type", MySqlDbType.VarChar, 50)).Value = cmbType.Text
                command.ExecuteNonQuery()
                MessageBox.Show("Your Data Has Been Saved!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvCEF.Visible = False
                connection.Close()
                loadgdv()

                'FOR ACTIVITY LOG
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' ADDED new transferee student named '" & TextBox2.Text.ToUpper & "' ('" & TextBox1.Text & "')"
                command.ExecuteNonQuery()
                connection.Close()
                Form11.loadgdv()
                clear() ' clearing on txtbox
            End If
        Else
                connection.Open()
                command = New MySqlCommand("Insert into tbl_student (col_StudID, col_Fname, col_Lname, col_MN, col_cNum, col_add, col_sex, col_type) values (@id, @fn, @ln, @mn, @n, @add, @sex, @type)", connection)
                command.Parameters.Add(New MySqlParameter("@id", MySqlDbType.VarChar, 50)).Value = TextBox1.Text
                command.Parameters.Add(New MySqlParameter("@fn", MySqlDbType.VarChar, 50)).Value = TextBox2.Text
                command.Parameters.Add(New MySqlParameter("@ln", MySqlDbType.VarChar, 50)).Value = TextBox3.Text
                command.Parameters.Add(New MySqlParameter("@mn", MySqlDbType.VarChar, 50)).Value = TextBox4.Text
                command.Parameters.Add(New MySqlParameter("@n", MySqlDbType.VarChar, 50)).Value = TextBox5.Text
                command.Parameters.Add(New MySqlParameter("@add", MySqlDbType.VarChar, 50)).Value = TextBox6.Text
                command.Parameters.Add(New MySqlParameter("@sex", MySqlDbType.VarChar, 50)).Value = ComboBox1.Text
                command.Parameters.Add(New MySqlParameter("@type", MySqlDbType.VarChar, 50)).Value = cmbType.Text
                command.ExecuteNonQuery()
            MessageBox.Show("Your Data Has Been Saved!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()


            'FOR ACTIVITY LOG
            connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' ADDED new '" & cmbType.Text & "' student named '" & TextBox2.Text.ToUpper & "' ('" & TextBox1.Text & "')"
                command.ExecuteNonQuery()
                connection.Close()
            loadgdv()
            clear() ' clearing on txtbox
            End If

    End Sub
    Public Sub loadgdv() ' para mag load ng data sa datgrid at mag refresh pag nag add
        connection.Close()
        connection.Open()
        command = New MySqlCommand("select col_StudID as 'Student ID', col_Lname as 'Last Name', col_Fname as 'First Name', 
        col_MN as 'Middle Name',col_sex as 'Sex', col_cNum as 'Contact Number', col_add as 'Address' from tbl_student", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        dgvstudent.DataSource = table
        connection.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadgdv()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Or TextBox5.Text = Nothing Then
            MessageBox.Show("Please input the needed", "VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Dim update As Integer = MessageBox.Show("Are you sure want to UPDATE this?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If update = DialogResult.Yes Then
            connection.Open()
            command = New MySqlCommand("update tbl_student SET col_StudID='" & TextBox1.Text & "', col_Fname='" & TextBox2.Text & "' , col_Lname='" & TextBox3.Text & "', col_MN='" & TextBox4.Text & "'
                , col_cNum='" & TextBox5.Text & "', col_add='" & TextBox6.Text & "', col_sex='" & ComboBox1.Text & "', col_type='" & cmbType.Text & "' where col_StudID='" & TextBox1.Text & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Your Data is  Updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loadgdv()

            'FOR ACTIVITY LOG
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' UPDATED an information of a '" & cmbType.Text & "' student named '" & TextBox2.Text.ToUpper & "' ('" & TextBox1.Text & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Form11.loadgdv()
            clear() ' clearing on txtbox

        ElseIf update = DialogResult.No Then

        End If
        connection.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim del As Integer = MessageBox.Show("Are you sure want to DELETE?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If del = DialogResult.Yes Then
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Delete from tbl_student where col_StudID ='" & TextBox1.Text & "'", connection)
            dataReader = command.ExecuteReader
            connection.Close()

            connection.Open()
            command = New MySqlCommand("Delete from tbl_grades where col_studentID ='" & TextBox1.Text & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Data Has Been Delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            loadgdv()

            'FOR ACTIVITY LOG
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' DELETED the information of a '" & cmbType.Text & "' student named '" & TextBox2.Text.ToUpper & "' ('" & TextBox1.Text & "')"
            command.ExecuteNonQuery()
            connection.Close()

            clear() ' clearing on txtbox
        ElseIf del = DialogResult.No Then

        End If



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvstudent.CellContentClick
        dgvstudent.ClearSelection()
        If e.RowIndex < 0 Then Exit Sub
        TextBox1.Text = dgvstudent.Item(0, e.RowIndex).Value.ToString
        TextBox3.Text = dgvstudent.Item(1, e.RowIndex).Value.ToString
        TextBox2.Text = dgvstudent.Item(2, e.RowIndex).Value.ToString
        TextBox4.Text = dgvstudent.Item(3, e.RowIndex).Value.ToString
        TextBox5.Text = dgvstudent.Item(5, e.RowIndex).Value.ToString
        TextBox6.Text = dgvstudent.Item(6, e.RowIndex).Value.ToString
        ComboBox1.Text = dgvstudent.Item(4, e.RowIndex).Value.ToString


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Or TextBox5.Text = Nothing Or TextBox6.Text = Nothing Or ComboBox1.Text = Nothing Then
            cmbType.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False

        Else
            cmbType.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
        End If

    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.Text = "Transferee" Then
            dgvCEF.Visible = True
        Else
            dgvCEF.Visible = False
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allownum As String = "0123456789"
            Dim allowsym As String = "-"

            If Not allownum.Contains(e.KeyChar.ToString) And Not allowsym.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please enter valid ID!", "VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allownum As String = "0123456789"


            If Not allownum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please enter valid number!", "VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

End Class