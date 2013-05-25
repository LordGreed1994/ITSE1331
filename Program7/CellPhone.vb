Public Class CellPhone

    Private Sub CellPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "The Individual Plan provides one " + vbNewLine +
                      "cell phone and a variety" + vbNewLine +
                      " of monthly packages."
        Label2.Text = "The family plan allows you to" + vbNewLine +
                      "purchase multiple cell phones of" + vbNewLine +
                      " the same model, with each phone " + vbNewLine +
                      "sharing one monthly package."
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FamilyPlan.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IndividualPlan.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class