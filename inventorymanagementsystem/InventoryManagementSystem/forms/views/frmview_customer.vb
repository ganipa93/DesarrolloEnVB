Public Class frmview_customer

    Private Sub frmview_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT  `SUPLIERCUSTOMERID` as 'CUSTOMERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE  `TYPE` ='Customer'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT  `SUPLIERCUSTOMERID` as 'CUSTOMERID', `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE` FROM `tblperson` WHERE  `TYPE` ='Customer' AND  SUPLIERCUSTOMERID LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try
            frm_transaction.txt_cusid.Text = dtglist.CurrentRow.Cells(0).Value
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class