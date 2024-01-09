Imports MySql.Data.MySqlClient 'mysql datbase
Public Class Form6
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=db_advisng;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable


    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaddgv()
    End Sub
    Public Sub loaddgv() ' para mag load ng data sa datgrid at mag refresh pag nag add
        connection.Open()
        command = New MySqlCommand("select col_subcode as 'Subject Code', col_subTitle as 'Subject Title', col_Units as 'Units', 
        col_lab as 'Laboratory', col_lec as 'Lecture', col_PreRequisite as 'Pre-Requisite' from tbl_subject", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()

        Dim sum As Double = 0   'Totalling pf Units
        For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(2).Value
        Next
        txtTotalU.Text = sum.ToString()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If cmbByrlvl.Text = Nothing Then
                Dim ques As Integer = MessageBox.Show("Is This a BRIDGING subject? ", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If ques = DialogResult.Yes Then
                    cmbByrlvl.Text = "Bridging"
                    cmbBsem.Text = "Bridging"
                    connection.Open()
                    command = New MySqlCommand("Insert into tbl_subject (col_subcode, col_subTitle, col_Units, col_PreRequisite, col_lec, col_lab, col_yrLvl, col_Sem) values (@SC, @ST, @U, @PR, @lec, @lab, @Y, @S)", connection)
                    command.Parameters.Add(New MySqlParameter("@SC", MySqlDbType.VarChar, 50)).Value = txtsubcode.Text
                    command.Parameters.Add(New MySqlParameter("@ST", MySqlDbType.VarChar, 50)).Value = txtsubtitle.Text
                    command.Parameters.Add(New MySqlParameter("@U", MySqlDbType.VarChar, 50)).Value = txtunits.Text
                    command.Parameters.Add(New MySqlParameter("@PR", MySqlDbType.VarChar, 50)).Value = txtPR.Text
                    command.Parameters.Add(New MySqlParameter("@lec", MySqlDbType.VarChar, 50)).Value = txtlec.Text
                    command.Parameters.Add(New MySqlParameter("@lab", MySqlDbType.VarChar, 50)).Value = txtlab.Text
                    command.Parameters.Add(New MySqlParameter("@Y", MySqlDbType.VarChar, 50)).Value = cmbByrlvl.Text
                    command.Parameters.Add(New MySqlParameter("@S", MySqlDbType.VarChar, 50)).Value = cmbBsem.Text
                    command.ExecuteNonQuery()
                    MessageBox.Show("Subject has been added successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()

                    loaddgv()
                    Form5.loaddgv()

                    'FOR ACTIVITY LOG
                    connection.Close()
                    connection.Open()
                    command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
                    command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' ADDED a new subject '" & txtsubcode.Text & "' at the '" & cmbBsem.Text.ToUpper & "' of '" & cmbByrlvl.Text.ToUpper & "'"
                    command.ExecuteNonQuery()
                    connection.Close()
                    Form11.loadgdv()
                    cleartext()
                ElseIf cmbByrlvl.text = Nothing Then
                    MessageBox.Show("Please select a Year Level", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Else
                connection.Open()
                command = New MySqlCommand("Insert into tbl_subject (col_subcode, col_subTitle, col_Units, col_PreRequisite, col_lec, col_lab, col_yrLvl, col_Sem) values (@SC, @ST, @U, @PR, @lec, @lab, @Y, @S)", connection)
                command.Parameters.Add(New MySqlParameter("@SC", MySqlDbType.VarChar, 50)).Value = txtsubcode.Text
                command.Parameters.Add(New MySqlParameter("@ST", MySqlDbType.VarChar, 50)).Value = txtsubtitle.Text
                command.Parameters.Add(New MySqlParameter("@U", MySqlDbType.VarChar, 50)).Value = txtunits.Text
                command.Parameters.Add(New MySqlParameter("@PR", MySqlDbType.VarChar, 50)).Value = txtPR.Text
                command.Parameters.Add(New MySqlParameter("@lec", MySqlDbType.VarChar, 50)).Value = txtlec.Text
                command.Parameters.Add(New MySqlParameter("@lab", MySqlDbType.VarChar, 50)).Value = txtlab.Text
                command.Parameters.Add(New MySqlParameter("@Y", MySqlDbType.VarChar, 50)).Value = cmbByrlvl.Text
                command.Parameters.Add(New MySqlParameter("@S", MySqlDbType.VarChar, 50)).Value = cmbBsem.Text
                command.ExecuteNonQuery()
                MessageBox.Show("Subject has been added successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()
                loaddgv()
                Form5.loaddgv()


                'FOR ACTIVITY LOG
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' ADDED a new subject '" & txtsubcode.Text & "' at the '" & cmbBsem.Text.ToUpper & "' of '" & cmbByrlvl.Text.ToUpper & "'"
                command.ExecuteNonQuery()
                connection.Close()
                Form11.loadgdv()
                cleartext()
            End If
        Catch
            MessageBox.Show("This Subject is already added", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbByrlvl.SelectedIndexChanged
        If cmbByrlvl.SelectedIndex Then
            cmbBsem.Text = Nothing
        End If
        connection.Close()
        connection.Open()
        command = New MySqlCommand("select col_subcode as 'Subject Code', col_subTitle as 'Subject Title', col_Units as 'Units',
        col_lab as 'Laboratory', col_lec as 'Lecture', col_PreRequisite as 'Pre-Requisite'from tbl_subject  where col_yrLvl = '" & cmbByrlvl.Text & "'", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()


        Dim sum As Double = 0   'Totalling pf Units
        For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(2).Value
        Next
        txtTotalU.Text = sum.ToString()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbBsem.SelectedIndexChanged
        connection.Open()
        command = New MySqlCommand("select col_subcode as 'Subject Code', col_subTitle as 'Subject Title', col_Units as 'Units',
        col_lab as 'Laboratory', col_lec as 'Lecture', col_PreRequisite as 'Pre-Requisite' from tbl_subject  where col_yrLvl = '" & cmbByrlvl.Text & "' and  col_Sem ='" & cmbBsem.Text & "'", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()
        Dim sum As Double = 0
        For i As Double = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(2).Value
        Next
        txtTotalU.Text = sum.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim del As Integer = MessageBox.Show("Are you sure want to DELETE?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If del = DialogResult.Yes Then
            connection.Open()
            command = New MySqlCommand("Delete from tbl_subject where col_subcode ='" & txtsubcode.Text & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Data Has Been Delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()

            loaddgv()
            Form5.loaddgv()

            'FOR ACTIVITY LOG
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' DELETED the subject '" & txtsubcode.Text & "' at the '" & cmbBsem.Text.ToUpper & "' of '" & cmbByrlvl.Text.ToUpper & "'"
            command.ExecuteNonQuery()
            connection.Close()
            Form11.loadgdv()

            cleartext()
        ElseIf del = DialogResult.No Then

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim update As Integer = MessageBox.Show("Are you sure want to UPDATE this?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If update = DialogResult.Yes Then
            connection.Open()
            command = New MySqlCommand("update tbl_subject SET col_subcode='" & txtsubcode.Text & "', col_subTitle='" & txtsubtitle.Text & "' , col_Units='" & txtunits.Text & "', col_lec='" & txtlec.Text & "'
                , col_lab='" & txtlab.Text & "', col_PreRequisite='" & txtPR.Text & "', col_yrLvl = '" & cmbByrlvl.Text & "', col_Sem = '" & cmbBsem.Text & "' where col_subcode='" & txtsubcode.Text & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Your Data is  Updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)

            connection.Close()

            loaddgv()
            Form5.loaddgv()

            'FOR ACTIVITY LOG
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' UPDATED the subject '" & txtsubcode.Text & "' at the '" & cmbBsem.Text.ToUpper & "' of '" & cmbByrlvl.Text.ToUpper & "'"
            command.ExecuteNonQuery()
            connection.Close()
            Form11.loadgdv()
            cleartext()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex < 0 Then Exit Sub
        txtsubcode.Text = DataGridView1.Item(0, e.RowIndex).Value.ToString
        txtsubtitle.Text = DataGridView1.Item(1, e.RowIndex).Value.ToString
        txtunits.Text = DataGridView1.Item(2, e.RowIndex).Value.ToString
        txtPR.Text = DataGridView1.Item(5, e.RowIndex).Value.ToString
        txtlec.Text = DataGridView1.Item(4, e.RowIndex).Value.ToString
        txtlab.Text = DataGridView1.Item(3, e.RowIndex).Value.ToString


    End Sub
    Public Sub cleartext()
        txtlab.Text = Nothing
        txtlec.Text = Nothing
        txtPR.Text = Nothing
        txtsubcode.Text = Nothing
        txtsubtitle.Text = Nothing
        txtunits.Text = Nothing
        cmbBsem.Text = Nothing
        cmbByrlvl.Text = Nothing

    End Sub

    Private Sub txtsubcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsubcode.KeyPress
        'Dim allownum As String = "123456789"
        'Dim allowletter As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

        'If Not allownum.Contains(e.KeyChar.ToString) And Not allowletter.Contains(e.KeyChar.ToString) Then
        '    MessageBox.Show("Please Enter it in CAPSLOCK with no space!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return
        'End If

        If Not (Asc(e.KeyChar) = 8) Then
            Dim allownum As String = "0123456789"
            Dim allowletter As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Dim allowsym As String = "@."

            If Not allownum.Contains(e.KeyChar.ToString) And Not allowletter.Contains(e.KeyChar.ToString) And Not allowsym.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please Enter it in CAPSLOCK with no space!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPR.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allownum As String = "0123456789"
            Dim allowletter As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Dim allowsym As String = "@."

            If Not allownum.Contains(e.KeyChar.ToString) And Not allowletter.Contains(e.KeyChar.ToString) And Not allowsym.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please Enter it in CAPSLOCK with no space!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If txtsubcode.Text = Nothing Or txtsubtitle.Text = Nothing Or txtlab.Text = Nothing Or txtlec.Text = Nothing Or txtPR.Text = Nothing Or txtunits.Text = Nothing Or cmbByrlvl.Text = Nothing Or cmbBsem.Text = Nothing Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
        Else
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
        End If
    End Sub

    Private Sub txtunits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtunits.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allownum As String = "0123456789"

            If Not allownum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please Enter a number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtlec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlec.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allownum As String = "0123456789"

            If Not allownum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please Enter a number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtlab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlab.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allownum As String = "0123456789"

            If Not allownum.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Please Enter a number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class