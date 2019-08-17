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
        Me.chkred = New System.Windows.Forms.RadioButton()
        Me.chkblue = New System.Windows.Forms.RadioButton()
        Me.chkorange = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'chkred
        '
        Me.chkred.AutoSize = True
        Me.chkred.Location = New System.Drawing.Point(227, 72)
        Me.chkred.Name = "chkred"
        Me.chkred.Size = New System.Drawing.Size(40, 17)
        Me.chkred.TabIndex = 3
        Me.chkred.TabStop = True
        Me.chkred.Text = "red"
        Me.chkred.UseVisualStyleBackColor = True
        '
        'chkblue
        '
        Me.chkblue.AutoSize = True
        Me.chkblue.Location = New System.Drawing.Point(276, 124)
        Me.chkblue.Name = "chkblue"
        Me.chkblue.Size = New System.Drawing.Size(45, 17)
        Me.chkblue.TabIndex = 4
        Me.chkblue.TabStop = True
        Me.chkblue.Text = "blue"
        Me.chkblue.UseVisualStyleBackColor = True
        '
        'chkorange
        '
        Me.chkorange.AutoSize = True
        Me.chkorange.Location = New System.Drawing.Point(300, 201)
        Me.chkorange.Name = "chkorange"
        Me.chkorange.Size = New System.Drawing.Size(58, 17)
        Me.chkorange.TabIndex = 5
        Me.chkorange.TabStop = True
        Me.chkorange.Text = "orange"
        Me.chkorange.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 533)
        Me.Controls.Add(Me.chkorange)
        Me.Controls.Add(Me.chkblue)
        Me.Controls.Add(Me.chkred)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkred As System.Windows.Forms.RadioButton
    Friend WithEvents chkblue As System.Windows.Forms.RadioButton
    Friend WithEvents chkorange As System.Windows.Forms.RadioButton

End Class
