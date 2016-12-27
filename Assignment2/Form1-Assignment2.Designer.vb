<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignmentHomeForm
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
        Me.Assignment2Label = New System.Windows.Forms.Label()
        Me.Number1Button = New System.Windows.Forms.Button()
        Me.Number2Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Assignment2Label
        '
        Me.Assignment2Label.AutoSize = True
        Me.Assignment2Label.Font = New System.Drawing.Font("Script MT Bold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Assignment2Label.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Assignment2Label.Location = New System.Drawing.Point(-3, 52)
        Me.Assignment2Label.Name = "Assignment2Label"
        Me.Assignment2Label.Size = New System.Drawing.Size(364, 58)
        Me.Assignment2Label.TabIndex = 0
        Me.Assignment2Label.Text = "Assignment No. 2"
        '
        'Number1Button
        '
        Me.Number1Button.BackColor = System.Drawing.Color.IndianRed
        Me.Number1Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Number1Button.FlatAppearance.BorderSize = 5
        Me.Number1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Number1Button.Font = New System.Drawing.Font("Script MT Bold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number1Button.Location = New System.Drawing.Point(6, 122)
        Me.Number1Button.Name = "Number1Button"
        Me.Number1Button.Size = New System.Drawing.Size(168, 176)
        Me.Number1Button.TabIndex = 1
        Me.Number1Button.Text = "8-Digit Calculator"
        Me.Number1Button.UseVisualStyleBackColor = False
        '
        'Number2Button
        '
        Me.Number2Button.BackColor = System.Drawing.Color.IndianRed
        Me.Number2Button.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Number2Button.FlatAppearance.BorderSize = 5
        Me.Number2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Number2Button.Font = New System.Drawing.Font("Script MT Bold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number2Button.Location = New System.Drawing.Point(180, 123)
        Me.Number2Button.Name = "Number2Button"
        Me.Number2Button.Size = New System.Drawing.Size(168, 176)
        Me.Number2Button.TabIndex = 2
        Me.Number2Button.Text = "Area Calculator"
        Me.Number2Button.UseVisualStyleBackColor = False
        '
        'AssignmentHomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(354, 331)
        Me.Controls.Add(Me.Number2Button)
        Me.Controls.Add(Me.Number1Button)
        Me.Controls.Add(Me.Assignment2Label)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AssignmentHomeForm"
        Me.Text = "Assignment No. 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Assignment2Label As Label
    Friend WithEvents Number1Button As Button
    Friend WithEvents Number2Button As Button
End Class
