Public Class Form1
    Public inici As String
    Public final As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        inici = "Inici coodrdenades X" + CStr(e.X) + " Y " + CStr(e.Y)

        Me.Text = inici


    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        final = inici + " Final coodrdenades X" + CStr(e.X) + " Y " + CStr(e.Y)

        If e.Button = MouseButtons.Right Then
            Me.Text = final + " BOTÓ DRET "
        ElseIf e.Button = MouseButtons.Left Then
            Me.Text = final + " BOTÓ ESQUERRE "
        End If

    End Sub
End Class
