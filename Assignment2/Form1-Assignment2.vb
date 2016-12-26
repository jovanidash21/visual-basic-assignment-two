Public Class AssignmentHomeForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Number1Button.Click
        Me.Hide() 'Hides this form
        FormNumber1.Show() 'Shows Form For Item Number 1
    End Sub

    Private Sub Number2Button_Click(sender As Object, e As EventArgs) Handles Number2Button.Click
        Me.Hide() 'Hides this form
        FormNumber2.Show() 'Shows Form For Item Number 2
    End Sub
End Class
