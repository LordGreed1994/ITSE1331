<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RainfallStats
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.InputB = New System.Windows.Forms.Button()
        Me.DisplayStatsB = New System.Windows.Forms.Button()
        Me.ClearB = New System.Windows.Forms.Button()
        Me.ExitB = New System.Windows.Forms.Button()
        Me.StatsLabel = New System.Windows.Forms.Label()
        Me.TotalAnnualRainfall_TextBox = New System.Windows.Forms.TextBox()
        Me.Average_TextBox = New System.Windows.Forms.TextBox()
        Me.Min_TextBox = New System.Windows.Forms.TextBox()
        Me.Max_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(193, 186)
        Me.ListBox1.TabIndex = 0
        '
        'InputB
        '
        Me.InputB.Location = New System.Drawing.Point(13, 232)
        Me.InputB.Name = "InputB"
        Me.InputB.Size = New System.Drawing.Size(137, 47)
        Me.InputB.TabIndex = 1
        Me.InputB.Text = "Input Monthly Rainfall"
        Me.InputB.UseVisualStyleBackColor = True
        '
        'DisplayStatsB
        '
        Me.DisplayStatsB.Location = New System.Drawing.Point(187, 232)
        Me.DisplayStatsB.Name = "DisplayStatsB"
        Me.DisplayStatsB.Size = New System.Drawing.Size(137, 47)
        Me.DisplayStatsB.TabIndex = 2
        Me.DisplayStatsB.Text = "Display Stats"
        Me.DisplayStatsB.UseVisualStyleBackColor = True
        '
        'ClearB
        '
        Me.ClearB.Location = New System.Drawing.Point(348, 232)
        Me.ClearB.Name = "ClearB"
        Me.ClearB.Size = New System.Drawing.Size(137, 47)
        Me.ClearB.TabIndex = 3
        Me.ClearB.Text = "Clear"
        Me.ClearB.UseVisualStyleBackColor = True
        '
        'ExitB
        '
        Me.ExitB.Location = New System.Drawing.Point(512, 232)
        Me.ExitB.Name = "ExitB"
        Me.ExitB.Size = New System.Drawing.Size(137, 47)
        Me.ExitB.TabIndex = 4
        Me.ExitB.Text = "Exit"
        Me.ExitB.UseVisualStyleBackColor = True
        '
        'StatsLabel
        '
        Me.StatsLabel.AutoSize = True
        Me.StatsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatsLabel.Location = New System.Drawing.Point(253, 34)
        Me.StatsLabel.Name = "StatsLabel"
        Me.StatsLabel.Size = New System.Drawing.Size(158, 16)
        Me.StatsLabel.TabIndex = 5
        Me.StatsLabel.Text = "Monthly Rainfall Statistics"
        '
        'TotalAnnualRainfall_TextBox
        '
        Me.TotalAnnualRainfall_TextBox.Location = New System.Drawing.Point(256, 68)
        Me.TotalAnnualRainfall_TextBox.Name = "TotalAnnualRainfall_TextBox"
        Me.TotalAnnualRainfall_TextBox.ReadOnly = True
        Me.TotalAnnualRainfall_TextBox.Size = New System.Drawing.Size(393, 20)
        Me.TotalAnnualRainfall_TextBox.TabIndex = 6
        Me.TotalAnnualRainfall_TextBox.Text = "The total annual rainfall was "
        '
        'Average_TextBox
        '
        Me.Average_TextBox.Location = New System.Drawing.Point(256, 94)
        Me.Average_TextBox.Name = "Average_TextBox"
        Me.Average_TextBox.ReadOnly = True
        Me.Average_TextBox.Size = New System.Drawing.Size(393, 20)
        Me.Average_TextBox.TabIndex = 7
        Me.Average_TextBox.Text = "The average monthly rainfall was"
        '
        'Min_TextBox
        '
        Me.Min_TextBox.Location = New System.Drawing.Point(256, 120)
        Me.Min_TextBox.Name = "Min_TextBox"
        Me.Min_TextBox.ReadOnly = True
        Me.Min_TextBox.Size = New System.Drawing.Size(393, 20)
        Me.Min_TextBox.TabIndex = 8
        Me.Min_TextBox.Text = "The minimum monthly rainfall was"
        '
        'Max_TextBox
        '
        Me.Max_TextBox.Location = New System.Drawing.Point(256, 146)
        Me.Max_TextBox.Name = "Max_TextBox"
        Me.Max_TextBox.ReadOnly = True
        Me.Max_TextBox.Size = New System.Drawing.Size(393, 20)
        Me.Max_TextBox.TabIndex = 9
        Me.Max_TextBox.Text = "The maximum monthly rainfall was "
        '
        'RainfallStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 291)
        Me.Controls.Add(Me.Max_TextBox)
        Me.Controls.Add(Me.Min_TextBox)
        Me.Controls.Add(Me.Average_TextBox)
        Me.Controls.Add(Me.TotalAnnualRainfall_TextBox)
        Me.Controls.Add(Me.StatsLabel)
        Me.Controls.Add(Me.ExitB)
        Me.Controls.Add(Me.ClearB)
        Me.Controls.Add(Me.DisplayStatsB)
        Me.Controls.Add(Me.InputB)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "RainfallStats"
        Me.Text = "Rainfall Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents InputB As System.Windows.Forms.Button
    Friend WithEvents DisplayStatsB As System.Windows.Forms.Button
    Friend WithEvents ClearB As System.Windows.Forms.Button
    Friend WithEvents ExitB As System.Windows.Forms.Button
    Friend WithEvents StatsLabel As System.Windows.Forms.Label
    Friend WithEvents TotalAnnualRainfall_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Average_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Min_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Max_TextBox As System.Windows.Forms.TextBox

End Class
