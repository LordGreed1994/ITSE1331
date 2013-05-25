Public Class Form1

    ' Clear Subs
    Private Sub ClearOilLube()
        OilChange_Check.Checked = False
        LubeJob_Check.Checked = False
    End Sub

    Private Sub ClearFlushes()
        Radiator_Check.Checked = False
        Transmission_Check.Checked = False
    End Sub

    Private Sub ClearMisc()
        Inspection_Check.Checked = False
        Replace_Check.Checked = False
        Tire_Check.Checked = False
    End Sub

    Private Sub ClearOther()
        PL_Textbox.Text = ""
        Labor_Textbox.Text = ""
    End Sub

    Private Sub ClearFees()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    ' Charge Functions
    ' Returns the total charges for an oil change and/or lube job, if any
    Private Function OilLubeCharges() As Double
        Dim m_total = 0
        If (OilChange_Check.Checked) Then
            m_total += 26.0
        End If
        If (LubeJob_Check.Checked) Then
            m_total += 18.0
        End If

        Return m_total
    End Function

    Private Function FlushCharges() As Double
        Dim m_total = 0
        If (Radiator_Check.Checked) Then
            m_total += 26.0
        End If
        If (LubeJob_Check.Checked) Then
            m_total += 18.0
        End If

        Return m_total
    End Function

    Private Function MiscCharges() As Integer
        Dim m_total = 0
        If (Inspection_Check.Checked) Then
            m_total += 15.0
        End If
        If (Replace_Check.Checked) Then
            m_total += 100.0
        End If
        If (Tire_Check.Checked) Then
            m_total += 20.0
        End If

        Return m_total
    End Function

    Private Function OtherCharges() As Double
        Dim m_total As Double
        m_total = 0.0
        If isCorrectInput() Then
            m_total = Double.Parse(PL_Textbox.Text)
            m_total += Double.Parse(Labor_Textbox.Text) * 20.0
        End If

        Return m_total
    End Function

    Private Function TaxCharges() As Double
        Dim Taxes As Double
        Dim Parts As Double
        If (isCorrectInput()) Then
            Parts = Double.Parse(PL_Textbox.Text)
            Taxes = Parts * 0.06
            Return Taxes
        Else
            Return 0.0
        End If
    End Function

    Private Function TotalCharges() As Double
        Dim m_total As Double

        m_total = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges()

        Return m_total
    End Function


    ' Helper Functions
    ' Ensure that the input inside of labor/parts is not blank, and is a number
    Private Function isCorrectInput() As Boolean

        Dim Textbox As Control
        For Each Textbox In GroupBox4.Controls
            If (TypeOf Textbox Is TextBox) Then
                If (Textbox.Text.Length > 0) Then
                    If (Not IsNumeric(Textbox.Text) Or Textbox.Text < 0.0 Or Textbox.Text < 0) Then
                        Return False
                    End If
                Else
                    Return False
                End If
            End If
        Next
        Return True
    End Function


    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

        TextBox1.Text = OtherCharges()
        If (Not IsNumeric(PL_Textbox.Text) Or PL_Textbox.Text.Contains("-")) Then
            TextBox2.Text = "0"
            PL_Textbox.Text = "0.0"
            MessageBox.Show("Ensure no empty values in Parts and Labor Charges.")
        Else
            TextBox2.Text = PL_Textbox.Text
        End If
        TextBox3.Text = TaxCharges()
        TextBox4.Text = TotalCharges()

    End Sub

    Private Sub ExitB_Click(sender As Object, e As EventArgs) Handles ExitB.Click
        Me.Close()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        ClearOilLube()
        ClearFlushes()
        ClearMisc()
        ClearOther()
        ClearFees()

    End Sub
End Class
