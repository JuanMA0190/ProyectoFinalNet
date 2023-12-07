Public Class frm_Splash
    ''Formulario que se encarga de la presentación del programa

    ''Metodo  se ejecutará cada vez que el temporizador (timer) asociado alcance su intervalo predefinido y active el evento Tick.
    Private Sub Timer_Muestra_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Muestra.Tick
        Timer_EfectoCierr.Enabled = True
        Timer_Muestra.Enabled = False
    End Sub

    '' Este método maneja el evento Tick del temporizador (Timer_Efecto).
    Private Sub Timer_Efecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Efecto.Tick
        If Me.Opacity < 1 Then
            '' Incrementa gradualmente la opacidad de la ventana hasta que alcanza el valor 1.
            Me.Opacity = Me.Opacity + 0.1
        Else
            '' Cuando la opacidad llega a 1, desactiva Timer_Efecto y activa Timer_Muestra.
            Timer_Efecto.Enabled = False
            Timer_Muestra.Enabled = True
        End If
    End Sub

    '' Este método maneja el evento Tick del temporizador
    Private Sub Timer_EfectoCierr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_EfectoCierr.Tick
        If Me.Opacity > 0 Then
            '' Reduce gradualmente la opacidad de la ventana hasta que alcanza el valor 0.
            Me.Opacity = Me.Opacity - 0.1
        Else
            '' muestra el formulario de inicio de sesión (frm_Login) y oculta la ventana actual.
            Timer_EfectoCierr.Enabled = False
            frm_Login.Show()
            Me.Hide()
        End If
    End Sub
    '' Este método se ejecuta cuando se carga el formulario (frm_Splash).
    '' Establece la opacidad del formulario en 1 al cargar para asegurar que sea completamente visible.
    Private Sub frm_Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 1
    End Sub
End Class