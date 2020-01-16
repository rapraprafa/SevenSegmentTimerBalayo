Public Class SevenSegmentTimerBalayo
    Dim Second As Int32 = 0

    Private Sub SevenSegmentTimerBalayo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Second += 1
        If (Second = 0) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red

        ElseIf (Second = 1) Then
            Button4.BackColor = Color.Red
            Button3.BackColor = Color.Red

        ElseIf (Second = 2) Then
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button1.BackColor = Color.Red
            Button7.BackColor = Color.Red

        ElseIf (Second = 3) Then
            Button6.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button1.BackColor = Color.Red
            Button7.BackColor = Color.Red
            Button4.BackColor = Color.Red

        ElseIf (Second = 4) Then
            Button7.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button2.BackColor = Color.Red
        End If
    End Sub
End Class
