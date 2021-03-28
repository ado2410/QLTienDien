Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Owner.Enabled = False
    End Sub

    Private Sub About_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Owner.Enabled = True
    End Sub
End Class