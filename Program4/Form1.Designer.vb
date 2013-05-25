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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Runner1_Label = New System.Windows.Forms.Label()
        Me.Runner2_Label = New System.Windows.Forms.Label()
        Me.Runner3_Label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Runner1_TextBox = New System.Windows.Forms.TextBox()
        Me.Runner2_TextBox = New System.Windows.Forms.TextBox()
        Me.Runner3_TextBox = New System.Windows.Forms.TextBox()
        Me.Finish1_Textbox = New System.Windows.Forms.TextBox()
        Me.Finish2_Textbox = New System.Windows.Forms.TextBox()
        Me.Finish3_Textbox = New System.Windows.Forms.TextBox()
        Me.GBox = New System.Windows.Forms.GroupBox()
        Me.Win1 = New System.Windows.Forms.Label()
        Me.Win2 = New System.Windows.Forms.Label()
        Me.Win3 = New System.Windows.Forms.Label()
        Me.Winner1 = New System.Windows.Forms.TextBox()
        Me.Winner2 = New System.Windows.Forms.TextBox()
        Me.Winner3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.textPanel = New System.Windows.Forms.Panel()
        Me.GBox.SuspendLayout()
        Me.textPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the three runners' names"
        '
        'Runner1_Label
        '
        Me.Runner1_Label.AutoSize = True
        Me.Runner1_Label.Location = New System.Drawing.Point(14, 127)
        Me.Runner1_Label.Name = "Runner1_Label"
        Me.Runner1_Label.Size = New System.Drawing.Size(57, 13)
        Me.Runner1_Label.TabIndex = 1
        Me.Runner1_Label.Text = "Runner 1: "
        '
        'Runner2_Label
        '
        Me.Runner2_Label.AutoSize = True
        Me.Runner2_Label.Location = New System.Drawing.Point(14, 162)
        Me.Runner2_Label.Name = "Runner2_Label"
        Me.Runner2_Label.Size = New System.Drawing.Size(57, 13)
        Me.Runner2_Label.TabIndex = 2
        Me.Runner2_Label.Text = "Runner 2: "
        '
        'Runner3_Label
        '
        Me.Runner3_Label.AutoSize = True
        Me.Runner3_Label.Location = New System.Drawing.Point(14, 197)
        Me.Runner3_Label.Name = "Runner3_Label"
        Me.Runner3_Label.Size = New System.Drawing.Size(57, 13)
        Me.Runner3_Label.TabIndex = 3
        Me.Runner3_Label.Text = "Runner 3: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(231, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Finishing Time"
        '
        'Runner1_TextBox
        '
        Me.Runner1_TextBox.Location = New System.Drawing.Point(17, 12)
        Me.Runner1_TextBox.Name = "Runner1_TextBox"
        Me.Runner1_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Runner1_TextBox.TabIndex = 6
        '
        'Runner2_TextBox
        '
        Me.Runner2_TextBox.Location = New System.Drawing.Point(17, 44)
        Me.Runner2_TextBox.Name = "Runner2_TextBox"
        Me.Runner2_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Runner2_TextBox.TabIndex = 7
        '
        'Runner3_TextBox
        '
        Me.Runner3_TextBox.Location = New System.Drawing.Point(17, 82)
        Me.Runner3_TextBox.Name = "Runner3_TextBox"
        Me.Runner3_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Runner3_TextBox.TabIndex = 8
        '
        'Finish1_Textbox
        '
        Me.Finish1_Textbox.Location = New System.Drawing.Point(159, 12)
        Me.Finish1_Textbox.Name = "Finish1_Textbox"
        Me.Finish1_Textbox.Size = New System.Drawing.Size(50, 20)
        Me.Finish1_Textbox.TabIndex = 9
        '
        'Finish2_Textbox
        '
        Me.Finish2_Textbox.Location = New System.Drawing.Point(159, 47)
        Me.Finish2_Textbox.Name = "Finish2_Textbox"
        Me.Finish2_Textbox.Size = New System.Drawing.Size(50, 20)
        Me.Finish2_Textbox.TabIndex = 10
        '
        'Finish3_Textbox
        '
        Me.Finish3_Textbox.Location = New System.Drawing.Point(159, 82)
        Me.Finish3_Textbox.Name = "Finish3_Textbox"
        Me.Finish3_Textbox.Size = New System.Drawing.Size(50, 20)
        Me.Finish3_Textbox.TabIndex = 11
        '
        'GBox
        '
        Me.GBox.Controls.Add(Me.Win1)
        Me.GBox.Controls.Add(Me.Win2)
        Me.GBox.Controls.Add(Me.Win3)
        Me.GBox.Controls.Add(Me.Winner1)
        Me.GBox.Controls.Add(Me.Winner2)
        Me.GBox.Controls.Add(Me.Winner3)
        Me.GBox.Location = New System.Drawing.Point(30, 239)
        Me.GBox.Name = "GBox"
        Me.GBox.Size = New System.Drawing.Size(240, 100)
        Me.GBox.TabIndex = 12
        Me.GBox.TabStop = False
        Me.GBox.Text = "Race Results"
        '
        'Win1
        '
        Me.Win1.AutoSize = True
        Me.Win1.Location = New System.Drawing.Point(29, 26)
        Me.Win1.Name = "Win1"
        Me.Win1.Size = New System.Drawing.Size(56, 13)
        Me.Win1.TabIndex = 13
        Me.Win1.Text = "First Place"
        '
        'Win2
        '
        Me.Win2.AutoSize = True
        Me.Win2.Location = New System.Drawing.Point(11, 55)
        Me.Win2.Name = "Win2"
        Me.Win2.Size = New System.Drawing.Size(74, 13)
        Me.Win2.TabIndex = 14
        Me.Win2.Text = "Second Place"
        '
        'Win3
        '
        Me.Win3.AutoSize = True
        Me.Win3.Location = New System.Drawing.Point(24, 81)
        Me.Win3.Name = "Win3"
        Me.Win3.Size = New System.Drawing.Size(61, 13)
        Me.Win3.TabIndex = 15
        Me.Win3.Text = "Third Place"
        '
        'Winner1
        '
        Me.Winner1.Location = New System.Drawing.Point(103, 19)
        Me.Winner1.Name = "Winner1"
        Me.Winner1.ReadOnly = True
        Me.Winner1.Size = New System.Drawing.Size(100, 20)
        Me.Winner1.TabIndex = 13
        '
        'Winner2
        '
        Me.Winner2.Location = New System.Drawing.Point(103, 48)
        Me.Winner2.Name = "Winner2"
        Me.Winner2.ReadOnly = True
        Me.Winner2.Size = New System.Drawing.Size(100, 20)
        Me.Winner2.TabIndex = 14
        '
        'Winner3
        '
        Me.Winner3.Location = New System.Drawing.Point(103, 74)
        Me.Winner3.Name = "Winner3"
        Me.Winner3.ReadOnly = True
        Me.Winner3.Size = New System.Drawing.Size(100, 20)
        Me.Winner3.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 50)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Calculate Results"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 50)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(200, 359)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 50)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'textPanel
        '
        Me.textPanel.Controls.Add(Me.Finish3_Textbox)
        Me.textPanel.Controls.Add(Me.Finish2_Textbox)
        Me.textPanel.Controls.Add(Me.Finish1_Textbox)
        Me.textPanel.Controls.Add(Me.Runner3_TextBox)
        Me.textPanel.Controls.Add(Me.Runner2_TextBox)
        Me.textPanel.Controls.Add(Me.Runner1_TextBox)
        Me.textPanel.Location = New System.Drawing.Point(77, 115)
        Me.textPanel.Name = "textPanel"
        Me.textPanel.Size = New System.Drawing.Size(228, 118)
        Me.textPanel.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 437)
        Me.Controls.Add(Me.textPanel)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GBox)
        Me.Controls.Add(Me.Runner3_Label)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Runner2_Label)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Runner1_Label)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBox.ResumeLayout(False)
        Me.GBox.PerformLayout()
        Me.textPanel.ResumeLayout(False)
        Me.textPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Runner1_Label As System.Windows.Forms.Label
    Friend WithEvents Runner2_Label As System.Windows.Forms.Label
    Friend WithEvents Runner3_Label As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Runner1_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Runner2_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Runner3_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Finish1_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Finish2_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Finish3_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents GBox As System.Windows.Forms.GroupBox
    Friend WithEvents Win1 As System.Windows.Forms.Label
    Friend WithEvents Win2 As System.Windows.Forms.Label
    Friend WithEvents Win3 As System.Windows.Forms.Label
    Friend WithEvents Winner1 As System.Windows.Forms.TextBox
    Friend WithEvents Winner2 As System.Windows.Forms.TextBox
    Friend WithEvents Winner3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents textPanel As System.Windows.Forms.Panel

End Class
