Public Class Form1
    Dim LABELS() As String = {"First Name: ", "Middle Name: ", "Last Name: ", "Employee #: ", "Email Addr: ", "Telephone: ", "Extension ", "Department "}
    Dim Filename As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Filename += InputBox("What would you like to name this file?", "Input")
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Writer As IO.StreamWriter = New IO.StreamWriter(Filename)
        Dim index = 0
        Dim textcontrol As Control
        For Each textcontrol In textPanel.Controls
            If (TypeOf textcontrol Is TextBox) Then
                Writer.Write(LABELS(index) + " " + textcontrol.Text)
            ElseIf (TypeOf textcontrol Is ComboBox) Then
                Writer.Write(LABELS(index) + " " + TryCast(textcontrol, ComboBox).SelectedItem)
            End If
            Writer.Write(vbNewLine)
            index += 1
        Next
        Writer.Close()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim textcontrol As Control
        For Each textcontrol In textPanel.Controls
            If (TypeOf textcontrol Is TextBox) Then
                textcontrol.Text = ""
            ElseIf (TypeOf textcontrol Is ComboBox) Then
                TryCast(textcontrol, ComboBox).SelectedIndex = 0
            End If

        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class
