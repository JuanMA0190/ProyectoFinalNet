''Interacción con bases de datos MySQL.
Imports MySql.Data.MySqlClient
Public Class frm_Login
    ''Clase del formulario Login que se encarga de validadar usuario y contraseña para determinar si puede entrar o no en el programa

    Dim cmd As String ''String (cadena de texto) que se ocupa para las consultas sql.

    ''Variable String que tiene el nombre de la base de datos.
    Dim database As String = "tallerbd"
    ''Variable String que tiene el nombre del usuario de la base de datos.
    Dim user As String = "root"
    ''Variable String que tiene la contraseña del usuario de la base de datos.
    Dim pass As String = "03020106j"
    ''Instancia de la clase DataSet que representa un conjunto completo de datos, incluyendo tablas y relaciones, para poder manipular
    Dim oDataSet As New DataSet

    ''Metodo del evento del boton salir que cierra el formulario actual y el splash, ya que el mismo queda escondido
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Dispose()
        frm_Splash.Dispose()
    End Sub

    ''Metodo del evento del boton Aceptar que valida con la base de datos el usuario y contraseña ingresado en el formulario
    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdAceptar.Click
        ''valida que no se ingresen string vacíos
        If txtUsuario.Text = "" Or txtPass.Text = "" Then
            MsgBox("Hay campos vacíos")
        Else
            Try
                ' Estructura Using: Utilizado para gestionar recursos y garantizar la liberación adecuada de objetos
                ' Crea y utiliza un objeto IDisposable dentro de este bloque, asegurándose de que Dispose se llame automáticamente al salir.
                Using connDB As New MySqlConnection($"Server=localhost;Database={database};Uid={user};Pwd={pass};")
                    ''se abre la conexión con la bd
                    connDB.Open()
                    ''se escribe la consulta a realizar a la bd
                    cmd = "SELECT * FROM usuarios WHERE Usuario=@usuario and Contrasenia=@contrasenia"
                    ''se instancia con la clase MySqlCommand con la consulta y la base de datos como parametro
                    Dim command As New MySqlCommand(cmd, connDB)
                    'Se agragan los valores a la consulta con los respectivos campos
                    command.Parameters.AddWithValue("@usuario", txtUsuario.Text)
                    command.Parameters.AddWithValue("@contrasenia", txtPass.Text)

                    ' Se crea un adaptador de datos MySqlDataAdapter para ejecutar la consulta representada por el objeto MySqlCommand.
                    Dim oDataAdapter As New MySqlDataAdapter(command)

                    'Limpia cualquier contenido en DataSet, se eliminan viejas tablas o relaciones para poder recibir nuevos
                    oDataSet.Clear()
                    ' llena el DataSet con los resultados de la consulta SQL definida en el adaptado
                    oDataAdapter.Fill(oDataSet, "Usuario")

                    'si hay mas de una fila en el DataSet (existe en la bd) significa que el usuario y la contraseña es correcta
                    If (oDataSet.Tables("Usuario").Rows.Count() <> 0) Then
                        'se muestra el formulario principal
                        frm_Principal.Show()
                        'se cierra la base de datos para optimizar funcionamiento
                        Me.Close()
                    Else
                        MessageBox.Show("Usuario y/o contraseña incorrectas", "Sistema")
                        txtUsuario.Text = ""
                        txtPass.Text = ""
                        txtUsuario.Focus()
                    End If
                End Using

            Catch ex As MySqlException
                MsgBox("Error en la base de datos: " & ex.Message, vbCritical, "Error")
            Catch ex As Exception
                MsgBox("Error general: " & ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub
    ' Este evento se activa cuando se presiona una tecla mientras el foco está en el botón cmdAceptar.
    ' Si la tecla presionada es Enter, se simula un clic en el botón cmdAceptar.
    Private Sub cmdAceptar_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cmdAceptar.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = False
            cmdAceptar.PerformClick()
        End If
    End Sub
    ' Este evento se activa cuando se presiona una tecla mientras el foco está en el cuadro de texto txtPass.
    ' Si la tecla presionada es Enter, se simula un clic en el botón cmdAceptar.
    Private Sub txtPass_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = False
            cmdAceptar.PerformClick()
        End If
    End Sub
    'Metodo de evento de cargar form que hace foco en el textfield usuario
    Private Sub frmAcceso_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtUsuario.Focus()
    End Sub
    'Metodo de evento de boton que muestra o no el contenido del textfield contraseña
    Private Sub bttshow_pass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttshow_pass.Click
        If bttshow_pass.Text = "‏‏‎‎ ‍‍‍‍‍‎ " Then
            txtPass.PasswordChar = ""
            bttshow_pass.Text = "‎‍‍‍‍‍‎ ‏‏‎‎ ‏‏‎‎ ‏‏‎‏‏‎‎ ‏‏‎‎ "
        ElseIf bttshow_pass.Text = "‎‍‍‍‍‍‎ ‏‏‎‎ ‏‏‎‎ ‏‏‎‏‏‎‎ ‏‏‎‎ " Then
            txtPass.PasswordChar = "*"
            bttshow_pass.Text = "‏‏‎‎ ‍‍‍‍‍‎ "
        End If
    End Sub
End Class