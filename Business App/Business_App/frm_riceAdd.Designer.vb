<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_riceAdd
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Date_StartLabel As System.Windows.Forms.Label
        Dim Lender_NameLabel As System.Windows.Forms.Label
        Dim Week_1Label As System.Windows.Forms.Label
        Dim Week_2Label As System.Windows.Forms.Label
        Dim Week_4Label As System.Windows.Forms.Label
        Dim Week_3Label As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Remaining_BalanceLabel As System.Windows.Forms.Label
        Dim Amount_PaidLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Week_1TextBox = New System.Windows.Forms.TextBox()
        Me.Week_4TextBox = New System.Windows.Forms.TextBox()
        Me.Week_2TextBox = New System.Windows.Forms.TextBox()
        Me.Week_3TextBox = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.DescriptionTextbox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Remaining_BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_PaidTextBox = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        IDLabel = New System.Windows.Forms.Label()
        Date_StartLabel = New System.Windows.Forms.Label()
        Lender_NameLabel = New System.Windows.Forms.Label()
        Week_1Label = New System.Windows.Forms.Label()
        Week_2Label = New System.Windows.Forms.Label()
        Week_4Label = New System.Windows.Forms.Label()
        Week_3Label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Remaining_BalanceLabel = New System.Windows.Forms.Label()
        Amount_PaidLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(924, 640)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(296, 511)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 107)
        Me.Panel1.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(191, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 38)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(64, 34)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 38)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
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
        Me.GroupBox4.Location = New System.Drawing.Point(36, 279)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(429, 208)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Account"
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
        Me.GroupBox3.Location = New System.Drawing.Point(36, 47)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(429, 210)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Information"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(68, 143)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(311, 28)
        Me.DateTimePicker1.TabIndex = 2
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(68, 33)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(311, 28)
        Me.IDTextBox.TabIndex = 33
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
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(68, 84)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(311, 28)
        Me.txtName.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Remaining_BalanceTextBox)
        Me.GroupBox2.Controls.Add(Remaining_BalanceLabel)
        Me.GroupBox2.Controls.Add(Me.Amount_PaidTextBox)
        Me.GroupBox2.Controls.Add(Amount_PaidLabel)
        Me.GroupBox2.Controls.Add(Me.Week_1TextBox)
        Me.GroupBox2.Controls.Add(Week_1Label)
        Me.GroupBox2.Controls.Add(Week_2Label)
        Me.GroupBox2.Controls.Add(Me.Week_4TextBox)
        Me.GroupBox2.Controls.Add(Me.Week_2TextBox)
        Me.GroupBox2.Controls.Add(Week_4Label)
        Me.GroupBox2.Controls.Add(Week_3Label)
        Me.GroupBox2.Controls.Add(Me.Week_3TextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(489, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 440)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Weekly Payment"
        '
        'Week_1TextBox
        '
        Me.Week_1TextBox.Location = New System.Drawing.Point(119, 38)
        Me.Week_1TextBox.Name = "Week_1TextBox"
        Me.Week_1TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_1TextBox.TabIndex = 4
        Me.Week_1TextBox.Text = "0.00"
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
        'Week_4TextBox
        '
        Me.Week_4TextBox.Location = New System.Drawing.Point(119, 156)
        Me.Week_4TextBox.Name = "Week_4TextBox"
        Me.Week_4TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_4TextBox.TabIndex = 7
        Me.Week_4TextBox.Text = "0.00"
        '
        'Week_2TextBox
        '
        Me.Week_2TextBox.Location = New System.Drawing.Point(119, 77)
        Me.Week_2TextBox.Name = "Week_2TextBox"
        Me.Week_2TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_2TextBox.TabIndex = 5
        Me.Week_2TextBox.Text = "0.00"
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
        'Week_3TextBox
        '
        Me.Week_3TextBox.Location = New System.Drawing.Point(119, 116)
        Me.Week_3TextBox.Name = "Week_3TextBox"
        Me.Week_3TextBox.Size = New System.Drawing.Size(252, 28)
        Me.Week_3TextBox.TabIndex = 6
        Me.Week_3TextBox.Text = "0.00"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(183, 71)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(194, 28)
        Me.txtAmount.TabIndex = 27
        Me.txtAmount.Text = "0.00"
        '
        'DescriptionTextbox
        '
        Me.DescriptionTextbox.Location = New System.Drawing.Point(183, 30)
        Me.DescriptionTextbox.Name = "DescriptionTextbox"
        Me.DescriptionTextbox.Size = New System.Drawing.Size(194, 28)
        Me.DescriptionTextbox.TabIndex = 28
        Me.DescriptionTextbox.Text = "25kg"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.Color.DarkGreen
        Label1.Location = New System.Drawing.Point(70, 78)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(107, 21)
        Label1.TabIndex = 29
        Label1.Text = "Total Amount:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.ForeColor = System.Drawing.Color.DarkGreen
        AmountLabel.Location = New System.Drawing.Point(52, 37)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(125, 21)
        AmountLabel.TabIndex = 30
        AmountLabel.Text = "Rice Description:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.Location = New System.Drawing.Point(183, 151)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(194, 28)
        Me.StatusTextBox.TabIndex = 32
        Me.StatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(256, 127)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(56, 21)
        StatusLabel.TabIndex = 31
        StatusLabel.Text = "Status:"
        '
        'Remaining_BalanceTextBox
        '
        Me.Remaining_BalanceTextBox.Location = New System.Drawing.Point(119, 319)
        Me.Remaining_BalanceTextBox.Name = "Remaining_BalanceTextBox"
        Me.Remaining_BalanceTextBox.ReadOnly = True
        Me.Remaining_BalanceTextBox.Size = New System.Drawing.Size(252, 28)
        Me.Remaining_BalanceTextBox.TabIndex = 34
        Me.Remaining_BalanceTextBox.Text = "0.00"
        '
        'Remaining_BalanceLabel
        '
        Remaining_BalanceLabel.AutoSize = True
        Remaining_BalanceLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Remaining_BalanceLabel.ForeColor = System.Drawing.Color.Red
        Remaining_BalanceLabel.Location = New System.Drawing.Point(178, 295)
        Remaining_BalanceLabel.Name = "Remaining_BalanceLabel"
        Remaining_BalanceLabel.Size = New System.Drawing.Size(145, 21)
        Remaining_BalanceLabel.TabIndex = 33
        Remaining_BalanceLabel.Text = "Remaining Balance:"
        '
        'Amount_PaidTextBox
        '
        Me.Amount_PaidTextBox.Location = New System.Drawing.Point(119, 232)
        Me.Amount_PaidTextBox.Name = "Amount_PaidTextBox"
        Me.Amount_PaidTextBox.ReadOnly = True
        Me.Amount_PaidTextBox.Size = New System.Drawing.Size(252, 28)
        Me.Amount_PaidTextBox.TabIndex = 32
        Me.Amount_PaidTextBox.Text = "0.00"
        '
        'Amount_PaidLabel
        '
        Amount_PaidLabel.AutoSize = True
        Amount_PaidLabel.ForeColor = System.Drawing.Color.DarkGreen
        Amount_PaidLabel.Location = New System.Drawing.Point(182, 208)
        Amount_PaidLabel.Name = "Amount_PaidLabel"
        Amount_PaidLabel.Size = New System.Drawing.Size(141, 21)
        Amount_PaidLabel.TabIndex = 31
        Amount_PaidLabel.Text = "Total Amount Paid:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_riceAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(946, 676)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frm_riceAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rice Purchaser"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Week_1TextBox As TextBox
    Friend WithEvents Week_4TextBox As TextBox
    Friend WithEvents Week_2TextBox As TextBox
    Friend WithEvents Week_3TextBox As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents DescriptionTextbox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents Remaining_BalanceTextBox As TextBox
    Friend WithEvents Amount_PaidTextBox As TextBox
    Friend WithEvents Timer1 As Timer
End Class
