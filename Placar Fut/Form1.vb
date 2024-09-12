Imports System.Reflection.Emit

Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbCasa.SelectedIndexChanged
        If cbbCasa.Text = "Al Mossar" Then
            ptbCasa.Image = My.Resources.Al_Mossar
        End If
        If cbbCasa.Text = "Meia Boca Juniors" Then
            ptbCasa.Image = My.Resources.Meia_Boca_Juniors
        End If
        If cbbCasa.Text = "Patético de Madrid" Then
            ptbCasa.Image = My.Resources.Patetico_Madrid
        End If
        If cbbCasa.Text = "Shaktar dos Leks" Then
            ptbCasa.Image = My.Resources.Shaktar_dos_Leks
        End If
        If cbbCasa.Text = "" Then
            ptbCasa.Image = Nothing
        End If
        If cbbCasa.Text <> "" And cbbVisitante.Text <> "" Then
            btnComecar.Enabled = True
        Else
            btnComecar.Enabled = False
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbVisitante.SelectedIndexChanged
        If cbbVisitante.Text = "Al Mossar" Then
            ptbVisitante.Image = My.Resources.Al_Mossar
        End If
        If cbbVisitante.Text = "Meia Boca Juniors" Then
            ptbVisitante.Image = My.Resources.Meia_Boca_Juniors
        End If
        If cbbVisitante.Text = "Patético de Madrid" Then
            ptbVisitante.Image = My.Resources.Patetico_Madrid
        End If
        If cbbVisitante.Text = "Shaktar dos Leks" Then
            ptbVisitante.Image = My.Resources.Shaktar_dos_Leks
        End If
        If cbbVisitante.Text = "" Then
            ptbVisitante.Image = Nothing
        End If
        If cbbCasa.Text <> "" And cbbVisitante.Text <> "" Then
            btnComecar.Enabled = True
        Else
            btnComecar.Enabled = False
        End If

    End Sub

    Private Sub btnComecar_Click(sender As Object, e As EventArgs) Handles btnComecar.Click
        'habilita os botões de gol
        btnCasa.Enabled = True
        btnVisitante.Enabled = True

        'zera placar e tempo
        lblCasa.Text = "0"
        lblVisitante.Text = "0"
        lblMinutos.Text = "0"
        pgbTempo.Value = 0

        'desabilita escolha dos clubes
        cbbCasa.Enabled = False
        cbbVisitante.Enabled = False

        For cont As Integer = 1 To 90
            lblMinutos.Text = lblMinutos.Text * 1 + 1
            lblMinutos.Refresh()
            System.Threading.Thread.Sleep(200)
            pgbTempo.Increment(1)
            Application.DoEvents()
        Next

        If Val(lblCasa.Text) > Val(lblVisitante.Text) Then
            MsgBox(cbbCasa.Text + " venceu por " + lblCasa.Text + " X " + lblVisitante.Text)
        Else
            If Val(lblVisitante.Text) > Val(lblCasa.Text) Then
                MsgBox(cbbVisitante.Text + " venceu por " + lblVisitante.Text + " X " + lblCasa.Text)
            Else
                MsgBox("O jogo empatou em " + lblCasa.Text + " X " + lblVisitante.Text)
            End If
        End If

        btnCasa.Enabled = False
        btnVisitante.Enabled = False
        btnComecar.Enabled = False
        cbbCasa.Enabled = True
        cbbVisitante.Enabled = True
        cbbCasa.Text = ""
        cbbVisitante.Text = ""
        lblMinutos.Text = "0"
        pgbTempo.Value = 0
        lblCasa.Text = "0"
        lblVisitante.Text = "0"
    End Sub

    Private Sub btnCasa_Click(sender As Object, e As EventArgs) Handles btnCasa.Click
        lblCasa.Text = lblCasa.Text * 1 + 1
    End Sub

    Private Sub btnVisitante_Click(sender As Object, e As EventArgs) Handles btnVisitante.Click
        lblVisitante.Text = lblVisitante.Text * 1 + 1

    End Sub
End Class
