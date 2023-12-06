Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class frm_Login
    Dim con As String
    Dim connDB As New MySqlConnection(con)
    Dim cmd As String
    Dim database As String = "tallerbd"
    Dim user As String = "root"
    Dim pass As String = "03020106j"
    Dim oDataSet As New DataSet
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Dispose()
        frm_Splash.Dispose()
    End Sub
    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdAceptar.Click

        If txtUsuario.Text = "" Or txtPass.Text = "" Then
            MsgBox("Hay campos vacíos")
        Else
            Try
                Using connDB As New MySqlConnection($"Server=localhost;Database={database};Uid={user};Pwd={pass};")
                    connDB.Open()
                    cmd = "SELECT * FROM usuarios WHERE Usuario=@usuario and Contrasenia=@contrasenia"
                    Dim command As New MySqlCommand(cmd, connDB)
                    command.Parameters.AddWithValue("@usuario", txtUsuario.Text)
                    command.Parameters.AddWithValue("@contrasenia", txtPass.Text)
                    Dim oDataAdapter As New MySqlDataAdapter(command)
                    oDataSet.Clear()
                    oDataAdapter.Fill(oDataSet, "Usuario")
                    If (oDataSet.Tables("Usuario").Rows.Count() <> 0) Then
                        frm_Principal.Show()
                        Me.Close()
                    Else
                        MessageBox.Show("Usuario y/o contraseña incorrectas", "Sistema")
                        txtUsuario.Text = ""
                        txtPass.Text = ""
                        txtUsuario.Focus()
                    End If
                End Using

            Catch ea As Exception
                MessageBox.Show("Error: " & ea.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub cmdAceptar_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cmdAceptar.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = False
            cmdAceptar.PerformClick()
        End If
    End Sub
    Private Sub txtPass_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = False
            cmdAceptar.PerformClick()
        End If
    End Sub
    Private Sub frmAcceso_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtUsuario.Focus()
    End Sub

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