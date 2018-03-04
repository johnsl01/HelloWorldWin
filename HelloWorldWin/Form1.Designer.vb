<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloWorldForm
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
        Me.PressMeButton = New System.Windows.Forms.Button()
        Me.HelloWorldLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PressMeButton
        '
        Me.PressMeButton.Location = New System.Drawing.Point(100, 57)
        Me.PressMeButton.Name = "PressMeButton"
        Me.PressMeButton.Size = New System.Drawing.Size(75, 23)
        Me.PressMeButton.TabIndex = 0
        Me.PressMeButton.Text = "Press Me!"
        Me.PressMeButton.UseVisualStyleBackColor = True
        '
        'HelloWorldLabel
        '
        Me.HelloWorldLabel.AutoSize = True
        Me.HelloWorldLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelloWorldLabel.ForeColor = System.Drawing.Color.Red
        Me.HelloWorldLabel.Location = New System.Drawing.Point(25, 98)
        Me.HelloWorldLabel.Name = "HelloWorldLabel"
        Me.HelloWorldLabel.Size = New System.Drawing.Size(0, 44)
        Me.HelloWorldLabel.TabIndex = 1
        Me.HelloWorldLabel.Visible = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(71, 226)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(132, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Press here to Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        Me.ExitButton.Visible = False
        '
        'HelloWorldForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.HelloWorldLabel)
        Me.Controls.Add(Me.PressMeButton)
        Me.Name = "HelloWorldForm"
        Me.Text = "Hello World Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PressMeButton As Button
    Friend WithEvents HelloWorldLabel As Label
    Friend WithEvents ExitButton As Button
End Class
