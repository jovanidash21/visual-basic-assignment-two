<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNumber2
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
        Me.SquareGroupBox = New System.Windows.Forms.GroupBox()
        Me.SquareAreaAnswer = New System.Windows.Forms.Label()
        Me.SquareAreaLabel = New System.Windows.Forms.Label()
        Me.SquareSideLabel = New System.Windows.Forms.Label()
        Me.SquareSideTextBox = New System.Windows.Forms.TextBox()
        Me.SquareComputeButton = New System.Windows.Forms.Button()
        Me.TriangleGroupBox = New System.Windows.Forms.GroupBox()
        Me.TriangleAreaAnswer = New System.Windows.Forms.Label()
        Me.TriangleAreaLabel = New System.Windows.Forms.Label()
        Me.TriangleHeightLabel = New System.Windows.Forms.Label()
        Me.TriangleBaseLabel = New System.Windows.Forms.Label()
        Me.TriangleHeightTextBox = New System.Windows.Forms.TextBox()
        Me.TriangleBaseTextBox = New System.Windows.Forms.TextBox()
        Me.TriangleComputeButton = New System.Windows.Forms.Button()
        Me.Rectangle = New System.Windows.Forms.GroupBox()
        Me.RectangleAreaAnswer = New System.Windows.Forms.Label()
        Me.RectangleHeightTextBox = New System.Windows.Forms.TextBox()
        Me.RectangleWidthTextBox = New System.Windows.Forms.TextBox()
        Me.RectangleAreaLabel = New System.Windows.Forms.Label()
        Me.RectangleWidthLabel = New System.Windows.Forms.Label()
        Me.RectangleHeightLabel = New System.Windows.Forms.Label()
        Me.RectangleComputeButton = New System.Windows.Forms.Button()
        Me.HistoryGroupBox = New System.Windows.Forms.GroupBox()
        Me.HistoryTextBox = New System.Windows.Forms.TextBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SquareGroupBox.SuspendLayout()
        Me.TriangleGroupBox.SuspendLayout()
        Me.Rectangle.SuspendLayout()
        Me.HistoryGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SquareGroupBox
        '
        Me.SquareGroupBox.Controls.Add(Me.SquareAreaAnswer)
        Me.SquareGroupBox.Controls.Add(Me.SquareAreaLabel)
        Me.SquareGroupBox.Controls.Add(Me.SquareSideLabel)
        Me.SquareGroupBox.Controls.Add(Me.SquareSideTextBox)
        Me.SquareGroupBox.Controls.Add(Me.SquareComputeButton)
        Me.SquareGroupBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SquareGroupBox.ForeColor = System.Drawing.Color.White
        Me.SquareGroupBox.Location = New System.Drawing.Point(9, 155)
        Me.SquareGroupBox.Name = "SquareGroupBox"
        Me.SquareGroupBox.Size = New System.Drawing.Size(165, 123)
        Me.SquareGroupBox.TabIndex = 1
        Me.SquareGroupBox.TabStop = False
        Me.SquareGroupBox.Text = "Square"
        '
        'SquareAreaAnswer
        '
        Me.SquareAreaAnswer.AutoSize = True
        Me.SquareAreaAnswer.ForeColor = System.Drawing.Color.Black
        Me.SquareAreaAnswer.Location = New System.Drawing.Point(63, 56)
        Me.SquareAreaAnswer.Name = "SquareAreaAnswer"
        Me.SquareAreaAnswer.Size = New System.Drawing.Size(19, 19)
        Me.SquareAreaAnswer.TabIndex = 9
        Me.SquareAreaAnswer.Text = "0"
        '
        'SquareAreaLabel
        '
        Me.SquareAreaLabel.AutoSize = True
        Me.SquareAreaLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SquareAreaLabel.Location = New System.Drawing.Point(18, 58)
        Me.SquareAreaLabel.Name = "SquareAreaLabel"
        Me.SquareAreaLabel.Size = New System.Drawing.Size(45, 16)
        Me.SquareAreaLabel.TabIndex = 8
        Me.SquareAreaLabel.Text = "Area:"
        '
        'SquareSideLabel
        '
        Me.SquareSideLabel.AutoSize = True
        Me.SquareSideLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SquareSideLabel.Location = New System.Drawing.Point(23, 33)
        Me.SquareSideLabel.Name = "SquareSideLabel"
        Me.SquareSideLabel.Size = New System.Drawing.Size(40, 16)
        Me.SquareSideLabel.TabIndex = 8
        Me.SquareSideLabel.Text = "Side:"
        '
        'SquareSideTextBox
        '
        Me.SquareSideTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SquareSideTextBox.Location = New System.Drawing.Point(67, 30)
        Me.SquareSideTextBox.MaxLength = 9
        Me.SquareSideTextBox.Name = "SquareSideTextBox"
        Me.SquareSideTextBox.Size = New System.Drawing.Size(90, 23)
        Me.SquareSideTextBox.TabIndex = 8
        '
        'SquareComputeButton
        '
        Me.SquareComputeButton.BackColor = System.Drawing.Color.IndianRed
        Me.SquareComputeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.SquareComputeButton.FlatAppearance.BorderSize = 2
        Me.SquareComputeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SquareComputeButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SquareComputeButton.Location = New System.Drawing.Point(5, 85)
        Me.SquareComputeButton.Name = "SquareComputeButton"
        Me.SquareComputeButton.Size = New System.Drawing.Size(153, 31)
        Me.SquareComputeButton.TabIndex = 1
        Me.SquareComputeButton.Text = "COMPUTE"
        Me.SquareComputeButton.UseVisualStyleBackColor = False
        '
        'TriangleGroupBox
        '
        Me.TriangleGroupBox.Controls.Add(Me.TriangleAreaAnswer)
        Me.TriangleGroupBox.Controls.Add(Me.TriangleAreaLabel)
        Me.TriangleGroupBox.Controls.Add(Me.TriangleHeightLabel)
        Me.TriangleGroupBox.Controls.Add(Me.TriangleBaseLabel)
        Me.TriangleGroupBox.Controls.Add(Me.TriangleHeightTextBox)
        Me.TriangleGroupBox.Controls.Add(Me.TriangleBaseTextBox)
        Me.TriangleGroupBox.Controls.Add(Me.TriangleComputeButton)
        Me.TriangleGroupBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TriangleGroupBox.ForeColor = System.Drawing.Color.White
        Me.TriangleGroupBox.Location = New System.Drawing.Point(8, 12)
        Me.TriangleGroupBox.Name = "TriangleGroupBox"
        Me.TriangleGroupBox.Size = New System.Drawing.Size(165, 140)
        Me.TriangleGroupBox.TabIndex = 0
        Me.TriangleGroupBox.TabStop = False
        Me.TriangleGroupBox.Text = "Triangle"
        '
        'TriangleAreaAnswer
        '
        Me.TriangleAreaAnswer.AutoSize = True
        Me.TriangleAreaAnswer.ForeColor = System.Drawing.Color.Black
        Me.TriangleAreaAnswer.Location = New System.Drawing.Point(64, 78)
        Me.TriangleAreaAnswer.Name = "TriangleAreaAnswer"
        Me.TriangleAreaAnswer.Size = New System.Drawing.Size(19, 19)
        Me.TriangleAreaAnswer.TabIndex = 8
        Me.TriangleAreaAnswer.Text = "0"
        '
        'TriangleAreaLabel
        '
        Me.TriangleAreaLabel.AutoSize = True
        Me.TriangleAreaLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TriangleAreaLabel.Location = New System.Drawing.Point(18, 78)
        Me.TriangleAreaLabel.Name = "TriangleAreaLabel"
        Me.TriangleAreaLabel.Size = New System.Drawing.Size(45, 16)
        Me.TriangleAreaLabel.TabIndex = 5
        Me.TriangleAreaLabel.Text = "Area:"
        '
        'TriangleHeightLabel
        '
        Me.TriangleHeightLabel.AutoSize = True
        Me.TriangleHeightLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TriangleHeightLabel.Location = New System.Drawing.Point(8, 54)
        Me.TriangleHeightLabel.Name = "TriangleHeightLabel"
        Me.TriangleHeightLabel.Size = New System.Drawing.Size(55, 16)
        Me.TriangleHeightLabel.TabIndex = 3
        Me.TriangleHeightLabel.Text = "Height:"
        '
        'TriangleBaseLabel
        '
        Me.TriangleBaseLabel.AutoSize = True
        Me.TriangleBaseLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TriangleBaseLabel.Location = New System.Drawing.Point(19, 29)
        Me.TriangleBaseLabel.Name = "TriangleBaseLabel"
        Me.TriangleBaseLabel.Size = New System.Drawing.Size(44, 16)
        Me.TriangleBaseLabel.TabIndex = 0
        Me.TriangleBaseLabel.Text = "Base:"
        '
        'TriangleHeightTextBox
        '
        Me.TriangleHeightTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TriangleHeightTextBox.Location = New System.Drawing.Point(69, 51)
        Me.TriangleHeightTextBox.MaxLength = 9
        Me.TriangleHeightTextBox.Name = "TriangleHeightTextBox"
        Me.TriangleHeightTextBox.Size = New System.Drawing.Size(90, 23)
        Me.TriangleHeightTextBox.TabIndex = 4
        '
        'TriangleBaseTextBox
        '
        Me.TriangleBaseTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TriangleBaseTextBox.Location = New System.Drawing.Point(69, 26)
        Me.TriangleBaseTextBox.MaxLength = 9
        Me.TriangleBaseTextBox.Name = "TriangleBaseTextBox"
        Me.TriangleBaseTextBox.Size = New System.Drawing.Size(90, 23)
        Me.TriangleBaseTextBox.TabIndex = 1
        '
        'TriangleComputeButton
        '
        Me.TriangleComputeButton.BackColor = System.Drawing.Color.IndianRed
        Me.TriangleComputeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.TriangleComputeButton.FlatAppearance.BorderSize = 2
        Me.TriangleComputeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TriangleComputeButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TriangleComputeButton.Location = New System.Drawing.Point(6, 103)
        Me.TriangleComputeButton.Name = "TriangleComputeButton"
        Me.TriangleComputeButton.Size = New System.Drawing.Size(153, 31)
        Me.TriangleComputeButton.TabIndex = 7
        Me.TriangleComputeButton.Text = "COMPUTE"
        Me.TriangleComputeButton.UseVisualStyleBackColor = False
        '
        'Rectangle
        '
        Me.Rectangle.Controls.Add(Me.RectangleAreaAnswer)
        Me.Rectangle.Controls.Add(Me.RectangleHeightTextBox)
        Me.Rectangle.Controls.Add(Me.RectangleWidthTextBox)
        Me.Rectangle.Controls.Add(Me.RectangleAreaLabel)
        Me.Rectangle.Controls.Add(Me.RectangleWidthLabel)
        Me.Rectangle.Controls.Add(Me.RectangleHeightLabel)
        Me.Rectangle.Controls.Add(Me.RectangleComputeButton)
        Me.Rectangle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rectangle.ForeColor = System.Drawing.Color.White
        Me.Rectangle.Location = New System.Drawing.Point(9, 284)
        Me.Rectangle.Name = "Rectangle"
        Me.Rectangle.Size = New System.Drawing.Size(165, 140)
        Me.Rectangle.TabIndex = 3
        Me.Rectangle.TabStop = False
        Me.Rectangle.Text = "Rectangle"
        '
        'RectangleAreaAnswer
        '
        Me.RectangleAreaAnswer.AutoSize = True
        Me.RectangleAreaAnswer.ForeColor = System.Drawing.Color.Black
        Me.RectangleAreaAnswer.Location = New System.Drawing.Point(63, 74)
        Me.RectangleAreaAnswer.Name = "RectangleAreaAnswer"
        Me.RectangleAreaAnswer.Size = New System.Drawing.Size(19, 19)
        Me.RectangleAreaAnswer.TabIndex = 10
        Me.RectangleAreaAnswer.Text = "0"
        '
        'RectangleHeightTextBox
        '
        Me.RectangleHeightTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RectangleHeightTextBox.Location = New System.Drawing.Point(67, 48)
        Me.RectangleHeightTextBox.MaxLength = 9
        Me.RectangleHeightTextBox.Name = "RectangleHeightTextBox"
        Me.RectangleHeightTextBox.Size = New System.Drawing.Size(90, 23)
        Me.RectangleHeightTextBox.TabIndex = 11
        '
        'RectangleWidthTextBox
        '
        Me.RectangleWidthTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RectangleWidthTextBox.Location = New System.Drawing.Point(67, 23)
        Me.RectangleWidthTextBox.MaxLength = 9
        Me.RectangleWidthTextBox.Name = "RectangleWidthTextBox"
        Me.RectangleWidthTextBox.Size = New System.Drawing.Size(90, 23)
        Me.RectangleWidthTextBox.TabIndex = 9
        '
        'RectangleAreaLabel
        '
        Me.RectangleAreaLabel.AutoSize = True
        Me.RectangleAreaLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RectangleAreaLabel.Location = New System.Drawing.Point(18, 74)
        Me.RectangleAreaLabel.Name = "RectangleAreaLabel"
        Me.RectangleAreaLabel.Size = New System.Drawing.Size(45, 16)
        Me.RectangleAreaLabel.TabIndex = 8
        Me.RectangleAreaLabel.Text = "Area:"
        '
        'RectangleWidthLabel
        '
        Me.RectangleWidthLabel.AutoSize = True
        Me.RectangleWidthLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RectangleWidthLabel.Location = New System.Drawing.Point(14, 28)
        Me.RectangleWidthLabel.Name = "RectangleWidthLabel"
        Me.RectangleWidthLabel.Size = New System.Drawing.Size(51, 16)
        Me.RectangleWidthLabel.TabIndex = 10
        Me.RectangleWidthLabel.Text = "Width:"
        '
        'RectangleHeightLabel
        '
        Me.RectangleHeightLabel.AutoSize = True
        Me.RectangleHeightLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RectangleHeightLabel.Location = New System.Drawing.Point(10, 51)
        Me.RectangleHeightLabel.Name = "RectangleHeightLabel"
        Me.RectangleHeightLabel.Size = New System.Drawing.Size(55, 16)
        Me.RectangleHeightLabel.TabIndex = 9
        Me.RectangleHeightLabel.Text = "Height:"
        '
        'RectangleComputeButton
        '
        Me.RectangleComputeButton.BackColor = System.Drawing.Color.IndianRed
        Me.RectangleComputeButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleComputeButton.FlatAppearance.BorderSize = 2
        Me.RectangleComputeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RectangleComputeButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RectangleComputeButton.Location = New System.Drawing.Point(5, 103)
        Me.RectangleComputeButton.Name = "RectangleComputeButton"
        Me.RectangleComputeButton.Size = New System.Drawing.Size(153, 31)
        Me.RectangleComputeButton.TabIndex = 2
        Me.RectangleComputeButton.Text = "COMPUTE"
        Me.RectangleComputeButton.UseVisualStyleBackColor = False
        '
        'HistoryGroupBox
        '
        Me.HistoryGroupBox.Controls.Add(Me.HistoryTextBox)
        Me.HistoryGroupBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryGroupBox.ForeColor = System.Drawing.Color.White
        Me.HistoryGroupBox.Location = New System.Drawing.Point(183, 12)
        Me.HistoryGroupBox.Name = "HistoryGroupBox"
        Me.HistoryGroupBox.Size = New System.Drawing.Size(165, 375)
        Me.HistoryGroupBox.TabIndex = 4
        Me.HistoryGroupBox.TabStop = False
        Me.HistoryGroupBox.Text = "History"
        '
        'HistoryTextBox
        '
        Me.HistoryTextBox.BackColor = System.Drawing.Color.Silver
        Me.HistoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HistoryTextBox.Enabled = False
        Me.HistoryTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryTextBox.Location = New System.Drawing.Point(6, 26)
        Me.HistoryTextBox.Multiline = True
        Me.HistoryTextBox.Name = "HistoryTextBox"
        Me.HistoryTextBox.Size = New System.Drawing.Size(153, 343)
        Me.HistoryTextBox.TabIndex = 3
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.Maroon
        Me.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ResetButton.FlatAppearance.BorderSize = 2
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(183, 393)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(165, 31)
        Me.ResetButton.TabIndex = 2
        Me.ResetButton.Text = "RESET"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'FormNumber2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(354, 431)
        Me.Controls.Add(Me.HistoryGroupBox)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Rectangle)
        Me.Controls.Add(Me.TriangleGroupBox)
        Me.Controls.Add(Me.SquareGroupBox)
        Me.Name = "FormNumber2"
        Me.Text = "Area Calculator"
        Me.SquareGroupBox.ResumeLayout(False)
        Me.SquareGroupBox.PerformLayout()
        Me.TriangleGroupBox.ResumeLayout(False)
        Me.TriangleGroupBox.PerformLayout()
        Me.Rectangle.ResumeLayout(False)
        Me.Rectangle.PerformLayout()
        Me.HistoryGroupBox.ResumeLayout(False)
        Me.HistoryGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SquareGroupBox As GroupBox
    Friend WithEvents TriangleGroupBox As GroupBox
    Friend WithEvents Rectangle As GroupBox
    Friend WithEvents HistoryGroupBox As GroupBox
    Friend WithEvents TriangleComputeButton As Button
    Friend WithEvents SquareComputeButton As Button
    Friend WithEvents RectangleComputeButton As Button
    Friend WithEvents TriangleHeightLabel As Label
    Friend WithEvents TriangleBaseLabel As Label
    Friend WithEvents TriangleHeightTextBox As TextBox
    Friend WithEvents TriangleBaseTextBox As TextBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents TriangleAreaLabel As Label
    Friend WithEvents SquareAreaLabel As Label
    Friend WithEvents SquareSideLabel As Label
    Friend WithEvents SquareSideTextBox As TextBox
    Friend WithEvents RectangleHeightTextBox As TextBox
    Friend WithEvents RectangleWidthTextBox As TextBox
    Friend WithEvents RectangleAreaLabel As Label
    Friend WithEvents RectangleWidthLabel As Label
    Friend WithEvents RectangleHeightLabel As Label
    Friend WithEvents HistoryTextBox As TextBox
    Friend WithEvents SquareAreaAnswer As Label
    Friend WithEvents TriangleAreaAnswer As Label
    Friend WithEvents RectangleAreaAnswer As Label
End Class
