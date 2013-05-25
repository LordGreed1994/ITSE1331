Public Class InputDialog


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (isCorrectData()) Then
            Me.Close()
        Else
            MessageBox.Show("All data input must be numeric")
        End If
    End Sub

    Private Function isCorrectData() As Boolean
        Dim Index As Integer
        Dim control As Control
        Index = 11
        For Each control In Me.Controls
            If (TypeOf control Is TextBox) Then
                If (Not IsNumeric(control.Text)) Then
                    Return False
                Else
                    RainfallStats.RAINFALL(Index) = Integer.Parse(control.Text)
                End If
                Index -= 1
            End If
        Next
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each control In Me.Controls
            If (TypeOf control Is TextBox) Then
                TryCast(control, TextBox).Text = ""
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class