Public Class FormNumber1

    Dim FirstNumber As Decimal
    Dim SecondNumber As Decimal
    Dim Operation As String
    Dim OperatorSelector As Boolean = False

    Private Sub ButtonPoint_Click(sender As Object, e As EventArgs) Handles ButtonPoint.Click
        If Not (CalculatorMainTextBox.Text.Contains(".")) Then
            CalculatorMainTextBox.Text += "."
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        CalculatorMainTextBox.Text += "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalculatorMainTextBox.Text += "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CalculatorMainTextBox.Text += "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CalculatorMainTextBox.Text += "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CalculatorMainTextBox.Text += "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CalculatorMainTextBox.Text += "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CalculatorMainTextBox.Text += "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CalculatorMainTextBox.Text += "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CalculatorMainTextBox.Text += "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        CalculatorMainTextBox.Text += "9"
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If CalculatorMainTextBox.Text.Length > 0 Then
            CalculatorMainTextBox.Text = CalculatorMainTextBox.Text.Remove(CalculatorMainTextBox.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        CalculatorMainTextBox.Text = ""
    End Sub

    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        FirstNumber = CalculatorMainTextBox.Text
        CalculatorMainTextBox.Text = ""
        OperatorSelector = True
        Operation = "+"
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        FirstNumber = CalculatorMainTextBox.Text
        CalculatorMainTextBox.Text = ""
        OperatorSelector = True
        Operation = "-"
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        FirstNumber = CalculatorMainTextBox.Text
        CalculatorMainTextBox.Text = ""
        OperatorSelector = True
        Operation = "*"
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        FirstNumber = CalculatorMainTextBox.Text
        CalculatorMainTextBox.Text = ""
        OperatorSelector = True
        Operation = "/"
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
    End Sub
End Class