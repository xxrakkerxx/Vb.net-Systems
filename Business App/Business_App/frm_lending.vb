Imports System.Data.OleDb
Public Class frm_lending


    Private Sub frm_lending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Business_recordDataSet.tb_lending' table. You can move, or remove it, as needed.
        Me.Tb_lendingTableAdapter.Fill(Me.Business_recordDataSet.tb_lending)
        'TODO: This line of code loads data into the 'Business_recordDataSet.tb_lending' table. You can move, or remove it, as needed.


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try

            frm_lendingAdd.ShowDialog()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Tb_lendingBindingSource.EndEdit()
            Tb_lendingTableAdapter.Update(Business_recordDataSet.tb_lending)
            'MessageBox .Show ("Saved")
            'readonly textboxes set to true
            Lender_NameTextBox.ReadOnly = True
            DateTimePicker1.Enabled = False
            AmountTextBox.ReadOnly = True
            Week_1TextBox.ReadOnly = True
            Week_2TextBox.ReadOnly = True
            Week_3TextBox.ReadOnly = True
            Week_4TextBox.ReadOnly = True
            Week_5TextBox.ReadOnly = True
            Week_6TextBox.ReadOnly = True
            Week_7TextBox.ReadOnly = True
            Week_8TextBox.ReadOnly = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (MessageBox.Show("Are you sure you want to erase this data?", "Warning! deleting can't be undone", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes) Then
                Tb_lendingBindingSource.RemoveCurrent()
                Tb_lendingTableAdapter.Update(Business_recordDataSet.tb_lending)
                MessageBox.Show("Record Deleted", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                'no action
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'readonly textboxes set to false
            Lender_NameTextBox.ReadOnly = False
            DateTimePicker1.Enabled = True
            AmountTextBox.ReadOnly = False
            Week_1TextBox.ReadOnly = False
            Week_2TextBox.ReadOnly = False
            Week_3TextBox.ReadOnly = False
            Week_4TextBox.ReadOnly = False
            Week_5TextBox.ReadOnly = False
            Week_6TextBox.ReadOnly = False
            Week_7TextBox.ReadOnly = False
            Week_8TextBox.ReadOnly = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If txtSearch.TextLength > 0 Then
                Tb_lendingBindingSource.Filter = "(Borrower_Name LIKE '" & txtSearch.Text & "%') OR(Status LIKE '" & txtSearch.Text & "%')"
                'clear rbt
                rbtPaid.Checked = False
                rbtUnPaid.Checked = False
                If Tb_lendingBindingSource.Count = 0 Then
                    MessageBox.Show("Record not found", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
            Else
                'no action
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub AmountTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AmountTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) = 47 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) < 46 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'disable update,save,delete button automatically if tables returns 0
        If Business_recordDataSet.tb_lending.Count = 0 Then
            btnSave.Enabled = False
            btnDelete.Enabled = False
            btnUpdate.Enabled = False
            btnSearch.Enabled = False
            txtSearch.ReadOnly = True
        Else
            btnSave.Enabled = True
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
            btnSearch.Enabled = True
            txtSearch.ReadOnly = False
        End If

        'calculation
        Dim tTotal, tTotalR As String
        Dim Amount = Val(AmountTextBox.Text)
        Dim t1 = Val(Week_1TextBox.Text)
        Dim t2 = Val(Week_2TextBox.Text)
        Dim t3 = Val(Week_3TextBox.Text)
        Dim t4 = Val(Week_4TextBox.Text)
        Dim t5 = Val(Week_5TextBox.Text)
        Dim t6 = Val(Week_6TextBox.Text)
        Dim t7 = Val(Week_7TextBox.Text)
        Dim t8 = Val(Week_8TextBox.Text)
        tTotal = (t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8).ToString("c")
        tTotalR = (Amount - (t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8)).ToString("c")
        Remaining_BalanceTextBox.Text = tTotalR
        Amount_PaidTextBox.Text = tTotal

        Try
            If tTotalR <= 0 And Val(IDTextBox.Text) <> 0 Then
                StatusTextBox.Text = "Settled"
                StatusTextBox.BackColor = Color.Green
                StatusTextBox.ForeColor = Color.White
            Else
                StatusTextBox.Text = "UnSettled"
                StatusTextBox.BackColor = Color.Red
                StatusTextBox.ForeColor = Color.Yellow
            End If
        Catch ex As Exception
            'wag lagyan ng msgbox once na may exception, panigurado sabog ang low end pc 
        End Try

        'count displayed records
        Dim count As String = Tb_lendingBindingSource.Count
        lblTotal.Text = "Total Record(s): " & count
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Tb_lendingBindingSource.Filter = Nothing
    End Sub

    Private Sub btnAdd_MouseHover(sender As Object, e As EventArgs) Handles btnAdd.MouseHover
        btnAdd.ForeColor = Color.Yellow
    End Sub

    Private Sub btnAdd_MouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave
        btnAdd.ForeColor = Color.Black
    End Sub

    Private Sub btnSave_MouseHover(sender As Object, e As EventArgs) Handles btnSave.MouseHover
        btnSave.ForeColor = Color.Yellow
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.ForeColor = Color.Black
    End Sub

    Private Sub btnDelete_MouseHover(sender As Object, e As EventArgs) Handles btnDelete.MouseHover
        btnDelete.ForeColor = Color.Yellow
    End Sub

    Private Sub btnDelete_MouseLeave(sender As Object, e As EventArgs) Handles btnDelete.MouseLeave
        btnDelete.ForeColor = Color.Black
    End Sub

    Private Sub btnUpdate_MouseHover(sender As Object, e As EventArgs) Handles btnUpdate.MouseHover
        btnUpdate.ForeColor = Color.Yellow
    End Sub

    Private Sub btnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave
        btnUpdate.ForeColor = Color.Black
    End Sub

    Private Sub btnSearch_MouseHover(sender As Object, e As EventArgs) Handles btnSearch.MouseHover
        btnSearch.ForeColor = Color.Yellow
    End Sub

    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        btnSearch.ForeColor = Color.Black
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
            e.SuppressKeyPress = True
        End If

        If e.KeyCode = Keys.Escape Then
            btnSearch_Click(sender, e)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub rbtPaid_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPaid.CheckedChanged
        If rbtPaid.Checked Then
            Tb_lendingBindingSource.Filter = "(Status LIKE '" & "Settled" & "')"
        End If
    End Sub

    Private Sub rbtUnPaid_CheckedChanged(sender As Object, e As EventArgs) Handles rbtUnPaid.CheckedChanged
        If rbtUnPaid.Checked Then
            Tb_lendingBindingSource.Filter = "(Status LIKE '" & "UnSettled" & "')"
        End If
    End Sub
End Class