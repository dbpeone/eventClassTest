

Public Class Form1

    Public WithEvents CoolFire As New ABFire()

    Private Sub coolFire_completed(e As String) Handles CoolFire.Action
        MsgBox("finished " + e.ToString + "! !")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CoolFire.setName = "TEST1"
        CoolFire.RandomFire()
    End Sub

End Class
