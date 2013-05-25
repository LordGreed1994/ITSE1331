Public Class IndividualPlan
    'Price Per Month:
    '800 Mins, 1500 mins, Unlimited Mins
    ReadOnly PACKAGE = {45.0, 65.0, 99.0}

    ' Price Per month
    ' Email, Unlimited Messaging
    ReadOnly OPTIONS = {25.0, 10.0}

    'Types Of Phones
    ' Unused
    'ReadOnly PHONETYPES = {"Model 100", "Model 110", "Model 200"}

    'Prices per type
    ReadOnly PHONEPRICES = {29.95, 49.95, 99.95}

    ' Indexes to use when computing Totals
    Dim PhoneIndex
    Dim PackageIndex
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = "Total Monthly" + vbNewLine + "Charge"
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Total
        If (isFormFilledOut()) Then
            Total = PHONEPRICES(PhoneIndex)
            Subtotal_Text.Text = Total
            Tax_Text.Text = Format(Total * 0.06, "0.00")
            PhoneTotal_Text.Text = Format((Total + (Total * 0.06)), "0.00")
            Option_Text.Text = Format(OptionCharges(), "0.00")
            PackageCharge_Text.Text = Format(PACKAGE(PackageIndex), "0.00")

            Total_Text.Text = Format(Double.Parse(PhoneTotal_Text.Text) + OptionCharges() + PACKAGE(PackageIndex), "0.00")
        Else

        End If

    End Sub

    Private Function OptionCharges() As Double
        Dim m_total = 0
        If (CheckBox1.Checked = True) Then
            m_total += OPTIONS(0)
        End If
        If (CheckBox2.Checked = True) Then
            m_total += OPTIONS(1)
        End If


        Return m_total
    End Function
    Private Function isFormFilledOut() As Boolean

        Dim AllControls As Control
        Dim Checked As Integer
        Checked = 0

        For Each AllControls In GroupBox1.Controls

            If (TypeOf AllControls Is RadioButton) Then
                If (TryCast(AllControls, RadioButton).Checked = False) Then
                    Checked += 1
                Else
                    PhoneIndex = Checked
                End If
            End If
        Next

        If Checked = 3 Then
            MessageBox.Show("There is nothing checked for Phones.")
            Return False
        End If
        Checked = 0
        For Each AllControls In GroupBox2.Controls

            If (TypeOf AllControls Is RadioButton) Then
                If (TryCast(AllControls, RadioButton).Checked = False) Then
                    Checked += 1
                Else
                    PackageIndex = Checked
                End If
            End If
        Next
        If Checked = 3 Then
            MessageBox.Show("There is nothing checked for packages ")
            Return False
        End If

        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

End Class