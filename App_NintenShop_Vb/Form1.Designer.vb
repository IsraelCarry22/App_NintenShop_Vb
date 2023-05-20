<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Inf_puntero = New ToolTip(components)
        Btn_Pic_Nes = New PictureBox()
        Btn_Pic_Gb = New PictureBox()
        Btn_Pic_Snes = New PictureBox()
        Btn_Pic_N64 = New PictureBox()
        Btn_Pic_Gba = New PictureBox()
        Btn_Pic_Carrito = New PictureBox()
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        CarritoToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Pic_Caratula = New PictureBox()
        lbl_Contador_Carrito = New Label()
        Label1 = New Label()
        Lista_Juegos = New ListBox()
        Btn_Comprar = New Button()
        btn_Agregar_carrito = New Button()
        lbl_Titulo = New Label()
        lbl_Precio = New Label()
        lbl_Genero = New Label()
        Lbl_Año = New Label()
        lbl_Consola = New Label()
        lbl_Bits = New Label()
        lbl_Creadores = New Label()
        Panel_Carrito = New Panel()
        Panel_Ayuda = New Panel()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Btn_Elimiar_Item = New Button()
        Btn_Comprar_Carrito = New Button()
        lbl_Total_Carrito = New Label()
        lbl_Total_Iva = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Dgv_Carrito = New DataGridView()
        Titulo = New DataGridViewTextBoxColumn()
        Genero = New DataGridViewTextBoxColumn()
        Consola = New DataGridViewTextBoxColumn()
        Precio = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CType(Btn_Pic_Nes, ComponentModel.ISupportInitialize).BeginInit()
        CType(Btn_Pic_Gb, ComponentModel.ISupportInitialize).BeginInit()
        CType(Btn_Pic_Snes, ComponentModel.ISupportInitialize).BeginInit()
        CType(Btn_Pic_N64, ComponentModel.ISupportInitialize).BeginInit()
        CType(Btn_Pic_Gba, ComponentModel.ISupportInitialize).BeginInit()
        CType(Btn_Pic_Carrito, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Pic_Caratula, ComponentModel.ISupportInitialize).BeginInit()
        Panel_Carrito.SuspendLayout()
        Panel_Ayuda.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(Dgv_Carrito, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btn_Pic_Nes
        ' 
        Btn_Pic_Nes.BorderStyle = BorderStyle.FixedSingle
        Btn_Pic_Nes.Image = CType(resources.GetObject("Btn_Pic_Nes.Image"), Image)
        Btn_Pic_Nes.Location = New Point(447, 27)
        Btn_Pic_Nes.Name = "Btn_Pic_Nes"
        Btn_Pic_Nes.Size = New Size(86, 63)
        Btn_Pic_Nes.SizeMode = PictureBoxSizeMode.StretchImage
        Btn_Pic_Nes.TabIndex = 3
        Btn_Pic_Nes.TabStop = False
        Inf_puntero.SetToolTip(Btn_Pic_Nes, "Filtro Nes")
        ' 
        ' Btn_Pic_Gb
        ' 
        Btn_Pic_Gb.BorderStyle = BorderStyle.FixedSingle
        Btn_Pic_Gb.Image = CType(resources.GetObject("Btn_Pic_Gb.Image"), Image)
        Btn_Pic_Gb.Location = New Point(539, 27)
        Btn_Pic_Gb.Name = "Btn_Pic_Gb"
        Btn_Pic_Gb.Size = New Size(86, 63)
        Btn_Pic_Gb.SizeMode = PictureBoxSizeMode.StretchImage
        Btn_Pic_Gb.TabIndex = 4
        Btn_Pic_Gb.TabStop = False
        Inf_puntero.SetToolTip(Btn_Pic_Gb, "Filtro Gb")
        ' 
        ' Btn_Pic_Snes
        ' 
        Btn_Pic_Snes.BorderStyle = BorderStyle.FixedSingle
        Btn_Pic_Snes.Image = CType(resources.GetObject("Btn_Pic_Snes.Image"), Image)
        Btn_Pic_Snes.Location = New Point(631, 27)
        Btn_Pic_Snes.Name = "Btn_Pic_Snes"
        Btn_Pic_Snes.Size = New Size(86, 63)
        Btn_Pic_Snes.SizeMode = PictureBoxSizeMode.StretchImage
        Btn_Pic_Snes.TabIndex = 5
        Btn_Pic_Snes.TabStop = False
        Inf_puntero.SetToolTip(Btn_Pic_Snes, "Filtro Snes")
        ' 
        ' Btn_Pic_N64
        ' 
        Btn_Pic_N64.BorderStyle = BorderStyle.FixedSingle
        Btn_Pic_N64.Image = CType(resources.GetObject("Btn_Pic_N64.Image"), Image)
        Btn_Pic_N64.Location = New Point(723, 27)
        Btn_Pic_N64.Name = "Btn_Pic_N64"
        Btn_Pic_N64.Size = New Size(86, 63)
        Btn_Pic_N64.SizeMode = PictureBoxSizeMode.StretchImage
        Btn_Pic_N64.TabIndex = 6
        Btn_Pic_N64.TabStop = False
        Inf_puntero.SetToolTip(Btn_Pic_N64, "Filtro N64")
        ' 
        ' Btn_Pic_Gba
        ' 
        Btn_Pic_Gba.BorderStyle = BorderStyle.FixedSingle
        Btn_Pic_Gba.Image = CType(resources.GetObject("Btn_Pic_Gba.Image"), Image)
        Btn_Pic_Gba.Location = New Point(815, 27)
        Btn_Pic_Gba.Name = "Btn_Pic_Gba"
        Btn_Pic_Gba.Size = New Size(86, 63)
        Btn_Pic_Gba.SizeMode = PictureBoxSizeMode.StretchImage
        Btn_Pic_Gba.TabIndex = 7
        Btn_Pic_Gba.TabStop = False
        Inf_puntero.SetToolTip(Btn_Pic_Gba, "Filtro Gba")
        ' 
        ' Btn_Pic_Carrito
        ' 
        Btn_Pic_Carrito.BorderStyle = BorderStyle.FixedSingle
        Btn_Pic_Carrito.Image = CType(resources.GetObject("Btn_Pic_Carrito.Image"), Image)
        Btn_Pic_Carrito.Location = New Point(907, 27)
        Btn_Pic_Carrito.Name = "Btn_Pic_Carrito"
        Btn_Pic_Carrito.Size = New Size(58, 41)
        Btn_Pic_Carrito.SizeMode = PictureBoxSizeMode.StretchImage
        Btn_Pic_Carrito.TabIndex = 9
        Btn_Pic_Carrito.TabStop = False
        Inf_puntero.SetToolTip(Btn_Pic_Carrito, "Ver Carrito")
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, CarritoToolStripMenuItem, AyudaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1034, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' InicioToolStripMenuItem
        ' 
        InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        InicioToolStripMenuItem.Size = New Size(48, 20)
        InicioToolStripMenuItem.Text = "Inicio"' 
        ' CarritoToolStripMenuItem
        ' 
        CarritoToolStripMenuItem.Name = "CarritoToolStripMenuItem"
        CarritoToolStripMenuItem.Size = New Size(55, 20)
        CarritoToolStripMenuItem.Text = "Carrito"' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(53, 20)
        AyudaToolStripMenuItem.Text = "Ayuda"' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1034, 654)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 24)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1034, 654)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Pic_Caratula
        ' 
        Pic_Caratula.BackColor = Color.Silver
        Pic_Caratula.BorderStyle = BorderStyle.FixedSingle
        Pic_Caratula.Location = New Point(447, 96)
        Pic_Caratula.Name = "Pic_Caratula"
        Pic_Caratula.Size = New Size(529, 361)
        Pic_Caratula.SizeMode = PictureBoxSizeMode.StretchImage
        Pic_Caratula.TabIndex = 8
        Pic_Caratula.TabStop = False
        ' 
        ' lbl_Contador_Carrito
        ' 
        lbl_Contador_Carrito.AutoSize = True
        lbl_Contador_Carrito.Location = New Point(907, 75)
        lbl_Contador_Carrito.Name = "lbl_Contador_Carrito"
        lbl_Contador_Carrito.Size = New Size(17, 15)
        lbl_Contador_Carrito.TabIndex = 10
        lbl_Contador_Carrito.Text = "--"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 30)
        Label1.TabIndex = 11
        Label1.Text = "Selecciona una consola"' 
        ' Lista_Juegos
        ' 
        Lista_Juegos.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Lista_Juegos.FormattingEnabled = True
        Lista_Juegos.HorizontalScrollbar = True
        Lista_Juegos.ItemHeight = 30
        Lista_Juegos.Location = New Point(14, 149)
        Lista_Juegos.Name = "Lista_Juegos"
        Lista_Juegos.ScrollAlwaysVisible = True
        Lista_Juegos.Size = New Size(387, 514)
        Lista_Juegos.TabIndex = 12
        ' 
        ' Btn_Comprar
        ' 
        Btn_Comprar.BackColor = Color.Lime
        Btn_Comprar.Font = New Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Comprar.ForeColor = SystemColors.Control
        Btn_Comprar.Location = New Point(750, 624)
        Btn_Comprar.Name = "Btn_Comprar"
        Btn_Comprar.Size = New Size(272, 39)
        Btn_Comprar.TabIndex = 13
        Btn_Comprar.Text = "Comprar"
        Btn_Comprar.UseVisualStyleBackColor = False
        ' 
        ' btn_Agregar_carrito
        ' 
        btn_Agregar_carrito.BackColor = Color.Blue
        btn_Agregar_carrito.Font = New Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_Agregar_carrito.ForeColor = SystemColors.Control
        btn_Agregar_carrito.Location = New Point(447, 627)
        btn_Agregar_carrito.Name = "btn_Agregar_carrito"
        btn_Agregar_carrito.Size = New Size(272, 39)
        btn_Agregar_carrito.TabIndex = 14
        btn_Agregar_carrito.Text = "Agregar al carrito"
        btn_Agregar_carrito.UseVisualStyleBackColor = False
        ' 
        ' lbl_Titulo
        ' 
        lbl_Titulo.AutoSize = True
        lbl_Titulo.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_Titulo.Location = New Point(447, 458)
        lbl_Titulo.Name = "lbl_Titulo"
        lbl_Titulo.Size = New Size(30, 25)
        lbl_Titulo.TabIndex = 15
        lbl_Titulo.Text = "--"' 
        ' lbl_Precio
        ' 
        lbl_Precio.AutoSize = True
        lbl_Precio.Font = New Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_Precio.ForeColor = Color.Green
        lbl_Precio.Location = New Point(750, 583)
        lbl_Precio.Name = "lbl_Precio"
        lbl_Precio.Size = New Size(31, 30)
        lbl_Precio.TabIndex = 22
        lbl_Precio.Text = "--"' 
        ' lbl_Genero
        ' 
        lbl_Genero.AutoSize = True
        lbl_Genero.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_Genero.Location = New Point(447, 483)
        lbl_Genero.Name = "lbl_Genero"
        lbl_Genero.Size = New Size(30, 25)
        lbl_Genero.TabIndex = 23
        lbl_Genero.Text = "--"' 
        ' Lbl_Año
        ' 
        Lbl_Año.AutoSize = True
        Lbl_Año.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_Año.Location = New Point(447, 558)
        Lbl_Año.Name = "Lbl_Año"
        Lbl_Año.Size = New Size(30, 25)
        Lbl_Año.TabIndex = 25
        Lbl_Año.Text = "--"' 
        ' lbl_Consola
        ' 
        lbl_Consola.AutoSize = True
        lbl_Consola.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_Consola.Location = New Point(447, 533)
        lbl_Consola.Name = "lbl_Consola"
        lbl_Consola.Size = New Size(30, 25)
        lbl_Consola.TabIndex = 24
        lbl_Consola.Text = "--"' 
        ' lbl_Bits
        ' 
        lbl_Bits.AutoSize = True
        lbl_Bits.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_Bits.Location = New Point(447, 583)
        lbl_Bits.Name = "lbl_Bits"
        lbl_Bits.Size = New Size(30, 25)
        lbl_Bits.TabIndex = 26
        lbl_Bits.Text = "--"' 
        ' lbl_Creadores
        ' 
        lbl_Creadores.AutoSize = True
        lbl_Creadores.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_Creadores.Location = New Point(447, 508)
        lbl_Creadores.Name = "lbl_Creadores"
        lbl_Creadores.Size = New Size(30, 25)
        lbl_Creadores.TabIndex = 27
        lbl_Creadores.Text = "--"' 
        ' Panel_Carrito
        ' 
        Panel_Carrito.Controls.Add(Panel_Ayuda)
        Panel_Carrito.Controls.Add(Btn_Elimiar_Item)
        Panel_Carrito.Controls.Add(Btn_Comprar_Carrito)
        Panel_Carrito.Controls.Add(lbl_Total_Carrito)
        Panel_Carrito.Controls.Add(lbl_Total_Iva)
        Panel_Carrito.Controls.Add(Label4)
        Panel_Carrito.Controls.Add(Label3)
        Panel_Carrito.Controls.Add(Dgv_Carrito)
        Panel_Carrito.Controls.Add(Label2)
        Panel_Carrito.Dock = DockStyle.Fill
        Panel_Carrito.Location = New Point(0, 24)
        Panel_Carrito.Name = "Panel_Carrito"
        Panel_Carrito.Size = New Size(1034, 654)
        Panel_Carrito.TabIndex = 28
        Panel_Carrito.Visible = False
        ' 
        ' Panel_Ayuda
        ' 
        Panel_Ayuda.Controls.Add(Label6)
        Panel_Ayuda.Controls.Add(Label5)
        Panel_Ayuda.Controls.Add(PictureBox3)
        Panel_Ayuda.Controls.Add(PictureBox4)
        Panel_Ayuda.Dock = DockStyle.Fill
        Panel_Ayuda.Location = New Point(0, 0)
        Panel_Ayuda.Name = "Panel_Ayuda"
        Panel_Ayuda.Size = New Size(1034, 654)
        Panel_Ayuda.TabIndex = 8
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(521, 38)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(318, 81)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 30
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(203, 38)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(318, 81)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 29
        PictureBox4.TabStop = False
        ' 
        ' Btn_Elimiar_Item
        ' 
        Btn_Elimiar_Item.BackColor = Color.Red
        Btn_Elimiar_Item.Font = New Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Elimiar_Item.ForeColor = Color.White
        Btn_Elimiar_Item.Location = New Point(539, 603)
        Btn_Elimiar_Item.Name = "Btn_Elimiar_Item"
        Btn_Elimiar_Item.Size = New Size(226, 39)
        Btn_Elimiar_Item.TabIndex = 7
        Btn_Elimiar_Item.Text = "Eliminar"
        Btn_Elimiar_Item.UseVisualStyleBackColor = False
        ' 
        ' Btn_Comprar_Carrito
        ' 
        Btn_Comprar_Carrito.BackColor = Color.Lime
        Btn_Comprar_Carrito.Font = New Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Comprar_Carrito.ForeColor = Color.White
        Btn_Comprar_Carrito.Location = New Point(772, 603)
        Btn_Comprar_Carrito.Name = "Btn_Comprar_Carrito"
        Btn_Comprar_Carrito.Size = New Size(226, 39)
        Btn_Comprar_Carrito.TabIndex = 6
        Btn_Comprar_Carrito.Text = "Comprar Carrito"
        Btn_Comprar_Carrito.UseVisualStyleBackColor = False
        ' 
        ' lbl_Total_Carrito
        ' 
        lbl_Total_Carrito.AutoSize = True
        lbl_Total_Carrito.Font = New Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_Total_Carrito.ForeColor = Color.Lime
        lbl_Total_Carrito.Location = New Point(172, 607)
        lbl_Total_Carrito.Name = "lbl_Total_Carrito"
        lbl_Total_Carrito.Size = New Size(31, 30)
        lbl_Total_Carrito.TabIndex = 5
        lbl_Total_Carrito.Text = "--"' 
        ' lbl_Total_Iva
        ' 
        lbl_Total_Iva.AutoSize = True
        lbl_Total_Iva.Font = New Font("Segoe UI Historic", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_Total_Iva.ForeColor = Color.Black
        lbl_Total_Iva.Location = New Point(172, 534)
        lbl_Total_Iva.Name = "lbl_Total_Iva"
        lbl_Total_Iva.Size = New Size(29, 30)
        lbl_Total_Iva.TabIndex = 4
        lbl_Total_Iva.Text = "--"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Historic", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(33, 595)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 45)
        Label4.TabIndex = 3
        Label4.Text = "Total:"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Historic", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(33, 534)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 30)
        Label3.TabIndex = 2
        Label3.Text = "Sub total iva:"' 
        ' Dgv_Carrito
        ' 
        Dgv_Carrito.AllowUserToAddRows = False
        Dgv_Carrito.AllowUserToDeleteRows = False
        Dgv_Carrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        Dgv_Carrito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Dgv_Carrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgv_Carrito.Columns.AddRange(New DataGridViewColumn() {Titulo, Genero, Consola, Precio})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        Dgv_Carrito.DefaultCellStyle = DataGridViewCellStyle2
        Dgv_Carrito.Location = New Point(33, 72)
        Dgv_Carrito.Name = "Dgv_Carrito"
        Dgv_Carrito.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        Dgv_Carrito.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Font = New Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Dgv_Carrito.RowsDefaultCellStyle = DataGridViewCellStyle4
        Dgv_Carrito.RowTemplate.Height = 25
        Dgv_Carrito.Size = New Size(965, 434)
        Dgv_Carrito.TabIndex = 1
        ' 
        ' Titulo
        ' 
        Titulo.HeaderText = "Titulo del juego"
        Titulo.Name = "Titulo"
        Titulo.ReadOnly = True
        ' 
        ' Genero
        ' 
        Genero.HeaderText = "Genero del juego"
        Genero.Name = "Genero"
        Genero.ReadOnly = True
        ' 
        ' Consola
        ' 
        Consola.HeaderText = "Consola del juego"
        Consola.Name = "Consola"
        Consola.ReadOnly = True
        ' 
        ' Precio
        ' 
        Precio.HeaderText = "Precio del juego"
        Precio.Name = "Precio"
        Precio.ReadOnly = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(33, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 40)
        Label2.TabIndex = 0
        Label2.Text = "Tu Carrito:"' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI Historic", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(33, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(965, 322)
        Label5.TabIndex = 31
        Label5.Text = resources.GetString("Label5.Text")
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(12, 613)
        Label6.Name = "Label6"
        Label6.Size = New Size(705, 29)
        Label6.TabIndex = 32
        Label6.Text = "Gracias por darle un uso correcto al software: Attm. J. Israel C. Moncada."' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1034, 678)
        Controls.Add(Panel_Carrito)
        Controls.Add(lbl_Creadores)
        Controls.Add(lbl_Bits)
        Controls.Add(Lbl_Año)
        Controls.Add(lbl_Consola)
        Controls.Add(lbl_Genero)
        Controls.Add(lbl_Precio)
        Controls.Add(lbl_Titulo)
        Controls.Add(btn_Agregar_carrito)
        Controls.Add(Btn_Comprar)
        Controls.Add(Lista_Juegos)
        Controls.Add(Label1)
        Controls.Add(lbl_Contador_Carrito)
        Controls.Add(Btn_Pic_Carrito)
        Controls.Add(Pic_Caratula)
        Controls.Add(Btn_Pic_Gba)
        Controls.Add(Btn_Pic_N64)
        Controls.Add(Btn_Pic_Snes)
        Controls.Add(Btn_Pic_Gb)
        Controls.Add(Btn_Pic_Nes)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        CType(Btn_Pic_Nes, ComponentModel.ISupportInitialize).EndInit()
        CType(Btn_Pic_Gb, ComponentModel.ISupportInitialize).EndInit()
        CType(Btn_Pic_Snes, ComponentModel.ISupportInitialize).EndInit()
        CType(Btn_Pic_N64, ComponentModel.ISupportInitialize).EndInit()
        CType(Btn_Pic_Gba, ComponentModel.ISupportInitialize).EndInit()
        CType(Btn_Pic_Carrito, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Pic_Caratula, ComponentModel.ISupportInitialize).EndInit()
        Panel_Carrito.ResumeLayout(False)
        Panel_Carrito.PerformLayout()
        Panel_Ayuda.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(Dgv_Carrito, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Inf_puntero As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarritoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btn_Pic_Nes As PictureBox
    Friend WithEvents Btn_Pic_Gb As PictureBox
    Friend WithEvents Btn_Pic_Snes As PictureBox
    Friend WithEvents Btn_Pic_N64 As PictureBox
    Friend WithEvents Btn_Pic_Gba As PictureBox
    Friend WithEvents Pic_Caratula As PictureBox
    Friend WithEvents Btn_Pic_Carrito As PictureBox
    Friend WithEvents lbl_Contador_Carrito As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lista_Juegos As ListBox
    Friend WithEvents Btn_Comprar As Button
    Friend WithEvents btn_Agregar_carrito As Button
    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_Precio As Label
    Friend WithEvents lbl_Genero As Label
    Friend WithEvents Lbl_Año As Label
    Friend WithEvents lbl_Consola As Label
    Friend WithEvents lbl_Bits As Label
    Friend WithEvents lbl_Creadores As Label
    Friend WithEvents Panel_Carrito As Panel
    Friend WithEvents Dgv_Carrito As DataGridView
    Friend WithEvents Titulo As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents Consola As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_Total_Carrito As Label
    Friend WithEvents lbl_Total_Iva As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Elimiar_Item As Button
    Friend WithEvents Btn_Comprar_Carrito As Button
    Friend WithEvents Panel_Ayuda As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
