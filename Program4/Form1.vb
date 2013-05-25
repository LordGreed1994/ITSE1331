Public Class Form1

    ' Event SubRoutines
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter three Runner's Names " + ControlChars.NewLine + "and Finishing Times!"
        Label6.Text = "Finishing Time" + ControlChars.NewLine + "(in Seconds)"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim TextBoxes As Control
        For Each TextBoxes In textPanel.Controls
            TextBoxes.Text = " "
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DoWork = CalculatePlace()


        If (DoWork) Then
            Dim finish1 = Integer.Parse(Finish1_Textbox.Text)
            Dim finish2 = Integer.Parse(Finish2_Textbox.Text)
            Dim finish3 = Integer.Parse(Finish3_Textbox.Text)

            Dim Runner1, Runner2, Runner3
            Runner1 = Runner1_TextBox.Text
            Runner2 = Runner2_TextBox.Text
            Runner3 = Runner3_TextBox.Text

            If (Math.Max(finish1, finish2) = finish1 And Math.Max(finish1, finish3) = finish1) Then
                Winner1.Text = Runner1
                Winner2.Text = Runner2
                If (Math.Max(finish2, finish3) = finish2) Then
                    Winner3.Text = Runner3
                Else
                    Winner2.Text = Runner3
                    Winner3.Text = Runner2
                End If
            ElseIf (Math.Max(finish1, finish2) = finish2 And Math.Max(finish2, finish3) = finish2) Then
                Winner1.Text = Runner2
                Winner2.Text = Runner1
                If (Math.Max(finish1, finish3) = finish1) Then
                    Winner3.Text = Runner3
                Else
                    Winner2.Text = Runner3
                    Winner3.Text = Runner1
                End If
            Else
                Winner1.Text = Runner3
                If (Math.Max(finish1, finish2) = finish2) Then
                    Winner2.Text = Runner2
                    Winner3.Text = Runner1

                Else
                    Winner2.Text = Runner1
                    Winner3.Text = Runner2
                End If
            End If

        End If
    End Sub

    ' Helper Functions

    ' Returns True if Numeric, Not blank, and non-negative
    Private Function CalculatePlace() As Boolean
        If Not (ErrorCheck(Finish1_Textbox) And ErrorCheck(Finish2_Textbox) And ErrorCheck(Finish3_Textbox) And Not isBlank()) Then
            MessageBox.Show("ERROR!! Ensure that the Runner Names are not blank and the Finishing Times are non-negative Numerics")
            Return False
        End If
        Return True
    End Function

    ' Returns True if the textbox has a number and if the number is nonnegative
    Private Function ErrorCheck(ByVal TextBox As TextBox) As Boolean
        If (IsNumeric(Trim(TextBox.Text))) Then
            If (TextBox.Text >= 0) Then
                Return True
            End If
        End If
        Return False
    End Function

    ' Returns true if textbox is blank
    Private Function isBlank() As Boolean

        Dim TextBoxes As Control
        For Each TextBoxes In textPanel.Controls
            If (Trim(TextBoxes.Text).Length = 0) Then
                Return True
            End If
        Next

        Return False
    End Function

End Class
