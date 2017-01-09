Public Class FormNumber1

    Dim FirstNumber As Decimal
    Dim SecondNumber As Decimal
    Dim Operation As String
    Dim OperatorSelector As Boolean = False

    Private Sub ButtonPoint_Click(sender As Object, e As EventArgs) Handles ButtonPoint.Click
        If Not CalculatorMainTextBox.Text.Contains(".") Then
            If Len(CalculatorMainTextBox.Text) < 8 Then
                CalculatorMainTextBox.Text += "."
            End If
        End If
        'Point Button
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If Len(CalculatorMainTextBox.Text) < 8 Then
            CalculatorMainTextBox.Text += "0"
        End If
        'Zero Button
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(CalculatorMainTextBox.Text) < 8 Then
            CalculatorMainTextBox.Text += "1"
        End If
        'One Button
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Len(CalculatorMainTextBox.Text) < 8 Then
            CalculatorMainTextBox.Text += "2"
        End If
        'Two Button
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Len(CalculatorMainTextBox.Text) < 8 Then
            CalculatorMainTextBox.Text += "3"
        End If
        'Three Button
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Len(CalculatorMainTextBox.Text) < 8 Then
            CalculatorMainTextBox.Text += "4"
        End If
        'Four Button
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Len(CalculatorMainTextBox.Text) < 8 Then
            CalculatorMainTextBox.Text += "5"
        End If
        'Five Button
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Len(CalculatorMainTextBox.Text) < 8 Then
            CalculatorMainTextBox.Text += "6"
        End If
        'Six Button
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Len(CalculatorMainTextBox.Text) < 8 Then
            CalculatorMainTextBox.Text += "7"
        End If
        'Seven Button
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Len(CalculatorMainTextBox.Text) < 8 Then
            CalculatorMainTextBox.Text += "8"
        End If
        'Eight Button
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Len(CalculatorMainTextBox.Text) < 8 Then
            CalculatorMainTextBox.Text += "9"
        End If
        'Nine Button
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If CalculatorMainTextBox.Text.Length > 0 Then
            CalculatorMainTextBox.Text = CalculatorMainTextBox.Text.Remove(CalculatorMainTextBox.Text.Length - 1, 1)
        End If
        'Backspace Button
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        CalculatorMainTextBox.Text = ""
        'Clear Button
    End Sub

    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        If CalculatorMainTextBox.Text = "" Then
            OperatorSelector = False
        Else
            FirstNumber = CalculatorMainTextBox.Text
            CalculatorMainTextBox.Text = ""
            OperatorSelector = True
            Operation = "+"
        End If
        'Plus Button
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        If CalculatorMainTextBox.Text = "" Then
            OperatorSelector = False
        Else
            FirstNumber = CalculatorMainTextBox.Text
            CalculatorMainTextBox.Text = ""
            OperatorSelector = True
            Operation = "-"
        End If
        'Minus Button
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        If CalculatorMainTextBox.Text = "" Then
            OperatorSelector = False
        Else
            FirstNumber = CalculatorMainTextBox.Text
            CalculatorMainTextBox.Text = ""
            OperatorSelector = True
            Operation = "*"
        End If
        'Mutiply Button
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        If CalculatorMainTextBox.Text = "" Then
            OperatorSelector = False
        Else
            FirstNumber = CalculatorMainTextBox.Text
            CalculatorMainTextBox.Text = ""
            OperatorSelector = True
            Operation = "/"
        End If
        'Divide Button
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        If OperatorSelector = True Then
            SecondNumber = CalculatorMainTextBox.Text
            If Operation = "+" Then
                CalculatorMainTextBox.Text = FirstNumber + SecondNumber
            ElseIf Operation = "-" Then
                CalculatorMainTextBox.Text = FirstNumber - SecondNumber
            ElseIf Operation = "*" Then
                CalculatorMainTextBox.Text = FirstNumber * SecondNumber
            ElseIf Operation = "/" Then
                CalculatorMainTextBox.Text = FirstNumber / SecondNumber
            End If
            OperatorSelector = False
        End If
        'Equal Button
    End Sub
End Class