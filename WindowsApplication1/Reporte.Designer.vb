<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Reporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Reporte))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.lstView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btt_Salir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.OliveDrab
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.Gold
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint.Location = New System.Drawing.Point(415, 424)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(171, 152)
        Me.cmdPrint.TabIndex = 0
        Me.cmdPrint.Text = "Imprimir PDF"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'lstView
        '
        Me.lstView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17})
        Me.lstView.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstView.Location = New System.Drawing.Point(23, 24)
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(847, 394)
        Me.lstView.TabIndex = 2
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
        Me.ColumnHeader4.Width = 85
        '
        'btt_Salir
        '
        Me.btt_Salir.BackColor = System.Drawing.Color.OliveDrab
        Me.btt_Salir.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt_Salir.ForeColor = System.Drawing.Color.Gold
        Me.btt_Salir.Image = CType(resources.GetObject("btt_Salir.Image"), System.Drawing.Image)
        Me.btt_Salir.Location = New System.Drawing.Point(786, 496)
        Me.btt_Salir.Name = "btt_Salir"
        Me.btt_Salir.Size = New System.Drawing.Size(67, 80)
        Me.btt_Salir.TabIndex = 3
        Me.btt_Salir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 424)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sexo"
        Me.ColumnHeader5.Width = 70
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Fecha Nac."
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Telefono"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 75
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Direccion"
        Me.ColumnHeader14.Width = 100
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Estado"
        Me.ColumnHeader15.Width = 80
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Fecha Reg."
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader16.Width = 80
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Hora Reg."
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader17.Width = 80
        '
        'frm_Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(882, 588)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btt_Salir)
        Me.Controls.Add(Me.lstView)
        Me.Controls.Add(Me.cmdPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents lstView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btt_Salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
End Class
