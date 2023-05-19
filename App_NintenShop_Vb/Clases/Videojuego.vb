Public Class Videojuego
    Inherits Consola
    Implements IConsola_juegos

    Protected _Title As String
    Protected _Gender As String
    Protected _Creators As String
    Protected _Price As Double
    Protected _Folder As Integer
    Protected _Num_Image As Integer

    Property TITLE_N As String Implements IConsola_juegos.TITLE_N
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
        End Set
    End Property

    Property GENERE_N As String Implements IConsola_juegos.GENERE_N
        Get
            Return _Gender
        End Get
        Set(ByVal value As String)
            _Gender = value
        End Set
    End Property

    Property CREATORS_N As String Implements IConsola_juegos.CREATORS_N
        Get
            Return _Creators
        End Get
        Set(ByVal value As String)
            _Creators = value
        End Set
    End Property

    Property PRICE_N As Double Implements IConsola_juegos.PRICE_N
        Get
            Return _Price
        End Get
        Set(ByVal value As Double)
            _Price = value
        End Set
    End Property

    Property FOLDER_N As Integer Implements IConsola_juegos.FOLDER_N
        Get
            Return _Folder
        End Get
        Set(ByVal value As Integer)
            _Folder = value
        End Set
    End Property

    Property NUM_IMAGE_N As Integer Implements IConsola_juegos.NUM_IMAGE_N
        Get
            Return _Num_Image
        End Get
        Set(ByVal value As Integer)
            _Num_Image = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        _Title = String.Empty
        _Gender = String.Empty
        _Creators = String.Empty
        _Price = 0
        _Folder = 0
        _Num_Image = 0
    End Sub

    Public Sub New(ByVal title As String, ByVal gender As String, ByVal creators As String, ByVal price As Double, ByVal folder As Integer, ByVal num_image As Integer, ByVal console As String, ByVal year As Integer, ByVal bits As Integer)
        MyBase.New(console, year, bits)
        Me._Title = title
        Me._Gender = gender
        Me._Creators = creators
        Me._Price = price
        Me._Folder = folder
        Me._Num_Image = num_image
    End Sub

    Public Overrides Function ToString() As String Implements IConsola_juegos.ToString
        Return $"Titulo: {_Title}" & ", " & $"Genero: {_Gender}" & ", " & $"Precio: ${_Price}"
    End Function

    Public Overrides Function Ticket() As String Implements IConsola_juegos.Ticket
        Return $"Titulo: {_Title}" & vbLf & $"Año: {_Year}" & vbLf & $"Genero: {_Gender}" & vbLf & $"Consola: {_Console}" & vbLf & $"Creadores: {_Creators}" & vbLf & $"Precio: ${_Price}" & vbLf & $"Bits: {_Bits}" & vbLf & vbLf + MyBase.ToString()
    End Function
End Class