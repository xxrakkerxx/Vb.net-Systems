<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_lending
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim Lender_NameLabel As System.Windows.Forms.Label
        Dim Date_StartLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim Week_1Label As System.Windows.Forms.Label
        Dim Week_2Label As System.Windows.Forms.Label
        Dim Week_3Label As System.Windows.Forms.Label
        Dim Week_4Label As System.Windows.Forms.Label
        Dim Week_5Label As System.Windows.Forms.Label
        Dim Week_6Label As System.Windows.Forms.Label
        Dim Week_7Label As System.Windows.Forms.Label
        Dim Week_8Label As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Amount_PaidLabel As System.Windows.Forms.Label
        Dim Remaining_BalanceLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Tb_lendingDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Week1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Week2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Week3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Week4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Week5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Week6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Week7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Week8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemainingBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tb_lendingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Business_recordDataSet = New Business_App.business_recordDataSet()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Remaining_BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Lender_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Week_1TextBox = New System.Windows.Forms.TextBox()
        Me.Amount_PaidTextBox = New System.Windows.Forms.TextBox()
        Me.Week_8TextBox = New System.Windows.Forms.TextBox()
        Me.Week_7TextBox = New System.Windows.Forms.TextBox()
        Me.Week_6TextBox = New System.Windows.Forms.TextBox()
        Me.Week_5TextBox = New System.Windows.Forms.TextBox()
        Me.Week_4TextBox = New System.Windows.Forms.TextBox()
        Me.Week_2TextBox = New System.Windows.Forms.TextBox()
        Me.Week_3TextBox = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tb_lendingTableAdapter = New Business_App.business_recordDataSetTableAdapters.tb_lendingTableAdapter()
        Me.TableAdapterManager = New Business_App.business_recordDataSetTableAdapters.TableAdapterManager()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.rbtUnPaid = New System.Windows.Forms.RadioButton()
        Me.rbtPaid = New System.Windows.Forms.RadioButton()
        IDLabel = New System.Windows.Forms.Label()
        Lender_NameLabel = New System.Windows.Forms.Label()
        Date_StartLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        Week_1Label = New System.Windows.Forms.Label()
        Week_2Label = New System.Windows.Forms.Label()
        Week_3Label = New System.Windows.Forms.Label()
        Week_4Label = New System.Windows.Forms.Label()
        Week_5Label = New System.Windows.Forms.Label()
        Week_6Label = New System.Windows.Forms.Label()
        Week_7Label = New System.Windows.Forms.Label()
        Week_8Label = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Amount_PaidLabel = New System.Windows.Forms.Label()
        Remaining_BalanceLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tb_lendingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Tb_lendingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Business_recordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(36, 41)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(28, 21)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'Lender_NameLabel
        '
        Lender_NameLabel.AutoSize = True
        Lender_NameLabel.Location = New System.Drawing.Point(7, 91)
        Lender_NameLabel.Name = "Lender_NameLabel"
        Lender_NameLabel.Size = New System.Drawing.Size(55, 21)
        Lender_NameLabel.TabIndex = 3
        Lender_NameLabel.Text = "Name:"
        '
        'Date_StartLabel
        '
        Date_StartLabel.AutoSize = True
        Date_StartLabel.Location = New System.Drawing.Point(7, 150)
        Date_StartLabel.Name = "Date_StartLabel"
        Date_StartLabel.Size = New System.Drawing.Size(63, 21)
        Date_StartLabel.TabIndex = 5
        Date_StartLabel.Text = "Started:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.ForeColor = System.Drawing.Color.DarkGreen
        AmountLabel.Location = New System.Drawing.Point(36, 46)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(141, 21)
        AmountLabel.TabIndex = 7
        AmountLabel.Text = "Amount Borrowed:"
        '
        'Week_1Label
        '
        Week_1Label.AutoSize = True
        Week_1Label.Location = New System.Drawing.Point(48, 45)
        Week_1Label.Name = "Week_1Label"
        Week_1Label.Size = New System.Drawing.Size(65, 21)
        Week_1Label.TabIndex = 9
        Week_1Label.Text = "Week 1:"
        '
        'Week_2Label
        '
        Week_2Label.AutoSize = True
        Week_2Label.Location = New System.Drawing.Point(48, 84)
        Week_2Label.Name = "Week_2Label"
        Week_2Label.Size = New System.Drawing.Size(65, 21)
        Week_2Label.TabIndex = 11
        Week_2Label.Text = "Week 2:"
        '
        'Week_3Label
        '
        Week_3Label.AutoSize = True
        Week_3Label.Location = New System.Drawing.Point(48, 123)
        Week_3Label.Name = "Week_3Label"
        Week_3Label.Size = New System.Drawing.Size(65, 21)
        Week_3Label.TabIndex = 13
        Week_3Label.Text = "Week 3:"
        '
        'Week_4Label
        '
        Week_4Label.AutoSize = True
        Week_4Label.Location = New System.Drawing.Point(48, 163)
        Week_4Label.Name = "Week_4Label"
        Week_4Label.Size = New System.Drawing.Size(65, 21)
        Week_4Label.TabIndex = 15
        Week_4Label.Text = "Week 4:"
        '
        'Week_5Label
        '
        Week_5Label.AutoSize = True
        Week_5Label.Location = New System.Drawing.Point(48, 202)
        Week_5Label.Name = "Week_5Label"
        Week_5Label.Size = New System.Drawing.Size(65, 21)
        Week_5Label.TabIndex = 17
        Week_5Label.Text = "Week 5:"
        '
        'Week_6Label
        '
        Week_6Label.AutoSize = True
        Week_6Label.Location = New System.Drawing.Point(48, 247)
        Week_6Label.Name = "Week_6Label"
        Week_6Label.Size = New System.Drawing.Size(65, 21)
        Week_6Label.TabIndex = 19
        Week_6Label.Text = "Week 6:"
        '
        'Week_7Label
        '
        Week_7Label.AutoSize = True
        Week_7Label.Location = New System.Drawing.Point(48, 293)
        Week_7Label.Name = "Week_7Label"
        Week_7Label.Size = New System.Drawing.Size(65, 21)
        Week_7Label.TabIndex = 21
        Week_7Label.Text = "Week 7:"
        '
        'Week_8Label
        '
        Week_8Label.AutoSize = True
        Week_8Label.Location = New System.Drawing.Point(48, 338)
        Week_8Label.Name = "Week_8Label"
        Week_8Label.Size = New System.Drawing.Size(65, 21)
        Week_8Label.TabIndex = 23
        Week_8Label.Text = "Week 8:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(256, 140)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(56, 21)
        StatusLabel.TabIndex = 25
        StatusLabel.Text = "Status:"
        '
        'Amount_PaidLabel
        '
        Amount_PaidLabel.AutoSize = True
        Amount_PaidLabel.ForeColor = System.Drawing.Color.DarkGreen
        Amount_PaidLabel.Location = New System.Drawing.Point(184, 372)
        Amount_PaidLabel.Name = "Amount_PaidLabel"
        Amount_PaidLabel.Size = New System.Drawing.Size(141, 21)
        Amount_PaidLabel.TabIndex = 27
        Amount_PaidLabel.Text = "Total Amount Paid:"
        '
        'Remaining_BalanceLabel
        '
        Remaining_BalanceLabel.AutoSize = True
        Remaining_BalanceLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Remaining_BalanceLabel.ForeColor = System.Drawing.Color.Red
        Remaining_BalanceLabel.Location = New System.Drawing.Point(38, 94)
        Remaining_BalanceLabel.Name = "Remaining_BalanceLabel"
        Remaining_BalanceLabel.Size = New System.Drawing.Size(139, 21)
        Remaining_BalanceLabel.TabIndex = 29
        Remaining_BalanceLabel.Text = "Unsettled Amount:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.rbtUnPaid)
        Me.GroupBox1.Controls.Add(Me.rbtPaid)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Tb_lendingDataGridView)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1219, 914)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearch.FlatAppearance.BorderSize = 2
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(491, 501)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 38)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(73, 501)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(412, 38)
        Me.txtSearch.TabIndex = 12
        '
        'Tb_lendingDataGridView
        '
        Me.Tb_lendingDataGridView.AllowUserToAddRows = False
        Me.Tb_lendingDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Tb_lendingDataGridView.AutoGenerateColumns = False
        Me.Tb_lendingDataGridView.BackgroundColor = System.Drawing.Color.Azure
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tb_lendingDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Tb_lendingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_lendingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BorrowerNameDataGridViewTextBoxColumn, Me.DateStartDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.Week1DataGridViewTextBoxColumn, Me.Week2DataGridViewTextBoxColumn, Me.Week3DataGridViewTextBoxColumn, Me.Week4DataGridViewTextBoxColumn, Me.Week5DataGridViewTextBoxColumn, Me.Week6DataGridViewTextBoxColumn, Me.Week7DataGridViewTextBoxColumn, Me.Week8DataGridViewTextBoxColumn, Me.AmountPaidDataGridViewTextBoxColumn, Me.RemainingBalanceDataGridViewTextBoxColumn})
        Me.Tb_lendingDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Tb_lendingDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tb_lendingDataGridView.DataSource = Me.Tb_lendingBindingSource
        Me.Tb_lendingDataGridView.Location = New System.Drawing.Point(0, 577)
        Me.Tb_lendingDataGridView.Name = "Tb_lendingDataGridView"
        Me.Tb_lendingDataGridView.ReadOnly = True
        Me.Tb_lendingDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_lendingDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.Tb_lendingDataGridView.Size = New System.Drawing.Size(1219, 337)
        Me.Tb_lendingDataGridView.TabIndex = 18
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowerNameDataGridViewTextBoxColumn
        '
        Me.BorrowerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BorrowerNameDataGridViewTextBoxColumn.DataPropertyName = "Borrower_Name"
        Me.BorrowerNameDataGridViewTextBoxColumn.HeaderText = "Borrower"
        Me.BorrowerNameDataGridViewTextBoxColumn.Name = "BorrowerNameDataGridViewTextBoxColumn"
        Me.BorrowerNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateStartDataGridViewTextBoxColumn
        '
        Me.DateStartDataGridViewTextBoxColumn.DataPropertyName = "Date_Start"
        Me.DateStartDataGridViewTextBoxColumn.HeaderText = "Date_Start"
        Me.DateStartDataGridViewTextBoxColumn.Name = "DateStartDataGridViewTextBoxColumn"
        Me.DateStartDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateStartDataGridViewTextBoxColumn.Width = 150
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Yellow
        Me.AmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Week1DataGridViewTextBoxColumn
        '
        Me.Week1DataGridViewTextBoxColumn.DataPropertyName = "Week_1"
        Me.Week1DataGridViewTextBoxColumn.HeaderText = "W1"
        Me.Week1DataGridViewTextBoxColumn.Name = "Week1DataGridViewTextBoxColumn"
        Me.Week1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Week1DataGridViewTextBoxColumn.Width = 50
        '
        'Week2DataGridViewTextBoxColumn
        '
        Me.Week2DataGridViewTextBoxColumn.DataPropertyName = "Week_2"
        Me.Week2DataGridViewTextBoxColumn.HeaderText = "W2"
        Me.Week2DataGridViewTextBoxColumn.Name = "Week2DataGridViewTextBoxColumn"
        Me.Week2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Week2DataGridViewTextBoxColumn.Width = 50
        '
        'Week3DataGridViewTextBoxColumn
        '
        Me.Week3DataGridViewTextBoxColumn.DataPropertyName = "Week_3"
        Me.Week3DataGridViewTextBoxColumn.HeaderText = "W3"
        Me.Week3DataGridViewTextBoxColumn.Name = "Week3DataGridViewTextBoxColumn"
        Me.Week3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Week3DataGridViewTextBoxColumn.Width = 50
        '
        'Week4DataGridViewTextBoxColumn
        '
        Me.Week4DataGridViewTextBoxColumn.DataPropertyName = "Week_4"
        Me.Week4DataGridViewTextBoxColumn.HeaderText = "W4"
        Me.Week4DataGridViewTextBoxColumn.Name = "Week4DataGridViewTextBoxColumn"
        Me.Week4DataGridViewTextBoxColumn.ReadOnly = True
        Me.Week4DataGridViewTextBoxColumn.Width = 50
        '
        'Week5DataGridViewTextBoxColumn
        '
        Me.Week5DataGridViewTextBoxColumn.DataPropertyName = "Week_5"
        Me.Week5DataGridViewTextBoxColumn.HeaderText = "W5"
        Me.Week5DataGridViewTextBoxColumn.Name = "Week5DataGridViewTextBoxColumn"
        Me.Week5DataGridViewTextBoxColumn.ReadOnly = True
        Me.Week5DataGridViewTextBoxColumn.Width = 50
        '
        'Week6DataGridViewTextBoxColumn
        '
        Me.Week6DataGridViewTextBoxColumn.DataPropertyName = "Week_6"
        Me.Week6DataGridViewTextBoxColumn.HeaderText = "W6"
        Me.Week6DataGridViewTextBoxColumn.Name = "Week6DataGridViewTextBoxColumn"
        Me.Week6DataGridViewTextBoxColumn.ReadOnly = True
        Me.Week6DataGridViewTextBoxColumn.Width = 50
        '
        'Week7DataGridViewTextBoxColumn
        '
        Me.Week7DataGridViewTextBoxColumn.DataPropertyName = "Week_7"
        Me.Week7DataGridViewTextBoxColumn.HeaderText = "W7"
        Me.Week7DataGridViewTextBoxColumn.Name = "Week7DataGridViewTextBoxColumn"
        Me.Week7DataGridViewTextBoxColumn.ReadOnly = True
        Me.Week7DataGridViewTextBoxColumn.Width = 50
        '
        'Week8DataGridViewTextBoxColumn
        '
        Me.Week8DataGridViewTextBoxColumn.DataPropertyName = "Week_8"
        Me.Week8DataGridViewTextBoxColumn.HeaderText = "W8"
        Me.Week8DataGridViewTextBoxColumn.Name = "Week8DataGridViewTextBoxColumn"
        Me.Week8DataGridViewTextBoxColumn.ReadOnly = True
        Me.Week8DataGridViewTextBoxColumn.Width = 50
        '
        'AmountPaidDataGridViewTextBoxColumn
        '
        Me.AmountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_Paid"
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Lime
        Me.AmountPaidDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.AmountPaidDataGridViewTextBoxColumn.HeaderText = "Paid"
        Me.AmountPaidDataGridViewTextBoxColumn.Name = "AmountPaidDataGridViewTextBoxColumn"
        Me.AmountPaidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemainingBalanceDataGridViewTextBoxColumn
        '
        Me.RemainingBalanceDataGridViewTextBoxColumn.DataPropertyName = "Remaining_Balance"
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Yellow
        Me.RemainingBalanceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.RemainingBalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.RemainingBalanceDataGridViewTextBoxColumn.Name = "RemainingBalanceDataGridViewTextBoxColumn"
        Me.RemainingBalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.HelpToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(143, 70)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.HelpToolStripMenuItem.Text = "Payment List"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'Tb_lendingBindingSource
        '
        Me.Tb_lendingBindingSource.DataMember = "tb_lending"
        Me.Tb_lendingBindingSource.DataSource = Me.Business_recordDataSet
        '
        'Business_recordDataSet
        '
        Me.Business_recordDataSet.DataSetName = "business_recordDataSet"
        Me.Business_recordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.FlatAppearance.BorderSize = 2
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(994, 501)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 38)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(871, 501)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(103, 38)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(745, 501)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 38)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(620, 501)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 38)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.AmountTextBox)
        Me.GroupBox4.Controls.Add(Me.Remaining_BalanceTextBox)
        Me.GroupBox4.Controls.Add(Remaining_BalanceLabel)
        Me.GroupBox4.Controls.Add(AmountLabel)
        Me.GroupBox4.Controls.Add(Me.StatusTextBox)
        Me.GroupBox4.Controls.Add(StatusLabel)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(182, 267)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(429, 208)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Account"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(183, 39)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.ReadOnly = True
        Me.AmountTextBox.Size = New System.Drawing.Size(194, 28)
        Me.AmountTextBox.TabIndex = 3
        Me.AmountTextBox.Text = "0.00"
        '
        'Remaining_BalanceTextBox
        '
        Me.Remaining_BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Remaining_Balance", True))
        Me.Remaining_BalanceTextBox.Location = New System.Drawing.Point(183, 87)
        Me.Remaining_BalanceTextBox.Name = "Remaining_BalanceTextBox"
        Me.Remaining_BalanceTextBox.ReadOnly = True
        Me.Remaining_BalanceTextBox.Size = New System.Drawing.Size(194, 28)
        Me.Remaining_BalanceTextBox.TabIndex = 30
        Me.Remaining_BalanceTextBox.Text = "0.00"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(183, 164)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(194, 28)
        Me.StatusTextBox.TabIndex = 26
        Me.StatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.IDTextBox)
        Me.GroupBox3.Controls.Add(IDLabel)
        Me.GroupBox3.Controls.Add(Date_StartLabel)
        Me.GroupBox3.Controls.Add(Lender_NameLabel)
        Me.GroupBox3.Controls.Add(Me.Lender_NameTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(182, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(429, 210)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Information"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tb_lendingBindingSource, "Date_Start", True))
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(68, 143)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(311, 28)
        Me.DateTimePicker1.TabIndex = 2
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(68, 33)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(311, 28)
        Me.IDTextBox.TabIndex = 2
        '
        'Lender_NameTextBox
        '
        Me.Lender_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Borrower_Name", True))
        Me.Lender_NameTextBox.Location = New System.Drawing.Point(68, 84)
        Me.Lender_NameTextBox.Name = "Lender_NameTextBox"
        Me.Lender_NameTextBox.ReadOnly = True
        Me.Lender_NameTextBox.Size = New System.Drawing.Size(311, 28)
        Me.Lender_NameTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Week_1TextBox)
        Me.GroupBox2.Controls.Add(Me.Amount_PaidTextBox)
        Me.GroupBox2.Controls.Add(Amount_PaidLabel)
        Me.GroupBox2.Controls.Add(Me.Week_8TextBox)
        Me.GroupBox2.Controls.Add(Week_8Label)
        Me.GroupBox2.Controls.Add(Me.Week_7TextBox)
        Me.GroupBox2.Controls.Add(Week_7Label)
        Me.GroupBox2.Controls.Add(Me.Week_6TextBox)
        Me.GroupBox2.Controls.Add(Week_6Label)
        Me.GroupBox2.Controls.Add(Week_1Label)
        Me.GroupBox2.Controls.Add(Me.Week_5TextBox)
        Me.GroupBox2.Controls.Add(Week_5Label)
        Me.GroupBox2.Controls.Add(Week_2Label)
        Me.GroupBox2.Controls.Add(Me.Week_4TextBox)
        Me.GroupBox2.Controls.Add(Me.Week_2TextBox)
        Me.GroupBox2.Controls.Add(Week_4Label)
        Me.GroupBox2.Controls.Add(Week_3Label)
        Me.GroupBox2.Controls.Add(Me.Week_3TextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(635, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 440)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Weekly Payment"
        '
        'Week_1TextBox
        '
        Me.Week_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Week_1", True))
        Me.Week_1TextBox.Location = New System.Drawing.Point(119, 38)
        Me.Week_1TextBox.Name = "Week_1TextBox"
        Me.Week_1TextBox.ReadOnly = True
        Me.Week_1TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_1TextBox.TabIndex = 4
        Me.Week_1TextBox.Text = "0.00"
        '
        'Amount_PaidTextBox
        '
        Me.Amount_PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Amount_Paid", True))
        Me.Amount_PaidTextBox.Location = New System.Drawing.Point(119, 396)
        Me.Amount_PaidTextBox.Name = "Amount_PaidTextBox"
        Me.Amount_PaidTextBox.ReadOnly = True
        Me.Amount_PaidTextBox.Size = New System.Drawing.Size(252, 28)
        Me.Amount_PaidTextBox.TabIndex = 28
        Me.Amount_PaidTextBox.Text = "0.00"
        '
        'Week_8TextBox
        '
        Me.Week_8TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Week_8", True))
        Me.Week_8TextBox.Location = New System.Drawing.Point(119, 331)
        Me.Week_8TextBox.Name = "Week_8TextBox"
        Me.Week_8TextBox.ReadOnly = True
        Me.Week_8TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_8TextBox.TabIndex = 11
        Me.Week_8TextBox.Text = "0.00"
        '
        'Week_7TextBox
        '
        Me.Week_7TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Week_7", True))
        Me.Week_7TextBox.Location = New System.Drawing.Point(119, 286)
        Me.Week_7TextBox.Name = "Week_7TextBox"
        Me.Week_7TextBox.ReadOnly = True
        Me.Week_7TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_7TextBox.TabIndex = 10
        Me.Week_7TextBox.Text = "0.00"
        '
        'Week_6TextBox
        '
        Me.Week_6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Week_6", True))
        Me.Week_6TextBox.Location = New System.Drawing.Point(119, 240)
        Me.Week_6TextBox.Name = "Week_6TextBox"
        Me.Week_6TextBox.ReadOnly = True
        Me.Week_6TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_6TextBox.TabIndex = 9
        Me.Week_6TextBox.Text = "0.00"
        '
        'Week_5TextBox
        '
        Me.Week_5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Week_5", True))
        Me.Week_5TextBox.Location = New System.Drawing.Point(119, 195)
        Me.Week_5TextBox.Name = "Week_5TextBox"
        Me.Week_5TextBox.ReadOnly = True
        Me.Week_5TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_5TextBox.TabIndex = 8
        Me.Week_5TextBox.Text = "0.00"
        '
        'Week_4TextBox
        '
        Me.Week_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Week_4", True))
        Me.Week_4TextBox.Location = New System.Drawing.Point(119, 156)
        Me.Week_4TextBox.Name = "Week_4TextBox"
        Me.Week_4TextBox.ReadOnly = True
        Me.Week_4TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_4TextBox.TabIndex = 7
        Me.Week_4TextBox.Text = "0.00"
        '
        'Week_2TextBox
        '
        Me.Week_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Week_2", True))
        Me.Week_2TextBox.Location = New System.Drawing.Point(119, 77)
        Me.Week_2TextBox.Name = "Week_2TextBox"
        Me.Week_2TextBox.ReadOnly = True
        Me.Week_2TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_2TextBox.TabIndex = 5
        Me.Week_2TextBox.Text = "0.00"
        '
        'Week_3TextBox
        '
        Me.Week_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_lendingBindingSource, "Week_3", True))
        Me.Week_3TextBox.Location = New System.Drawing.Point(119, 116)
        Me.Week_3TextBox.Name = "Week_3TextBox"
        Me.Week_3TextBox.ReadOnly = True
        Me.Week_3TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_3TextBox.TabIndex = 6
        Me.Week_3TextBox.Text = "0.00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Tb_lendingTableAdapter
        '
        Me.Tb_lendingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_chickensTableAdapter = Nothing
        Me.TableAdapterManager.tb_lendingTableAdapter = Me.Tb_lendingTableAdapter
        Me.TableAdapterManager.tb_riceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Business_App.business_recordDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(269, 546)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(20, 23)
        Me.lblTotal.TabIndex = 57
        Me.lblTotal.Text = "0"
        '
        'rbtUnPaid
        '
        Me.rbtUnPaid.AutoSize = True
        Me.rbtUnPaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtUnPaid.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtUnPaid.Location = New System.Drawing.Point(160, 544)
        Me.rbtUnPaid.Name = "rbtUnPaid"
        Me.rbtUnPaid.Size = New System.Drawing.Size(108, 27)
        Me.rbtUnPaid.TabIndex = 55
        Me.rbtUnPaid.TabStop = True
        Me.rbtUnPaid.Text = "Unsettled"
        Me.rbtUnPaid.UseVisualStyleBackColor = True
        '
        'rbtPaid
        '
        Me.rbtPaid.AutoSize = True
        Me.rbtPaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtPaid.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtPaid.Location = New System.Drawing.Point(73, 544)
        Me.rbtPaid.Name = "rbtPaid"
        Me.rbtPaid.Size = New System.Drawing.Size(86, 27)
        Me.rbtPaid.TabIndex = 56
        Me.rbtPaid.TabStop = True
        Me.rbtPaid.Text = "Settled"
        Me.rbtPaid.UseVisualStyleBackColor = True
        '
        'frm_lending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1238, 938)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_lending"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Money Lending"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tb_lendingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Tb_lendingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Business_recordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Week_1TextBox As TextBox
    Friend WithEvents Amount_PaidTextBox As TextBox
    Friend WithEvents Week_8TextBox As TextBox
    Friend WithEvents Week_7TextBox As TextBox
    Friend WithEvents Week_6TextBox As TextBox
    Friend WithEvents Week_5TextBox As TextBox
    Friend WithEvents Week_4TextBox As TextBox
    Friend WithEvents Week_2TextBox As TextBox
    Friend WithEvents Week_3TextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Lender_NameTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents Remaining_BalanceTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Tb_lendingDataGridView As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Business_recordDataSet As business_recordDataSet
    Friend WithEvents Tb_lendingBindingSource As BindingSource
    Friend WithEvents Tb_lendingTableAdapter As business_recordDataSetTableAdapters.tb_lendingTableAdapter
    Friend WithEvents TableAdapterManager As business_recordDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateStartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Week1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Week2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Week3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Week4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Week5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Week6DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Week7DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Week8DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountPaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemainingBalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblTotal As Label
    Friend WithEvents rbtUnPaid As RadioButton
    Friend WithEvents rbtPaid As RadioButton
End Class
