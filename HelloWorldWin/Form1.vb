Public Class HelloWorldForm
    Private Sub PressMeButton_Click(sender As Object, e As EventArgs) Handles PressMeButton.Click
        REM Set visiibility appropriately and add text to label
        HelloWorldLabel.Visible = True
        PressMeButton.Visible = False
        HelloWorldLabel.Text = "Hello World!"
        ExitButton.Visible = True
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        REM all we do here is exit 
        End
    End Sub

    Private Sub HelloWorldForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REM set visibility to starting states
        HelloWorldLabel.Visible = False
        PressMeButton.Visible = True
        ExitButton.Visible = False
    End Sub
End Class
