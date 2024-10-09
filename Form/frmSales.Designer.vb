<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        pnlTitle = New Panel()
        lblTitle = New Label()
        pnlInfo = New Panel()
        btnSearch = New Button()
        dtpOrdDate = New DateTimePicker()
        txtSearch = New TextBox()
        lblOrdDate = New Label()
        lblKeywords = New Label()
        btnAdd = New Button()
        btnExport = New Button()
        dgvGetItem = New DataGridView()
        Column1 = New DataGridViewCheckBoxColumn()
        btnEdit = New Button()
        btnDelete = New Button()
        btnExit = New Button()
        pnlTitle.SuspendLayout()
        pnlInfo.SuspendLayout()
        CType(dgvGetItem, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlTitle
        ' 
        pnlTitle.BackColor = Color.MidnightBlue
        pnlTitle.Controls.Add(lblTitle)
        pnlTitle.Location = New Point(0, 0)
        pnlTitle.Name = "pnlTitle"
        pnlTitle.Size = New Size(944, 54)
        pnlTitle.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.ForeColor = Color.Transparent
        lblTitle.Location = New Point(12, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(145, 29)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SALES ORDER"
        ' 
        ' pnlInfo
        ' 
        pnlInfo.BorderStyle = BorderStyle.FixedSingle
        pnlInfo.Controls.Add(btnSearch)
        pnlInfo.Controls.Add(dtpOrdDate)
        pnlInfo.Controls.Add(txtSearch)
        pnlInfo.Controls.Add(lblOrdDate)
        pnlInfo.Controls.Add(lblKeywords)
        pnlInfo.Location = New Point(12, 71)
        pnlInfo.Name = "pnlInfo"
        pnlInfo.Size = New Size(900, 131)
        pnlInfo.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.MidnightBlue
        btnSearch.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSearch.ForeColor = SystemColors.ButtonFace
        btnSearch.Location = New Point(735, 71)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(115, 37)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' dtpOrdDate
        ' 
        dtpOrdDate.CustomFormat = " dd/M/yyyy"
        dtpOrdDate.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        dtpOrdDate.Format = DateTimePickerFormat.Custom
        dtpOrdDate.Location = New Point(665, 26)
        dtpOrdDate.Name = "dtpOrdDate"
        dtpOrdDate.Size = New Size(200, 26)
        dtpOrdDate.TabIndex = 3
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(136, 30)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(173, 23)
        txtSearch.TabIndex = 2
        ' 
        ' lblOrdDate
        ' 
        lblOrdDate.AutoSize = True
        lblOrdDate.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblOrdDate.ForeColor = Color.Black
        lblOrdDate.Location = New Point(580, 30)
        lblOrdDate.Name = "lblOrdDate"
        lblOrdDate.Size = New Size(83, 18)
        lblOrdDate.TabIndex = 1
        lblOrdDate.Text = "Order Date :"
        ' 
        ' lblKeywords
        ' 
        lblKeywords.AutoSize = True
        lblKeywords.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblKeywords.Location = New Point(16, 32)
        lblKeywords.Name = "lblKeywords"
        lblKeywords.Size = New Size(116, 18)
        lblKeywords.TabIndex = 0
        lblKeywords.Text = "Search Order No :"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Firebrick
        btnAdd.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.ForeColor = SystemColors.ButtonFace
        btnAdd.Location = New Point(11, 217)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(130, 42)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add New Data"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.LimeGreen
        btnExport.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnExport.ForeColor = SystemColors.HighlightText
        btnExport.Location = New Point(161, 217)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(130, 42)
        btnExport.TabIndex = 3
        btnExport.Text = "Export To Excel"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' dgvGetItem
        ' 
        dgvGetItem.AllowUserToAddRows = False
        dgvGetItem.AllowUserToDeleteRows = False
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
        dgvGetItem.Columns.AddRange(New DataGridViewColumn() {Column1})
        dgvGetItem.Location = New Point(12, 274)
        dgvGetItem.Name = "dgvGetItem"
        dgvGetItem.ReadOnly = True
        dgvGetItem.RowHeadersVisible = False
        dgvGetItem.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvGetItem.RowTemplate.Height = 25
        dgvGetItem.Size = New Size(900, 218)
        dgvGetItem.TabIndex = 4
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "√"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Resizable = DataGridViewTriState.True
        Column1.Width = 30
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.MidnightBlue
        btnEdit.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.ForeColor = SystemColors.ButtonFace
        btnEdit.Location = New Point(12, 520)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(130, 42)
        btnEdit.TabIndex = 5
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.ForeColor = SystemColors.ButtonFace
        btnDelete.Location = New Point(149, 520)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(130, 42)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Tan
        btnExit.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnExit.ForeColor = SystemColors.ButtonHighlight
        btnExit.Location = New Point(285, 520)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(130, 42)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmSales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(944, 613)
        Controls.Add(btnExit)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(dgvGetItem)
        Controls.Add(btnExport)
        Controls.Add(btnAdd)
        Controls.Add(pnlInfo)
        Controls.Add(pnlTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmSales"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "frmSales"
        pnlTitle.ResumeLayout(False)
        pnlTitle.PerformLayout()
        pnlInfo.ResumeLayout(False)
        pnlInfo.PerformLayout()
        CType(dgvGetItem, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents lblKeywords As Label
    Friend WithEvents lblOrdDate As Label
    Friend WithEvents dtpOrdDate As DateTimePicker
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvGetItem As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
End Class
