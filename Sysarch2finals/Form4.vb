Imports MySql.Data.MySqlClient
Public Class Form4
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=db_advisng;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Dim drop As Boolean = True

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel5.Size = Panel5.MinimumSize

    End Sub
    Private Sub txtGrade_TextChanged(sender As Object, e As EventArgs) Handles txtGrade.TextChanged
        If txtGrade.Text = "4" Or txtGrade.Text = "INC" Then
            lblremarks.Text = "INC"
        ElseIf txtGrade.Text = "5" Or txtGrade.Text = "Fail" Then
            lblremarks.Text = "Failed"
        ElseIf txtGrade.Text = "D".ToLower Or txtGrade.Text = "DROP".ToLower Then
            lblremarks.Text = "Dropped"
        ElseIf txtGrade.Text = "" Then
            lblremarks.Text = "No Grade"
        ElseIf txtGrade.Text = "6" Or txtGrade.Text = "7" Or txtGrade.Text = "8" Or txtGrade.Text = "9" Then
            txtGrade.Text = Nothing
            lblremarks.Text = Nothing
        ElseIf txtGrade.Text = "3." Or txtGrade.Text = "44" Or txtGrade.Text = "4." Then
            txtGrade.Text = Nothing
            lblremarks.Text = Nothing
        ElseIf txtGrade.Text = "5." Or txtGrade.Text = "55" Then
            txtGrade.Text = Nothing
            lblremarks.Text = Nothing
        ElseIf txtGrade.Text = Nothing Then
            lblremarks.Text = Nothing
        Else
            lblremarks.Text = "Passed"
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'for dropping panel for adding grade
        If drop Then
            Panel5.Height += 10
            If Panel5.Size = Panel5.MaximumSize Then
                Timer1.Stop()
                drop = False
            End If
        End If

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If txtGrade.Text = "4" Or txtGrade.Text = "4.0" Or txtGrade.Text = "INC".ToLower Then 'FOR INC

            connection.Open()
            command = New MySqlCommand("update tbl_grades SET col_grades= 'INC' where col_subcode='" & lblsubcode.Text & "' and col_studentID='" & txtStdntID.Text & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Grade Inserted!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            propectus()
            connection.Close()

            'FOR ACTIVITY LOG
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' GRADED a '" & txttype.Text.ToUpper & "' student named '" & txtfname.Text.ToUpper & "' ('" & txtStdntID.Text & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Form11.loadgdv()
        ElseIf txtGrade.Text = "5" Or txtGrade.Text = "5.0" Then 'FOR FAILED

            connection.Open()
            command = New MySqlCommand("update tbl_grades SET col_grades= 'Failed' where col_subcode='" & lblsubcode.Text & "' and col_studentID='" & txtStdntID.Text & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Grade Inserted!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            propectus()
            connection.Close()

            'FOR ACTIVITY LOG
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' GRADED a '" & txttype.Text.ToUpper & "' student named '" & txtfname.Text.ToUpper & "' ('" & txtStdntID.Text & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Form11.loadgdv()
        ElseIf txtGrade.Text = "D" Or txtGrade.Text = "Drop" Or txtGrade.Text = "d" Then 'FOR Drop

            connection.Open()
            command = New MySqlCommand("update tbl_grades SET col_grades= 'Drop' where col_subcode='" & lblsubcode.Text & "' and col_studentID='" & txtStdntID.Text & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Grade Inserted!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            propectus()
            connection.Close()

            'FOR ACTIVITY LOG
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' GRADED a '" & txttype.Text.ToUpper & "' student named '" & txtfname.Text.ToUpper & "' ('" & txtStdntID.Text & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Form11.loadgdv()
        ElseIf txtGrade.Text = "" Then
            MessageBox.Show("Please Input a Grade!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else 'MAIN INSERT GRADE
            connection.Open()
            command = New MySqlCommand("update tbl_grades SET col_grades='" & txtGrade.Text & "' where col_subcode='" & lblsubcode.Text & "' and col_studentID='" & txtStdntID.Text & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Grade Inserted!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            propectus()
            connection.Close()

            'FOR ACTIVITY LOG
            connection.Close()
            connection.Open()
            command = New MySqlCommand("Insert into tbl_history (Description) values (@desc)", connection)
            command.Parameters.Add(New MySqlParameter("@desc", MySqlDbType.VarChar, 200)).Value = "Adviser '" & Form1.TextBox1.Text.ToUpper & "' GRADED a '" & txttype.Text.ToUpper & "' student named '" & txtfname.Text.ToUpper & "' ('" & txtStdntID.Text & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Form11.loadgdv()
        End If
        lblsubcode.Text = Nothing
        txtGrade.Text = Nothing
        Panel5.Size = Panel5.MinimumSize
        Timer1.Stop()
        drop = True

    End Sub
    '__________________________________________for clicking Datagrid_________________________________________________________

    Private Sub dgv1y1s_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1y1s.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        txtGrade.Text = dgv1y1s.Item(0, e.RowIndex).Value.ToString
        lblsubcode.Text = dgv1y1s.Item(1, e.RowIndex).Value.ToString
        If lblsubcode.Text = Nothing Then

        Else
            Timer1.Start()
        End If


    End Sub
    Private Sub dgv1y2s_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1y2s.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        txtGrade.Text = dgv1y2s.Item(0, e.RowIndex).Value.ToString
        lblsubcode.Text = dgv1y2s.Item(1, e.RowIndex).Value.ToString
        If lblsubcode.Text = Nothing Then

        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub dgv2y1s_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2y1s.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        txtGrade.Text = dgv2y1s.Item(0, e.RowIndex).Value.ToString
        lblsubcode.Text = dgv2y1s.Item(1, e.RowIndex).Value.ToString
        If lblsubcode.Text = Nothing Then

        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub dgv2y2s_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2y2s.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        txtGrade.Text = dgv2y2s.Item(0, e.RowIndex).Value.ToString
        lblsubcode.Text = dgv2y2s.Item(1, e.RowIndex).Value.ToString
        If lblsubcode.Text = Nothing Then

        Else
            Timer1.Start()
        End If
    End Sub
    Private Sub dgv3y1s_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv3y1s.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        txtGrade.Text = dgv3y1s.Item(0, e.RowIndex).Value.ToString
        lblsubcode.Text = dgv3y1s.Item(1, e.RowIndex).Value.ToString
        If lblsubcode.Text = Nothing Then

        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub dgv3y2s_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv3y2s.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        txtGrade.Text = dgv3y2s.Item(0, e.RowIndex).Value.ToString
        lblsubcode.Text = dgv3y2s.Item(1, e.RowIndex).Value.ToString
        If lblsubcode.Text = Nothing Then

        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub dgv4y1s_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv4y1s.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        txtGrade.Text = dgv4y1s.Item(0, e.RowIndex).Value.ToString
        lblsubcode.Text = dgv4y1s.Item(1, e.RowIndex).Value.ToString
        If lblsubcode.Text = Nothing Then

        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub dgv4y2s_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv4y2s.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        txtGrade.Text = dgv4y2s.Item(0, e.RowIndex).Value.ToString
        lblsubcode.Text = dgv4y2s.Item(1, e.RowIndex).Value.ToString
        If lblsubcode.Text = Nothing Then

        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub txtStdntID_TextChanged(sender As Object, e As EventArgs) Handles txtStdntID.TextChanged

        connection.Close()
        'for full name of student in textbox
        connection.Open()
        command = New MySqlCommand("Select * from tbl_student where col_StudID = '" & txtStdntID.Text & "'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim LName = dataReader.GetString("col_Lname")
            Dim Fname = dataReader.GetString("col_Fname")
            Dim Mname = dataReader.GetString("col_MN")
            Dim type = dataReader.GetString("col_type")

            txtlname.Text = LName
            txtfname.Text = Fname
            txtmn.Text = Mname
            txttype.Text = type
        End While

        If txtStdntID.Text = "" Then
            txtlname.Clear()
            txtfname.Clear()
            txtmn.Clear()
            txttype.Clear()
        End If
        'for clearing datagrid if id not exist to database
        connection.Close()
        connection.Open()
        command = New MySqlCommand("select * from tbl_student where col_StudID = '" & txtStdntID.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim sid As Integer
        sid = 0
        While dataReader.Read
            sid = sid + 1
        End While

        If sid = 1 Then
            connection.Close()
            propectus()
        Else
            dgv1y1s.DataSource = Nothing
            dgv1y2s.DataSource = Nothing
            dgv2y1s.DataSource = Nothing
            dgv2y2s.DataSource = Nothing
            dgv3y1s.DataSource = Nothing
            dgv3y2s.DataSource = Nothing
            dgv4y1s.DataSource = Nothing
            dgv4y2s.DataSource = Nothing
        End If

    End Sub
    Public Sub propectus()
        Dim tbl As New DataTable 'data table for first year first sem
        Dim tbl1 As New DataTable 'data table for first year second sem
        Dim tbl2 As New DataTable 'data table for second year first sem
        Dim tbl3 As New DataTable 'data table for second year second sem
        Dim tbl3y1s As New DataTable 'data table for Third year 1st sem
        Dim tbl3y2s As New DataTable 'data table for Third year 2st sem
        Dim tbl4y1s As New DataTable 'data table for fourth year 1st sem
        Dim tbl4y2s As New DataTable 'data table for Fourth year 2st sem
        '--------------------------------------------------------FOR PROSPECTUS-----------------------------------------------------------------'
        ' DATAGRID FOR 
        ' 1ST YEAR
        '1ST SEM
        connection.Close()
        connection.Open()
        command = New MySqlCommand("SELECT
                                        tbl_grades.col_grades AS 'Grades',
                                        tbl_grades.col_subcode AS 'Subject Code',
                                        tbl_subject.col_subTitle AS 'Subject Title',
                                        tbl_subject.col_Units as 'Units',
                                        tbl_subject.col_lec as 'Lec',
                                        tbl_subject.col_lab as 'Lab',
                                        tbl_subject.col_PreRequisite as 'Pre-Requisite'
                                    FROM
                                        tbl_grades
                                    INNER JOIN tbl_subject ON tbl_grades.col_subcode = tbl_subject.col_subcode
                                    WHERE
                                    tbl_grades.col_StudentID = '" & txtStdntID.Text & "' AND tbl_subject.col_yrLvl = 'First Year' AND tbl_subject.col_sem = 'First Semester' ", connection)
        adptr.SelectCommand = command
        tbl.Clear()
        adptr.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            dgv1y1s.DataSource = tbl
        End If

        For intI = dgv1y1s.Rows.Count - 1 To 0 Step -1 'mag delete ng subject pag doble
            For intJ = intI - 1 To 0 Step -1
                If dgv1y1s.Rows(intI).Cells(1).Value = dgv1y1s.Rows(intJ).Cells(1).Value AndAlso dgv1y1s.Rows(intI).Cells(3).Value = dgv1y1s.Rows(intJ).Cells(3).Value Then
                    dgv1y1s.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next

        Dim sum As Double = 0   'Totalling pf Units
        For i As Double = 0 To dgv1y1s.Rows.Count() - 1 Step +1
            sum = sum + dgv1y1s.Rows(i).Cells(3).Value
        Next
        txtunits1y1s.Text = sum.ToString()

        connection.Close()



        ' DATAGRID FOR 
        ' 1ST YEAR
        '2ND SEM
        connection.Open()
        command = New MySqlCommand("SELECT
                                        tbl_grades.col_grades AS 'Grades',
                                        tbl_grades.col_subcode AS 'Subject Code',
                                        tbl_subject.col_subTitle AS 'Subject Title',
                                        tbl_subject.col_Units as 'Units',
                                        tbl_subject.col_lec as 'Lec',
                                        tbl_subject.col_lab as 'Lab',
                                        tbl_subject.col_PreRequisite as 'Pre-Requisite'
                                    FROM
                                        tbl_grades
                                    INNER JOIN tbl_subject ON tbl_grades.col_subcode = tbl_subject.col_subcode
                                    WHERE
                                    tbl_grades.col_StudentID = '" & txtStdntID.Text & "' AND tbl_subject.col_yrLvl = 'First Year' AND tbl_subject.col_sem = 'Second Semester' ", connection)
        adptr.SelectCommand = command
        tbl1.Clear()
        adptr.Fill(tbl1)
        If tbl1.Rows.Count > 0 Then
            dgv1y2s.DataSource = tbl1
        End If

        For intI = dgv1y2s.Rows.Count - 1 To 0 Step -1 'mag delete ng subject pag doble
            For intJ = intI - 1 To 0 Step -1
                If dgv1y2s.Rows(intI).Cells(1).Value = dgv1y2s.Rows(intJ).Cells(1).Value AndAlso dgv1y2s.Rows(intI).Cells(3).Value = dgv1y2s.Rows(intJ).Cells(3).Value Then
                    dgv1y2s.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next


        Dim sum1 As Double = 0   'Totalling pf Units
        For i1 As Double = 0 To dgv1y2s.Rows.Count() - 1 Step +1
            sum1 = sum1 + dgv1y2s.Rows(i1).Cells(3).Value
        Next
        txtunits1y2s.Text = sum1.ToString()
        connection.Close()

        ' DATAGRID FOR 
        ' 2ND YEAR
        '1ST SEM

        connection.Open()
        command = New MySqlCommand("SELECT
                                        tbl_grades.col_grades AS 'Grades',
                                        tbl_grades.col_subcode AS 'Subject Code',
                                        tbl_subject.col_subTitle AS 'Subject Title',
                                        tbl_subject.col_Units as 'Units',
                                        tbl_subject.col_lec as 'Lec',
                                        tbl_subject.col_lab as 'Lab',
                                        tbl_subject.col_PreRequisite as 'Pre-Requisite'
                                    FROM
                                        tbl_grades
                                    INNER JOIN tbl_subject ON tbl_grades.col_subcode = tbl_subject.col_subcode
                                    WHERE
                                    tbl_grades.col_StudentID = '" & txtStdntID.Text & "' AND tbl_subject.col_yrLvl = 'Second Year' AND tbl_subject.col_sem = 'First Semester' ", connection)
        adptr.SelectCommand = command
        tbl2.Clear()
        adptr.Fill(tbl2)
        If tbl2.Rows.Count > 0 Then
            dgv2y1s.DataSource = tbl2
        End If

        For intI = dgv2y1s.Rows.Count - 1 To 0 Step -1 'mag delete ng subject pag doble
            For intJ = intI - 1 To 0 Step -1
                If dgv2y1s.Rows(intI).Cells(1).Value = dgv2y1s.Rows(intJ).Cells(1).Value AndAlso dgv2y1s.Rows(intI).Cells(3).Value = dgv2y1s.Rows(intJ).Cells(3).Value Then
                    dgv2y1s.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next

        Dim sum2 As Double = 0   'Totalling pf Units
        For i2 As Double = 0 To dgv2y1s.Rows.Count() - 1 Step +1
            sum2 = sum2 + dgv2y1s.Rows(i2).Cells(3).Value
        Next
        txtunits2y1s.Text = sum2.ToString()


        connection.Close()

        ' DATAGRID FOR 
        ' 2ND YEAR
        '2nd SEM

        connection.Open()
        command = New MySqlCommand("SELECT
                                        tbl_grades.col_grades AS 'Grades',
                                        tbl_grades.col_subcode AS 'Subject Code',
                                        tbl_subject.col_subTitle AS 'Subject Title',
                                        tbl_subject.col_Units as 'Units',
                                        tbl_subject.col_lec as 'Lec',
                                        tbl_subject.col_lab as 'Lab',
                                        tbl_subject.col_PreRequisite as 'Pre-Requisite'
                                    FROM
                                        tbl_grades
                                    INNER JOIN tbl_subject ON tbl_grades.col_subcode = tbl_subject.col_subcode
                                    WHERE
                                    tbl_grades.col_StudentID = '" & txtStdntID.Text & "' AND tbl_subject.col_yrLvl = 'Second Year' AND tbl_subject.col_sem = 'Second Semester' ", connection)
        adptr.SelectCommand = command
        tbl3.Clear()
        adptr.Fill(tbl3)
        If tbl3.Rows.Count > 0 Then
            dgv2y2s.DataSource = tbl3
        End If

        For intI = dgv2y2s.Rows.Count - 1 To 0 Step -1 'mag delete ng subject pag doble
            For intJ = intI - 1 To 0 Step -1
                If dgv2y2s.Rows(intI).Cells(1).Value = dgv2y2s.Rows(intJ).Cells(1).Value AndAlso dgv2y2s.Rows(intI).Cells(3).Value = dgv2y2s.Rows(intJ).Cells(3).Value Then
                    dgv2y2s.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next

        Dim sum3 As Double = 0   'Totalling pf Units
        For i2 As Double = 0 To dgv2y2s.Rows.Count() - 1 Step +1
            sum3 = sum3 + dgv2y2s.Rows(i2).Cells(3).Value
        Next
        txtunits2y2s.Text = sum3.ToString()
        connection.Close()


        ' DATAGRID FOR 
        ' 3rd YEAR
        '1st SEM
        connection.Open()
        command = New MySqlCommand("SELECT
                                        tbl_grades.col_grades AS 'Grades',
                                        tbl_grades.col_subcode AS 'Subject Code',
                                        tbl_subject.col_subTitle AS 'Subject Title',
                                        tbl_subject.col_Units as 'Units',
                                        tbl_subject.col_lec as 'Lec',
                                        tbl_subject.col_lab as 'Lab',
                                        tbl_subject.col_PreRequisite as 'Pre-Requisite'
                                    FROM
                                        tbl_grades
                                    INNER JOIN tbl_subject ON tbl_grades.col_subcode = tbl_subject.col_subcode
                                    WHERE
                                    tbl_grades.col_StudentID = '" & txtStdntID.Text & "' AND tbl_subject.col_yrLvl = 'Third Year' AND tbl_subject.col_sem = 'First Semester' ", connection)
        adptr.SelectCommand = command
        tbl3y1s.Clear()
        adptr.Fill(tbl3y1s)
        If tbl3y1s.Rows.Count > 0 Then
            dgv3y1s.DataSource = tbl3y1s
        End If

        For intI = dgv3y1s.Rows.Count - 1 To 0 Step -1 'mag delete ng subject pag doble
            For intJ = intI - 1 To 0 Step -1
                If dgv3y1s.Rows(intI).Cells(1).Value = dgv3y1s.Rows(intJ).Cells(1).Value AndAlso dgv3y1s.Rows(intI).Cells(3).Value = dgv3y1s.Rows(intJ).Cells(3).Value Then
                    dgv3y1s.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next

        Dim sum3y1s As Double = 0   'Totalling pf Units
        For i As Double = 0 To dgv3y1s.Rows.Count() - 1 Step +1
            sum3y1s = sum3y1s + dgv3y1s.Rows(i).Cells(3).Value
        Next
        txt3y1s.Text = sum3y1s.ToString()

        connection.Close()


        ' DATAGRID FOR 
        ' 3rd YEAR
        '2nd SEM
        connection.Open()
        command = New MySqlCommand("SELECT
                                        tbl_grades.col_grades AS 'Grades',
                                        tbl_grades.col_subcode AS 'Subject Code',
                                        tbl_subject.col_subTitle AS 'Subject Title',
                                        tbl_subject.col_Units as 'Units',
                                        tbl_subject.col_lec as 'Lec',
                                        tbl_subject.col_lab as 'Lab',
                                        tbl_subject.col_PreRequisite as 'Pre-Requisite'
                                    FROM
                                        tbl_grades
                                    INNER JOIN tbl_subject ON tbl_grades.col_subcode = tbl_subject.col_subcode
                                    WHERE
                                    tbl_grades.col_StudentID = '" & txtStdntID.Text & "' AND tbl_subject.col_yrLvl = 'Third Year' AND tbl_subject.col_sem = 'Second Semester' ", connection)
        adptr.SelectCommand = command
        tbl3y2s.Clear()
        adptr.Fill(tbl3y2s)
        If tbl3y2s.Rows.Count > 0 Then
            dgv3y2s.DataSource = tbl3y2s
        End If

        For intI = dgv3y2s.Rows.Count - 1 To 0 Step -1 'mag delete ng subject pag doble
            For intJ = intI - 1 To 0 Step -1
                If dgv3y2s.Rows(intI).Cells(1).Value = dgv3y2s.Rows(intJ).Cells(1).Value AndAlso dgv3y2s.Rows(intI).Cells(3).Value = dgv3y2s.Rows(intJ).Cells(3).Value Then
                    dgv3y2s.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next

        Dim sum3y2s As Double = 0   'Totalling pf Units
        For i As Double = 0 To dgv3y2s.Rows.Count() - 1 Step +1
            sum3y2s = sum3y2s + dgv3y2s.Rows(i).Cells(3).Value
        Next
        txt3y2s.Text = sum3y2s.ToString()

        connection.Close()


        ' DATAGRID FOR 
        ' 4th YEAR
        '1st SEM
        connection.Open()
        command = New MySqlCommand("SELECT
                                        tbl_grades.col_grades AS 'Grades',
                                        tbl_grades.col_subcode AS 'Subject Code',
                                        tbl_subject.col_subTitle AS 'Subject Title',
                                        tbl_subject.col_Units as 'Units',
                                        tbl_subject.col_lec as 'Lec',
                                        tbl_subject.col_lab as 'Lab',
                                        tbl_subject.col_PreRequisite as 'Pre-Requisite'
                                    FROM
                                        tbl_grades
                                    INNER JOIN tbl_subject ON tbl_grades.col_subcode = tbl_subject.col_subcode
                                    WHERE
                                    tbl_grades.col_StudentID = '" & txtStdntID.Text & "' AND tbl_subject.col_yrLvl = 'Fourth Year' AND tbl_subject.col_sem = 'First Semester' ", connection)
        adptr.SelectCommand = command
        tbl4y1s.Clear()
        adptr.Fill(tbl4y1s)
        If tbl4y1s.Rows.Count > 0 Then
            dgv4y1s.DataSource = tbl4y1s
        End If

        For intI = dgv4y1s.Rows.Count - 1 To 0 Step -1 'mag delete ng subject pag doble
            For intJ = intI - 1 To 0 Step -1
                If dgv4y1s.Rows(intI).Cells(1).Value = dgv4y1s.Rows(intJ).Cells(1).Value AndAlso dgv4y1s.Rows(intI).Cells(3).Value = dgv4y1s.Rows(intJ).Cells(3).Value Then
                    dgv4y1s.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next

        Dim sum4y1s As Double = 0   'Totalling pf Units
        For i As Double = 0 To dgv4y1s.Rows.Count() - 1 Step +1
            sum4y1s = sum4y1s + dgv4y1s.Rows(i).Cells(3).Value
        Next
        txt4y1s.Text = sum4y1s.ToString()

        connection.Close()


        ' DATAGRID FOR 
        ' 4th YEAR
        '2nd SEM
        connection.Open()
        command = New MySqlCommand("SELECT
                                        tbl_grades.col_grades AS 'Grades',
                                        tbl_grades.col_subcode AS 'Subject Code',
                                        tbl_subject.col_subTitle AS 'Subject Title',
                                        tbl_subject.col_Units as 'Units',
                                        tbl_subject.col_lec as 'Lec',
                                        tbl_subject.col_lab as 'Lab',
                                        tbl_subject.col_PreRequisite as 'Pre-Requisite'
                                    FROM
                                        tbl_grades
                                    INNER JOIN tbl_subject ON tbl_grades.col_subcode = tbl_subject.col_subcode
                                    WHERE
                                    tbl_grades.col_StudentID = '" & txtStdntID.Text & "' AND tbl_subject.col_yrLvl = 'Fourth Year' AND tbl_subject.col_sem = 'Second Semester' ", connection)
        adptr.SelectCommand = command
        tbl4y2s.Clear()
        adptr.Fill(tbl4y2s)
        If tbl4y2s.Rows.Count > 0 Then
            dgv4y2s.DataSource = tbl4y2s
        End If

        For intI = dgv4y2s.Rows.Count - 1 To 0 Step -1 'mag delete ng subject pag doble
            For intJ = intI - 1 To 0 Step -1
                If dgv4y2s.Rows(intI).Cells(1).Value = dgv4y2s.Rows(intJ).Cells(1).Value AndAlso dgv4y2s.Rows(intI).Cells(3).Value = dgv4y2s.Rows(intJ).Cells(3).Value Then
                    dgv4y2s.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next

        Dim sum4y2s As Double = 0   'Totalling pf Units
        For i As Double = 0 To dgv4y2s.Rows.Count() - 1 Step +1
            sum4y2s = sum4y2s + dgv4y2s.Rows(i).Cells(3).Value
        Next
        txt4y2s.Text = sum4y2s.ToString()

        connection.Close()
    End Sub

    Private Sub txtGrade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrade.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allownum As String = "0123456789"
            Dim allowletter As String = "dD"
            Dim allowsym As String = "."

            If Not allownum.Contains(e.KeyChar.ToString) And Not allowletter.Contains(e.KeyChar.ToString) And Not allowsym.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("Press 5 = Failed" & vbCrLf & "Press 4 = INC" & vbCrLf & "Press D = Drop", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
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