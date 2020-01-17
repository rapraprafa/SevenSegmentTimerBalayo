Public Class SevenSegmentTimerBalayo
    Dim Second As Int32 = -1

    Private Sub SevenSegmentTimerBalayo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Second = Second + 1
        If (Second = 1) Then
            Button1.BackColor = Color.White
            Button2.BackColor = Color.White
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.White
        ElseIf (Second = 2) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.White
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.White
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red

        ElseIf (Second = 3) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.White
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red

        ElseIf (Second = 4) Then
            Button1.BackColor = Color.White
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.Red

        ElseIf (Second = 5) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.White
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red

        ElseIf (Second = 6) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.White
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red

        ElseIf (Second = 7) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.White

        ElseIf (Second = 8) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red

        ElseIf (Second = 9) Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.Red

        Else
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button7.BackColor = Color.White
            Second = 0
        End If

    End Sub
End Class
