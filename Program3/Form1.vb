Public Class Form1

    Dim total As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim findNum As Boolean
        findNum = Check()
        If findNum Then
            total += Integer.Parse(TextBox2.Text) + Integer.Parse(TextBox3.Text) + Integer.Parse(TextBox4.Text) +
            Integer.Parse(TextBox5.Text) + Integer.Parse(TextBox6.Text)
            total = total / 5
            TextBox1.Text = total
        Else
            MessageBox.Show("The textboxes should contain only numbers!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    ' Helper functions
    ' The Check Function returns true if the textboxes all have numbers, and false otherwise.
    Private Function Check() As Boolean

        Dim textbox As Control
        For Each textbox In Me.Controls
            If (TypeOf textbox Is TextBox) Then
                If Not IsNumeric(Trim(textbox.Text)) Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    ' Clear goes through all of the textboxes in the form, and sets them to Zero
    ' for the Clear subroutine
    Private Sub Clear()
        Dim textbox As Control
        For Each textbox In Me.Controls
            If (TypeOf textbox Is TextBox) Then
                textbox.Text = "0"
            End If
        Next
    End Sub

End Class
