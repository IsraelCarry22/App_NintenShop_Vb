Imports System
Imports MySql.Data.MySqlClient
Imports System.Linq
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Media
Imports System.IO
Imports System.Data
Imports System.Drawing

Public Class Form1
    Private Files As Management_of_arhcivos
    Private videojuegos_nes As Videojuego(), videojuegos_snes As Videojuego(), videojuegos_n64 As Videojuego(), videojuegos_gb As Videojuego(), videojuegos_gba As Videojuego()
    Private Cart_Video_Games_List As List(Of Videojuego)
    Private Accountan As Integer, Index_Dgv As Integer, Ticket_quantity As Integer = 0
    Private Final_purchase_with_Iva As Double, Final_purchase As Double = 0.0
    Private Filter_Nes As Boolean, Filter_Snes As Boolean, Filter_Gb As Boolean, Filter_N64 As Boolean, Filter_Gba As Boolean
    Private Music As String
    Private Image_Paths As String(,)

    Public Sub New()
        InitializeComponent()
        Me.MaximizeBox = False
        Music = "C:\Users\Israe\Pictures\NintenShop\NintenShop.wav"
        Dim player As New SoundPlayer(Music)
        player.PlayLooping()
        videojuegos_nes = New Videojuego(14) {}
        videojuegos_gb = New Videojuego(14) {}
        videojuegos_snes = New Videojuego(14) {}
        videojuegos_n64 = New Videojuego(14) {}
        videojuegos_gba = New Videojuego(14) {}
        Cart_Video_Games_List = New List(Of Videojuego)()
        Image_Paths = New String(4, 14) {}
        Filter_Nes = True
        Filter_Snes = False
        Filter_Gb = False
        Filter_N64 = False
        Filter_Gba = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datos_MySql_Arreglos()
        Dim rutaPrincipal As String = "C:\Users\Israe\Pictures\NintenShop"
        Dim carpetas As String() = Directory.GetDirectories(rutaPrincipal)
        For i As Integer = 0 To carpetas.Length - 1
            Dim rutaCarpeta As String = carpetas(i)
            Dim imagenes As String() = Directory.GetFiles(rutaCarpeta)
            For j As Integer = 0 To imagenes.Length - 1
                Image_Paths(i, j) = imagenes(j)
            Next j
        Next i
    End Sub

    Private Sub Btn_Pic_Nes_Click(sender As Object, e As EventArgs) Handles Btn_Pic_Nes.Click
        Filter_Nes = True
        Filter_Snes = False
        Filter_Gb = False
        Filter_N64 = False
        Filter_Gba = False
        Filter_Games(Filter_Nes, videojuegos_nes)
    End Sub

    Private Sub Btn_Pic_Gb_Click(sender As Object, e As EventArgs) Handles Btn_Pic_Gb.Click
        Filter_Nes = False
        Filter_Snes = False
        Filter_Gb = True
        Filter_N64 = False
        Filter_Gba = False
        Filter_Games(Filter_Gb, videojuegos_gb)
    End Sub

    Private Sub Btn_Pic_Snes_Click(sender As Object, e As EventArgs) Handles Btn_Pic_Snes.Click
        Filter_Nes = False
        Filter_Snes = True
        Filter_Gb = False
        Filter_N64 = False
        Filter_Gba = False
        Filter_Games(Filter_Snes, videojuegos_snes)
    End Sub

    Private Sub Btn_Pic_N64_Click(sender As Object, e As EventArgs) Handles Btn_Pic_N64.Click
        Filter_Nes = False
        Filter_Snes = False
        Filter_Gb = False
        Filter_N64 = True
        Filter_Gba = False
        Filter_Games(Filter_N64, videojuegos_n64)
    End Sub

    Private Sub Btn_Pic_Gba_Click(sender As Object, e As EventArgs) Handles Btn_Pic_Gba.Click
        Filter_Nes = False
        Filter_Snes = False
        Filter_Gb = False
        Filter_N64 = False
        Filter_Gba = True
        Filter_Games(Filter_Gba, videojuegos_gba)
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Panel_Carrito.Visible = False
        Panel_Ayuda.Visible = False
    End Sub

    Private Sub CarritoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarritoToolStripMenuItem.Click
        Panel_Carrito.Visible = True
        Panel_Ayuda.Visible = False
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Panel_Carrito.Visible = True
        Panel_Ayuda.Visible = True
    End Sub

    Private Sub Btn_Pic_Carrito_Click(sender As Object, e As EventArgs) Handles Btn_Pic_Carrito.Click
        Panel_Carrito.Visible = True
        Panel_Ayuda.Visible = False
    End Sub

    Private Sub Btn_Comprar_Click(sender As Object, e As EventArgs) Handles Btn_Comprar.Click
        Dim selected_game_buy As Integer = Lista_Juegos.SelectedIndex
        If Filter_Nes = True Then
            Comprar_Unidad(videojuegos_nes, selected_game_buy)
        ElseIf Filter_Gb = True Then
            Comprar_Unidad(videojuegos_gb, selected_game_buy)
        ElseIf Filter_Snes = True Then
            Comprar_Unidad(videojuegos_snes, selected_game_buy)
        ElseIf Filter_N64 = True Then
            Comprar_Unidad(videojuegos_n64, selected_game_buy)
        Else
            Comprar_Unidad(videojuegos_gba, selected_game_buy)
        End If
    End Sub

    Private Sub btn_Agregar_carrito_Click(sender As Object, e As EventArgs) Handles btn_Agregar_carrito.Click
        Dim Selected_Game_Buy As Integer = Lista_Juegos.SelectedIndex
        Dim Selected_Game As Videojuego = Nothing
        If Filter_Nes = True Then
            Selected_Game = videojuegos_nes(Selected_Game_Buy)
            Add_Cart_Item(Selected_Game)
        ElseIf Filter_Gb = True Then
            Selected_Game = videojuegos_gb(Selected_Game_Buy)
            Add_Cart_Item(Selected_Game)
        ElseIf Filter_Snes = True Then
            Selected_Game = videojuegos_snes(Selected_Game_Buy)
            Add_Cart_Item(Selected_Game)
        ElseIf Filter_N64 = True Then
            Selected_Game = videojuegos_n64(Selected_Game_Buy)
            Add_Cart_Item(Selected_Game)
        Else
            Selected_Game = videojuegos_gba(Selected_Game_Buy)
            Add_Cart_Item(Selected_Game)
        End If
    End Sub

    Private Sub Lista_Juegos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lista_Juegos.SelectedIndexChanged
        Dim Selected_Index As Integer = Lista_Juegos.SelectedIndex
        If Selected_Index <> -1 Then
            Dim Video_Game As Videojuego
            If Filter_Nes = True Then
                Video_Game = videojuegos_nes(Selected_Index)
                Infromation_Game(videojuegos_nes, Selected_Index)
            ElseIf Filter_Gb = True Then
                Video_Game = videojuegos_gb(Selected_Index)
                Infromation_Game(videojuegos_gb, Selected_Index)
            ElseIf Filter_Snes = True Then
                Video_Game = videojuegos_snes(Selected_Index)
                Infromation_Game(videojuegos_snes, Selected_Index)
            ElseIf Filter_N64 = True Then
                Video_Game = videojuegos_n64(Selected_Index)
                Infromation_Game(videojuegos_n64, Selected_Index)
            Else
                Video_Game = videojuegos_gba(Selected_Index)
                Infromation_Game(videojuegos_gba, Selected_Index)
            End If
        End If
    End Sub

    Private Sub Btn_Elimiar_Item_Click(sender As Object, e As EventArgs) Handles Btn_Elimiar_Item.Click
        Dim selectedRowIndex As Integer = Dgv_Carrito.SelectedCells(0).RowIndex
        If selectedRowIndex <> -1 Then
            Dim deletedVideoGame As Videojuego = Cart_Video_Games_List(selectedRowIndex)
            Final_purchase -= deletedVideoGame.PRICE_N
            Final_purchase_with_Iva -= Math.Round(deletedVideoGame.PRICE_N * 0.16, 2)
            Dgv_Carrito.Rows.RemoveAt(selectedRowIndex)
            Cart_Video_Games_List.RemoveAt(selectedRowIndex)
            Accountan -= 1
            lbl_Total_Iva.Text = $"${Math.Round(Final_purchase * 0.16, 2)}"
            lbl_Total_Carrito.Text = $"${Final_purchase}"
            lbl_Contador_Carrito.Text = Accountan.ToString()
        End If
    End Sub

    Private Sub Btn_Comprar_Carrito_Click(sender As Object, e As EventArgs) Handles Btn_Comprar_Carrito.Click
        If Cart_Video_Games_List.Count > 0 Then
            Ticket_quantity += 1
            Try
                Files = New Management_of_arhcivos(Cart_Video_Games_List, Ticket_quantity, Final_purchase_with_Iva, Final_purchase)
                Console.Beep()
                MessageBox.Show("Ticket impreso exitosamente...")
                Dgv_Carrito.Rows.Clear()
                Cart_Video_Games_List.Clear()
                lbl_Total_Iva.Text = "--"
                lbl_Total_Carrito.Text = "--"
                lbl_Contador_Carrito.Text = "0"
                Accountan = 0
                Final_purchase_with_Iva = 0.00
                Final_purchase = 0.00
            Catch ex As Exception
                MessageBox.Show("Error al imprimir el ticket..." & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Add_Cart_Item(ByVal Game As Videojuego)
        If Not Cart_Video_Games_List.Contains(Game) Then
            Index_Dgv = Dgv_Carrito.Rows.Add()
            Cart_Video_Games_List.Add(Game)
            Accountan += 1
            lbl_Contador_Carrito.Text = Accountan.ToString()
            Final_purchase += Game.PRICE_N
            Final_purchase_with_Iva = Math.Round((Final_purchase * 0.16), 2)
            Console.Beep()
            Dim Add_Console As Videojuego = Cart_Video_Games_List.Last()
            Dgv_Carrito.Rows(Index_Dgv).Cells(0).Value = Add_Console.TITLE_N
            Dgv_Carrito.Rows(Index_Dgv).Cells(1).Value = Add_Console.GENERE_N
            Dgv_Carrito.Rows(Index_Dgv).Cells(2).Value = Add_Console.CONSOLE_N
            Dgv_Carrito.Rows(Index_Dgv).Cells(3).Value = Add_Console.PRICE_N
            lbl_Total_Iva.Text = $"${Final_purchase_with_Iva}"
            lbl_Total_Carrito.Text = $"${Final_purchase}"
        End If
    End Sub

    Private Sub Filter_Games(Filter As Boolean, Video_Games As Videojuego())
        If Filter <> False Then
            Lista_Juegos.Items.Clear()
            For Each Consoles As Consola In Video_Games
                If TypeOf Consoles Is Videojuego Then
                    Dim Video_Game As Videojuego = DirectCast(Consoles, Videojuego)
                    Lista_Juegos.Items.Add(Video_Game.TITLE_N)
                End If
            Next
            Lista_Juegos.SelectedIndex = 0
            Return
        End If
    End Sub

    Private Sub Comprar_Unidad(Video_Games As Videojuego(), Selected_Index As Integer)
        If Selected_Index <> -1 Then
            Dim selected_game As Videojuego = Video_Games(Selected_Index)
            Dim buy As Double = selected_game.PRICE_N
            Dim IVA As Double = Math.Round((buy / 1.16) * 0.16, 2)
            buy = Math.Round(buy - IVA, 2)
            Dim buy_final As Double = buy + IVA
            Console.Beep()
            MessageBox.Show("NintenShop " & DateTime.Now & vbCrLf & vbCrLf &
                "Titulo: " & selected_game.TITLE_N & vbCrLf &
                "Genero: " & selected_game.GENERE_N & vbCrLf &
                "Año: " & selected_game.YEAR_N & vbCrLf &
                "Precio: " & selected_game.PRICE_N & vbCrLf & vbCrLf &
                "Iva: $" & IVA & vbCrLf &
                "Total: $" & buy & vbCrLf & vbCrLf &
                "Sub Total Final: $" & buy_final & vbCrLf &
                "Gracias por su compra.")
        End If
    End Sub

    Private Sub Infromation_Game(Video_Games As Videojuego(), Selected_Image As Integer)
        Dim Selected_Game As Videojuego = Video_Games(Selected_Image)
        lbl_Titulo.Text = "Título: " & Selected_Game.TITLE_N & "."
        lbl_Genero.Text = "Género: " & Selected_Game.GENERE_N & "."
        lbl_Creadores.Text = "Creadores: " & Selected_Game.CREATORS_N & "."
        Lbl_Año.Text = "Año: " & Selected_Game.YEAR_N.ToString() & "."
        lbl_Consola.Text = "Consola: " & Selected_Game.CONSOLE_N & "."
        lbl_Precio.Text = "$" & Selected_Game.PRICE_N.ToString()
        lbl_Bits.Text = "Bits: " & Selected_Game.BITS_N.ToString() & "."
        Dim fila As Integer = Selected_Game.FOLDER_N
        Dim columna As Integer = Selected_Game.NUM_IMAGE_N
        If fila >= 0 AndAlso columna >= 0 AndAlso fila < Image_Paths.GetLength(0) AndAlso columna < Image_Paths.GetLength(1) Then
            Pic_Caratula.ImageLocation = Image_Paths(fila, columna)
        Else
            Pic_Caratula.Image = Nothing
        End If
    End Sub

    Private Sub Datos_Tablas_MySql(consoleList As List(Of Videojuego), commandConsole As MySqlCommand, readerConsole As MySqlDataReader)
        While readerConsole.Read()
            Dim videojuego As New Videojuego()
            videojuego.TITLE_N = readerConsole("Titulo").ToString()
            videojuego.GENERE_N = readerConsole("Genero").ToString()
            videojuego.CREATORS_N = readerConsole("Creadores").ToString()
            videojuego.PRICE_N = Convert.ToDouble(readerConsole("Precio"))
            videojuego.CONSOLE_N = readerConsole("Consola").ToString()
            videojuego.YEAR_N = Convert.ToInt32(readerConsole("Año"))
            videojuego.BITS_N = Convert.ToInt32(readerConsole("Bits"))
            videojuego.FOLDER_N = Convert.ToInt32(readerConsole("Carpeta"))
            videojuego.NUM_IMAGE_N = Convert.ToInt32(readerConsole("Imagen"))
            consoleList.Add(videojuego)
        End While
        readerConsole.Close()
    End Sub

    Private Sub Datos_MySql_Arreglos()
        Dim Cadena As New Connect_database()
        Using connection As New MySqlConnection(Cadena.CADENA_CONEXION)
            Try
                connection.Open()
                Console.Beep()
                If connection.State <> ConnectionState.Open Then
                    Return
                End If
                Dim consoleArr As String() = {"nes", "gb", "snes", "n64", "gba"}
                For i As Integer = 0 To consoleArr.Length - 1
                    Dim console As String = consoleArr(i)
                    Dim command As New MySqlCommand($"SELECT Titulo, Genero, Creadores, Precio, Consola, Año, Bits, Carpeta, Imagen FROM videojuegos_{console}", connection)
                    Dim readerTable As MySqlDataReader = command.ExecuteReader()
                    Dim TableList As New List(Of Videojuego)()
                    Datos_Tablas_MySql(TableList, command, readerTable)
                    Select Case console.ToLower()
                        Case "nes"
                            videojuegos_nes = TableList.ToArray()
                            Exit Select
                        Case "gb"
                            videojuegos_gb = TableList.ToArray()
                            Exit Select
                        Case "snes"
                            videojuegos_snes = TableList.ToArray()
                            Exit Select
                        Case "n64"
                            videojuegos_n64 = TableList.ToArray()
                            Exit Select
                        Case "gba"
                            videojuegos_gba = TableList.ToArray()
                            Exit Select
                    End Select
                Next
            Catch ex As Exception
                MessageBox.Show("Error al obtener datos: " & ex.Message)
                Return
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
End Class