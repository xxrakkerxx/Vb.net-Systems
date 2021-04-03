Imports System.Data.OleDb
Public Class frm_lendingAdd
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sqlconn As New OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim connString As String

        Try
            'Tb_lendingBindingSource.EndEdit()
            'Tb_lendingTableAdapter.Update(Business_recordDataSet.tb_lending)
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\business_record.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn

            sqlconn.Open()
            'Save the data sa database

            sqlquery.CommandText = "INSERT INTO tb_lending([ID], [Date_Start], [Amount], [Week_1], [Week_2], [Week_3], [Week_4],
                                    [Week_5], [Week_6], [Week_7], [Week_8], [Status], [Amount_Paid], [Remaining_Balance], [Borrower_Name])
                                    VALUES([@ID], [@Date], [@Amt], [@W1], [@W2], [@W3], [@W4], [@W5], [@W6], [@W7], [@W8], [@Stat], [@Amt_Paid], [@Bal], [@Borrower])"

            sqlquery.Parameters.AddWithValue("[@ID]", IDTextBox.Text)
            sqlquery.Parameters.AddWithValue("[@Date]", DateTimePicker1.Value.ToShortDateString)
            sqlquery.Parameters.AddWithValue("[@Amt]", AmountTextBox.Text)
            sqlquery.Parameters.AddWithValue("[@W1]", Week_1TextBox.Text)
            sqlquery.Parameters.AddWithValue("[@W2]", Week_2TextBox.Text)
            sqlquery.Parameters.AddWithValue("[@W3]", Week_3TextBox.Text)
            sqlquery.Parameters.AddWithValue("[@W4]", Week_4TextBox.Text)
            sqlquery.Parameters.AddWithValue("[@W5]", Week_5TextBox.Text)
            sqlquery.Parameters.AddWithValue("[@W6]", Week_6TextBox.Text)
            sqlquery.Parameters.AddWithValue("[@W7]", Week_7TextBox.Text)
            sqlquery.Parameters.AddWithValue("[@W8]", Week_8TextBox.Text)
            sqlquery.Parameters.AddWithValue("[@Stat]", StatusTextBox.Text)
            sqlquery.Parameters.AddWithValue("[@Amt_Paid]", Amount_PaidTextBox.Text)
            sqlquery.Parameters.AddWithValue("[@Bal]", Remaining_BalanceTextBox.Text)
            sqlquery.Parameters.AddWithValue("[@Borrower]", Lender_NameTextBox.Text)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            'refresh data adapters
            frm_lending.Tb_lendingTableAdapter.Fill(frm_lending.Business_recordDataSet.tb_lending)

            'return all to normal
            DateTimePicker1.Value = Date.Today.ToLongDateString
            'readonly textboxes set to true
            Lender_NameTextBox.ResetText()
            AmountTextBox.Text = "0.00"
            Week_1TextBox.Text = "0.00"
            Week_2TextBox.Text = "0.00"
            Week_3TextBox.Text = "0.00"
            Week_4TextBox.Text = "0.00"
            Week_5TextBox.Text = "0.00"
            Week_6TextBox.Text = "0.00"
            Week_7TextBox.Text = "0.00"
            Week_8TextBox.Text = "0.00"
            Remaining_BalanceTextBox.Text = "0.00"
            Amount_PaidTextBox.Text = "0.00"



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub frm_lendingAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Business_recordDataSet.tb_lending' table. You can move, or remove it, as needed.
        Me.Tb_lendingTableAdapter.Fill(Me.Business_recordDataSet.tb_lending)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim count As Integer = 0
        Dim f1, f2, f3, total

        count = frm_lending.Tb_lendingBindingSource.Count + 1
        f1 = Date.Today.Year
        f2 = Date.Today.Day
        f3 = Date.Today.Month
        total = f1 & f2 & f3 & count

        IDTextBox.Text = total

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
            If tTotalR <= 0 Then
                StatusTextBox.Text = "Settled"
                StatusTextBox.BackColor = Color.Green
                StatusTextBox.ForeColor = Color.White
            Else
                StatusTextBox.Text = "UnSettled"
                StatusTextBox.BackColor = Color.Red
                StatusTextBox.ForeColor = Color.Yellow
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Tb_lendingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_lendingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Business_recordDataSet)

    End Sub

    Private Sub btnSave_MouseHover(sender As Object, e As EventArgs) Handles btnSave.MouseHover
        btnSave.ForeColor = Color.Yellow
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = Color.Yellow
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black
    End Sub
End Class