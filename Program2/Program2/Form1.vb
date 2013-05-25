Public Class Form1
    ' Each Subroutine maps to a .Click event per Button Clicked.
    ' Each Button will produce the correct abbreviation.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        State_Label_Abb.Text = "VA"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        State_Label_Abb.Text = "NC"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        State_Label_Abb.Text = "SC"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        State_Label_Abb.Text = "GA"
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        State_Label_Abb.Text = "AL"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        State_Label_Abb.Text = "FL"
    End Sub

End Class
