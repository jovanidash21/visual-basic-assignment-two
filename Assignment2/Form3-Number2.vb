Public Class FormNumber2

    Private Sub FormNumber2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TriangleAreaAnswer.Text = "0"
        SquareAreaAnswer.Text = "0"
        RectangleAreaAnswer.Text = "0"
        'Sets Default Value Of 0
    End Sub

    Private Sub TriangleBaseTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TriangleBaseTextBox.KeyPress
        If TriangleBaseTextBox.Text.Length > 9 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
        'Disables Alphabetic Letters And Special Characters In TextBox
    End Sub

    Private Sub TriangleHeightTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TriangleHeightTextBox.KeyPress
        If TriangleHeightTextBox.Text.Length > 9 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
        'Disables Alphabetic Letters And Special Characters In TextBox
    End Sub

    Private Sub SquareSideTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SquareSideTextBox.KeyPress
        If SquareSideTextBox.Text.Length > 9 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
        'Disables Alphabetic Letters And Special Characters In TextBox
    End Sub

    Private Sub RectangleWidthTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RectangleWidthTextBox.KeyPress
        If RectangleWidthTextBox.Text.Length > 9 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
        'Disables Alphabetic Letters And Special Characters In TextBox
    End Sub

    Private Sub RectangleHeightTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RectangleHeightTextBox.KeyPress
        If RectangleHeightTextBox.Text.Length > 9 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
        'Disables Alphabetic Letters And Special Characters In TextBox
    End Sub

    Private Sub TriangleComputeButton_Click(sender As Object, e As EventArgs) Handles TriangleComputeButton.Click
        Dim TriangleBase As Decimal = Val(TriangleBaseTextBox.Text) 'Triangle Base
        Dim TriangleHeight As Decimal = Val(TriangleHeightTextBox.Text) 'Triangle Height

        TriangleAreaAnswer.Text = Format(((TriangleBase * TriangleHeight) / 2), "0.00") 'Triangle Area
        HistoryTextBox.AppendText("Triangle Area: " & TriangleAreaAnswer.Text & Environment.NewLine)
    End Sub

    Private Sub SquareComputeButton_Click(sender As Object, e As EventArgs) Handles SquareComputeButton.Click
        Dim SquareSide As Decimal = Val(SquareSideTextBox.Text) 'Square Side

        SquareAreaAnswer.Text = Format(SquareSide * SquareSide, "0.00") 'Square Area
        HistoryTextBox.AppendText("Square Area: " & SquareAreaAnswer.Text & Environment.NewLine)
    End Sub

    Private Sub RectangleComputeButton_Click(sender As Object, e As EventArgs) Handles RectangleComputeButton.Click
        Dim RectangleWidth As Decimal = Val(RectangleWidthTextBox.Text) 'Triangle Base
        Dim RectangleHeight As Decimal = Val(RectangleHeightTextBox.Text) 'Triangle Height

        RectangleAreaAnswer.Text = Format(RectangleWidth * RectangleHeight, "0.00") 'Rectangle Area
        HistoryTextBox.AppendText("Rectangle Area: " & RectangleAreaAnswer.Text & Environment.NewLine)
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        TriangleBaseTextBox.Text = ""
        TriangleHeightTextBox.Text = ""
        TriangleAreaAnswer.Text = "0"

        SquareSideTextBox.Text = ""
        SquareAreaAnswer.Text = "0"

        RectangleHeightTextBox.Text = ""
        RectangleAreaAnswer.Text = "0"

        HistoryTextBox.Text = ""
        'Reset Values
    End Sub
End Class