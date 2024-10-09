Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmSales
    Dim sOrd As String, dDateOrd As Date, sCust As String, iLop As Integer = 0, uid As Integer = 0
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getData()
    End Sub

    Private Sub getData()
        Dim sGet = "SELECT * FROM (SELECT Row_Number() OVER (ORDER BY A.ORDER_NO ASC) AS [NO], A.ORDER_NO, FORMAT(A.ORDER_DATE, 'dd/MM/yyyy') AS ORDER_DATE, B.CUSTOMER_NAME, A.ADDRESS " &
            "FROM SO_ORDER AS A LEFT JOIN COM_CUSTOMER AS B ON A.COM_CUSTOMER_ID= B.COM_CUSTOMER_ID) T"
        Dim dataadapter As New SqlDataAdapter(sGet, SQLConn)
        SQLConn.Open()
        Dim ds As New DataSet()
        dataadapter.Fill(ds, "DtTbl")
        SQLConn.Close()

        dgvGetItem.DataSource = ds
        dgvGetItem.DataMember = "DtTbl"
        dgvGetItem.ReadOnly = True
        dgvGetItem.Columns(1).Frozen = True
        dgvGetItem.AllowUserToResizeColumns = False
        dgvGetItem.AllowUserToResizeRows = False

        dgvGetItem.Columns(1).HeaderText = "NO"
        dgvGetItem.Columns(2).HeaderText = "SALES ORDER"
        dgvGetItem.Columns(3).HeaderText = "ORDER DATE"
        dgvGetItem.Columns(4).HeaderText = "CUSTOMER"
        dgvGetItem.Columns(5).HeaderText = "ADDRESS"

        dgvGetItem.Columns(1).Width = 60
        dgvGetItem.Columns(2).Width = 270
        dgvGetItem.Columns(3).Width = 270
        dgvGetItem.Columns(4).Width = 270
        dgvGetItem.Columns(5).Width = 50

        dgvGetItem.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvGetItem.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvGetItem.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvGetItem.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvGetItem.Columns(3).DefaultCellStyle.Format = "dd/MM/yyyy" 'Format date

        dgvGetItem.Columns(5).Visible = False

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim keyword As String = txtSearch.Text.Trim()
        Dim orderDate As Date = dtpOrdDate.Value.ToString("dd/M/yyyy")

        If keyword = "" Then
            MsgBox("Harap isi keyword pencarian pada textbox", MsgBoxStyle.Information, "Warning!")
            Exit Sub
        End If

        dgvGetItem.ClearSelection()

        For Each row As DataGridViewRow In dgvGetItem.Rows
            Dim matchKeyword As Boolean = False
            Dim matchOrderDate As Boolean = False

            If row.Cells(2).Value IsNot Nothing AndAlso row.Cells(2).Value.ToString().Contains(keyword) Then
                matchKeyword = True
            End If

            If row.Cells(3).Value IsNot Nothing AndAlso Convert.ToDateTime(row.Cells(3).Value).Date = orderDate Then
                matchOrderDate = True
            End If

            If matchKeyword AndAlso matchOrderDate Then
                row.Selected = True
                row.Cells(0).Value = True
            End If
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        iAsk = MessageBox.Show("Are you sure to exit this program ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iAsk = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        sStat = "A"
        sTitle = "ADD NEW - SALES ORDER"

        fordel1 = Me.dgvGetItem.CurrentRow.Cells(2).Value 'NO ORDER

        frm = New frmAddSales
        frm.ShowDialog()
        frm = Nothing

        getData()
    End Sub

    Private Sub dgvGetItem_Click(sender As Object, e As EventArgs) Handles dgvGetItem.Click
        If Me.dgvGetItem.CurrentCell.ColumnIndex = 0 Then
            Dim nrow As Integer = Me.dgvGetItem.CurrentCell.RowIndex()
            If CBool(Me.dgvGetItem.Rows(nrow).Cells(0).Value) = False Then
                Me.dgvGetItem.Rows(nrow).Cells(0).Value = True
                Me.dgvGetItem.Rows(nrow).Cells(5).Value = "V"
            Else
                Me.dgvGetItem.Rows(nrow).Cells(0).Value = False
                Me.dgvGetItem.Rows(nrow).Cells(5).Value = ""
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        sStat = "B"
        sTitle = "EDIT - SALES ORDER"

        fordel1 = Me.dgvGetItem.CurrentRow.Cells(2).Value 'NO ORDER
        dfordel = Me.dgvGetItem.CurrentRow.Cells(3).Value 'ORDER DATE
        fordel2 = Me.dgvGetItem.CurrentRow.Cells(4).Value 'customer

        frm = New frmAddSales
        frm.ShowDialog()
        frm = Nothing

        getData()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim noord As String = Me.dgvGetItem.CurrentRow.Cells(2).Value

        iAsk = MessageBox.Show("Wanna delete this order No " & noord & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iAsk = MsgBoxResult.No Then
            Exit Sub
        End If

        fordel1 = Me.dgvGetItem.CurrentRow.Cells(2).Value 'NO ORDER
        dfordel = Me.dgvGetItem.CurrentRow.Cells(3).Value 'ORDER DATE

        Dim str = "SELECT SO_ORDER_ID FROM SO_ORDER WHERE ORDER_NO='" & fordel1 & "'"
        SQLConn.Open()
        UsingSql(str)
        Baca = SQLComm.ExecuteReader(CommandBehavior.CloseConnection)
        If Baca.Read Then
            uid = Baca(0)
        End If
        Baca = Nothing
        SQLConn.Close()

        'DELETE MASORDER
        Dim upd = "DELETE FROM SO_ORDER WHERE ORDER_NO='" & fordel1 & "'"
        SQLConn.Open()
        UsingSql(upd)
        SQLConn.Close()

        'DELETE DETAIL ITEMS
        upd = "DELETE FROM SO_ITEM WHERE SO_ORDER_ID='" & uid & "'"
        SQLConn.Open()
        UsingSql(upd)
        SQLConn.Close()

        MsgBox("Deleted success", MsgBoxStyle.Information)
        getData()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim excelApp As New Excel.Application
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Add
        Dim excelWorksheet As Excel.Worksheet = excelWorkbook.Sheets(1)

        For j As Integer = 1 To dgvGetItem.Columns.Count - 1
            excelWorksheet.Cells(1, j) = dgvGetItem.Columns(j).HeaderText
        Next

        For i As Integer = 0 To dgvGetItem.Rows.Count - 1
            For j As Integer = 1 To dgvGetItem.Columns.Count - 1
                If dgvGetItem.Rows(i).Cells(j).Value IsNot Nothing Then
                    excelWorksheet.Cells(i + 2, j) = dgvGetItem.Rows(i).Cells(j).Value.ToString()
                Else
                    excelWorksheet.Cells(i + 2, j) = ""
                End If
            Next
        Next

        excelWorksheet.Cells.Columns.AutoFit()

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "Excel Files|*.xlsx"
        saveFileDialog.Title = "Save Excel File"
        saveFileDialog.ShowDialog()

        If saveFileDialog.FileName <> "" Then
            excelWorkbook.SaveAs(saveFileDialog.FileName)
            excelWorkbook.Close()
            excelApp.Quit()

            MessageBox.Show("Export Excel Success", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)

            getData()
        End If

        releaseObject(excelWorksheet)
        releaseObject(excelWorkbook)
        releaseObject(excelApp)

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class