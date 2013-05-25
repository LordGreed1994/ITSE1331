Public Class RainfallStats
    ' Public so that the other form can mutate.
    ' Could have used properties, but this is easier
    Public Rainfall As Integer() = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}

    'Enumerated the months for easier access.
    ReadOnly MONTHS = {"January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

    Private Sub DisplayStatsB_Click(sender As Object, e As EventArgs) Handles DisplayStatsB.Click
        Dim i = 0
        Dim LargestNumber
        Dim IndexOfLargest
        Dim SmallestNumber
        Dim IndexOfSmallest
        Dim Average As Double = 0.0
        Dim Total = 0

        ListBox1.Items.Add("Monthly Rainfall Input")
        ListBox1.Items.Add("---------------------------------------")

        IndexOfLargest = i
        IndexOfSmallest = i
        LargestNumber = Rainfall(0)
        SmallestNumber = Rainfall(0)
        For i = 0 To 11
            Dim month = MONTHS(i)
            Dim stat = Rainfall(i)

            'smallest
            If (SmallestNumber > Rainfall(i)) Then
                SmallestNumber = Rainfall(i)
                IndexOfSmallest = i
            End If

            'largest
            If (LargestNumber < Rainfall(i)) Then
                LargestNumber = Rainfall(i)
                IndexOfLargest = i
            End If

            'Calculate Total
            Total += Rainfall(i)


            ListBox1.Items.Add("Rainfall for " + MONTHS(i) + " = " + Convert.ToString(stat))
        Next
        'Average
        Average = Total / 11

        Min_TextBox.Text = "The minimum monthly rainfall was " + Convert.ToString(SmallestNumber) + " " + MONTHS(IndexOfSmallest)
        Max_TextBox.Text = "The minimum monthly rainfall was " + Convert.ToString(LargestNumber) + " " + MONTHS(IndexOfLargest)
        Average_TextBox.Text = "The average monthly rainfall was " + Convert.ToString(Average)
        TotalAnnualRainfall_TextBox.Text = "The total annual rainfall was " + Convert.ToString(Total)
    End Sub

    ' Clear
    ' Clears the Listbox, and defaults the textboxes
    ' Resets the array back to 0...11
    Private Sub Clear()

        ListBox1.Items.Clear()
        Rainfall = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}
        Min_TextBox.Text = "The minimum monthly rainfall was "
        Max_TextBox.Text = "The minimum monthly rainfall was "
        Average_TextBox.Text = "The average monthly rainfall was "
        TotalAnnualRainfall_TextBox.Text = "The total annual rainfall was "
    End Sub


    ' The Input Dialog form allows the user to input the rainfall
    Private Sub InputB_Click(sender As Object, e As EventArgs) Handles InputB.Click
        InputDialog.Show()
    End Sub

    Private Sub ExitB_Click(sender As Object, e As EventArgs) Handles ExitB.Click
        Me.Close()
    End Sub

    Private Sub ClearB_Click(sender As Object, e As EventArgs) Handles ClearB.Click
        Clear()
    End Sub
End Class
