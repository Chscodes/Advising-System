Imports MySql.Data.MySqlClient
Public Class Form5
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=db_advisng;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable

    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader


    '--------------------------------------------Private SUBS OF System Form-----------------------------------------------------------'

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaddgv()
        If txtpreRequisite.Text = Nothing Then
            txtsb.Text = Nothing
        End If
        If txtpreRequisite.Text = Nothing Then
            btnforward.Enabled = False
        End If
        'counting total of subjects this curiculum
        connection.Open()
        command = New MySqlCommand("SELECT COUNT(`col_subcode`) FROM tbl_subject", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            txtCount.Text = dataReader(0)
        End While
        connection.Close()


        ' checkbox para sa datagrid1
        'Dim checkbox1 As New DataGridViewCheckBoxColumn
        'checkbox1.Width = 40
        'checkbox1.Name = "dgv1checkbox"
        'checkbox1.HeaderText = ""
        'dgv1.Columns.Insert(0, checkbox1)


    End Sub
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        txtpreRequisite.Text = Nothing
        txtpreRequisite.Text = dgv1.Item(3, e.RowIndex).Value.ToString
        txtsb.Text = dgv1.Item(0, e.RowIndex).Value.ToString
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Text = Nothing
        connection.Close()
        connection.Open()
        command = New MySqlCommand("select col_subcode as 'Subject Code', col_subTitle as 'Subject Title', col_Units as 'Units', col_PreRequisite as 'Pre-Requisite' from tbl_subject  where col_yrLvl = '" & ComboBox1.Text & "'", connection)
        adptr.SelectCommand = command
        table.Clear()

        adptr.Fill(table)
        dgv1.DataSource = table
        connection.Close()

        Dim sum As Double = 0   'Totalling pf Units
        For i As Double = 0 To dgv1.Rows.Count() - 1 Step +1
            sum = sum + dgv1.Rows(i).Cells(2).Value
        Next
        txtsem_units.Text = sum.ToString()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        connection.Close()
        connection.Open()
        command = New MySqlCommand("select col_subcode as 'Subject Code', col_subTitle as 'Subject Title', col_Units as 'Units', col_PreRequisite as 'Pre-Requisite' from tbl_subject  where col_yrLvl = '" & ComboBox1.Text & "' and  col_Sem ='" & ComboBox2.Text & "'", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        dgv1.DataSource = table
        connection.Close()


        Dim sum As Double = 0   'Totalling pf Units
        For i As Double = 0 To dgv1.Rows.Count() - 1 Step +1
            sum = sum + dgv1.Rows(i).Cells(2).Value
        Next
        txtsem_units.Text = sum.ToString()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnALlFrwrd.Click
        If txtfname.Text = Nothing And txtLname.Text = Nothing Then
            MessageBox.Show("Please Input the StudentID to be advised")
            Return
        End If
        For Each row As DataGridViewRow In dgv2.Rows 'vallidation para d mag doble ang ma add na subject
            If Convert.ToString(row.Cells(0).Value).Equals(dgv1.CurrentRow.Cells(0).Value) Then
                MessageBox.Show("Subject Already added!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        For sb = 0 To dgv1.Rows.Count - 1
            connection.Close()
            connection.Open()
            command = New MySqlCommand("select col_subcode from tbl_grades where col_subcode ='" & dgv1.Rows(sb).Cells(0).Value.ToString & "' AND col_studentID = '" & txtStdntID.Text & "' ", connection)
            dataReader = command.ExecuteReader
            Dim search As Integer
            search = 0
            'While dataReader.Read
            search = search + 1
                'End While
                If search = 1 Then
                connection.Close()
                connection.Open()
                command = New MySqlCommand("select col_grades from tbl_grades where col_subcode='" & dgv1.Rows(sb).Cells(0).Value.ToString & "' and col_studentID ='" & txtStdntID.Text & "'", connection)
                dataReader = command.ExecuteReader

                'While dataReader.Read
                If dataReader.Read Then
                    Dim grade = dataReader.GetString("col_grades")
                    If grade <= 3.ToString Then
                        MessageBox.Show("Subject " & dgv1.Rows(sb).Cells(0).Value.ToString & " already taken by student!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    Else
                        dgv2.Rows.Add(dgv1.Rows(sb).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
                    End If
                End If
                'End While
                connection.Close()

                End If

        Next

        addgv_all()

        'para pag doble ang sub na add automatic ma delete
        For intI = dgv2.Rows.Count - 1 To 0 Step -1
            For intJ = intI - 1 To 0 Step -1
                If dgv2.Rows(intI).Cells(1).Value = dgv2.Rows(intJ).Cells(1).Value AndAlso dgv2.Rows(intI).Cells(3).Value = dgv2.Rows(intJ).Cells(3).Value Then
                    dgv2.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
            Dim sum1 As Double = 0   'Totalling pf Units in dgv2
            For i As Double = 0 To dgv2.Rows.Count() - 1 Step +1
                sum1 = sum1 + dgv2.Rows(i).Cells(2).Value
            Next
            txtAdvised_units.Text = sum1.ToString()
        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnforward.Click

        If txtfname.Text = Nothing And txtLname.Text = Nothing Then
            MessageBox.Show("Please Input the StudentID to be advised")
            Return
        Else
            For Each row As DataGridViewRow In dgv2.Rows 'vallidation para d mag doble ang ma add na subject
                If Convert.ToString(row.Cells(0).Value).Equals(dgv1.CurrentRow.Cells(0).Value) Then
                    MessageBox.Show("Subject Already added!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Next
            'para pag nakuha na ang sub o naipasa na ay d na pwede makuha

            connection.Close()
            connection.Open()
            command = New MySqlCommand("select col_subcode from tbl_grades where col_subcode ='" & txtsb.Text & "' AND col_studentID = '" & txtStdntID.Text & "' ", connection)
            dataReader = command.ExecuteReader
            Dim search As Integer
            search = 0
            While dataReader.Read
                search = search + 1
            End While
            If search = 1 Then
                connection.Close()
                connection.Open()
                command = New MySqlCommand("select col_grades from tbl_grades where col_subcode='" & txtsb.Text & "' and col_studentID ='" & txtStdntID.Text & "'", connection)
                dataReader = command.ExecuteReader

                While dataReader.Read
                    Dim grade = dataReader.GetString("col_grades")
                    If grade <= 3.ToString Then
                        MessageBox.Show("Subject " & txtsb.Text & " already taken by student!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    Else
                        dgv2.Rows.Add(dgv1.SelectedRows(0).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray) ' sa pag add ng data to dgv2
                        txtpreRequisite.Text = Nothing
                    End If
                End While
                connection.Close()

            End If

        End If
        adddgv()

        For intI = dgv2.Rows.Count - 1 To 0 Step -1 'mag delete ng subject pag doble
            For intJ = intI - 1 To 0 Step -1
                If dgv2.Rows(intI).Cells(1).Value = dgv2.Rows(intJ).Cells(1).Value AndAlso dgv2.Rows(intI).Cells(3).Value = dgv2.Rows(intJ).Cells(3).Value Then
                    dgv2.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next


            Dim sum1 As Double = 0   'Totalling pf Units in dgv2
            For i As Double = 0 To dgv2.Rows.Count() - 1 Step +1
                sum1 = sum1 + dgv2.Rows(i).Cells(2).Value
            Next
            txtAdvised_units.Text = sum1.ToString()
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btndec.Click
        Try
            dgv2.Rows.Remove(dgv2.SelectedRows(0))


            Dim sum1 As Double = 0   'Totalling pf Units in dgv2
            For i As Double = 0 To dgv2.Rows.Count() - 1 Step +1
                sum1 = sum1 + dgv2.Rows(i).Cells(2).Value
            Next
            txtAdvised_units.Text = sum1.ToString()
        Catch
            MessageBox.Show("There Is no subject to delete!")
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklbl_save.LinkClicked
        If dgv2.RowCount > 1 = False Then
            MessageBox.Show("Please enter a subject for student!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Dim txt1Advised = Convert.ToDouble(txtAdvised_units.Text)
        Dim txtsem = Convert.ToDouble(lblunits.Text)
        Dim grad = txtsem + 6
        If cmbtype.Text = "Irregular" And cmbyrlvl.Text = "Fourth Year" Then
            If txt1Advised > grad Then
                MessageBox.Show("Can't Proceed due to limitations of Units (Max of +6 Units per Semester)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                Dim i1 As Integer
                For i1 = 0 To dgv2.RowCount - 2
                    connection.Close()
                    connection.Open()
                    command = New MySqlCommand("Insert into tbl_grades (col_studentID, col_subcode, col_yrLvl, col_Sem) values (@sID, @subject, @yr, @sem)", connection)
                    command.Parameters.Add(New MySqlParameter("@sID", MySqlDbType.VarChar, 50)).Value = txtStdntID.Text
                    command.Parameters.AddWithValue("@subject", dgv2.Rows(i1).Cells(0).Value.ToString)
                    command.Parameters.Add(New MySqlParameter("@yr", MySqlDbType.VarChar, 50)).Value = cmbyrlvl.Text
                    command.Parameters.Add(New MySqlParameter("@sem", MySqlDbType.VarChar, 50)).Value = cmbsem.Text
                    command.ExecuteNonQuery()
                    connection.Close()
                Next

                connection.Open() 'PARA SA PAG UPDATe NG TYPE NG STUDENT
                command = New MySqlCommand("update tbl_student SET col_type ='" & cmbtype.Text & "' where col_StudID='" & txtStdntID.Text & "'", connection)
                dataReader = command.ExecuteReader
                connection.Close()

                MessageBox.Show("Advised Subjects Has Been Saved!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv2.Rows.Clear()
                Form4.propectus()

                'FOR ACTIVITY LOG
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
                command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' advised student '" & txtfname.Text.ToUpper & "' ('" & txtStdntID.Text & "') in the '" & cmbsem.Text & "' of '" & cmbyrlvl.Text & "'"
                command.ExecuteNonQuery()
                connection.Close()
                Form11.loadgdv()
                txtStdntID.Clear()

            End If
        ElseIf txt1Advised > txtsem Then
            MessageBox.Show("Can't Proceed due to limitations of Units per Semester", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        Else
            Dim i As Integer
            For i = 0 To dgv2.RowCount - 2
                connection.Close()
                connection.Open()
                command = New MySqlCommand("Insert into tbl_grades (col_studentID, col_subcode, col_yrLvl, col_Sem) values (@sID, @subject, @yr, @sem)", connection)
                command.Parameters.Add(New MySqlParameter("@sID", MySqlDbType.VarChar, 50)).Value = txtStdntID.Text
                command.Parameters.AddWithValue("@subject", dgv2.Rows(i).Cells(0).Value.ToString)
                command.Parameters.Add(New MySqlParameter("@yr", MySqlDbType.VarChar, 50)).Value = cmbyrlvl.Text
                command.Parameters.Add(New MySqlParameter("@sem", MySqlDbType.VarChar, 50)).Value = cmbsem.Text
                command.ExecuteNonQuery()
                connection.Close()
            Next

            connection.Open() 'PARA SA PAG UPDATe NG TYPE NG STUDENT
            command = New MySqlCommand("update tbl_student SET col_type ='" & cmbtype.Text & "' where col_StudID='" & txtStdntID.Text & "'", connection)
            dataReader = command.ExecuteReader
            connection.Close()

            MessageBox.Show("Advised Subjects Has Been Saved!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgv2.Rows.Clear()
            Form4.propectus()


            Dim sum1 As Double = 0   'Totalling pf Units in dgv2
            For z As Double = 0 To dgv2.Rows.Count() - 1 Step +1
                sum1 = sum1 + dgv2.Rows(z).Cells(2).Value
            Next
            txtAdvised_units.Text = sum1.ToString()

        End If

        'FOR ACTIVITY LOG
        connection.Close()
        connection.Open()
        command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
        command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' advised student '" & txtfname.Text.ToUpper & "' ('" & txtStdntID.Text & "') in the '" & cmbsem.Text & "' of '" & cmbyrlvl.Text & "'"
        command.ExecuteNonQuery()
        connection.Close()
        Form11.loadgdv()
        txtStdntID.Clear()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtStdntID.TextChanged
        'para sa pag count ilan na ang natake na sub sa stydent
        connection.Close()
        connection.Open()
        command = New MySqlCommand("SELECT COUNT(`col_subcode`) FROM tbl_grades WHERE col_studentID = '" & txtStdntID.Text & "' and col_grades Between 1 and 3 ", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            txtStudTake.Text = dataReader(0)

        End While

        connection.Close()
        connection.Open()
        command.CommandText = "Select * from tbl_student where col_StudID = '" & txtStdntID.Text & "'"
        adptr.SelectCommand = command
        ds.Clear()
        adptr.Fill(ds, "List")

        txtLname.DataBindings.Add("Text", ds, "List.col_Lname")
        txtLname.DataBindings.Clear()

        txtfname.DataBindings.Add("Text", ds, "List.col_Fname")
        txtfname.DataBindings.Clear()

        txtmn.DataBindings.Add("Text", ds, "List.col_MN")
        txtmn.DataBindings.Clear()

        cmbtype.DataBindings.Add("Text", ds, "List.col_type")
        cmbtype.DataBindings.Clear()

        If txtStdntID.Text = "" Then
            txtLname.Clear()
            txtfname.Clear()
            txtmn.Clear()
            cmbtype.Text = Nothing
            ComboBox1.Text = Nothing
            ComboBox1.Text = Nothing
        End If
        connection.Close()
    End Sub

    '--------------------------------------------Public SUBS OF System Form-----------------------------------------------------------'

    Public Sub adddgv()
        If txtpreRequisite.Text = "NONE" Then


            connection.Close()
            connection.Open()
            command = New MySqlCommand("select col_subcode from tbl_grades where col_subcode ='" & txtsb.Text & "' AND col_studentID = '" & txtStdntID.Text & "' ", connection)
            dataReader = command.ExecuteReader
            Dim search As Integer
            search = 0
            While dataReader.Read
                search = search + 1
            End While
            If search = 1 Then
                connection.Close()
                connection.Open()
                command = New MySqlCommand("select col_grades from tbl_grades where col_subcode='" & txtsb.Text & "' and col_studentID ='" & txtStdntID.Text & "'", connection)
                dataReader = command.ExecuteReader

                While dataReader.Read
                    Dim grade = dataReader.GetString("col_grades")
                    If grade <= 3.ToString Then
                        MessageBox.Show("Subject " & txtsb.Text & " already taken by student!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    Else
                        dgv2.Rows.Add(dgv1.SelectedRows(0).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray) ' sa pag add ng data to dgv2
                        txtpreRequisite.Text = Nothing
                    End If
                End While
                connection.Close()
            Else
                dgv2.Rows.Add(dgv1.SelectedRows(0).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray) ' sa pag add ng data to dgv2
                txtpreRequisite.Text = Nothing
            End If


            Dim sum1 As Double = 0   'Totalling pf Units in dgv2
            For i As Double = 0 To dgv2.Rows.Count() - 1 Step +1
                sum1 = sum1 + dgv2.Rows(i).Cells(2).Value
            Next
            txtAdvised_units.Text = sum1.ToString()
        ElseIf txtpreRequisite.Text = "70% of academic requirements" Then
            Dim Pcount = Convert.ToInt32(txtCount.Text)
            Dim Esub = Pcount * 0.7
            Dim acad = Convert.ToInt32(txtStudTake.Text)
            If acad < Esub Then
                MessageBox.Show("Student did not reach the '" & txtpreRequisite.Text & "'!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dgv2.Rows.Add(dgv1.SelectedRows(0).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray) ' sa pag add ng data to dgv2
                txtpreRequisite.Text = Nothing
            End If


        Else
            connection.Close()
            connection.Open()
            command = New MySqlCommand("select col_grades from tbl_grades where col_subcode='" & txtpreRequisite.Text & "' and col_studentID ='" & txtStdntID.Text & "'", connection)
            dataReader = command.ExecuteReader
            Dim subj As Integer ' para pag d pa na take ang preRequisite subject d pwede makuha
            subj = 0
            While dataReader.Read
                subj = subj + 1
                Dim colgrade = dataReader.GetString("col_grades") 'para sa pag kuha ng grade sa student
                If colgrade = "Fail" Then
                    MessageBox.Show("Student need To take the subject '" & txtpreRequisite.Text & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtpreRequisite.Text = Nothing
                ElseIf colgrade = "INC" Then
                    MessageBox.Show("Student need To take the subject '" & txtpreRequisite.Text & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtpreRequisite.Text = Nothing
                ElseIf colgrade = "Drop" Then
                    MessageBox.Show("Student need To take the subject '" & txtpreRequisite.Text & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtpreRequisite.Text = Nothing
                ElseIf colgrade = "" Then
                    MessageBox.Show("Student need To take the subject '" & txtpreRequisite.Text & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtpreRequisite.Text = Nothing
                ElseIf colgrade <= 3 Then
                    dgv2.Rows.Add(dgv1.SelectedRows(0).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray) ' sa pag add ng data to dgv2
                    txtpreRequisite.Text = Nothing

                End If

            End While
            'code para sa d na take na prereq na sub
            'If subj = 1 Then

            'Else
            '    MessageBox.Show("Student need To take the subject '" & txtpreRequisite.Text & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    txtpreRequisite.Text = Nothing
            'End If
            connection.Close()
            Dim sum1 As Double = 0   'Totalling pf Units in dgv2
            For i As Double = 0 To dgv2.Rows.Count() - 1 Step +1
                sum1 = sum1 + dgv2.Rows(i).Cells(2).Value
            Next
            txtAdvised_units.Text = sum1.ToString()
        End If
    End Sub

    Public Sub loaddgv()
        ' para mag load ng data sa datgrid at mag refresh pag nag add

        connection.Open()
        command = New MySqlCommand("select col_subcode as 'Subject Code', col_subTitle as 'Subject Title', col_Units as 'Units' , col_PreRequisite as 'Pre-Requisite' from tbl_subject", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        dgv1.DataSource = table
        connection.Close()

        Dim sum As Double = 0   'Totalling pf Units in dgv1
        For i As Double = 0 To dgv1.Rows.Count() - 1 Step +1
            sum = sum + dgv1.Rows(i).Cells(2).Value
        Next
        txtsem_units.Text = sum.ToString()

    End Sub

    Private Sub txtpreRequisite_TextChanged(sender As Object, e As EventArgs) Handles txtpreRequisite.TextChanged
        btnforward.Enabled = True

        If txtpreRequisite.Text = Nothing Then
            btnforward.Enabled = False
        End If
    End Sub

    Private Sub linklbl_Bridge_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklbl_Bridge.LinkClicked
        If txtLname.Text = Nothing Then
            MessageBox.Show("Please Input a Student", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Form7.ShowDialog()
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ComboBox1.Text = cmbyrlvl.Text
        ComboBox2.Text = cmbsem.Text
        lblunits.Text = txtsem_units.Text

        If cmbyrlvl.Text = Nothing Or cmbsem.Text = Nothing Then
            cmbyrlvl.Enabled = True
            cmbsem.Enabled = True
            GroupBox1.Enabled = False
            btnALlFrwrd.Enabled = False
            btnforward.Enabled = False
        ElseIf cmbtype.Text = "Regular" Then
            GroupBox1.Enabled = False
            btnALlFrwrd.Enabled = True
            cmbyrlvl.Enabled = True
            cmbsem.Enabled = True

        Else
            GroupBox1.Enabled = True
            btnALlFrwrd.Enabled = False
            cmbyrlvl.Enabled = False
            cmbsem.Enabled = False
        End If




    End Sub

    Private Sub cmbyrlvl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbyrlvl.SelectedIndexChanged
        cmbsem.Text = Nothing
        If cmbsem.Text = "" Then
            Label16.Visible = False
            lblunits.Visible = False

        Else
            Label16.Visible = True
            lblunits.Visible = True
        End If

    End Sub

    Private Sub cmbsem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsem.SelectedIndexChanged
        If cmbsem.Text = "" And cmbyrlvl.Text = "" Then
            Label16.Visible = False
            lblunits.Visible = False

        Else
            Label16.Visible = True
            lblunits.Visible = True
        End If

    End Sub

    Private Sub btnre_Click(sender As Object, e As EventArgs) Handles btnre.Click
        cmbsem.Text = Nothing
        cmbyrlvl.Text = Nothing
    End Sub


    Public Sub addgv_all()
        For pre = 0 To dgv1.Rows.Count - 1
            If dgv1.Rows(pre).Cells(3).Value.ToString = "NONE" Then
                dgv2.Rows.Add(dgv1.Rows(pre).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)

            ElseIf dgv1.Rows(pre).Cells(3).Value.ToString = "70% of academic requirements" Then
                Dim Pcount = Convert.ToInt32(txtCount.Text)
                Dim Esub = Pcount * 0.7
                Dim acad = Convert.ToInt32(txtStudTake.Text)
                If acad > Esub Then

                    dgv2.Rows.Add(dgv1.Rows(pre).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
                Else
                    MessageBox.Show("Student did not reach the '" & dgv1.Rows(pre).Cells(3).Value.ToString & "'!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                connection.Close()
                connection.Open()
                command = New MySqlCommand("select col_grades from tbl_grades where col_subcode='" & dgv1.Rows(pre).Cells(3).Value.ToString & "' and col_studentID ='" & txtStdntID.Text & "'", connection)
                dataReader = command.ExecuteReader
                Dim s As Integer ' para pag d pa na take ang preRequisite subject d pwede makuha
                s = 0
                While dataReader.Read
                    s = s + 1
                    Dim colgrade = dataReader.GetString("col_grades")
                    If colgrade <= 3.ToString Then
                        dgv2.Rows.Add(dgv1.Rows(pre).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
                    ElseIf colgrade = "" Then
                        MessageBox.Show("Student need To take the subject '" & dgv1.Rows(pre).Cells(3).Value.ToString & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ElseIf colgrade = "Fail" Then
                        MessageBox.Show("Student need To take the subject '" & dgv1.Rows(pre).Cells(3).Value.ToString & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ElseIf colgrade = "INC" Then
                        MessageBox.Show("Student need To take the subject '" & dgv1.Rows(pre).Cells(3).Value.ToString & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf colgrade = "Drop" Then
                        MessageBox.Show("Student need To take the subject '" & dgv1.Rows(pre).Cells(3).Value.ToString & "'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)



                        Dim sum1 As Double = 0   'Totalling pf Units in dgv2
                        For i As Double = 0 To dgv2.Rows.Count() - 1 Step +1
                            sum1 = sum1 + dgv2.Rows(i).Cells(2).Value
                        Next
                        txtAdvised_units.Text = sum1.ToString()

                    End If

                End While
                If s = 1 Then

                Else
                    MessageBox.Show("Student need To take the subject '" & dgv1.Rows(pre).Cells(3).Value.ToString & " first!'", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If

        Next

        'For Each row As DataGridViewRow In dgv1.Rows
        '    If Not row.IsNewRow Then

        '        MessageBox.Show(row.Cells(0).Value.ToString & "," & row.Cells(1).Value.ToString)

        '    End If
        'Next
    End Sub

    Private Sub txtStdntID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStdntID.KeyPress
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


End Class
