Public Class Form1

    ReadOnly LOCATIONS = {95, 125, 110, 100, 92, 90}
    ReadOnly DAYS = {3, 3, 3, 5, 1}
    ReadOnly REGISTRATION = {595, 695, 995, 1295, 395}
    ReadOnly WORKSHOPS = {"Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview"}
    ReadOnly CITIES = {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"}
    Dim Total = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim workshopIndex = ListBox1.SelectedIndex
        Dim locationIndex = ListBox2.SelectedIndex
        If (isSelected()) Then
            Total += REGISTRATION(workshopIndex) + (DAYS(workshopIndex) * LOCATIONS(locationIndex))
            ListBox3.Items.Add(WORKSHOPS(workshopIndex) + " in " + CITIES(locationIndex))
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TotalCost_TextBox.Text = Total
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.ClearSelected()
        ListBox2.ClearSelected()
        ListBox3.Items.Clear()
        TotalCost_TextBox.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    ' Helper Method

    Private Function isSelected() As Boolean
        If (ListBox1.SelectedItems.Count = Nothing Or ListBox2.SelectedItems.Count = Nothing) Then
            MessageBox.Show("You must select items from the Workshop and Location to continue.")
            Return False
        End If
        Return True
    End Function


End Class
