Public Class frm_suplier
    Dim ID As String = 0
    Dim maxcolumn
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        sql = "INSERT INTO tblperson (`SUPLIERCUSTOMERID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`)" &
        " VALUES ('" & ID & "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtaddress.Text & "','" & txttelephone.Text & "','" & txtmobile.Text & "','SUPLIER')"
        create(sql, txtfname.Text & " " & txtlname.Text, txtfname.Text & " " & txtlname.Text)
        '----------------------------------
        sql = "SELECT * FROM tblperson WHERE TYPE='SUPLIER'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '------------------------------------------
        createNoMsg("UPDATE tblautonumber SET END = END + INCREMENT WHERE ID =3")
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 3")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "UPDATE tblperson SET  `FIRSTNAME`='" & txtfname.Text & "', `LASTNAME`='" & txtlname.Text &
        "', `ADDRESS`='" & txtaddress.Text & "', `TELEPHONE`='" & txttelephone.Text & "', `MOBILE`='" & txtmobile.Text & "' WHERE `SUPLIERCUSTOMERID`='" & ID & "'"
        updates(sql, txtfname.Text & " " & txtlname.Text, txtfname.Text & " " & txtlname.Text)
        '----------------------------------
        sql = "SELECT * FROM tblperson WHERE TYPE='SUPLIER'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 3")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "DELETE FROM tblperson WHERE `SUPLIERCUSTOMERID`='" & dtglist.CurrentRow.Cells("SUPLIERCUSTOMERID").Value & "'"
        deletes(sql, dtglist.CurrentRow.Cells("SUPLIERCUSTOMERID").Value, dtglist.CurrentRow.Cells("SUPLIERCUSTOMERID").Value)
        '----------------------------------
        sql = "SELECT * FROM tblperson WHERE TYPE = 'SUPLIER'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 3")
        ID = dt.Rows(0).Item(0)

    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        sql = "SELECT * FROM tblperson WHERE TYPE='SUPLIER' AND SUPLIERCUSTOMERID LIKE '%" & txtsearch.Text & "%'"
        reloadDtg(sql, dtglist)
        '----------------------------------
        cleartext(Panel1)
        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 3")
        ID = dt.Rows(0).Item(0)
    End Sub

    Private Sub frm_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '----------------------------------
        sql = "SELECT * FROM tblperson WHERE TYPE='SUPLIER'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 3")
        ID = dt.Rows(0).Item(0)
        ' MsgBox(ID)
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        '----------------------------------
        sql = "SELECT * FROM tblperson WHERE TYPE='SUPLIER'"
        reloadDtg(sql, dtglist)
        '---------------------------------
        cleartext(Panel1)
        '----------------------------------
        maxcolumn = dtglist.Columns.Count - 1
        dtglist.Columns(maxcolumn).Visible = False
        dtglist.Columns(0).Visible = False
        '-------------------------------------
        reloadtxt("SELECT CONCAT(STRT, END) FROM tblautonumber WHERE ID = 3")
        ID = dt.Rows(0).Item(0)
        ' MsgBox(ID)
    End Sub

    Private Sub dtglist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglist.DoubleClick
        Try
            ID = dtglist.CurrentRow.Cells(1).Value
            reloadtxt("SELECT * FROM tblperson WHERE TYPE='SUPLIER' AND SUPLIERCUSTOMERID ='" & dtglist.CurrentRow.Cells(1).Value & "'")
            txtfname.Text = dt.Rows(0).Item("FIRSTNAME")
            txtlname.Text = dt.Rows(0).Item("LASTNAME")
            txtaddress.Text = dt.Rows(0).Item("ADDRESS")
            txttelephone.Text = dt.Rows(0).Item("TELEPHONE")
            txtmobile.Text = dt.Rows(0).Item("MOBILE")
        Catch ex As Exception
            MsgBox("Action is not valid.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        frm_transaction.txt_suplierId.Text = dtglist.CurrentRow.Cells(1).Value
        Me.Close()
    End Sub
End Class