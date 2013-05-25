<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Workshop_Box = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Location_Box = New System.Windows.Forms.GroupBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.TotalCost_Label = New System.Windows.Forms.Label()
        Me.TotalCost_TextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Workshop_Box.SuspendLayout()
        Me.Location_Box.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Workshop_Box
        '
        Me.Workshop_Box.Controls.Add(Me.ListBox1)
        Me.Workshop_Box.Location = New System.Drawing.Point(12, 12)
        Me.Workshop_Box.Name = "Workshop_Box"
        Me.Workshop_Box.Size = New System.Drawing.Size(204, 148)
        Me.Workshop_Box.TabIndex = 0
        Me.Workshop_Box.TabStop = False
        Me.Workshop_Box.Text = "Pick A Workshop"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview"})
        Me.ListBox1.Location = New System.Drawing.Point(6, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(198, 121)
        Me.ListBox1.TabIndex = 0
        '
        'Location_Box
        '
        Me.Location_Box.Controls.Add(Me.ListBox2)
        Me.Location_Box.Location = New System.Drawing.Point(222, 12)
        Me.Location_Box.Name = "Location_Box"
        Me.Location_Box.Size = New System.Drawing.Size(204, 148)
        Me.Location_Box.TabIndex = 1
        Me.Location_Box.TabStop = False
        Me.Location_Box.Text = "Pick a Location"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.ListBox2.Location = New System.Drawing.Point(6, 21)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(198, 121)
        Me.ListBox2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(432, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(204, 148)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "List of Costs"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(6, 19)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(198, 121)
        Me.ListBox3.TabIndex = 2
        '
        'TotalCost_Label
        '
        Me.TotalCost_Label.AutoSize = True
        Me.TotalCost_Label.Location = New System.Drawing.Point(219, 181)
        Me.TotalCost_Label.Name = "TotalCost_Label"
        Me.TotalCost_Label.Size = New System.Drawing.Size(55, 13)
        Me.TotalCost_Label.TabIndex = 2
        Me.TotalCost_Label.Text = "Total Cost"
        '
        'TotalCost_TextBox
        '
        Me.TotalCost_TextBox.Location = New System.Drawing.Point(288, 181)
        Me.TotalCost_TextBox.Name = "TotalCost_TextBox"
        Me.TotalCost_TextBox.ReadOnly = True
        Me.TotalCost_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalCost_TextBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add Workshop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(193, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 38)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Calculate Total"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(367, 217)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 38)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(532, 217)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 38)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 267)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TotalCost_TextBox)
        Me.Controls.Add(Me.TotalCost_Label)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Location_Box)
        Me.Controls.Add(Me.Workshop_Box)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Workshop_Box.ResumeLayout(False)
        Me.Location_Box.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Workshop_Box As System.Windows.Forms.GroupBox
    Friend WithEvents Location_Box As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalCost_Label As System.Windows.Forms.Label
    Friend WithEvents TotalCost_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
