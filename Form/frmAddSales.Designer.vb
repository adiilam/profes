<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSales
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlTitle = New Panel()
        lblTitle = New Label()
        dgvGetItem = New DataGridView()
        btnAdd = New Button()
        lblSoNo = New Label()
        lblOrdDate = New Label()
        txtNoSo = New TextBox()
        dtpCreated = New DateTimePicker()
        pnlInfo = New Panel()
        lblInfo = New Label()
        pnlDetail = New Panel()
        lblDetail = New Label()
        txtAddress = New TextBox()
        lblAddress = New Label()
        lblCust = New Label()
        cmbCust = New ComboBox()
        btnSave = New Button()
        btnCancel = New Button()
        btnDelete = New Button()
        clmNo = New DataGridViewTextBoxColumn()
        clmItem = New DataGridViewTextBoxColumn()
        clmQty = New DataGridViewTextBoxColumn()
        clmPrice = New DataGridViewTextBoxColumn()
        clmTotal = New DataGridViewTextBoxColumn()
        clmId = New DataGridViewTextBoxColumn()
        pnlTitle.SuspendLayout()
        CType(dgvGetItem, ComponentModel.ISupportInitialize).BeginInit()
        pnlInfo.SuspendLayout()
        pnlDetail.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTitle
        ' 
        pnlTitle.BackColor = Color.RoyalBlue
        pnlTitle.Controls.Add(lblTitle)
        pnlTitle.Location = New Point(-2, -1)
        pnlTitle.Name = "pnlTitle"
        pnlTitle.Size = New Size(944, 54)
        pnlTitle.TabIndex = 5
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.ForeColor = Color.Transparent
        lblTitle.Location = New Point(12, 11)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(260, 29)
        lblTitle.TabIndex = 0
        lblTitle.Text = "ADD NEW - SALES ORDER"
        ' 
        ' dgvGetItem
        ' 
        dgvGetItem.AllowUserToAddRows = False
        dgvGetItem.AllowUserToResizeColumns = False
        dgvGetItem.AllowUserToResizeRows = False
        dgvGetItem.BackgroundColor = SystemColors.AppWorkspace
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvGetItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvGetItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvGetItem.Columns.AddRange(New DataGridViewColumn() {clmNo, clmItem, clmQty, clmPrice, clmTotal, clmId})
        dgvGetItem.Location = New Point(12, 306)
        dgvGetItem.Name = "dgvGetItem"
        dgvGetItem.RowHeadersVisible = False
        dgvGetItem.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvGetItem.RowTemplate.Height = 25
        dgvGetItem.Size = New Size(900, 218)
        dgvGetItem.TabIndex = 9
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Firebrick
        btnAdd.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.ForeColor = SystemColors.ButtonFace
        btnAdd.Location = New Point(13, 258)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(130, 42)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add Item"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' lblSoNo
        ' 
        lblSoNo.AutoSize = True
        lblSoNo.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSoNo.Location = New Point(26, 109)
        lblSoNo.Name = "lblSoNo"
        lblSoNo.Size = New Size(79, 18)
        lblSoNo.TabIndex = 0
        lblSoNo.Text = "SO Number"
        ' 
        ' lblOrdDate
        ' 
        lblOrdDate.AutoSize = True
        lblOrdDate.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblOrdDate.ForeColor = Color.Black
        lblOrdDate.Location = New Point(29, 141)
        lblOrdDate.Name = "lblOrdDate"
        lblOrdDate.Size = New Size(76, 18)
        lblOrdDate.TabIndex = 1
        lblOrdDate.Text = "Order Date"
        ' 
        ' txtNoSo
        ' 
        txtNoSo.Location = New Point(111, 108)
        txtNoSo.Name = "txtNoSo"
        txtNoSo.Size = New Size(173, 23)
        txtNoSo.TabIndex = 2
        ' 
        ' dtpCreated
        ' 
        dtpCreated.CustomFormat = " dd/MM/yyyy"
        dtpCreated.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        dtpCreated.Format = DateTimePickerFormat.Custom
        dtpCreated.Location = New Point(111, 137)
        dtpCreated.Name = "dtpCreated"
        dtpCreated.Size = New Size(173, 26)
        dtpCreated.TabIndex = 3
        ' 
        ' pnlInfo
        ' 
        pnlInfo.BackColor = Color.MidnightBlue
        pnlInfo.BorderStyle = BorderStyle.FixedSingle
        pnlInfo.Controls.Add(lblInfo)
        pnlInfo.Location = New Point(-2, 52)
        pnlInfo.Name = "pnlInfo"
        pnlInfo.Size = New Size(944, 43)
        pnlInfo.TabIndex = 6
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblInfo.ForeColor = Color.Transparent
        lblInfo.Location = New Point(375, 8)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(197, 23)
        lblInfo.TabIndex = 1
        lblInfo.Text = "Sales Order Information"
        ' 
        ' pnlDetail
        ' 
        pnlDetail.BackColor = Color.MidnightBlue
        pnlDetail.BorderStyle = BorderStyle.FixedSingle
        pnlDetail.Controls.Add(lblDetail)
        pnlDetail.Location = New Point(-2, 208)
        pnlDetail.Name = "pnlDetail"
        pnlDetail.Size = New Size(944, 43)
        pnlDetail.TabIndex = 7
        ' 
        ' lblDetail
        ' 
        lblDetail.AutoSize = True
        lblDetail.Font = New Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblDetail.ForeColor = Color.Transparent
        lblDetail.Location = New Point(377, 8)
        lblDetail.Name = "lblDetail"
        lblDetail.Size = New Size(192, 23)
        lblDetail.TabIndex = 1
        lblDetail.Text = "Detail Item Information"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(653, 140)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(174, 55)
        txtAddress.TabIndex = 5
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblAddress.Location = New Point(589, 143)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(58, 18)
        lblAddress.TabIndex = 10
        lblAddress.Text = "Address"
        ' 
        ' lblCust
        ' 
        lblCust.AutoSize = True
        lblCust.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblCust.Location = New Point(579, 113)
        lblCust.Name = "lblCust"
        lblCust.Size = New Size(68, 18)
        lblCust.TabIndex = 12
        lblCust.Text = "Customer"
        ' 
        ' cmbCust
        ' 
        cmbCust.FormattingEnabled = True
        cmbCust.Location = New Point(653, 108)
        cmbCust.Name = "cmbCust"
        cmbCust.Size = New Size(174, 23)
        cmbCust.TabIndex = 4
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Firebrick
        btnSave.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.ForeColor = SystemColors.ButtonFace
        btnSave.Location = New Point(196, 538)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(130, 42)
        btnSave.TabIndex = 20
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.MidnightBlue
        btnCancel.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancel.ForeColor = SystemColors.ButtonFace
        btnCancel.Location = New Point(486, 538)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(130, 42)
        btnCancel.TabIndex = 21
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.RoyalBlue
        btnDelete.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.ForeColor = SystemColors.ButtonFace
        btnDelete.Location = New Point(344, 538)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(130, 42)
        btnDelete.TabIndex = 22
        btnDelete.Text = "Delete Row"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' clmNo
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        clmNo.DefaultCellStyle = DataGridViewCellStyle2
        clmNo.Frozen = True
        clmNo.HeaderText = "No"
        clmNo.Name = "clmNo"
        clmNo.ReadOnly = True
        clmNo.SortMode = DataGridViewColumnSortMode.Programmatic
        clmNo.Width = 50
        ' 
        ' clmItem
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        clmItem.DefaultCellStyle = DataGridViewCellStyle3
        clmItem.HeaderText = "ITEM NAME"
        clmItem.Name = "clmItem"
        clmItem.Width = 250
        ' 
        ' clmQty
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        clmQty.DefaultCellStyle = DataGridViewCellStyle4
        clmQty.HeaderText = "QTY"
        clmQty.Name = "clmQty"
        clmQty.Width = 200
        ' 
        ' clmPrice
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        clmPrice.DefaultCellStyle = DataGridViewCellStyle5
        clmPrice.HeaderText = "PRICE"
        clmPrice.Name = "clmPrice"
        clmPrice.Width = 250
        ' 
        ' clmTotal
        ' 
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        clmTotal.DefaultCellStyle = DataGridViewCellStyle6
        clmTotal.HeaderText = "TOTAL"
        clmTotal.Name = "clmTotal"
        clmTotal.ReadOnly = True
        clmTotal.Width = 250
        ' 
        ' clmId
        ' 
        clmId.HeaderText = "ID"
        clmId.Name = "clmId"
        clmId.ReadOnly = True
        clmId.Visible = False
        ' 
        ' frmAddSales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(936, 616)
        Controls.Add(btnDelete)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(cmbCust)
        Controls.Add(lblCust)
        Controls.Add(txtAddress)
        Controls.Add(lblAddress)
        Controls.Add(pnlDetail)
        Controls.Add(dtpCreated)
        Controls.Add(pnlTitle)
        Controls.Add(txtNoSo)
        Controls.Add(pnlInfo)
        Controls.Add(lblOrdDate)
        Controls.Add(dgvGetItem)
        Controls.Add(lblSoNo)
        Controls.Add(btnAdd)
        MaximizeBox = False
        Name = "frmAddSales"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAddSales"
        pnlTitle.ResumeLayout(False)
        pnlTitle.PerformLayout()
        CType(dgvGetItem, ComponentModel.ISupportInitialize).EndInit()
        pnlInfo.ResumeLayout(False)
        pnlInfo.PerformLayout()
        pnlDetail.ResumeLayout(False)
        pnlDetail.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvGetItem As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblSoNo As Label
    Friend WithEvents lblOrdDate As Label
    Friend WithEvents txtNoSo As TextBox
    Friend WithEvents dtpCreated As DateTimePicker
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents lblInfo As Label
    Friend WithEvents pnlDetail As Panel
    Friend WithEvents lblDetail As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCust As Label
    Friend WithEvents cmbCust As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents clmNo As DataGridViewTextBoxColumn
    Friend WithEvents clmItem As DataGridViewTextBoxColumn
    Friend WithEvents clmQty As DataGridViewTextBoxColumn
    Friend WithEvents clmPrice As DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As DataGridViewTextBoxColumn
    Friend WithEvents clmId As DataGridViewTextBoxColumn
End Class
