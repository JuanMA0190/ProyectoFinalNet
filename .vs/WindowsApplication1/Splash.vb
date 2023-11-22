Public Class frm_Splash
    Private Sub Timer_Muestra_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Muestra.Tick
        Timer_EfectoCierr.Enabled = True
        Timer_Muestra.Enabled = False
    End Sub
    Private Sub Timer_Efecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Efecto.Tick
        If Me.Opacity < 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Timer_Efecto.Enabled = False
            Timer_Muestra.Enabled = True
        End If
    End Sub

    Private Sub Timer_EfectoCierr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_EfectoCierr.Tick
        If Me.Opacity > 0 Then
            Me.Opacity = Me.Opacity - 0.1
        Else
            Timer_EfectoCierr.Enabled = False
            frm_Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frm_Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 1
    End Sub
End Class