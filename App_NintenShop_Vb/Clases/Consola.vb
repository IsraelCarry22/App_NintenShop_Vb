Public MustInherit Class Consola
    Protected _Console As String
    Protected _Year As Integer
    Protected _Bits As Integer

    Public Property CONSOLE_N As String
        Get
            Return _Console
        End Get
        Set(ByVal value As String)
            _Console = value
        End Set
    End Property

    Public Property YEAR_N As Integer
        Get
            Return _Year
        End Get
        Set(ByVal value As Integer)
            _Year = value
        End Set
    End Property

    Public Property BITS_N As Integer
        Get
            Return _Bits
        End Get
        Set(ByVal value As Integer)
            _Bits = value
        End Set
    End Property

    Public Sub New()
        _Console = String.Empty
        _Year = 0
        _Bits = 0
    End Sub

    Public Sub New(ByVal console As String, ByVal year As Integer, ByVal bits As Integer)
        Me._Console = console
        Me._Year = year
        Me._Bits = bits
    End Sub

    Public Overrides Function ToString() As String
        Return ""
    End Function

    Public Overridable Function Ticket() As String
        Return ""
    End Function
End Class