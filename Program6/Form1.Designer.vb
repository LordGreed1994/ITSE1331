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
        Me.Submit = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.ExitB = New System.Windows.Forms.Button()
        Me.Summary_Box = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LubeJob_Check = New System.Windows.Forms.CheckBox()
        Me.OilChange_Check = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Transmission_Check = New System.Windows.Forms.CheckBox()
        Me.Radiator_Check = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Tire_Check = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Replace_Check = New System.Windows.Forms.CheckBox()
        Me.Inspection_Check = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Labor_Textbox = New System.Windows.Forms.TextBox()
        Me.PL_Textbox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Summary_Box.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(50, 346)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(144, 43)
        Me.Submit.TabIndex = 0
        Me.Submit.Text = "CalculateTotal"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(200, 346)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(144, 43)
        Me.Clear.TabIndex = 1
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'ExitB
        '
        Me.ExitB.Location = New System.Drawing.Point(350, 346)
        Me.ExitB.Name = "ExitB"
        Me.ExitB.Size = New System.Drawing.Size(144, 43)
        Me.ExitB.TabIndex = 2
        Me.ExitB.Text = "Exit"
        Me.ExitB.UseVisualStyleBackColor = True
        '
        'Summary_Box
        '
        Me.Summary_Box.Controls.Add(Me.TextBox4)
        Me.Summary_Box.Controls.Add(Me.TextBox3)
        Me.Summary_Box.Controls.Add(Me.TextBox2)
        Me.Summary_Box.Controls.Add(Me.TextBox1)
        Me.Summary_Box.Controls.Add(Me.Label4)
        Me.Summary_Box.Controls.Add(Me.Label3)
        Me.Summary_Box.Controls.Add(Me.Label2)
        Me.Summary_Box.Controls.Add(Me.Label1)
        Me.Summary_Box.Location = New System.Drawing.Point(13, 192)
        Me.Summary_Box.Name = "Summary_Box"
        Me.Summary_Box.Size = New System.Drawing.Size(499, 138)
        Me.Summary_Box.TabIndex = 3
        Me.Summary_Box.TabStop = False
        Me.Summary_Box.Text = "Summary"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(251, 110)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(251, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(251, 50)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(251, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(179, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Fees"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tax ( on Parts )"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Parts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Services and Labor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LubeJob_Check)
        Me.GroupBox1.Controls.Add(Me.OilChange_Check)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 77)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oil and Lube"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(129, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "($18.00)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(129, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "($26.00)"
        '
        'LubeJob_Check
        '
        Me.LubeJob_Check.AutoSize = True
        Me.LubeJob_Check.Location = New System.Drawing.Point(7, 43)
        Me.LubeJob_Check.Name = "LubeJob_Check"
        Me.LubeJob_Check.Size = New System.Drawing.Size(70, 17)
        Me.LubeJob_Check.TabIndex = 1
        Me.LubeJob_Check.Text = "Lube Job"
        Me.LubeJob_Check.UseVisualStyleBackColor = True
        '
        'OilChange_Check
        '
        Me.OilChange_Check.AutoSize = True
        Me.OilChange_Check.Location = New System.Drawing.Point(7, 20)
        Me.OilChange_Check.Name = "OilChange_Check"
        Me.OilChange_Check.Size = New System.Drawing.Size(78, 17)
        Me.OilChange_Check.TabIndex = 0
        Me.OilChange_Check.Text = "Oil Change"
        Me.OilChange_Check.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Transmission_Check)
        Me.GroupBox2.Controls.Add(Me.Radiator_Check)
        Me.GroupBox2.Location = New System.Drawing.Point(274, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 77)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flushes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(129, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "($18.00)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(129, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "($26.00)"
        '
        'Transmission_Check
        '
        Me.Transmission_Check.AutoSize = True
        Me.Transmission_Check.Location = New System.Drawing.Point(7, 43)
        Me.Transmission_Check.Name = "Transmission_Check"
        Me.Transmission_Check.Size = New System.Drawing.Size(115, 17)
        Me.Transmission_Check.TabIndex = 1
        Me.Transmission_Check.Text = "Transmission Flush"
        Me.Transmission_Check.UseVisualStyleBackColor = True
        '
        'Radiator_Check
        '
        Me.Radiator_Check.AutoSize = True
        Me.Radiator_Check.Location = New System.Drawing.Point(7, 20)
        Me.Radiator_Check.Name = "Radiator_Check"
        Me.Radiator_Check.Size = New System.Drawing.Size(94, 17)
        Me.Radiator_Check.TabIndex = 0
        Me.Radiator_Check.Text = "Radiator Flush"
        Me.Radiator_Check.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Tire_Check)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Replace_Check)
        Me.GroupBox3.Controls.Add(Me.Inspection_Check)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 90)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Misc"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(129, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "($20.00)"
        '
        'Tire_Check
        '
        Me.Tire_Check.AutoSize = True
        Me.Tire_Check.Location = New System.Drawing.Point(7, 66)
        Me.Tire_Check.Name = "Tire_Check"
        Me.Tire_Check.Size = New System.Drawing.Size(87, 17)
        Me.Tire_Check.TabIndex = 4
        Me.Tire_Check.Text = "Tire Rotation"
        Me.Tire_Check.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(129, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "($100.00)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(129, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "($15.00)"
        '
        'Replace_Check
        '
        Me.Replace_Check.AutoSize = True
        Me.Replace_Check.Location = New System.Drawing.Point(7, 43)
        Me.Replace_Check.Name = "Replace_Check"
        Me.Replace_Check.Size = New System.Drawing.Size(101, 17)
        Me.Replace_Check.TabIndex = 1
        Me.Replace_Check.Text = "Replace Muffler"
        Me.Replace_Check.UseVisualStyleBackColor = True
        '
        'Inspection_Check
        '
        Me.Inspection_Check.AutoSize = True
        Me.Inspection_Check.Location = New System.Drawing.Point(7, 20)
        Me.Inspection_Check.Name = "Inspection_Check"
        Me.Inspection_Check.Size = New System.Drawing.Size(75, 17)
        Me.Inspection_Check.TabIndex = 0
        Me.Inspection_Check.Text = "Inspection"
        Me.Inspection_Check.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Labor_Textbox)
        Me.GroupBox4.Controls.Add(Me.PL_Textbox)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(274, 96)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(238, 90)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parts and Labor"
        '
        'Labor_Textbox
        '
        Me.Labor_Textbox.Location = New System.Drawing.Point(70, 46)
        Me.Labor_Textbox.Name = "Labor_Textbox"
        Me.Labor_Textbox.Size = New System.Drawing.Size(52, 20)
        Me.Labor_Textbox.TabIndex = 11
        '
        'PL_Textbox
        '
        Me.PL_Textbox.Location = New System.Drawing.Point(70, 20)
        Me.PL_Textbox.Name = "PL_Textbox"
        Me.PL_Textbox.Size = New System.Drawing.Size(52, 20)
        Me.PL_Textbox.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Labor"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Parts"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(129, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "($20.00 per Hour)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 401)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Summary_Box)
        Me.Controls.Add(Me.ExitB)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Submit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Summary_Box.ResumeLayout(False)
        Me.Summary_Box.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents ExitB As System.Windows.Forms.Button
    Friend WithEvents Summary_Box As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LubeJob_Check As System.Windows.Forms.CheckBox
    Friend WithEvents OilChange_Check As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Transmission_Check As System.Windows.Forms.CheckBox
    Friend WithEvents Radiator_Check As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Tire_Check As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Replace_Check As System.Windows.Forms.CheckBox
    Friend WithEvents Inspection_Check As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Labor_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents PL_Textbox As System.Windows.Forms.TextBox

End Class
