Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmAddSales
    Dim idgud As Integer = 0, uid As Integer = 0
    Private deletedRows As New List(Of String)
    Private Sub frmAddSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblTitle.Text = sTitle

        If sStat = "A" Then
            getCust()
            GenerateOrderNumber()
        Else
            getDetailItem()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub getCust()
        Me.cmbCust.Items.Clear()

        Dim sNm = "SELECT CUSTOMER_NAME FROM COM_CUSTOMER ORDER BY CUSTOMER_NAME ASC"
        SQLConn.Open()
        UsingSql(sNm)
        Baca = SQLComm.ExecuteReader(CommandBehavior.CloseConnection)
        Do While Baca.Read
            Me.cmbCust.Items.Add(Baca(0))
        Loop
        SQLConn.Close()
        Baca = Nothing

        If Me.dgvGetItem.Rows.Count < 1 Then
            Me.btnSave.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnCancel.Enabled = True
        End If
    End Sub

    Private Sub GenerateOrderNumber()

        Dim sql = "SELECT TOP 1 ORDER_NO FROM SO_ORDER ORDER BY ORDER_NO DESC"
        SQLConn.Open()
        UsingSql(sql)
        Baca = SQLComm.ExecuteReader(CommandBehavior.CloseConnection)
        If Baca.Read Then
            Dim lastOrderNumberString As String = Baca(0).ToString()

            Dim orderPrefix As String = lastOrderNumberString.Substring(0, 3) ' Format 50
            Dim orderNumber As Integer = Convert.ToInt32(lastOrderNumberString.Substring(4)) 'Angka terakhir(001)

            orderNumber += 1

            Dim newOrderNumber As String = orderPrefix & orderNumber.ToString("D3")

            txtNoSo.Text = newOrderNumber

        End If
        SQLConn.Close()

    End Sub

    Private Sub getDetailItem()
        Me.txtNoSo.Text = fordel1
        Me.cmbCust.Text = fordel2
        Me.dtpCreated.Value = dfordel

        Dim sBrg As String = "", iQty As Integer = 0, dPrc As Decimal = 0, dTotal As Decimal = 0, sAddress As String = "", no As Integer = 0, id As Integer = 0

        Dim add = "SELECT ADDRESS FROM SO_ORDER WHERE ORDER_NO='" & fordel1 & "'"
        SQLConn.Open()
        UsingSql(add)
        Baca = SQLComm.ExecuteReader(CommandBehavior.CloseConnection)
        If Baca.Read Then
            Me.txtAddress.Text = Baca(0)
        End If
        Baca = Nothing
        SQLConn.Close()

        Dim Str = "SELECT SO_ORDER_ID FROM SO_ORDER WHERE ORDER_NO='" & fordel1 & "'"
        SQLConn.Open()
        UsingSql(Str)
        Baca = SQLComm.ExecuteReader(CommandBehavior.CloseConnection)
        If Baca.Read Then
            uid = Baca(0)
        End If
        Baca = Nothing
        SQLConn.Close()

        Dim item = "SELECT * FROM (SELECT Row_Number() OVER (ORDER BY ITEM_NAME ASC) AS [NO], ITEM_NAME, QUANTITY, PRICE, QUANTITY * PRICE AS TOTAL, SO_ITEM_ID FROM SO_ITEM WHERE SO_ORDER_ID='" & uid & "') T"
        Dim dataadapter As New SqlDataAdapter(item, SQLConn)
        SQLConn.Open()
        Dim ds As New DataSet()
        dataadapter.Fill(ds, "DtaTbl")
        SQLConn.Close()
        For i = 0 To ds.Tables(0).Rows.Count - 1

            If Not String.IsNullOrEmpty(ds.Tables(0).Rows(i).Item(0).ToString) Then
                no = ds.Tables(0).Rows(i).Item(0)
            End If

            If Not String.IsNullOrEmpty(ds.Tables(0).Rows(i).Item(1).ToString) Then
                sBrg = ds.Tables(0).Rows(i).Item(1)
            End If

            If Not String.IsNullOrEmpty(ds.Tables(0).Rows(i).Item(2).ToString) Then
                iQty = ds.Tables(0).Rows(i).Item(2)
            End If

            If Not String.IsNullOrEmpty(ds.Tables(0).Rows(i).Item(3).ToString) Then
                dPrc = ds.Tables(0).Rows(i).Item(3)
            End If

            dTotal = iQty * dPrc

            If Not String.IsNullOrEmpty(ds.Tables(0).Rows(i).Item(5).ToString) Then
                id = ds.Tables(0).Rows(i).Item(5)
            End If

            dgvGetItem.Rows.Add(no, sBrg, iQty, dPrc, dTotal, id)
        Next

        If Me.dgvGetItem.Rows.Count > 0 Then
            Me.btnAdd.Enabled = True
            Me.btnDelete.Enabled = True
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.txtNoSo.Text = "" Or Me.txtAddress.Text = "" Or Me.cmbCust.Text = "" Then
            MsgBox("Parameters cannot be empty", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim newRowIndex As Integer = dgvGetItem.Rows.Add()

        dgvGetItem.Rows(newRowIndex).Cells(0).Value = dgvGetItem.Rows.Count.ToString()

        dgvGetItem.CurrentCell = dgvGetItem.Rows(newRowIndex).Cells(1)
        dgvGetItem.BeginEdit(True)

        If Me.dgvGetItem.Rows.Count > 0 Then
            Me.btnSave.Enabled = True
            Me.btnDelete.Enabled = True
            Me.btnCancel.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim no As Integer = Me.dgvGetItem.CurrentRow.Cells(0).Value

        iAsk = MessageBox.Show("Wanna clear this item No " & no & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iAsk = MsgBoxResult.No Then
            Exit Sub
        End If

        'ARRAY LIST ITEM DELETE
        If dgvGetItem.CurrentRow IsNot Nothing Then
            Dim id As Integer = dgvGetItem.CurrentRow.Cells(5).Value.ToString()
            deletedRows.Add(id)

            dgvGetItem.Rows.RemoveAt(dgvGetItem.CurrentRow.Index)

            For i As Integer = 0 To dgvGetItem.Rows.Count - 1
                dgvGetItem.Rows(i).Cells(0).Value = i + 1
            Next
        End If

        If Me.dgvGetItem.Rows.Count = 0 Then
            Me.cmbCust.Items.Clear()
            Me.cmbCust.Text = ""
            Me.txtAddress.Text = ""
            Me.btnSave.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnCancel.Enabled = True
        End If
    End Sub

    Private Sub dgvGetItem_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGetItem.CellEndEdit
        If Me.dgvGetItem.CurrentCellAddress.X = 1 Then 'Saat input barang
            If Not IsDBNull(dgvGetItem.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                dgvGetItem.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = dgvGetItem.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString().ToUpper()
            End If
        End If

        If Me.dgvGetItem.CurrentCellAddress.X = 2 Or Me.dgvGetItem.CurrentCellAddress.X = 3 Then 'Saat input qty dan price
            Dim cellValue As Decimal
            If Decimal.TryParse(dgvGetItem.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString(), cellValue) Then
                dgvGetItem.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = cellValue.ToString("N2")
            End If
        End If

        If Me.dgvGetItem.CurrentCellAddress.X = 3 Then 'hitung total price
            Dim dQty As Decimal = Me.dgvGetItem.CurrentRow.Cells(2).Value
            Dim dHrg As Decimal = Me.dgvGetItem.CurrentRow.Cells(3).Value
            Me.dgvGetItem.CurrentRow.Cells(4).Value = dQty * dHrg
        End If
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        Dim currentPosition As Integer = txtAddress.SelectionStart
        txtAddress.Text = txtAddress.Text.ToUpper()
        txtAddress.SelectionStart = currentPosition
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.dgvGetItem.Rows.Count = 0 Then
            MsgBox("No data to store !", MsgBoxStyle.Information)
            Exit Sub
        End If

        'VALIDASI NO ORDER
        If sStat = "A" Then
            Dim val = "Select ORDER_NO FROM SO_ORDER WHERE ORDER_NO='" & Me.txtNoSo.Text & "'"
            SQLConn.Open()
            UsingSql(val)
            Baca = SQLComm.ExecuteReader(CommandBehavior.CloseConnection)
            If Baca.Read Then
                MsgBox("This transaction number has already been used", MsgBoxStyle.Information)
                SQLConn.Close()
                Exit Sub
            End If
            SQLConn.Close()
            Baca = Nothing
        End If

        Dim str = "SELECT COM_CUSTOMER_ID FROM COM_CUSTOMER WHERE CUSTOMER_NAME='" & Me.cmbCust.Text & "'"
        SQLConn.Open()
        UsingSql(str)
        Baca = SQLComm.ExecuteReader(CommandBehavior.CloseConnection)
        If Baca.Read Then
            idgud = Baca(0)
        End If
        Baca = Nothing
        SQLConn.Close()

        If sStat = "A" Then
            'STORE MASTER ORDER
            str = "INSERT INTO SO_ORDER (ORDER_NO,ORDER_DATE,COM_CUSTOMER_ID,ADDRESS) VALUES ('" & Me.txtNoSo.Text & "', '" & Me.dtpCreated.Value & "', '" & idgud & "', '" & Me.txtAddress.Text & "')"
            SQLConn.Open()
            UsingSql(str)
            SQLConn.Close()
        Else
            If deletedRows.Count > 0 Then
                For Each id As Integer In deletedRows
                    Dim sqlDelete = "DELETE FROM SO_ITEM WHERE SO_ITEM_ID='" & id & "'"
                    If SQLConn.State = ConnectionState.Closed Then
                        SQLConn.Open()
                    End If
                    UsingSql(sqlDelete)
                Next
                SQLConn.Close()
            End If
        End If

        str = "SELECT SO_ORDER_ID FROM SO_ORDER WHERE ORDER_NO='" & Me.txtNoSo.Text & "'"
        SQLConn.Open()
        UsingSql(str)
        Baca = SQLComm.ExecuteReader(CommandBehavior.CloseConnection)
        If Baca.Read Then
            uid = Baca(0)
        End If
        Baca = Nothing
        SQLConn.Close()

        Dim sBrg As String = "", iQty As Integer = 0, dPrc As Decimal = 0

        For i = 0 To Me.dgvGetItem.Rows.Count - 1

            sBrg = ""
            If Not String.IsNullOrEmpty(Me.dgvGetItem.Item(1, i).Value.ToString) Then
                sBrg = Me.dgvGetItem.Item(1, i).Value
            End If

            iQty = 0
            If Not String.IsNullOrEmpty(Me.dgvGetItem.Item(2, i).Value.ToString) Then
                iQty = Me.dgvGetItem.Item(2, i).Value
            End If

            dPrc = 0
            If Not String.IsNullOrEmpty(Me.dgvGetItem.Item(3, i).Value.ToString) Then
                dPrc = Me.dgvGetItem.Item(3, i).Value
            End If

            If sStat = "A" Then
                'STORE DETAIL ORDER
                Dim simp = "INSERT INTO SO_ITEM (SO_ORDER_ID,ITEM_NAME,QUANTITY,PRICE) VALUES ('" & uid & "', '" & sBrg & "', '" & iQty & "', '" & dPrc & "')"
                SQLConn.Open()
                UsingSql(simp)
                SQLConn.Close()
            Else
                Dim ada As Boolean = False
                Dim upd = "SELECT SO_ITEM_ID FROM SO_ITEM WHERE SO_ITEM_ID='" & Me.dgvGetItem.Item(5, i).Value & "'"
                SQLConn.Open()
                UsingSql(upd)
                Baca = SQLComm.ExecuteReader(CommandBehavior.CloseConnection)
                If Baca.Read Then
                    ada = True
                End If
                Baca = Nothing
                SQLConn.Close()

                If ada Then
                    upd = "UPDATE SO_ITEM SET ITEM_NAME='" & sBrg & "',QUANTITY='" & iQty & "',PRICE='" & dPrc & "' WHERE SO_ITEM_ID='" & Me.dgvGetItem.Item(5, i).Value & "'"
                    SQLConn.Open()
                    UsingSql(upd)
                    SQLConn.Close()
                Else
                    Dim simp = "INSERT INTO SO_ITEM (SO_ORDER_ID,ITEM_NAME,QUANTITY,PRICE) VALUES ('" & uid & "', '" & sBrg & "', '" & iQty & "', '" & dPrc & "')"
                    SQLConn.Open()
                    UsingSql(simp)
                    SQLConn.Close()
                End If

            End If

        Next
        If sStat = "A" Then
            MsgBox("Data Saved!")
        Else
            MsgBox("Update Done!")
            Me.Close()
        End If

        Me.dgvGetItem.Rows.Clear()
        GenerateOrderNumber()
        Me.cmbCust.Items.Clear()
        Me.cmbCust.Text = ""
        Me.txtAddress.Text = ""

    End Sub
End Class