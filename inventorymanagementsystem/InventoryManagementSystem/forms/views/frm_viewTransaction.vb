Public Class frm_viewTransaction
    Private Sub frm_viewTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = " SELECT `TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `FIRSTNAME`, `LASTNAME`  FROM `tbltransaction` t,`tblperson` c WHERE  c.`SUPLIERCUSTOMERID`=t.`SUPLIERCUSTOMERID` AND t.TYPE ='StockOut'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = " SELECT `TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `FIRSTNAME`, `LASTNAME`  FROM `tbltransaction` t,`tblperson` c WHERE  c.`SUPLIERCUSTOMERID`=t.`SUPLIERCUSTOMERID` AND t.TYPE ='StockOut' " &
        " WHERE TRANSACTIONNUMBER LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        frm_transaction.txttransactionid.Text = dtglist.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub
End Class