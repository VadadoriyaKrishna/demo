Public Class tic_tac_toe

    Private Sub tic_tac_toe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "tic_tac_toe game"
        lblname.Text = "Player1:X"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        Dim btn1 As Button = sender
        display(btn1)

    End Sub
    Sub display(ByVal btn As Button)
        If btn.Text = "" Then
            If lblname.Text = "Player1:X" Then
                btn.Text = "X"
                lblname.Text = "Player2:0"
            Else
                btn.Text = "0"
                lblname.Text = "Player1:X"
            End If
            checkwinner()

        End If
    End Sub
    Sub checkwinner()
        If (Button1.Text = Button2.Text And Button2.Text = Button3.Text And Button1.Text <> "" And Button2.Text <> "" And Button3.Text <> "") _
         Or (Button4.Text = Button5.Text And Button5.Text = Button6.Text And Button4.Text <> "" And Button5.Text <> "" And Button6.Text <> "") _
         Or (Button7.Text = Button8.Text And Button8.Text = Button9.Text And Button7.Text <> "" And Button8.Text <> "" And Button9.Text <> "") _
         Or (Button1.Text = Button4.Text And Button4.Text = Button7.Text And Button1.Text <> "" And Button4.Text <> "" And Button7.Text <> "") _
         Or (Button2.Text = Button5.Text And Button5.Text = Button8.Text And Button2.Text <> "" And Button5.Text <> "" And Button8.Text <> "") _
         Or (Button3.Text = Button6.Text And Button6.Text = Button9.Text And Button3.Text <> "" And Button6.Text <> "" And Button9.Text <> "") _
         Or (Button1.Text = Button5.Text And Button5.Text = Button9.Text And Button1.Text <> "" And Button5.Text <> "" And Button9.Text <> "") _
         Or (Button3.Text = Button5.Text And Button5.Text = Button7.Text And Button3.Text <> "" And Button5.Text <> "" And Button7.Text <> "") Then
            If lblname.Text = "Player1:X" Then
                MessageBox.Show("Playyer 2 is winner.")
            Else
                MessageBox.Show("Playyer 1 is winner.")
            End If
            Call clearcontrols()
        ElseIf (Button1.Text <> "" And Button2.Text <> "" And Button3.Text <> "" And Button4.Text <> "" And Button5.Text <> "" And Button6.Text <> "" And Button7.Text <> "" And Button8.Text <> "" And Button9.Text <> "") Then
            MessageBox.Show("Nobody is winner")

            clearcontrols()



        End If




    End Sub
    Sub clearcontrols()
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
    End Sub

    Private Sub lblname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblname.Click

    End Sub
End Class