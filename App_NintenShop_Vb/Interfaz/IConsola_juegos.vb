Public Interface IConsola_juegos
    Property TITLE_N As String
    Property GENERE_N As String
    Property CREATORS_N As String
    Property PRICE_N As Double
    Property FOLDER_N As Integer
    Property NUM_IMAGE_N As Integer
    Function ToString() As String
    Function Ticket() As String
End Interface