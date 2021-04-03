Imports System.Data.OleDb
Public Class frm_view
    Dim sqlconn As New OleDbConnection
    Dim sqlquery As New OleDb.OleDbCommand
    Dim cmd, cmd2, cmd3, cmd4 As OleDbCommand
    Dim connString As String
    Dim sql, sql2, sql3, sql4 As String
    Private Sub Tb_chickensBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_chickensBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Business_recordDataSet)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Sum all columns       
        Try
            Timer1.Stop()
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\business_record.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sql3 = "SELECT SUM(Amount) FROM tb_chickens WHERE Remarks='Paid'"
            sql4 = "SELECT SUM(QTY) FROM tb_chickens WHERE Remarks='Paid'"

            sql = "SELECT SUM(Amount) FROM tb_chickens WHERE Remarks='UnPaid'"
            sql2 = "SELECT SUM(QTY) FROM tb_chickens WHERE Remarks='UnPaid'"



            sqlconn.Open()
            'SELECT SUM(Quantity) AS items FROM OrderDetails;
            cmd = New OleDbCommand(sql, sqlconn)
            cmd2 = New OleDbCommand(sql2, sqlconn)
            cmd3 = New OleDbCommand(sql3, sqlconn)
            cmd4 = New OleDbCommand(sql4, sqlconn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar()) 'this is for unpaid chart sum
            Dim count2 As Int32 = Convert.ToInt32(cmd2.ExecuteScalar()) 'this is for unpaid chart qty

            Dim count3 As Int32 = Convert.ToInt32(cmd3.ExecuteScalar()) 'for paid chart sum
            Dim count4 As Int32 = Convert.ToInt32(cmd4.ExecuteScalar()) 'for paid chart qty
            cmd.Dispose()
            cmd2.Dispose()
            cmd3.Dispose()
            cmd4.Dispose()
            sqlconn.Close()

            'charts
            Dim d = Date.Today.ToLongDateString
            Me.Chart1.Series("Paid").Points.AddXY("", count3)
            Me.Chart1.Series("UnPaid").Points.AddXY("", count)




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub frm_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Business_recordDataSet.tb_chickens' table. You can move, or remove it, as needed.
        Me.Tb_chickensTableAdapter.Fill(Me.Business_recordDataSet.tb_chickens)



        Try
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\business_record.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sql = "SELECT SUM(Amount) FROM tb_chickens WHERE Remarks='Paid'"

            sqlconn.Open()
            'SELECT SUM(Quantity) AS items FROM OrderDetails;
            cmd = New OleDbCommand(sql, sqlconn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            cmd.Dispose()
            sqlconn.Close()
            lblEarnings.Text = count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub cbotype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbotype.SelectedIndexChanged
        Dim ch As String = cbotype.GetItemText(cbotype.SelectedItem)
        Tb_chickensBindingSource.Filter = "(Remarks LIKE '" & ch & "')"
        lblcount.Text = Tb_chickensBindingSource.Count

        If ch = "UnPaid" Then
            lblType.Text = "UnPaid"
            lblType.BackColor = Color.Red

            'Sum all columns       
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
                Me.lblEarnings.Text = count.ToString("c") 'Amount total
                Me.lblTotal.Text = count2.ToString() 'QTY total
                Me.lblCaption.Text = "UnPaid Earnings:"

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End Try

        ElseIf ch = "Paid" Then
            lblType.Text = "Paid"
            lblType.BackColor = Color.Green

            'Sum all columns       
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
                Me.lblEarnings.Text = count.ToString("c") 'Amount total
                Me.lblTotal.Text = count2.ToString() 'QTY total
                Me.lblCaption.Text = "Paid Earnings:"

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Something wen't wrong", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End Try
        End If
    End Sub
End Class