Imports MySql.Data.MySqlClient
Public Class Form7
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=db_advisng;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable

    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Dim dr As New System.Windows.Forms.DataGridViewRow
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SubJ()
        If txtprerequisite.Text = Nothing Then
            btnadd.Enabled = False
        End If
    End Sub

    Private Sub SubJ()
        connection.Open()
        command = New MySqlCommand("select col_subcode as 'Subject Code', col_subTitle as 'Subject Title', col_Units as 'Units' , col_PreRequisite as 'Pre-Requisite' from tbl_subject WHERE col_yrlvl = 'Bridging' or col_sem = 'Bridging'", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        dgv1.DataSource = table
        connection.Close()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        txtprerequisite.Text = dgv1.Item(3, e.RowIndex).Value.ToString
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        'Dim dr1 As New System.Windows.Forms.DataGridViewRow


        For Each row As DataGridViewRow In Form5.dgv2.Rows 'vallidation para d mag doble ang ma add na subject
            If Convert.ToString(row.Cells(0).Value).Equals(dgv1.CurrentRow.Cells(0).Value) Then
                MessageBox.Show("Subject Already added!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtprerequisite.Text = Nothing
                Return
            End If
        Next
        'para pag wlaang prerequisite pwede ma add
        If txtprerequisite.Text = "None" Then
            For Each dr In Me.dgv1.SelectedRows 'pag add ng value sa datagrid for bridging
                Form5.dgv2.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value)
            Next
            txtprerequisite.Text = Nothing

            'Dim sum1 As Double = 0   'Totalling pf Units in dgv2
            'For i As Double = 0 To Form5.dgv2.Rows.Count() - 1 Step +1
            '    sum1 = sum1 + Form5.dgv2.Rows(i).Cells(2).Value
            'Next
            'Form5.TextBox5.Text = sum1.ToString()

        ElseIf txtpreRequisite.Text = Nothing Then
            MessageBox.Show("Please Select a subject", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            adddgv()
        End If

    End Sub

    Public Sub adddgv()

        connection.Open()
        command = New MySqlCommand("select col_grades from tbl_grades where col_subcode='" & txtprerequisite.Text & "' and col_studentID ='" & Form5.txtStdntID.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim subj As Integer ' para pag d pa na take ang subject d pwede makuha
        subj = 0
        While dataReader.Read
            subj = subj + 1
            Dim colgrade = dataReader.GetString("col_grades") 'para sa pag kuha ng grade sa student
            If colgrade = "Fail" Then
                MessageBox.Show("Student need To take the subject '" & txtprerequisite.Text & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtprerequisite.Text = Nothing
            ElseIf colgrade = "INC" Then
                MessageBox.Show("Student need To take the subject '" & txtprerequisite.Text & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtprerequisite.Text = Nothing
            ElseIf colgrade = "Drop" Then
                MessageBox.Show("Student need To take the subject '" & txtprerequisite.Text & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtprerequisite.Text = Nothing
            ElseIf colgrade <= 3 Then
                For Each dr In Me.dgv1.SelectedRows 'pag add ng value sa datagrid for bridging
                    Form5.dgv2.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value) ' sa pag add ng data to form5 dgv2
                    txtprerequisite.Text = Nothing
                Next
            End If
        End While

        If subj = 1 Then

        Else
            MessageBox.Show("Student need To take the subject '" & txtprerequisite.Text & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtprerequisite.Text = Nothing
        End If
        connection.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtprerequisite_TextChanged(sender As Object, e As EventArgs) Handles txtprerequisite.TextChanged
        btnadd.Enabled = True

        If txtprerequisite.Text = Nothing Then
            btnadd.Enabled = False
        End If
    End Sub
End Class