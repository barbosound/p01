Public Class Form1
    Public inici As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        inici = "Inici coodrdenades X" + CStr(e.X) + " Y " + CStr(e.Y)
        Me.Text = inici

        If  
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Me.Text = inici + " Final coodrdenades X" + CStr(e.X) + " Y " + CStr(e.Y)
    End Sub
End Class
