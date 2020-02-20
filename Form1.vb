Public Class Form1
    Private Declare Function key Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Keys) As Keys

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            WebBrowser1.Navigate(TextBox1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.TopMost = False Then
            NotifyIcon1.Text = "Top Off"
            Me.TopMost = True
        ElseIf Me.TopMost = True Then
            Me.TopMost = False
            NotifyIcon1.Text = "Top On"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
       
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        NotifyIcon1.Text = "Top Off"
        Me.TopMost = True
        Me.BringToFront()
        Me.Refresh()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Text = "asdf"
    End Sub
End Class
