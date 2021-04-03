Imports System.Data.OleDb
Public Class Form1
    Private Sub Tb_chickensBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_chickensBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Business_recordDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Business_recordDataSet.tb_chickens' table. You can move, or remove it, as needed.
        Me.Tb_chickensTableAdapter.Fill(Me.Business_recordDataSet.tb_chickens)

        'check for paid and unpaid onload
        Tb_chickensBindingSource.Filter = "(Remarks LIKE'" & "Paid" & "')"
        lblPaid.Text = Tb_chickensBindingSource.Count

        Tb_chickensBindingSource.Filter = "(Remarks LIKE'" & "UnPaid" & "')"
        lblUnPaid.Text = Tb_chickensBindingSource.Count

        Tb_chickensBindingSource.RemoveFilter()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim count As Integer = 0
        Dim f1, f2, f3, total

        count = Tb_chickensBindingSource.Count + 1
        f1 = Date.Today.Year
        f2 = Date.Today.Day
        f3 = Date.Today.Month
        total = f1 & f2 & f3 & count

        Try
            If btnAdd.Text = "Add" Then
                Tb_chickensBindingSource.AddNew()
                IDTextBox.Text = total
                DateTimePicker1.Enabled = True
                DateTimePicker1.Value = DateTimePicker1.Value.AddDays(1)
                PurchaserTextBox.ReadOnly = False
                QTYTextBox.ReadOnly = False
                cboMark.Enabled = True
                AmountTextBox.ReadOnly = False
                btnAdd.Text = "Cancel"

                'buttons behaviors
                btnSave.Enabled = True
                btnDel.Enabled = False
                btnUp.Enabled = False

            Else
                Tb_chickensBindingSource.RemoveCurrent()
                DateTimePicker1.Enabled = False
                PurchaserTextBox.ReadOnly = True
                QTYTextBox.ReadOnly = True
                cboMark.Enabled = False
                AmountTextBox.ReadOnly = True
                btnAdd.Text = "Add"

                'buttons behaviors
                btnSave.Enabled = False
                btnDel.Enabled = True
                btnUp.Enabled = True
            End If


        Catch ex As Exception

        End Try




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Tb_chickensBindingSource.EndEdit()
            Tb_chickensTableAdapter.Update(Business_recordDataSet.tb_chickens)
            'MessageBox.Show("Save Successful!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DateTimePicker1.Enabled = False
            PurchaserTextBox.ReadOnly = True
            QTYTextBox.ReadOnly = True
            cboMark.Enabled = False
            AmountTextBox.ReadOnly = True
            btnAdd.Text = "Add"

            'button behaviors
            btnAdd.Enabled = True
            btnSave.Enabled = False
            btnDel.Enabled = True
            btnUp.Enabled = True

            'update counting 
            Tb_chickensBindingSource.Filter = "(Remarks LIKE'" & "Paid" & "')"
            lblPaid.Text = Tb_chickensBindingSource.Count

            Tb_chickensBindingSource.Filter = "(Remarks LIKE'" & "UnPaid" & "')"
            lblUnPaid.Text = Tb_chickensBindingSource.Count

            Tb_chickensBindingSource.RemoveFilter()
            'adjust chart in frm_view realtime
            frm_view.Chart1.Series("UnPaid").Points.Clear()
            frm_view.Chart1.Series("Paid").Points.Clear()
            frm_view.Timer1.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If (MessageBox.Show("Are you sure you want to delete this forever?", "Deletion Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                Tb_chickensBindingSource.RemoveCurrent()
                Tb_chickensBindingSource.EndEdit()
                Tb_chickensTableAdapter.Update(Business_recordDataSet.tb_chickens)

                'update counting 
                Tb_chickensBindingSource.Filter = "(Remarks LIKE'" & "Paid" & "')"
                lblPaid.Text = Tb_chickensBindingSource.Count

                Tb_chickensBindingSource.Filter = "(Remarks LIKE'" & "UnPaid" & "')"
                lblUnPaid.Text = Tb_chickensBindingSource.Count

                Tb_chickensBindingSource.RemoveFilter()
            Else
                'no action
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboMark_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMark.SelectedIndexChanged
        RemarksTextBox.Text = cboMark.GetItemText(cboMark.SelectedItem)
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        Try
            DateTimePicker1.Enabled = True
            PurchaserTextBox.ReadOnly = False
            QTYTextBox.ReadOnly = False
            cboMark.Enabled = True
            AmountTextBox.ReadOnly = False

            'button behaviors
            btnSave.Enabled = True
            btnAdd.Enabled = False
            btnDel.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AmountTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AmountTextBox.KeyDown

        'triggers only if btnsave is enabled, else no action needed
        If e.KeyCode = Keys.Enter And btnSave.Enabled = True Then
            Button2_Click(sender, e)
            e.SuppressKeyPress = True
        End If

        If e.KeyCode = Keys.Escape Then
            'Button1_Click(sender, e)
            'e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RemarksTextBox_TextChanged(sender As Object, e As EventArgs) Handles RemarksTextBox.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RemarksTextBox.Text = "UnPaid" Then
            RemarksTextBox.BackColor = Color.Red
            RemarksTextBox.ForeColor = Color.Yellow
            ' RemarksLabel.ForeColor = Color.Red
        ElseIf RemarksTextBox.Text = "Paid" Then
            RemarksTextBox.BackColor = Color.Green
            RemarksTextBox.ForeColor = Color.White
        Else
            RemarksTextBox.BackColor = SystemColors.Control
            RemarksTextBox.ForeColor = Color.Black
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtsearch.Text.Length > 0 Then
            Tb_chickensBindingSource.Filter = "(Remarks LIKE'" & txtsearch.Text & "%') OR(Purchaser LIKE '%" & txtsearch.Text & "%')"

            If Tb_chickensBindingSource.Count = 0 Then
                MessageBox.Show("Sorry No Data Found from your keyword", "Searching Failed")
                Exit Sub


            End If
        End If

    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
            e.SuppressKeyPress = True
        End If

        If e.KeyCode = Keys.Escape Then
            btnSearch_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Tb_chickensBindingSource.RemoveFilter()

    End Sub

    Private Sub PaidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaidToolStripMenuItem.Click
        Tb_chickensBindingSource.Filter = "(Remarks LIKE '" & "Paid" & "')"
        Dim count As Integer
        count = Tb_chickensBindingSource.Count
        Tb_chickensBindingSource.RemoveFilter()
        MessageBox.Show("Total Paid Customers: " & count, "Analyzing Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub UnPaidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnPaidToolStripMenuItem.Click
        Tb_chickensBindingSource.Filter = "(Remarks LIKE '" & "UnPaid" & "')"
        Dim count As Integer
        count = Tb_chickensBindingSource.Count
        Tb_chickensBindingSource.RemoveFilter()
        MessageBox.Show("Total UnPaid Customers: " & count, "Analyzing Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ErrorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErrorsToolStripMenuItem.Click
        Tb_chickensBindingSource.Filter = "(Remarks IS NULL)"
        Dim count As Integer
        count = Tb_chickensBindingSource.Count
        Tb_chickensBindingSource.RemoveFilter()
        MessageBox.Show("Undefined Remarks Detected: " & count, "Analyzing Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub PurchaserTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PurchaserTextBox.KeyDown
        'Plan: if qty and remarks hasn't set yet, focus on next control else, trigger save button
        If e.KeyCode = Keys.Enter And btnSave.Enabled = True Then
            QTYTextBox.Focus()
            e.SuppressKeyPress = True
        End If


    End Sub

    Private Sub btnUnpaid_Click(sender As Object, e As EventArgs) Handles btnUnpaid.Click
        frm_view.Show()
        frm_view.lblType.Text = "UnPaid"
        frm_view.lblType.BackColor = Color.Red
        frm_view.lblType.ForeColor = Color.White
        frm_view.Tb_chickensBindingSource.Filter = "(Remarks LIKE '" & "UnPaid" & "')"
        frm_view.lblcount.Text = frm_view.Tb_chickensBindingSource.Count
        frm_view.cbotype.SelectedIndex = 0

        Dim sqlconn As New OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim cmd, cmd2 As OleDbCommand
        Dim connString As String
        Dim sql, sql2 As String


        Try
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\business_record.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sql = "SELECT SUM(Amount) FROM tb_chickens WHERE Remarks='UnPaid'"
            sql2 = "SELECT SUM(QTY) FROM tb_chickens WHERE Remarks='UnPaid'"

            sqlconn.Open()
            'SELECT SUM(Quantity) AS items FROM OrderDetails;
            cmd = New OleDbCommand(sql, sqlconn)
            cmd2 = New OleDbCommand(sql2, sqlconn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            Dim count2 As Int32 = Convert.ToInt32(cmd2.ExecuteScalar())
            cmd.Dispose()
            cmd2.Dispose()
            sqlconn.Close()
            frm_view.lblEarnings.Text = count.ToString("c") 'Amount total
            frm_view.lblTotal.Text = count2.ToString() 'QTY total
            frm_view.lblCaption.Text = "UnPaid Earnings:"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub btnPaid_Click(sender As Object, e As EventArgs) Handles btnPaid.Click
        frm_view.Show()
        frm_view.lblType.Text = "Paid"
        frm_view.lblType.BackColor = Color.Green
        frm_view.lblType.ForeColor = Color.White
        frm_view.Tb_chickensBindingSource.Filter = "(Remarks LIKE '" & "Paid" & "')"
        frm_view.lblcount.Text = frm_view.Tb_chickensBindingSource.Count
        frm_view.cbotype.SelectedIndex = 1

        Dim sqlconn As New OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim cmd, cmd2 As OleDbCommand
        Dim connString As String
        Dim sql, sql2 As String

        Try
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\business_record.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sql = "SELECT SUM(Amount) FROM tb_chickens WHERE Remarks='Paid'"
            sql2 = "SELECT SUM(QTY) FROM tb_chickens WHERE Remarks='Paid'"

            sqlconn.Open()
            'SELECT SUM(Quantity) AS items FROM OrderDetails;
            cmd = New OleDbCommand(sql, sqlconn)
            cmd2 = New OleDbCommand(sql2, sqlconn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            Dim count2 As Int32 = Convert.ToInt32(cmd2.ExecuteScalar())
            cmd.Dispose()
            cmd2.Dispose()
            sqlconn.Close()
            frm_view.lblEarnings.Text = count.ToString("c") 'Amount total
            frm_view.lblTotal.Text = count2.ToString() 'QTY total
            frm_view.lblCaption.Text = "Total Earnings:"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub LendingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LendingToolStripMenuItem1.Click
        frm_lending.Show()

    End Sub

    Private Sub LendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LendingToolStripMenuItem.Click
        frm_rice.Show()

    End Sub
End Class
