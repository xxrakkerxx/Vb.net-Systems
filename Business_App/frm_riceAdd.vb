Imports System.Data.OleDb
Public Class frm_riceAdd
    Private Sub frm_riceAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sqlconn As New OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim connString As String

        Try
            'sanitize basic
            If txtName.Text = Nothing Or txtAmount.Text <= 0 Then
                MessageBox.Show("Please Fill Name or Amount Field Accordingly", "Failed to Submit", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            Else
                connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\business_record.mdb"
                sqlconn.ConnectionString = connString
                sqlquery.Connection = sqlconn

                sqlconn.Open()
                'Save the data sa database

                sqlquery.CommandText = "INSERT INTO tb_rice([ID], [Purchaser], [Date_Start], [Description], [Amount], [W1], [W2], [W3], [W4],
                                                             [Paid], [Balance], [Status])
                                    VALUES([@ID], [@Purchaser], [@Date], [@Desc], [@Amt], [@W1], [@W2], [@W3], [@W4],[@Amt_Paid],[@Bal], [@Stat])"

                sqlquery.Parameters.AddWithValue("[@ID]", IDTextBox.Text)
                sqlquery.Parameters.AddWithValue("[@Purchaser]", txtName.Text)
                sqlquery.Parameters.AddWithValue("[@Date]", DateTimePicker1.Value.ToShortDateString)
                sqlquery.Parameters.AddWithValue("[@Desc]", DescriptionTextbox.Text)
                sqlquery.Parameters.AddWithValue("[@Amt]", txtAmount.Text)
                sqlquery.Parameters.AddWithValue("[@W1]", Week_1TextBox.Text)
                sqlquery.Parameters.AddWithValue("[@W2]", Week_2TextBox.Text)
                sqlquery.Parameters.AddWithValue("[@W3]", Week_3TextBox.Text)
                sqlquery.Parameters.AddWithValue("[@W4]", Week_4TextBox.Text)
                sqlquery.Parameters.AddWithValue("[@Amt_Paid]", Amount_PaidTextBox.Text)
                sqlquery.Parameters.AddWithValue("[@Bal]", Remaining_BalanceTextBox.Text)
                sqlquery.Parameters.AddWithValue("[@Stat]", StatusTextBox.Text)

                sqlquery.ExecuteNonQuery()
                sqlconn.Close()
                'refresh data adapters
                frm_rice.Tb_riceTableAdapter.Fill(frm_rice.Business_recordDataSet.tb_rice)

                'return all to normal
                DateTimePicker1.Value = Date.Today.ToLongDateString
                'readonly textboxes set to true
                txtName.ResetText()
                DescriptionTextbox.Text = "25Kg"
                txtAmount.Text = "0.00"
                Week_1TextBox.Text = "0.00"
                Week_2TextBox.Text = "0.00"
                Week_3TextBox.Text = "0.00"
                Week_4TextBox.Text = "0.00"

                Remaining_BalanceTextBox.Text = "0.00"
                Amount_PaidTextBox.Text = "0.00"
            End If




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim count As Integer = 0
        Dim f1, f2, f3, total

        count = frm_rice.Tb_riceBindingSource.Count + 1
        f1 = Date.Today.Year
        f2 = Date.Today.Day
        f3 = Date.Today.Month
        total = f1 & f2 & f3 & count

        IDTextBox.Text = total

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
            If tTotalR <= 0 Then
                StatusTextBox.Text = "Paid"
                StatusTextBox.BackColor = Color.Green
                StatusTextBox.ForeColor = Color.White
            Else
                StatusTextBox.Text = "UnPaid"
                StatusTextBox.BackColor = Color.Red
                StatusTextBox.ForeColor = Color.Yellow
            End If
        Catch ex As Exception
            Timer1.Stop()
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub
End Class