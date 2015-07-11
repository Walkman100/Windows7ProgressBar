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
        Me.components = New System.ComponentModel.Container
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.radMarquee = New System.Windows.Forms.RadioButton
        Me.radPaused = New System.Windows.Forms.RadioButton
        Me.radError = New System.Windows.Forms.RadioButton
        Me.radNormal = New System.Windows.Forms.RadioButton
        Me.chkShowInTaskbar = New System.Windows.Forms.CheckBox
        Me.progressor = New System.Windows.Forms.Timer(Me.components)
        Me.windows7ProgressBar = New wyDay.Controls.Windows7ProgressBar
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 215)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(132, 13)
        Me.label4.TabIndex = 19
        Me.label4.Text = "For unknown task lengths."
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(12, 141)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(241, 41)
        Me.label3.TabIndex = 18
        Me.label3.Text = "This is for paused progress only (NOT because you think yellow is a super awesome" & _
            " color progress bar)"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(12, 75)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(241, 41)
        Me.label2.TabIndex = 17
        Me.label2.Text = "This is for errors only (NOT because you think red is a super awesome color progr" & _
            "ess bar)"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 33)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(168, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Show the regular old progress bar."
        '
        'radMarquee
        '
        Me.radMarquee.AutoSize = True
        Me.radMarquee.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radMarquee.Location = New System.Drawing.Point(12, 194)
        Me.radMarquee.Name = "radMarquee"
        Me.radMarquee.Size = New System.Drawing.Size(73, 18)
        Me.radMarquee.TabIndex = 15
        Me.radMarquee.Text = "Marquee"
        Me.radMarquee.UseVisualStyleBackColor = True
        '
        'radPaused
        '
        Me.radPaused.AutoSize = True
        Me.radPaused.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radPaused.Location = New System.Drawing.Point(12, 120)
        Me.radPaused.Name = "radPaused"
        Me.radPaused.Size = New System.Drawing.Size(67, 18)
        Me.radPaused.TabIndex = 14
        Me.radPaused.Text = "Paused"
        Me.radPaused.UseVisualStyleBackColor = True
        '
        'radError
        '
        Me.radError.AutoSize = True
        Me.radError.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radError.Location = New System.Drawing.Point(12, 54)
        Me.radError.Name = "radError"
        Me.radError.Size = New System.Drawing.Size(53, 18)
        Me.radError.TabIndex = 13
        Me.radError.Text = "Error"
        Me.radError.UseVisualStyleBackColor = True
        '
        'radNormal
        '
        Me.radNormal.AutoSize = True
        Me.radNormal.Checked = True
        Me.radNormal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radNormal.Location = New System.Drawing.Point(12, 12)
        Me.radNormal.Name = "radNormal"
        Me.radNormal.Size = New System.Drawing.Size(64, 18)
        Me.radNormal.TabIndex = 12
        Me.radNormal.TabStop = True
        Me.radNormal.Text = "Normal"
        Me.radNormal.UseVisualStyleBackColor = True
        '
        'chkShowInTaskbar
        '
        Me.chkShowInTaskbar.AutoSize = True
        Me.chkShowInTaskbar.Checked = True
        Me.chkShowInTaskbar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowInTaskbar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkShowInTaskbar.Location = New System.Drawing.Point(12, 255)
        Me.chkShowInTaskbar.Name = "chkShowInTaskbar"
        Me.chkShowInTaskbar.Size = New System.Drawing.Size(155, 18)
        Me.chkShowInTaskbar.TabIndex = 11
        Me.chkShowInTaskbar.Text = "Show progress in Taskbar"
        Me.chkShowInTaskbar.UseVisualStyleBackColor = True
        '
        'progressor
        '
        Me.progressor.Enabled = True
        '
        'windows7ProgressBar
        '
        Me.windows7ProgressBar.ContainerControl = Me
        Me.windows7ProgressBar.Location = New System.Drawing.Point(12, 278)
        Me.windows7ProgressBar.MarqueeAnimationSpeed = 50
        Me.windows7ProgressBar.Name = "windows7ProgressBar"
        Me.windows7ProgressBar.ShowInTaskbar = True
        Me.windows7ProgressBar.Size = New System.Drawing.Size(274, 17)
        Me.windows7ProgressBar.TabIndex = 10
        Me.windows7ProgressBar.Value = 65
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 307)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.radMarquee)
        Me.Controls.Add(Me.radPaused)
        Me.Controls.Add(Me.radError)
        Me.Controls.Add(Me.radNormal)
        Me.Controls.Add(Me.chkShowInTaskbar)
        Me.Controls.Add(Me.windows7ProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows7ProgressBar demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents radMarquee As System.Windows.Forms.RadioButton
    Private WithEvents radPaused As System.Windows.Forms.RadioButton
    Private WithEvents radError As System.Windows.Forms.RadioButton
    Private WithEvents radNormal As System.Windows.Forms.RadioButton
    Private WithEvents chkShowInTaskbar As System.Windows.Forms.CheckBox
    Private WithEvents windows7ProgressBar As wyDay.Controls.Windows7ProgressBar
    Friend WithEvents progressor As System.Windows.Forms.Timer

End Class
