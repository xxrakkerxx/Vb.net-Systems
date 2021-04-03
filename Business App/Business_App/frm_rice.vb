Public Class frm_rice
    Private Sub Tb_riceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_riceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Business_recordDataSet)

    End Sub

    Private Sub frm_rice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Business_recordDataSet.tb_rice' table. You can move, or remove it, as needed.
        Me.Tb_riceTableAdapter.Fill(Me.Business_recordDataSet.tb_rice)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'enable controls
        txtName.ReadOnly = False
        DateTimePicker1.Enabled = True
        Week_1TextBox.ReadOnly = False
        Week_2TextBox.ReadOnly = False
        Week_3TextBox.ReadOnly = False
        Week_4TextBox.ReadOnly = False

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
                Tb_riceBindingSource.RemoveCurrent()
                Tb_riceBindingSource.EndEdit()
                Tb_riceTableAdapter.Update(Business_recordDataSet.tb_rice)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frm_riceAdd.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'disable update,save,delete button automatically if tables returns 0
        If Business_recordDataSet.tb_rice.Count = 0 Then
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
        Dim Amount = Val(txtAmount.Text)
        Dim t1 = Val(Week_1TextBox.Text)
        Dim t2 = Val(Week_2TextBox.Text)
        Dim t3 = Val(Week_3TextBox.Text)
        Dim t4 = Val(Week_4TextBox.Text)
        tTotal = (t1 + t2 + t3 + t4).ToString("c")
        tTotalR = (Amount - (t1 + t2 + t3 + t4)).ToString("c")
        Remaining_BalanceTextBox.Text = tTotalR
        Amount_PaidTextBox.Text = tTotal

        Try
            If tTotalR <= 0 And Val(IDTextBox.Text) <> 0 Then
                StatusTextBox.Text = "Paid"
                StatusTextBox.BackColor = Color.Green
                StatusTextBox.ForeColor = Color.White
            Else
                StatusTextBox.Text = "UnPaid"
                StatusTextBox.BackColor = Color.Red
                StatusTextBox.ForeColor = Color.Yellow
            End If
        Catch ex As Exception
            'wag lagyan ng msgbox once na may exception, panigurado sabog ang low end pc 
        End Try
    End Sub

    Private Sub btnSearch_MouseHover(sender As Object, e As EventArgs) Handles btnSearch.MouseHover
        btnSearch.ForeColor = Color.Yellow
    End Sub

    Private Sub btnSearch_MouseLeave(sender As Object, e As EventArgs) Handles btnSearch.MouseLeave
        btnSearch.ForeColor = Color.Black
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If txtSearch.TextLength > 0 Then
                Tb_riceBindingSource.Filter = "(Purchaser LIKE '" & txtSearch.Text & "%') OR(Status LIKE '" & txtSearch.Text & "%')"

                If Tb_riceBindingSource.Count = 0 Then
                    MessageBox.Show("Record not found", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
            Else
                'no action
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Try
            Tb_riceBindingSource.Filter = Nothing

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'sanitize basic
            If txtName.Text = Nothing Or txtAmount.Text <= 0 Then
                MessageBox.Show("Please Fill Name or Amount Field Accordingly", "Failed to Submit", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            Else
                Tb_riceBindingSource.EndEdit()
                Tb_riceTableAdapter.Update(Business_recordDataSet.tb_rice)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub
End Class