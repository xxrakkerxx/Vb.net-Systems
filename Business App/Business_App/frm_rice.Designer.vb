<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Remaining_BalanceLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Date_StartLabel As System.Windows.Forms.Label
        Dim Lender_NameLabel As System.Windows.Forms.Label
        Dim Amount_PaidLabel As System.Windows.Forms.Label
        Dim Week_1Label As System.Windows.Forms.Label
        Dim Week_2Label As System.Windows.Forms.Label
        Dim Week_4Label As System.Windows.Forms.Label
        Dim Week_3Label As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Tb_lendingDataGridView = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tb_riceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Business_recordDataSet = New Business_App.business_recordDataSet()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.DescriptionTextbox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Week_1TextBox = New System.Windows.Forms.TextBox()
        Me.Remaining_BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_PaidTextBox = New System.Windows.Forms.TextBox()
        Me.Week_4TextBox = New System.Windows.Forms.TextBox()
        Me.Week_2TextBox = New System.Windows.Forms.TextBox()
        Me.Week_3TextBox = New System.Windows.Forms.TextBox()
        Me.Tb_riceTableAdapter = New Business_App.business_recordDataSetTableAdapters.tb_riceTableAdapter()
        Me.TableAdapterManager = New Business_App.business_recordDataSetTableAdapters.TableAdapterManager()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.W1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.W2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.W3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.W4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Remaining_BalanceLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Date_StartLabel = New System.Windows.Forms.Label()
        Lender_NameLabel = New System.Windows.Forms.Label()
        Amount_PaidLabel = New System.Windows.Forms.Label()
        Week_1Label = New System.Windows.Forms.Label()
        Week_2Label = New System.Windows.Forms.Label()
        Week_4Label = New System.Windows.Forms.Label()
        Week_3Label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tb_lendingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Tb_riceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Business_recordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Remaining_BalanceLabel
        '
        Remaining_BalanceLabel.AutoSize = True
        Remaining_BalanceLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Remaining_BalanceLabel.ForeColor = System.Drawing.Color.Red
        Remaining_BalanceLabel.Location = New System.Drawing.Point(178, 295)
        Remaining_BalanceLabel.Name = "Remaining_BalanceLabel"
        Remaining_BalanceLabel.Size = New System.Drawing.Size(145, 21)
        Remaining_BalanceLabel.TabIndex = 29
        Remaining_BalanceLabel.Text = "Remaining Balance:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.ForeColor = System.Drawing.Color.DarkGreen
        AmountLabel.Location = New System.Drawing.Point(52, 46)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(125, 21)
        AmountLabel.TabIndex = 7
        AmountLabel.Text = "Rice Description:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(256, 136)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(56, 21)
        StatusLabel.TabIndex = 25
        StatusLabel.Text = "Status:"
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
        'Date_StartLabel
        '
        Date_StartLabel.AutoSize = True
        Date_StartLabel.Location = New System.Drawing.Point(7, 150)
        Date_StartLabel.Name = "Date_StartLabel"
        Date_StartLabel.Size = New System.Drawing.Size(63, 21)
        Date_StartLabel.TabIndex = 5
        Date_StartLabel.Text = "Started:"
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
        'Amount_PaidLabel
        '
        Amount_PaidLabel.AutoSize = True
        Amount_PaidLabel.ForeColor = System.Drawing.Color.DarkGreen
        Amount_PaidLabel.Location = New System.Drawing.Point(182, 208)
        Amount_PaidLabel.Name = "Amount_PaidLabel"
        Amount_PaidLabel.Size = New System.Drawing.Size(141, 21)
        Amount_PaidLabel.TabIndex = 27
        Amount_PaidLabel.Text = "Total Amount Paid:"
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
        'Week_4Label
        '
        Week_4Label.AutoSize = True
        Week_4Label.Location = New System.Drawing.Point(48, 163)
        Week_4Label.Name = "Week_4Label"
        Week_4Label.Size = New System.Drawing.Size(65, 21)
        Week_4Label.TabIndex = 15
        Week_4Label.Text = "Week 4:"
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
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.Color.DarkGreen
        Label1.Location = New System.Drawing.Point(70, 87)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(107, 21)
        Label1.TabIndex = 7
        Label1.Text = "Total Amount:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HighlightText
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
        Me.GroupBox1.Size = New System.Drawing.Size(1219, 923)
        Me.GroupBox1.TabIndex = 2
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tb_lendingDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tb_lendingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_lendingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PurchaserDataGridViewTextBoxColumn, Me.DateStartDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.W1DataGridViewTextBoxColumn, Me.W2DataGridViewTextBoxColumn, Me.W3DataGridViewTextBoxColumn, Me.W4DataGridViewTextBoxColumn, Me.PaidDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.Tb_lendingDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Tb_lendingDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tb_lendingDataGridView.DataSource = Me.Tb_riceBindingSource
        Me.Tb_lendingDataGridView.Location = New System.Drawing.Point(0, 569)
        Me.Tb_lendingDataGridView.Name = "Tb_lendingDataGridView"
        Me.Tb_lendingDataGridView.ReadOnly = True
        Me.Tb_lendingDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_lendingDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Tb_lendingDataGridView.Size = New System.Drawing.Size(1219, 354)
        Me.Tb_lendingDataGridView.TabIndex = 18
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.PaymentListToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(143, 70)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'PaymentListToolStripMenuItem
        '
        Me.PaymentListToolStripMenuItem.Name = "PaymentListToolStripMenuItem"
        Me.PaymentListToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.PaymentListToolStripMenuItem.Text = "Payment List"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Tb_riceBindingSource
        '
        Me.Tb_riceBindingSource.DataMember = "tb_rice"
        Me.Tb_riceBindingSource.DataSource = Me.Business_recordDataSet
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
        Me.GroupBox4.Controls.Add(Me.txtAmount)
        Me.GroupBox4.Controls.Add(Me.DescriptionTextbox)
        Me.GroupBox4.Controls.Add(Label1)
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
        'txtAmount
        '
        Me.txtAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_riceBindingSource, "Amount", True))
        Me.txtAmount.Location = New System.Drawing.Point(183, 80)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(194, 28)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.Text = "1,200"
        '
        'DescriptionTextbox
        '
        Me.DescriptionTextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_riceBindingSource, "Description", True))
        Me.DescriptionTextbox.Location = New System.Drawing.Point(183, 39)
        Me.DescriptionTextbox.Name = "DescriptionTextbox"
        Me.DescriptionTextbox.ReadOnly = True
        Me.DescriptionTextbox.Size = New System.Drawing.Size(194, 28)
        Me.DescriptionTextbox.TabIndex = 3
        Me.DescriptionTextbox.Text = "25kg"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_riceBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(183, 160)
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
        Me.GroupBox3.Controls.Add(Me.txtName)
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
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tb_riceBindingSource, "Date_Start", True))
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(68, 143)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(311, 28)
        Me.DateTimePicker1.TabIndex = 2
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_riceBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(68, 33)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(311, 28)
        Me.IDTextBox.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_riceBindingSource, "Purchaser", True))
        Me.txtName.Location = New System.Drawing.Point(68, 84)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(311, 28)
        Me.txtName.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Week_1TextBox)
        Me.GroupBox2.Controls.Add(Me.Remaining_BalanceTextBox)
        Me.GroupBox2.Controls.Add(Remaining_BalanceLabel)
        Me.GroupBox2.Controls.Add(Me.Amount_PaidTextBox)
        Me.GroupBox2.Controls.Add(Amount_PaidLabel)
        Me.GroupBox2.Controls.Add(Week_1Label)
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
        Me.Week_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_riceBindingSource, "W1", True))
        Me.Week_1TextBox.Location = New System.Drawing.Point(119, 38)
        Me.Week_1TextBox.Name = "Week_1TextBox"
        Me.Week_1TextBox.ReadOnly = True
        Me.Week_1TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_1TextBox.TabIndex = 4
        Me.Week_1TextBox.Text = "0.00"
        '
        'Remaining_BalanceTextBox
        '
        Me.Remaining_BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_riceBindingSource, "Balance", True))
        Me.Remaining_BalanceTextBox.Location = New System.Drawing.Point(119, 319)
        Me.Remaining_BalanceTextBox.Name = "Remaining_BalanceTextBox"
        Me.Remaining_BalanceTextBox.ReadOnly = True
        Me.Remaining_BalanceTextBox.Size = New System.Drawing.Size(252, 28)
        Me.Remaining_BalanceTextBox.TabIndex = 30
        Me.Remaining_BalanceTextBox.Text = "0.00"
        '
        'Amount_PaidTextBox
        '
        Me.Amount_PaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_riceBindingSource, "Paid", True))
        Me.Amount_PaidTextBox.Location = New System.Drawing.Point(119, 232)
        Me.Amount_PaidTextBox.Name = "Amount_PaidTextBox"
        Me.Amount_PaidTextBox.ReadOnly = True
        Me.Amount_PaidTextBox.Size = New System.Drawing.Size(252, 28)
        Me.Amount_PaidTextBox.TabIndex = 28
        Me.Amount_PaidTextBox.Text = "0.00"
        '
        'Week_4TextBox
        '
        Me.Week_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_riceBindingSource, "W4", True))
        Me.Week_4TextBox.Location = New System.Drawing.Point(119, 156)
        Me.Week_4TextBox.Name = "Week_4TextBox"
        Me.Week_4TextBox.ReadOnly = True
        Me.Week_4TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_4TextBox.TabIndex = 7
        Me.Week_4TextBox.Text = "0.00"
        '
        'Week_2TextBox
        '
        Me.Week_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_riceBindingSource, "W2", True))
        Me.Week_2TextBox.Location = New System.Drawing.Point(119, 77)
        Me.Week_2TextBox.Name = "Week_2TextBox"
        Me.Week_2TextBox.ReadOnly = True
        Me.Week_2TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_2TextBox.TabIndex = 5
        Me.Week_2TextBox.Text = "0.00"
        '
        'Week_3TextBox
        '
        Me.Week_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_riceBindingSource, "W3", True))
        Me.Week_3TextBox.Location = New System.Drawing.Point(119, 116)
        Me.Week_3TextBox.Name = "Week_3TextBox"
        Me.Week_3TextBox.ReadOnly = True
        Me.Week_3TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_3TextBox.TabIndex = 6
        Me.Week_3TextBox.Text = "0.00"
        '
        'Tb_riceTableAdapter
        '
        Me.Tb_riceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_chickensTableAdapter = Nothing
        Me.TableAdapterManager.tb_lendingTableAdapter = Nothing
        Me.TableAdapterManager.tb_riceTableAdapter = Me.Tb_riceTableAdapter
        Me.TableAdapterManager.UpdateOrder = Business_App.business_recordDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PurchaserDataGridViewTextBoxColumn
        '
        Me.PurchaserDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PurchaserDataGridViewTextBoxColumn.DataPropertyName = "Purchaser"
        Me.PurchaserDataGridViewTextBoxColumn.HeaderText = "Purchaser"
        Me.PurchaserDataGridViewTextBoxColumn.Name = "PurchaserDataGridViewTextBoxColumn"
        Me.PurchaserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateStartDataGridViewTextBoxColumn
        '
        Me.DateStartDataGridViewTextBoxColumn.DataPropertyName = "Date_Start"
        Me.DateStartDataGridViewTextBoxColumn.HeaderText = "Date_Start"
        Me.DateStartDataGridViewTextBoxColumn.Name = "DateStartDataGridViewTextBoxColumn"
        Me.DateStartDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'W1DataGridViewTextBoxColumn
        '
        Me.W1DataGridViewTextBoxColumn.DataPropertyName = "W1"
        Me.W1DataGridViewTextBoxColumn.HeaderText = "W1"
        Me.W1DataGridViewTextBoxColumn.Name = "W1DataGridViewTextBoxColumn"
        Me.W1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'W2DataGridViewTextBoxColumn
        '
        Me.W2DataGridViewTextBoxColumn.DataPropertyName = "W2"
        Me.W2DataGridViewTextBoxColumn.HeaderText = "W2"
        Me.W2DataGridViewTextBoxColumn.Name = "W2DataGridViewTextBoxColumn"
        Me.W2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'W3DataGridViewTextBoxColumn
        '
        Me.W3DataGridViewTextBoxColumn.DataPropertyName = "W3"
        Me.W3DataGridViewTextBoxColumn.HeaderText = "W3"
        Me.W3DataGridViewTextBoxColumn.Name = "W3DataGridViewTextBoxColumn"
        Me.W3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'W4DataGridViewTextBoxColumn
        '
        Me.W4DataGridViewTextBoxColumn.DataPropertyName = "W4"
        Me.W4DataGridViewTextBoxColumn.HeaderText = "W4"
        Me.W4DataGridViewTextBoxColumn.Name = "W4DataGridViewTextBoxColumn"
        Me.W4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaidDataGridViewTextBoxColumn
        '
        Me.PaidDataGridViewTextBoxColumn.DataPropertyName = "Paid"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chartreuse
        Me.PaidDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PaidDataGridViewTextBoxColumn.HeaderText = "Paid"
        Me.PaidDataGridViewTextBoxColumn.Name = "PaidDataGridViewTextBoxColumn"
        Me.PaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaidDataGridViewTextBoxColumn.ToolTipText = "Amount Already Paid"
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow
        Me.BalanceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.BalanceDataGridViewTextBoxColumn.ToolTipText = "Remaining Balance To Pay"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frm_rice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1232, 938)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_rice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rice Logger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tb_lendingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Tb_riceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Business_recordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Tb_lendingDataGridView As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DescriptionTextbox As TextBox
    Friend WithEvents Remaining_BalanceTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Week_1TextBox As TextBox
    Friend WithEvents Amount_PaidTextBox As TextBox
    Friend WithEvents Week_4TextBox As TextBox
    Friend WithEvents Week_2TextBox As TextBox
    Friend WithEvents Week_3TextBox As TextBox
    Friend WithEvents Business_recordDataSet As business_recordDataSet
    Friend WithEvents Tb_riceBindingSource As BindingSource
    Friend WithEvents Tb_riceTableAdapter As business_recordDataSetTableAdapters.tb_riceTableAdapter
    Friend WithEvents TableAdapterManager As business_recordDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateStartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents W1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents W2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents W3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents W4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
