<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim PurchaserLabel As System.Windows.Forms.Label
        Dim QTYLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RemarksLabel = New System.Windows.Forms.Label()
        Me.Business_recordDataSet = New Business_App.business_recordDataSet()
        Me.Tb_chickensBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_chickensTableAdapter = New Business_App.business_recordDataSetTableAdapters.tb_chickensTableAdapter()
        Me.TableAdapterManager = New Business_App.business_recordDataSetTableAdapters.TableAdapterManager()
        Me.Tb_chickensDataGridView = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.PurchaserTextBox = New System.Windows.Forms.TextBox()
        Me.QTYTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.cboMark = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPaid = New System.Windows.Forms.Button()
        Me.btnUnpaid = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblUnPaid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalyticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesVisualizationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PaymentsVisualizationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MonthlyCalculationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalyzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnPaidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LendingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataInputsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.AuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.FixesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.HowToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        PurchaserLabel = New System.Windows.Forms.Label()
        QTYLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        CType(Me.Business_recordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_chickensBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_chickensDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(25, 128)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(114, 23)
        IDLabel.TabIndex = 2
        IDLabel.Text = "Purchase ID:"
        '
        'PurchaserLabel
        '
        PurchaserLabel.AutoSize = True
        PurchaserLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurchaserLabel.Location = New System.Drawing.Point(41, 178)
        PurchaserLabel.Name = "PurchaserLabel"
        PurchaserLabel.Size = New System.Drawing.Size(98, 23)
        PurchaserLabel.TabIndex = 4
        PurchaserLabel.Text = "Purchaser:"
        '
        'QTYLabel
        '
        QTYLabel.AutoSize = True
        QTYLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QTYLabel.Location = New System.Drawing.Point(90, 249)
        QTYLabel.Name = "QTYLabel"
        QTYLabel.Size = New System.Drawing.Size(49, 23)
        QTYLabel.TabIndex = 6
        QTYLabel.Text = "QTY:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountLabel.Location = New System.Drawing.Point(58, 295)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(81, 23)
        AmountLabel.TabIndex = 8
        AmountLabel.Text = "Amount:"
        '
        'RemarksLabel
        '
        Me.RemarksLabel.AutoSize = True
        Me.RemarksLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarksLabel.Location = New System.Drawing.Point(54, 344)
        Me.RemarksLabel.Name = "RemarksLabel"
        Me.RemarksLabel.Size = New System.Drawing.Size(85, 23)
        Me.RemarksLabel.TabIndex = 12
        Me.RemarksLabel.Text = "Remarks:"
        '
        'Business_recordDataSet
        '
        Me.Business_recordDataSet.DataSetName = "business_recordDataSet"
        Me.Business_recordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_chickensBindingSource
        '
        Me.Tb_chickensBindingSource.DataMember = "tb_chickens"
        Me.Tb_chickensBindingSource.DataSource = Me.Business_recordDataSet
        '
        'Tb_chickensTableAdapter
        '
        Me.Tb_chickensTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_chickensTableAdapter = Me.Tb_chickensTableAdapter
        Me.TableAdapterManager.tb_lendingTableAdapter = Nothing
        Me.TableAdapterManager.tb_riceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Business_App.business_recordDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_chickensDataGridView
        '
        Me.Tb_chickensDataGridView.AllowUserToAddRows = False
        Me.Tb_chickensDataGridView.AllowUserToOrderColumns = True
        Me.Tb_chickensDataGridView.AllowUserToResizeRows = False
        Me.Tb_chickensDataGridView.AutoGenerateColumns = False
        Me.Tb_chickensDataGridView.BackgroundColor = System.Drawing.Color.Azure
        Me.Tb_chickensDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_chickensDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Tb_chickensDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Tb_chickensDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tb_chickensDataGridView.DataSource = Me.Tb_chickensBindingSource
        Me.Tb_chickensDataGridView.Location = New System.Drawing.Point(19, 385)
        Me.Tb_chickensDataGridView.Name = "Tb_chickensDataGridView"
        Me.Tb_chickensDataGridView.ReadOnly = True
        Me.Tb_chickensDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Tb_chickensDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_chickensDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Tb_chickensDataGridView.Size = New System.Drawing.Size(753, 241)
        Me.Tb_chickensDataGridView.TabIndex = 10
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ViewHistoryToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 70)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ViewHistoryToolStripMenuItem
        '
        Me.ViewHistoryToolStripMenuItem.Name = "ViewHistoryToolStripMenuItem"
        Me.ViewHistoryToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ViewHistoryToolStripMenuItem.Text = "See History"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_chickensBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(145, 119)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(280, 32)
        Me.IDTextBox.TabIndex = 20
        '
        'PurchaserTextBox
        '
        Me.PurchaserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_chickensBindingSource, "Purchaser", True))
        Me.PurchaserTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaserTextBox.Location = New System.Drawing.Point(145, 169)
        Me.PurchaserTextBox.Name = "PurchaserTextBox"
        Me.PurchaserTextBox.ReadOnly = True
        Me.PurchaserTextBox.Size = New System.Drawing.Size(280, 32)
        Me.PurchaserTextBox.TabIndex = 2
        '
        'QTYTextBox
        '
        Me.QTYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_chickensBindingSource, "QTY", True))
        Me.QTYTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTYTextBox.Location = New System.Drawing.Point(145, 240)
        Me.QTYTextBox.Name = "QTYTextBox"
        Me.QTYTextBox.ReadOnly = True
        Me.QTYTextBox.Size = New System.Drawing.Size(140, 32)
        Me.QTYTextBox.TabIndex = 3
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_chickensBindingSource, "Amount", True))
        Me.AmountTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(145, 286)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.ReadOnly = True
        Me.AmountTextBox.Size = New System.Drawing.Size(280, 32)
        Me.AmountTextBox.TabIndex = 5
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_chickensBindingSource, "Remarks", True))
        Me.RemarksTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarksTextBox.Location = New System.Drawing.Point(145, 335)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.ReadOnly = True
        Me.RemarksTextBox.Size = New System.Drawing.Size(280, 32)
        Me.RemarksTextBox.TabIndex = 20
        Me.RemarksTextBox.TabStop = False
        Me.RemarksTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnAdd.Location = New System.Drawing.Point(60, 43)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 34)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Enabled = False
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnSave.Location = New System.Drawing.Point(183, 43)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 34)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Transparent
        Me.btnDel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnDel.FlatAppearance.BorderSize = 2
        Me.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnDel.Location = New System.Drawing.Point(60, 93)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(83, 34)
        Me.btnDel.TabIndex = 8
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'cboMark
        '
        Me.cboMark.Enabled = False
        Me.cboMark.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMark.FormattingEnabled = True
        Me.cboMark.Items.AddRange(New Object() {"UnPaid", "Paid"})
        Me.cboMark.Location = New System.Drawing.Point(304, 240)
        Me.cboMark.Name = "cboMark"
        Me.cboMark.Size = New System.Drawing.Size(121, 31)
        Me.cboMark.TabIndex = 4
        Me.cboMark.Text = "Select"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnUp)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnDel)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(442, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 189)
        Me.Panel1.TabIndex = 17
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.Transparent
        Me.btnUp.FlatAppearance.BorderSize = 2
        Me.btnUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnUp.Location = New System.Drawing.Point(183, 92)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(83, 35)
        Me.btnUp.TabIndex = 9
        Me.btnUp.Text = "Update"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Controls.Add(Me.btnPaid)
        Me.GroupBox1.Controls.Add(Me.btnUnpaid)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.lblPaid)
        Me.GroupBox1.Controls.Add(Me.lblUnPaid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Controls.Add(Me.Tb_chickensDataGridView)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.cboMark)
        Me.GroupBox1.Controls.Add(Me.RemarksTextBox)
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.RemarksLabel)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Controls.Add(PurchaserLabel)
        Me.GroupBox1.Controls.Add(Me.AmountTextBox)
        Me.GroupBox1.Controls.Add(Me.PurchaserTextBox)
        Me.GroupBox1.Controls.Add(AmountLabel)
        Me.GroupBox1.Controls.Add(QTYLabel)
        Me.GroupBox1.Controls.Add(Me.QTYTextBox)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(15, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 643)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'btnPaid
        '
        Me.btnPaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPaid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPaid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaid.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaid.Location = New System.Drawing.Point(6, 57)
        Me.btnPaid.Name = "btnPaid"
        Me.btnPaid.Size = New System.Drawing.Size(48, 24)
        Me.btnPaid.TabIndex = 12
        Me.btnPaid.Text = "View"
        Me.btnPaid.UseVisualStyleBackColor = True
        '
        'btnUnpaid
        '
        Me.btnUnpaid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnpaid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUnpaid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnUnpaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnpaid.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnpaid.Location = New System.Drawing.Point(6, 30)
        Me.btnUnpaid.Name = "btnUnpaid"
        Me.btnUnpaid.Size = New System.Drawing.Size(48, 24)
        Me.btnUnpaid.TabIndex = 11
        Me.btnUnpaid.Text = "View"
        Me.btnUnpaid.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_chickensBindingSource, "Date_Purchase", True))
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(442, 119)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(330, 32)
        Me.DateTimePicker1.TabIndex = 1
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaid.Location = New System.Drawing.Point(131, 59)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(20, 23)
        Me.lblPaid.TabIndex = 52
        Me.lblPaid.Text = "0"
        '
        'lblUnPaid
        '
        Me.lblUnPaid.AutoSize = True
        Me.lblUnPaid.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnPaid.Location = New System.Drawing.Point(131, 31)
        Me.lblUnPaid.Name = "lblUnPaid"
        Me.lblUnPaid.Size = New System.Drawing.Size(20, 23)
        Me.lblUnPaid.TabIndex = 52
        Me.lblUnPaid.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(58, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "UnPaid:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(82, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 23)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Paid:"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 2
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(683, 57)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(89, 35)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(265, 58)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(412, 34)
        Me.txtsearch.TabIndex = 13
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AnalyticsToolStripMenuItem, Me.DatabaseToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(843, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ToolStripSeparator6, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator7, Me.PrintToolStripMenuItem, Me.ToolStripSeparator8, Me.RestartToolStripMenuItem, Me.ToolStripSeparator9, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(111, 6)
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(111, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(111, 6)
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(111, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'AnalyticsToolStripMenuItem
        '
        Me.AnalyticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesVisualizationToolStripMenuItem, Me.ToolStripSeparator4, Me.PaymentsVisualizationToolStripMenuItem, Me.ToolStripSeparator5, Me.MonthlyCalculationsToolStripMenuItem})
        Me.AnalyticsToolStripMenuItem.Name = "AnalyticsToolStripMenuItem"
        Me.AnalyticsToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AnalyticsToolStripMenuItem.Text = "Analytics"
        '
        'SalesVisualizationToolStripMenuItem
        '
        Me.SalesVisualizationToolStripMenuItem.Name = "SalesVisualizationToolStripMenuItem"
        Me.SalesVisualizationToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SalesVisualizationToolStripMenuItem.Text = "Sales Visualization"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(192, 6)
        '
        'PaymentsVisualizationToolStripMenuItem
        '
        Me.PaymentsVisualizationToolStripMenuItem.Name = "PaymentsVisualizationToolStripMenuItem"
        Me.PaymentsVisualizationToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PaymentsVisualizationToolStripMenuItem.Text = "Payments Visualization"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(192, 6)
        '
        'MonthlyCalculationsToolStripMenuItem
        '
        Me.MonthlyCalculationsToolStripMenuItem.Name = "MonthlyCalculationsToolStripMenuItem"
        Me.MonthlyCalculationsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.MonthlyCalculationsToolStripMenuItem.Text = "Monthly Calculations"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnalyzeToolStripMenuItem, Me.ToolStripSeparator1, Me.LendingToolStripMenuItem, Me.ToolStripSeparator2, Me.LendingToolStripMenuItem1, Me.ToolStripSeparator3, Me.DataInputsToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'AnalyzeToolStripMenuItem
        '
        Me.AnalyzeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaidToolStripMenuItem, Me.UnPaidToolStripMenuItem, Me.ErrorsToolStripMenuItem})
        Me.AnalyzeToolStripMenuItem.Name = "AnalyzeToolStripMenuItem"
        Me.AnalyzeToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AnalyzeToolStripMenuItem.Text = "Analyze"
        '
        'PaidToolStripMenuItem
        '
        Me.PaidToolStripMenuItem.Name = "PaidToolStripMenuItem"
        Me.PaidToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.PaidToolStripMenuItem.Text = "Paid"
        '
        'UnPaidToolStripMenuItem
        '
        Me.UnPaidToolStripMenuItem.Name = "UnPaidToolStripMenuItem"
        Me.UnPaidToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UnPaidToolStripMenuItem.Text = "UnPaid"
        '
        'ErrorsToolStripMenuItem
        '
        Me.ErrorsToolStripMenuItem.Name = "ErrorsToolStripMenuItem"
        Me.ErrorsToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ErrorsToolStripMenuItem.Text = "Errors"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(131, 6)
        '
        'LendingToolStripMenuItem
        '
        Me.LendingToolStripMenuItem.Name = "LendingToolStripMenuItem"
        Me.LendingToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LendingToolStripMenuItem.Text = "Rice"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(131, 6)
        '
        'LendingToolStripMenuItem1
        '
        Me.LendingToolStripMenuItem1.Name = "LendingToolStripMenuItem1"
        Me.LendingToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.LendingToolStripMenuItem1.Text = "Lending"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(131, 6)
        '
        'DataInputsToolStripMenuItem
        '
        Me.DataInputsToolStripMenuItem.Name = "DataInputsToolStripMenuItem"
        Me.DataInputsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DataInputsToolStripMenuItem.Text = "Data Inputs"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionToolStripMenuItem, Me.ToolStripSeparator10, Me.AuthorToolStripMenuItem, Me.ToolStripSeparator11, Me.FixesToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.VersionToolStripMenuItem.Text = "Version"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(109, 6)
        '
        'AuthorToolStripMenuItem
        '
        Me.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem"
        Me.AuthorToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.AuthorToolStripMenuItem.Text = "Author"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(109, 6)
        '
        'FixesToolStripMenuItem
        '
        Me.FixesToolStripMenuItem.Name = "FixesToolStripMenuItem"
        Me.FixesToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.FixesToolStripMenuItem.Text = "Fixes"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator12, Me.HowToToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(153, 6)
        '
        'HowToToolStripMenuItem
        '
        Me.HowToToolStripMenuItem.Name = "HowToToolStripMenuItem"
        Me.HowToToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.HowToToolStripMenuItem.Text = "Help Dictionary"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Purchaser"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Name of Purchaser"
        Me.DataGridViewTextBoxColumn2.Width = 91
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "QTY"
        Me.DataGridViewTextBoxColumn3.HeaderText = "QTY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Amount"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 107
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Date_Purchase"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chartreuse
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date_Purchase"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 175
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Remarks"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(843, 702)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Business App"
        CType(Me.Business_recordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_chickensBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_chickensDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Business_recordDataSet As business_recordDataSet
    Friend WithEvents Tb_chickensBindingSource As BindingSource
    Friend WithEvents Tb_chickensTableAdapter As business_recordDataSetTableAdapters.tb_chickensTableAdapter
    Friend WithEvents TableAdapterManager As business_recordDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_chickensDataGridView As DataGridView
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents PurchaserTextBox As TextBox
    Friend WithEvents QTYTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents RemarksTextBox As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents cboMark As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnUp As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RemarksLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnalyticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesVisualizationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentsVisualizationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnalyzeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaidToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnPaidToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LendingToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuthorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FixesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents MonthlyCalculationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DataInputsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents lblPaid As Label
    Friend WithEvents lblUnPaid As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnPaid As Button
    Friend WithEvents btnUnpaid As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
