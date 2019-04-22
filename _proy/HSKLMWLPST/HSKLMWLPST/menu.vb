Public Class menuh

    Private Sub menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub BtnPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPagos.Click
        pagos.Show()
        BtnPagos.Enabled = False
        PagosToolStripMenuItem.Enabled = False

    End Sub

    Private Sub BtnArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArt.Click
        AddArticulos.Show()
        BtnArt.Enabled = False
        ArticulosToolStripMenuItem.Enabled = False
    End Sub

    Private Sub BtnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompras.Click
        Compras.Show()
        BtnCompras.Enabled = False
        ComprasToolStripMenuItem.Enabled = False

    End Sub

    Private Sub BtnAbonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAbonos.Click
        Abonos.Show()
        BtnAbonos.Enabled = False
        AbonosToolStripMenuItem.Enabled = False

    End Sub

    Private Sub BtnProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProv.Click
        AddProveedores.Show()
        BtnProv.Enabled = False
        ProveedorToolStripMenuItem.Enabled = False

    End Sub

    Private Sub BtnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVentas.Click
        Ventas.Show()
        BtnVentas.Enabled = False
        VentasToolStripMenuItem.Enabled = False
    End Sub

    Private Sub BtnClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClient.Click
        FmrAddClientes.Show()
        BtnClient.Enabled = False
        ClientesToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ACercaDeHSKLMWLPSTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACercaDeHSKLMWLPSTToolStripMenuItem.Click
        MessageBox.Show("HSKLMWLPST© es una aplicación diseñada exclusivamente para la materia de Proyecto de base de datos, se prohibe la reproducción total o parcial de la Aplicación sin la autorización del creador...(YoP)", "Derecho de autor y Copyright", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub PagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosToolStripMenuItem.Click
        pagos.Show()
        BtnPagos.Enabled = False
        PagosToolStripMenuItem.Enabled = False

    End Sub

    Private Sub ComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasToolStripMenuItem.Click
        Compras.Show()
        BtnCompras.Enabled = False
        ComprasToolStripMenuItem.Enabled = False

    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem.Click
        AddArticulos.Show()
        BtnArt.Enabled = False
        ArticulosToolStripMenuItem.Enabled = False

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        FmrAddClientes.Show()
        BtnClient.Enabled = False
        ClientesToolStripMenuItem.Enabled = False
    End Sub

    Private Sub AbonosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbonosToolStripMenuItem.Click
        Abonos.Show()
        BtnAbonos.Enabled = False
        AbonosToolStripMenuItem.Enabled = False

    End Sub

    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        Ventas.Show()
        BtnVentas.Enabled = False
        VentasToolStripMenuItem.Enabled = False

    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedorToolStripMenuItem.Click
        AddProveedores.Show()
        BtnProv.Enabled = False
        ProveedorToolStripMenuItem.Enabled = False

    End Sub
End Class