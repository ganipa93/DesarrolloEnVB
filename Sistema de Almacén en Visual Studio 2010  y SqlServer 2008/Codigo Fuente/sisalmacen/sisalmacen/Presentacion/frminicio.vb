Imports System.Windows.Forms

Public Class frminicio

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub


    Private m_ChildFormNumber As Integer

    Private Sub EquiposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquiposToolStripMenuItem.Click
        frmequipo.MdiParent = Me
        frmequipo.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        frmcliente2.MdiParent = Me
        frmcliente2.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmusuario.MdiParent = Me
        frmusuario.Show()
    End Sub
End Class
