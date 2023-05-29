Public Class MainMenu
    Private Sub tbxSearch_TextChanged(sender As Object, e As EventArgs) Handles tbxSearch.TextChanged
        tbxSearch.Text = ""
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblMatricular_Click(sender As Object, e As EventArgs) Handles lblMatricular.Click
        Dispose()
        Matriculas.ShowDialog()
    End Sub
End Class