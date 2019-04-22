Public Class Form1
    Private Sub ts_Transaction_Click(sender As Object, e As EventArgs) Handles ts_Transaction.Click
        With frm_transaction
            .Show()
            .Focus()

        End With

    End Sub

    Private Sub ts_StockMaster_Click(sender As Object, e As EventArgs) Handles ts_StockMaster.Click
        With frm_StockMaster
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_Customer_Click(sender As Object, e As EventArgs) Handles ts_Customer.Click
        With frm_customer
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_ManageUser_Click(sender As Object, e As EventArgs) Handles ts_ManageUser.Click
        With frm_user
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_Setting_Click(sender As Object, e As EventArgs) Handles ts_Setting.Click
        With frm_settings
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ts_Report_Click(sender As Object, e As EventArgs) Handles ts_Report.Click
        With frm_report
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ts_Login.Click


        With LoginForm1
            If ts_Login.Text = "LOGIN" Then
                .Show()
                .Focus()
            Else
                ts_Login.Text = "LOGIN"
                ts_Login.Image = My.Resources.lock
                enable_disable(False)
            End If

        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enable_disable(False)
    End Sub
End Class
