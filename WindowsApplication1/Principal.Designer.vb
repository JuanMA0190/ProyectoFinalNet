<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Principal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_Sexo = New System.Windows.Forms.TextBox()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rb_Fem = New System.Windows.Forms.RadioButton()
        Me.rb_Masc = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_estado = New System.Windows.Forms.TextBox()
        Me.tb_direc = New System.Windows.Forms.TextBox()
        Me.btt_Nuevo = New System.Windows.Forms.Button()
        Me.tb_tel = New System.Windows.Forms.TextBox()
        Me.tb_dni = New System.Windows.Forms.TextBox()
        Me.tb_ape = New System.Windows.Forms.TextBox()
        Me.tb_nom = New System.Windows.Forms.TextBox()
        Me.tb_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscaCli = New System.Windows.Forms.TextBox()
        Me.lstView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblHor = New System.Windows.Forms.Label()
        Me.lblFech = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btt_Agregar = New System.Windows.Forms.Button()
        Me.btt_reporte = New System.Windows.Forms.Button()
        Me.btt_Baja = New System.Windows.Forms.Button()
        Me.btt_Alta = New System.Windows.Forms.Button()
        Me.btt_Actualizar = New System.Windows.Forms.Button()
        Me.btt_Eliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_Sexo)
        Me.GroupBox1.Controls.Add(Me.datePicker)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.rb_Fem)
        Me.GroupBox1.Controls.Add(Me.rb_Masc)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tb_estado)
        Me.GroupBox1.Controls.Add(Me.tb_direc)
        Me.GroupBox1.Controls.Add(Me.btt_Nuevo)
        Me.GroupBox1.Controls.Add(Me.tb_tel)
        Me.GroupBox1.Controls.Add(Me.tb_dni)
        Me.GroupBox1.Controls.Add(Me.tb_ape)
        Me.GroupBox1.Controls.Add(Me.tb_nom)
        Me.GroupBox1.Controls.Add(Me.tb_id)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 496)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'tb_Sexo
        '
        Me.tb_Sexo.Enabled = False
        Me.tb_Sexo.Location = New System.Drawing.Point(128, 229)
        Me.tb_Sexo.Name = "tb_Sexo"
        Me.tb_Sexo.Size = New System.Drawing.Size(101, 25)
        Me.tb_Sexo.TabIndex = 20
        '
        'datePicker
        '
        Me.datePicker.Enabled = False
        Me.datePicker.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePicker.Location = New System.Drawing.Point(128, 189)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(100, 25)
        Me.datePicker.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gold
        Me.Label12.Location = New System.Drawing.Point(7, 189)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 22)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Fecha Nac."
        '
        'rb_Fem
        '
        Me.rb_Fem.AutoSize = True
        Me.rb_Fem.Location = New System.Drawing.Point(126, 260)
        Me.rb_Fem.Name = "rb_Fem"
        Me.rb_Fem.Size = New System.Drawing.Size(92, 23)
        Me.rb_Fem.TabIndex = 17
        Me.rb_Fem.TabStop = True
        Me.rb_Fem.Text = "Femenino"
        Me.rb_Fem.UseVisualStyleBackColor = True
        '
        'rb_Masc
        '
        Me.rb_Masc.AutoSize = True
        Me.rb_Masc.Location = New System.Drawing.Point(11, 260)
        Me.rb_Masc.Name = "rb_Masc"
        Me.rb_Masc.Size = New System.Drawing.Size(94, 23)
        Me.rb_Masc.TabIndex = 16
        Me.rb_Masc.TabStop = True
        Me.rb_Masc.Text = "Masculino"
        Me.rb_Masc.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(6, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 22)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Sexo"
        '
        'tb_estado
        '
        Me.tb_estado.Enabled = False
        Me.tb_estado.Location = New System.Drawing.Point(131, 378)
        Me.tb_estado.Name = "tb_estado"
        Me.tb_estado.Size = New System.Drawing.Size(100, 25)
        Me.tb_estado.TabIndex = 13
        '
        'tb_direc
        '
        Me.tb_direc.Enabled = False
        Me.tb_direc.Location = New System.Drawing.Point(131, 336)
        Me.tb_direc.Name = "tb_direc"
        Me.tb_direc.Size = New System.Drawing.Size(100, 25)
        Me.tb_direc.TabIndex = 12
        '
        'btt_Nuevo
        '
        Me.btt_Nuevo.BackColor = System.Drawing.Color.OliveDrab
        Me.btt_Nuevo.ForeColor = System.Drawing.Color.Gold
        Me.btt_Nuevo.Image = CType(resources.GetObject("btt_Nuevo.Image"), System.Drawing.Image)
        Me.btt_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btt_Nuevo.Location = New System.Drawing.Point(68, 409)
        Me.btt_Nuevo.Name = "btt_Nuevo"
        Me.btt_Nuevo.Size = New System.Drawing.Size(85, 85)
        Me.btt_Nuevo.TabIndex = 4
        Me.btt_Nuevo.Text = "Modificar"
        Me.btt_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btt_Nuevo.UseVisualStyleBackColor = False
        '
        'tb_tel
        '
        Me.tb_tel.Enabled = False
        Me.tb_tel.Location = New System.Drawing.Point(131, 292)
        Me.tb_tel.Name = "tb_tel"
        Me.tb_tel.Size = New System.Drawing.Size(100, 25)
        Me.tb_tel.TabIndex = 11
        '
        'tb_dni
        '
        Me.tb_dni.Enabled = False
        Me.tb_dni.Location = New System.Drawing.Point(128, 155)
        Me.tb_dni.Name = "tb_dni"
        Me.tb_dni.Size = New System.Drawing.Size(100, 25)
        Me.tb_dni.TabIndex = 10
        '
        'tb_ape
        '
        Me.tb_ape.Enabled = False
        Me.tb_ape.Location = New System.Drawing.Point(128, 113)
        Me.tb_ape.Name = "tb_ape"
        Me.tb_ape.Size = New System.Drawing.Size(100, 25)
        Me.tb_ape.TabIndex = 9
        '
        'tb_nom
        '
        Me.tb_nom.Enabled = False
        Me.tb_nom.Location = New System.Drawing.Point(128, 71)
        Me.tb_nom.Name = "tb_nom"
        Me.tb_nom.Size = New System.Drawing.Size(100, 25)
        Me.tb_nom.TabIndex = 8
        '
        'tb_id
        '
        Me.tb_id.Enabled = False
        Me.tb_id.Location = New System.Drawing.Point(129, 32)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.Size = New System.Drawing.Size(100, 25)
        Me.tb_id.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(7, 381)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(7, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(6, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nro. Teléfono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(8, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DNI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(10, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'txtBuscaCli
        '
        Me.txtBuscaCli.Location = New System.Drawing.Point(-4, 180)
        Me.txtBuscaCli.Name = "txtBuscaCli"
        Me.txtBuscaCli.Size = New System.Drawing.Size(10, 20)
        Me.txtBuscaCli.TabIndex = 2
        Me.txtBuscaCli.Visible = False
        '
        'lstView
        '
        Me.lstView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader8, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.lstView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstView.HideSelection = False
        Me.lstView.Location = New System.Drawing.Point(260, 191)
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(653, 351)
        Me.lstView.TabIndex = 1
        Me.lstView.Tag = ""
        Me.lstView.UseCompatibleStateImageBehavior = False
        Me.lstView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 35
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Apellido"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DNI"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sexo"
        Me.ColumnHeader8.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fecha Nac."
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Telefono"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 75
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Dirección"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Estado"
        Me.ColumnHeader14.Width = 80
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Fecha Reg."
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 80
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Hora Reg"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader16.Width = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(526, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 42)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "COMPRA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(512, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 42)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "SUPERIOR"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(591, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 31)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "s.r.l"
        '
        'lblHor
        '
        Me.lblHor.AutoSize = True
        Me.lblHor.Location = New System.Drawing.Point(755, 636)
        Me.lblHor.Name = "lblHor"
        Me.lblHor.Size = New System.Drawing.Size(0, 13)
        Me.lblHor.TabIndex = 14
        Me.lblHor.Visible = False
        '
        'lblFech
        '
        Me.lblFech.AutoSize = True
        Me.lblFech.Location = New System.Drawing.Point(755, 654)
        Me.lblFech.Name = "lblFech"
        Me.lblFech.Size = New System.Drawing.Size(0, 13)
        Me.lblFech.TabIndex = 15
        Me.lblFech.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btt_Agregar
        '
        Me.btt_Agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btt_Agregar.BackColor = System.Drawing.Color.OliveDrab
        Me.btt_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btt_Agregar.Enabled = False
        Me.btt_Agregar.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt_Agregar.ForeColor = System.Drawing.Color.Gold
        Me.btt_Agregar.Image = CType(resources.GetObject("btt_Agregar.Image"), System.Drawing.Image)
        Me.btt_Agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btt_Agregar.Location = New System.Drawing.Point(382, 574)
        Me.btt_Agregar.Name = "btt_Agregar"
        Me.btt_Agregar.Size = New System.Drawing.Size(83, 72)
        Me.btt_Agregar.TabIndex = 14
        Me.btt_Agregar.Text = "Agregar"
        Me.btt_Agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btt_Agregar.UseVisualStyleBackColor = False
        '
        'btt_reporte
        '
        Me.btt_reporte.BackColor = System.Drawing.Color.OliveDrab
        Me.btt_reporte.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt_reporte.ForeColor = System.Drawing.Color.Gold
        Me.btt_reporte.Image = CType(resources.GetObject("btt_reporte.Image"), System.Drawing.Image)
        Me.btt_reporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btt_reporte.Location = New System.Drawing.Point(747, 574)
        Me.btt_reporte.Name = "btt_reporte"
        Me.btt_reporte.Size = New System.Drawing.Size(94, 75)
        Me.btt_reporte.TabIndex = 8
        Me.btt_reporte.Text = "Reporte"
        Me.btt_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btt_reporte.UseVisualStyleBackColor = False
        '
        'btt_Baja
        '
        Me.btt_Baja.BackColor = System.Drawing.Color.OliveDrab
        Me.btt_Baja.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt_Baja.ForeColor = System.Drawing.Color.Gold
        Me.btt_Baja.Image = CType(resources.GetObject("btt_Baja.Image"), System.Drawing.Image)
        Me.btt_Baja.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btt_Baja.Location = New System.Drawing.Point(659, 574)
        Me.btt_Baja.Name = "btt_Baja"
        Me.btt_Baja.Size = New System.Drawing.Size(74, 72)
        Me.btt_Baja.TabIndex = 7
        Me.btt_Baja.Text = "Baja"
        Me.btt_Baja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btt_Baja.UseVisualStyleBackColor = False
        '
        'btt_Alta
        '
        Me.btt_Alta.BackColor = System.Drawing.Color.OliveDrab
        Me.btt_Alta.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt_Alta.ForeColor = System.Drawing.Color.Gold
        Me.btt_Alta.Image = CType(resources.GetObject("btt_Alta.Image"), System.Drawing.Image)
        Me.btt_Alta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btt_Alta.Location = New System.Drawing.Point(569, 574)
        Me.btt_Alta.Name = "btt_Alta"
        Me.btt_Alta.Size = New System.Drawing.Size(75, 72)
        Me.btt_Alta.TabIndex = 6
        Me.btt_Alta.Text = "Alta"
        Me.btt_Alta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btt_Alta.UseVisualStyleBackColor = False
        '
        'btt_Actualizar
        '
        Me.btt_Actualizar.BackColor = System.Drawing.Color.OliveDrab
        Me.btt_Actualizar.Enabled = False
        Me.btt_Actualizar.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt_Actualizar.ForeColor = System.Drawing.Color.Gold
        Me.btt_Actualizar.Image = CType(resources.GetObject("btt_Actualizar.Image"), System.Drawing.Image)
        Me.btt_Actualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btt_Actualizar.Location = New System.Drawing.Point(275, 574)
        Me.btt_Actualizar.Name = "btt_Actualizar"
        Me.btt_Actualizar.Size = New System.Drawing.Size(87, 72)
        Me.btt_Actualizar.TabIndex = 5
        Me.btt_Actualizar.Text = "Actualizar"
        Me.btt_Actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btt_Actualizar.UseVisualStyleBackColor = False
        '
        'btt_Eliminar
        '
        Me.btt_Eliminar.BackColor = System.Drawing.Color.OliveDrab
        Me.btt_Eliminar.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt_Eliminar.ForeColor = System.Drawing.Color.Gold
        Me.btt_Eliminar.Image = CType(resources.GetObject("btt_Eliminar.Image"), System.Drawing.Image)
        Me.btt_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btt_Eliminar.Location = New System.Drawing.Point(481, 574)
        Me.btt_Eliminar.Name = "btt_Eliminar"
        Me.btt_Eliminar.Size = New System.Drawing.Size(82, 72)
        Me.btt_Eliminar.TabIndex = 4
        Me.btt_Eliminar.Text = "Eliminar"
        Me.btt_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btt_Eliminar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OliveDrab
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(847, 600)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 87)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(917, 699)
        Me.Controls.Add(Me.lblFech)
        Me.Controls.Add(Me.lblHor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btt_Agregar)
        Me.Controls.Add(Me.btt_reporte)
        Me.Controls.Add(Me.btt_Baja)
        Me.Controls.Add(Me.btt_Alta)
        Me.Controls.Add(Me.btt_Actualizar)
        Me.Controls.Add(Me.btt_Eliminar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBuscaCli)
        Me.Controls.Add(Me.lstView)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_estado As System.Windows.Forms.TextBox
    Friend WithEvents tb_direc As System.Windows.Forms.TextBox
    Friend WithEvents tb_tel As System.Windows.Forms.TextBox
    Friend WithEvents tb_dni As System.Windows.Forms.TextBox
    Friend WithEvents tb_ape As System.Windows.Forms.TextBox
    Friend WithEvents tb_nom As System.Windows.Forms.TextBox
    Friend WithEvents tb_id As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtBuscaCli As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btt_Nuevo As System.Windows.Forms.Button
    Friend WithEvents btt_Agregar As System.Windows.Forms.Button
    Friend WithEvents btt_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btt_Actualizar As System.Windows.Forms.Button
    Friend WithEvents btt_Alta As System.Windows.Forms.Button
    Friend WithEvents btt_Baja As System.Windows.Forms.Button
    Friend WithEvents btt_reporte As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblHor As System.Windows.Forms.Label
    Friend WithEvents lblFech As System.Windows.Forms.Label
    Friend WithEvents rb_Masc As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Fem As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents datePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_Sexo As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
End Class
