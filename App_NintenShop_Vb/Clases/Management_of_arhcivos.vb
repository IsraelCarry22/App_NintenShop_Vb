Imports System
Imports System.Collections.Generic
Imports System.IO

Public Class Management_of_arhcivos
    Private file_tiket As StreamWriter

    Public Sub New(ByVal cart_Video_Games_List As List(Of Videojuego), ByVal ticket_quantity As Integer, ByVal final_purchase_with_Iva As Double, ByVal final_purchase As Double)
        Dim Date_Time_Ticket As String = DateTime.Now.ToString()
        Dim Desktop As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim Ticket As String = Path.Combine(Desktop, $"NintenShop {ticket_quantity}.txt")
        Using file_tiket = New StreamWriter(Ticket)
            file_tiket.WriteLine($"NintenShop Inc.                  {Date_Time_Ticket}{vbLf}")
            For Each Console As Consola In cart_Video_Games_List
                file_tiket.WriteLine(Console.Ticket())
            Next
            file_tiket.WriteLine($"Iva: ${final_purchase_with_Iva}.")
            file_tiket.WriteLine($"Compra Total: ${final_purchase}.")
            file_tiket.WriteLine($"{vbLf}Gracias por comprar en NintenShop Inc.")
        End Using
    End Sub

    Protected Overrides Sub Finalize()
        file_tiket.Close()
    End Sub
End Class