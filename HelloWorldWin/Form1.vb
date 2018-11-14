Public Class HelloWorldForm
    Private Sub PressMeButton_Click(sender As Object, e As EventArgs) Handles PressMeButton.Click
        REM Set visibility appropriately and add text to label
        ' Adding another comment to force git sync
        HelloWorldLabel.Visible = True
        PressMeButton.Visible = False
        HelloWorldLabel.Text = "Hello World!"
        ExitButton.Visible = True
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        REM all we do here is exit 
        ' Adding another comment to force git sync
        End
    End Sub

    Private Sub HelloWorldForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REM set visibility to starting states
        ' Adding another comment to force git sync
        ' Adding another comment to force git sync
        HelloWorldLabel.Visible = False
        PressMeButton.Visible = True
        ExitButton.Visible = False
    End Sub
End Class
