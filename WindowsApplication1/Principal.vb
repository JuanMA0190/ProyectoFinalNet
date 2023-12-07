Imports System.ComponentModel.Design
Imports MySql.Data.MySqlClient
Public Class frm_Principal
    ''Formulario principal que gestiona el CRUD de los clientes
    Dim cmd As String
    Dim database As String = "tallerbd"
    Dim user As String = "root"
    Dim pass As String = "03020106j"
    ''Metodo del evento de cargar formulario para cargar el list view trayendo las tablas de la bd
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Using connDB As New MySqlConnection($"Server=localhost;Database={database};Uid={user};Pwd={pass};")
                connDB.Open()
                cmd = "SELECT * FROM Clientes ORDER BY id_Clientes ASC"
                Dim oDataAdapter As New MySqlDataAdapter(cmd, connDB)
                Dim oDataSet As New DataSet
                oDataSet.Clear()
                oDataAdapter.Fill(oDataSet, "Clientes")
                If (oDataSet.Tables("Clientes").Rows.Count() <> 0) Then
                    Dim i As Integer
                    For i = 0 To oDataSet.Tables("Clientes").Rows.Count - 1
                        lstView.Items.Add(oDataSet.Tables("Clientes").Rows(i)("Id_Clientes"))
                        lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Nomb_Cli"))
                        lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Ape_Cli"))
                        lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Dni_Cli"))
                        lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Sexo_Cli"))
                        lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("FechaNac_Cli"))
                        lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Tel_Cli"))
                        lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Direcc_Cli"))
                        lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("Estado_Cli"))
                        lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("FechaReg_Cli"))
                        lstView.Items(i).SubItems.Add(oDataSet.Tables("Clientes").Rows(i)("HoraReg_Cli"))
                    Next
                Else
                    MsgBox("No se pudo acumular")
                End If
            End Using

        Catch ex As MySqlException
            MsgBox("Error en la base de datos: " & ex.Message, vbCritical, "Error")
        Catch ex As Exception
            MsgBox("Error general: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    ''Metodo del evento click listview para traer un cliente y rellenar los campos del formulario
    Private Sub lstview_selectedindexchanged(ByVal sender As Object, ByVal e As EventArgs) Handles lstView.SelectedIndexChanged
        If lstView.SelectedItems.Count > 0 Then
            Dim selectedClientId As String = lstView.SelectedItems(0).Text

            Try
                Using connDB As New MySqlConnection($"Server=localhost;Database={database};Uid={user};Pwd={pass};")
                    connDB.Open()
                    cmd = "SELECT * FROM Clientes WHERE id_Clientes = @clientId"
                    Dim command As New MySqlCommand(cmd, connDB)
                    command.Parameters.AddWithValue("@clientId", selectedClientId)

                    Dim oDataAdapter As New MySqlDataAdapter(command)
                    Dim oDataSet As New DataSet
                    oDataSet.Clear()
                    oDataAdapter.Fill(oDataSet, "Clientes")

                    If oDataSet.Tables("Clientes").Rows.Count > 0 Then
                        Dim selectedClientRow As DataRow = oDataSet.Tables("Clientes").Rows(0)

                        tb_id.Text = selectedClientRow("Id_Clientes").ToString()
                        tb_nom.Text = selectedClientRow("Nomb_Cli").ToString()
                        tb_ape.Text = selectedClientRow("Ape_Cli").ToString()
                        tb_dni.Text = selectedClientRow("Dni_Cli").ToString()
                        If selectedClientRow("Sexo_Cli").ToString.Equals("Masculino") Then
                            Me.rb_Masc.Checked = True
                        ElseIf selectedClientRow("Sexo_Cli").ToString.Equals("Femenino") Then
                            Me.rb_Fem.Checked = True
                        End If
                        datePicker.Value = Convert.ToDateTime(selectedClientRow("FechaNac_Cli"))
                        tb_tel.Text = selectedClientRow("Tel_Cli").ToString()
                        tb_direc.Text = selectedClientRow("Direcc_Cli").ToString()
                        tb_estado.Text = selectedClientRow("Estado_Cli").ToString()
                    End If
                End Using
            Catch ex As MySqlException
                MsgBox("Error en la base de datos: " & ex.Message, vbCritical, "Error")
            Catch ex As Exception
                MsgBox("Error general: " & ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub
    ''Metodo del evento de boton para cerrar este formulario al clickear
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        frm_Login.Dispose()
        frm_Splash.Dispose()
    End Sub

    ''Metodo del evento de boton Nuevo que cambia segun su estado
    Private Sub btt_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btt_Nuevo.Click

        If btt_Nuevo.Text = "Modificar" Then
            btt_Nuevo.Text = "Cancelar"
            ''cambia la imagen a "cancelar" si esta en estado "modificar"
            btt_Nuevo.Image = My.Resources.Cancel__1_
            tb_nom.Enabled = True
            tb_ape.Enabled = True
            tb_dni.Enabled = True
            tb_tel.Enabled = True
            tb_direc.Enabled = True
            btt_Agregar.Enabled = True
            btt_Actualizar.Enabled = True
            datePicker.Enabled = True

            btt_Eliminar.Enabled = False
            btt_Alta.Enabled = False
            btt_Baja.Enabled = False
            btt_reporte.Enabled = False
        Else
            If btt_Nuevo.Text = "Cancelar" Then
                btt_Nuevo.Text = "Modificar"
                ''cambia la imagen a "modificar" si esta en estado "cancelar"
                btt_Nuevo.Image = My.Resources._mod
                tb_nom.Enabled = False
                tb_ape.Enabled = False
                tb_dni.Enabled = False
                tb_tel.Enabled = False
                tb_direc.Enabled = False
                btt_Agregar.Enabled = False
                btt_Actualizar.Enabled = False
                datePicker.Enabled = False

                btt_Eliminar.Enabled = True
                btt_Alta.Enabled = True
                btt_Baja.Enabled = True
                btt_reporte.Enabled = True
                Call borrar()
            End If
        End If
    End Sub
    '''Metodo del evento que restablece todos los campos del formulario
    Private Sub borrar()
        tb_id.Clear()
        tb_nom.Clear()
        tb_ape.Clear()
        tb_dni.Clear()
        rb_Masc.Checked = False
        rb_Fem.Checked = False
        tb_tel.Clear()
        tb_direc.Clear()
        tb_estado.Clear()
    End Sub

    '''Metodo del evento del elemento boton que agrega un nuevo cliente si esta todo correcto
    Private Sub btt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btt_Agregar.Click
        ''Verifica si todos los campos estan llenos y por lo menos un genero seleccionado
        If tb_nom.Text <> "" And tb_ape.Text <> "" And tb_dni.Text <> "" And tb_direc.Text <> "" And tb_tel.Text <> "" And (rb_Masc.Checked Or rb_Fem.Checked) Then
            ''Verifica antes de cargar el usuario si ya no esta registrado por el dni
            If Not registrado(tb_dni.Text) Then
                Try
                    Using connDB As New MySqlConnection($"Server=localhost;Database={database};Uid={user};Pwd={pass};")
                        connDB.Open()

                        ' Verificar la edad (mayor de 18 años)
                        Dim fechaNacimiento As Date = datePicker.Value
                        Dim edad As Integer = DateTime.Now.Year - fechaNacimiento.Year

                        If DateTime.Now < fechaNacimiento.AddYears(edad) Then
                            MsgBox("Fecha no válida.")
                            Return
                        ElseIf edad < 18 Then
                            MsgBox("El cliente debe tener al menos 18 años.")
                            Return
                        End If

                        ' Crear el comando SQL con parámetros
                        cmd = "INSERT INTO Clientes (Nomb_Cli, Ape_Cli, Dni_Cli, Sexo_Cli, FechaNac_Cli, Tel_Cli, Direcc_Cli, Estado_Cli, FechaReg_Cli, HoraReg_Cli) VALUES (@Nombre, @Apellido, @DNI, @Sexo, @FechaNac, @Telefono, @Direccion, 'Activo', @FechaReg, @HoraReg)"
                        Dim command As New MySqlCommand(cmd, connDB)
                        command.Parameters.AddWithValue("@Nombre", tb_nom.Text)
                        command.Parameters.AddWithValue("@Apellido", tb_ape.Text)
                        command.Parameters.AddWithValue("@DNI", tb_dni.Text)
                        If Me.rb_Masc.Checked Then
                            command.Parameters.AddWithValue("@Sexo", "Masculino")
                        ElseIf Me.rb_Fem.Checked Then
                            command.Parameters.AddWithValue("@Sexo", "Femenino")
                        End If
                        command.Parameters.AddWithValue("@FechaNac", fechaNacimiento.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@Telefono", tb_tel.Text)
                        command.Parameters.AddWithValue("@Direccion", tb_direc.Text)
                        command.Parameters.AddWithValue("@FechaReg", Date.Now.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@HoraReg", Date.Now.ToString("HH:mm:ss"))

                        ' Ejecutar el comando
                        command.ExecuteNonQuery()
                        connDB.Close()

                        MsgBox("El cliente se registró correctamente.", vbInformation)
                        lstView.Items.Clear()
                        ''Se llama a la carga del formulario para actualizar los datos
                        Call Form3_Load(sender, e)
                        btt_Nuevo_Click(sender, e)
                    End Using
                Catch ex As MySqlException
                    MsgBox("Error en la base de datos: " & ex.Message, vbCritical, "Error")
                    Call borrar()
                Catch ex As Exception
                    MsgBox("Error general: " & ex.Message, vbCritical, "Error")
                    Call borrar()
                End Try
            Else
                MsgBox("No se pudo agregar el cliente. DNI ya registrado", vbCritical, "ERROR")
            End If
        Else
            MsgBox("Rellene todos los campos para continuar.", vbCritical, "Error")
        End If

    End Sub
    '''Metodo del evento del elemento boton que elimina un cliente seleccionado
    Private Sub btt_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btt_Eliminar.Click
        If lstView.SelectedItems.Count > 0 Then
            Dim selectedClientId As String = lstView.SelectedItems(0).Text

            Try
                Using connDB As New MySqlConnection($"Server=localhost;Database={database};Uid={user};Pwd={pass};")
                    connDB.Open()
                    cmd = "DELETE FROM Clientes WHERE id_Clientes = @clientId"
                    Dim command As New MySqlCommand(cmd, connDB)
                    command.Parameters.AddWithValue("@clientId", selectedClientId)
                    command.ExecuteNonQuery()
                    connDB.Close()


                    MsgBox("El cliente ha sido eliminado", vbInformation)
                    lstView.Items.Clear()
                    ''Se llama a la carga del formulario para actualizar los dat
                    Call Form3_Load(sender, e)
                    ''se llama al metodo borrar para limpiar los campos
                    Call borrar()
                End Using
            Catch ex As MySqlException
                MsgBox("Error en la base de datos: " & ex.Message, vbCritical, "Error")
            Catch ex As Exception
                MsgBox("Error general: " & ex.Message, vbCritical, "Error")
            End Try

        Else
            MsgBox("Seleccione un cliente en la lista para continuar", vbCritical, "Error")
        End If
    End Sub
    '''Metodo del evento del elemento boton que actualiza los datos de un cliente seleccionado siempre y cuando no se agregue un DNI ya ingresado
    Private Sub btt_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btt_Actualizar.Click
        If tb_nom.Text <> "" And tb_ape.Text <> "" And tb_dni.Text <> "" And tb_direc.Text <> "" And tb_tel.Text <> "" And lstView.SelectedItems.Count > 0 Then
            If Not registrado(Integer.Parse(tb_dni.Text), Integer.Parse(tb_id.Text) Or tb_dni.Text <> "") Then
                Dim selectedClientId As String = lstView.SelectedItems(0).Text
                Try
                    Using connDB As New MySqlConnection($"Server=localhost;Database={database};Uid={user};Pwd={pass};")
                        connDB.Open()

                        ' Verificación de la edad
                        Dim fechaNacimiento As DateTime = datePicker.Value
                        Dim edad As Integer = DateTime.Now.Year - fechaNacimiento.Year
                        If DateTime.Now < fechaNacimiento.AddYears(edad) Then
                            edad -= 1
                        End If

                        If edad < 18 Then
                            MsgBox("El cliente debe ser mayor de 18 años.", vbCritical, "Error")
                            Return
                        End If

                        ' Actualización de la base de datos
                        cmd = "UPDATE Clientes SET Nomb_Cli=@Nombre, Ape_Cli=@Apellido, Dni_Cli=@Dni, Sexo_Cli=@Sexo, FechaNac_Cli=@FechaNacimiento, Tel_Cli=@Telefono, Direcc_Cli=@Direccion WHERE Id_Clientes=@ClienteId"
                        Dim command As New MySqlCommand(cmd, connDB)
                        command.Parameters.AddWithValue("@Nombre", tb_nom.Text)
                        command.Parameters.AddWithValue("@Apellido", tb_ape.Text)
                        command.Parameters.AddWithValue("@Dni", tb_dni.Text)
                        If Me.rb_Masc.Checked Then
                            command.Parameters.AddWithValue("@Sexo", "Masculino")
                        ElseIf Me.rb_Fem.Checked Then
                            command.Parameters.AddWithValue("@Sexo", "Femenino")
                        End If
                        command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento)
                        command.Parameters.AddWithValue("@Telefono", tb_tel.Text)
                        command.Parameters.AddWithValue("@Direccion", tb_direc.Text)


                        command.Parameters.AddWithValue("@ClienteId", selectedClientId)

                        command.ExecuteNonQuery()
                        connDB.Close()

                        MsgBox("Los datos del cliente se actualizaron correctamente.", vbInformation)
                        lstView.Items.Clear()
                        Call Form3_Load(sender, e)
                        btt_Nuevo_Click(sender, e)
                    End Using

                Catch ex As MySqlException
                    MsgBox("Error en la base de datos: " & ex.Message, vbCritical, "Error")
                Catch ex As Exception
                    MsgBox("Error general: " & ex.Message, vbCritical, "Error")
                End Try
            Else
                MsgBox("Se intento actualizar el DNI con un valor ya registrado", vbCritical, "Error")
            End If
        Else
            MsgBox("Rellene todos los campos para continuar", vbCritical, "Error")
        End If
    End Sub
    '''Metodo del evento del elemento boton que actualiza el estado del cliente con respecto a las cuotas y su continuidad de alta
    Private Sub btt_Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btt_Alta.Click
        If lstView.SelectedItems.Count > 0 Then
            Dim selectedClientId As String = lstView.SelectedItems(0).Text
            If tb_estado.Text = "Inactivo" Then
                Try
                    Using connDB As New MySqlConnection($"Server=localhost;Database={database};Uid={user};Pwd={pass};")
                        connDB.Open()

                        cmd = "UPDATE Clientes SET Estado_Cli='Activo' WHERE Id_Clientes=@ClienteId"
                        Dim command As New MySqlCommand(cmd, connDB)
                        command.Parameters.AddWithValue("@ClienteId", selectedClientId)

                        command.ExecuteNonQuery()
                        connDB.Close()

                        MsgBox("Se le dio el alta al cliente seleccionado.", vbInformation)
                        lstView.Items.Clear()
                        Call Form3_Load(sender, e)

                    End Using
                Catch ex As MySqlException
                    MsgBox("Error en la base de datos: " & ex.Message, vbCritical, "Error")
                Catch ex As Exception
                    MsgBox("Error general: " & ex.Message, vbCritical, "Error")
                End Try

            Else
                MsgBox("El Cliente ya esta Activo", vbCritical, "Error")
            End If
        Else
            MsgBox("Seleccione un cliente en la lista para continuar", vbCritical, "Error")
        End If
    End Sub
    '''Metodo del evento del elemento boton que actualiza el estado del cliente con respecto a las cuotas y su continuidad de baja
    Private Sub btt_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btt_Baja.Click
        If lstView.SelectedItems.Count > 0 Then
            Dim selectedClientId As String = lstView.SelectedItems(0).Text
            If tb_estado.Text = "Activo" Then
                Try
                    Using connDB As New MySqlConnection($"Server=localhost;Database={database};Uid={user};Pwd={pass};")
                        connDB.Open()

                        cmd = "UPDATE Clientes SET Estado_Cli='Inactivo' WHERE Id_Clientes=@ClienteId"
                        Dim command As New MySqlCommand(cmd, connDB)
                        command.Parameters.AddWithValue("@ClienteId", selectedClientId)

                        command.ExecuteNonQuery()
                        connDB.Close()

                        MsgBox("Se le dio la baja al cliente seleccionado.", vbInformation)
                        lstView.Items.Clear()
                        Call Form3_Load(sender, e)

                    End Using
                Catch ex As MySqlException
                    MsgBox("Error en la base de datos: " & ex.Message, vbCritical, "Error")
                Catch ex As Exception
                    MsgBox("Error general: " & ex.Message, vbCritical, "Error")
                End Try

            Else
                MsgBox("El Cliente ya esta Inactivo", vbCritical, "Error")
            End If
        Else
            MsgBox("Seleccione un cliente en la lista para continuar", vbCritical, "Error")
        End If
    End Sub
    '''Metodo del evento del elemento boton que esconde este formulario y abre un nuevo formulario, en este caso, Reporte
    Private Sub btt_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btt_reporte.Click
        frm_Reporte.Show()
        Me.Hide()
    End Sub
    ''Funcio que evalua por dni y opcional por id si el cliente que se ingreso no coincide con uno ya ingresado
    ''Devuelve un booleano
    ''Solo se necesita el dni cuando se crea un nuevo cliente y cuando se actualiza se pasa por parametro el dni y el id del cliente
    Function registrado(ByVal dni As Integer, Optional ByVal clienteId As Integer = -1) As Boolean
        Dim flag As Boolean = False
        Try
            Using connDB As New MySqlConnection($"Server=localhost;Database={database};Uid={user};Pwd={pass};")
                connDB.Open()

                ' Construir la consulta SQL básica
                cmd = "SELECT * FROM Clientes WHERE Dni_Cli = @clientDni"

                ' Agregar condición adicional para excluir el cliente actualmente seleccionado (si se proporciona)
                If clienteId <> -1 Then
                    cmd &= " AND Id_Clientes <> @clienteId"
                End If

                Dim command As New MySqlCommand(cmd, connDB)
                command.Parameters.AddWithValue("@clientDni", dni)

                ' Agregar parámetro de clienteId solo si se proporciona
                If clienteId <> -1 Then
                    command.Parameters.AddWithValue("@clienteId", clienteId)
                End If

                Dim oDataAdapter As New MySqlDataAdapter(command)
                Dim oDataSet As New DataSet
                oDataSet.Clear()
                oDataAdapter.Fill(oDataSet, "Clientes")

                If oDataSet.Tables("Clientes").Rows.Count() <> 0 Then
                    flag = True
                Else
                    flag = False
                End If
            End Using
        Catch ea As Exception
            MsgBox("Error. Contacte al servicio técnico.", vbCritical, "Error")
        End Try
        Return flag
    End Function
    ''Metodo que valida que en el texfield que se le asigna el evento solo se ingresen numeros
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se permiten números en este campo.", vbExclamation, "Ingreso texto")
        End If
    End Sub
    ''Metodo que valida que en el texfield que se le asigna el evento solo se ingresen letras
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se permiten letras en este campo.", vbExclamation, "Ingreso números")
        End If
    End Sub
    ''Se asigna los metodos a los correspondientes Text Field -----------------------------------------------------------------------------
    Private Sub tb_nom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_nom.KeyPress
        Call SoloLetras(e)
    End Sub

    Private Sub tb_ape_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_ape.KeyPress
        Call SoloLetras(e)
    End Sub

    Private Sub tb_dni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_dni.KeyPress
        Call SoloNumeros(e)
    End Sub

    Private Sub tb_tel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_tel.KeyPress
        Call SoloNumeros(e)
    End Sub
    ''-----------------------------------------------------------------------------------------------------------------------------------
End Class