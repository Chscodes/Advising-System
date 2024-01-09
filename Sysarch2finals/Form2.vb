Public Class Form2
    Dim drop1 As Boolean = True
    Dim drop2 As Boolean = True
    Dim dropad As Boolean = True


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnl_drop1.Size = pnl_drop1.MinimumSize
        pnl_drop2.Size = pnl_drop2.MinimumSize
        pnlyear.Size = pnlyear.MinimumSize
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Logout As Integer = MessageBox.Show("Are you sure want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Logout = DialogResult.Yes Then
            Form1.clearText()
            Me.Close()
            Form1.Show()
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form1.Show()
    End Sub

    '--------------------------------------------Linking-----------------------------------------------------------'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProspectus.Click
        With Form4
            .TopLevel = False
            Panel5.Controls.Add(Form4)
            .BringToFront()
            .Show()
            Form4.Size = Panel5.Size
        End With
    End Sub
    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        With Form4
            .TopLevel = False
            Panel5.Controls.Add(Form4)
            .BringToFront()
            .Show()
            Form4.Size = Panel5.Size
        End With
    End Sub

    '--------------------------------------------Reg dropdown-----------------------------------------------------------'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If drop1 Then
            btnregA.Image = My.Resources.down_arrow
            pnl_drop1.Height += 10
            If pnl_drop1.Size = pnl_drop1.MaximumSize Then
                Timer1.Stop()
                drop1 = False
            End If
        Else
            btnregA.Image = My.Resources.right_arrow
            pnl_drop1.Height -= 10
            If pnl_drop1.Size = pnl_drop1.MinimumSize Then
                Timer1.Stop()
                drop1 = True
            End If
        End If
    End Sub
    Private Sub btnregA_Click(sender As Object, e As EventArgs) Handles btnregA.Click
        drop2 = False
        Timer1.Start()
        Timer2.Start()
    End Sub

    '--------------------------------------------Transfereee dropdown-----------------------------------------------------------'
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If drop2 Then
            btnTransf.Image = My.Resources.down_arrow
            pnl_drop2.Height += 10
            If pnl_drop2.Size = pnl_drop2.MaximumSize Then
                Timer2.Stop()
                drop2 = False
            End If
        Else
            btnTransf.Image = My.Resources.right_arrow
            pnl_drop2.Height -= 10
            If pnl_drop2.Size = pnl_drop2.MinimumSize Then
                Timer2.Stop()
                drop2 = True
            End If
        End If
    End Sub
    Private Sub btnTransf_Click(sender As Object, e As EventArgs) Handles btnTransf.Click
        drop1 = False
        Timer1.Start()
        Timer2.Start()
    End Sub

    '--------------------------------------------Advise dropdown-----------------------------------------------------------'
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If dropad Then
            pnlyear.Height += 10
            If pnlyear.Size = pnlyear.MaximumSize Then
                Timer5.Stop()
                dropad = False
            End If
        Else
            pnlyear.Height -= 10
            If pnlyear.Size = pnlyear.MinimumSize Then
                Timer5.Stop()
                dropad = True
            End If
        End If
    End Sub
    Private Sub btnadvise_Click(sender As Object, e As EventArgs) Handles btnadvise.Click
        drop1 = False
        drop2 = False

        Timer1.Start()
        Timer2.Start()
        Timer5.Start()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        With Form7
            .TopLevel = False
            Panel5.Controls.Add(Form7)
            .BringToFront()
            .Show()
            Form7.Size = Panel5.Size
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddSub.Click
        With Form6
            .TopLevel = False
            Panel5.Controls.Add(Form6)
            .BringToFront()
            .Show()
            Form6.Size = Panel5.Size
        End With
    End Sub

    Private Sub btnregEval_Click(sender As Object, e As EventArgs) Handles btnregEval.Click
        With Form5
            .TopLevel = False
            Panel5.Controls.Add(Form5)
            .BringToFront()
            .Show()
            Form5.Size = Panel5.Size
        End With
    End Sub

    Private Sub btnregADD_Click(sender As Object, e As EventArgs) Handles btnregADD.Click
        With Form3

            .TopLevel = False
            Panel5.Controls.Add(Form3)
            .BringToFront()
            .Show()
            Form3.Size = Panel5.Size
        End With
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        With Form11

            .TopLevel = False
            Panel5.Controls.Add(Form11)
            .BringToFront()
            .Show()
            Form11.Size = Panel5.Size
        End With
    End Sub
End Class