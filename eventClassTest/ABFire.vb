Public Class ABFire
    Private _result As String = ""
    Private _name As String = ""

    Public Property setName
        Set(value)
            _name = value
        End Set
        Get
            Return _name
        End Get
    End Property

    Public Event Action(e As String)

    Private Sub Completed()
        MsgBox("fire!!")
    End Sub

    Public Sub RandomFire()
        Dim testTime As New Random()
        Dim n As Integer = testTime.NextDouble() * 10
        Debug.Print("start randomfire:" & _name)
        While n > 0
            n = n - 1
            Application.DoEvents()
            Threading.Thread.Sleep(1000)
        End While
        Debug.Print("stop randomfire:" & _name)
        'startTest = True
        RaiseEvent Action(_name)
    End Sub

    Public Sub New()
        AddHandler Action, AddressOf Completed
    End Sub
End Class
