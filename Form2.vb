Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
        LoadDepartment()
        loadRecord()
        'set datagridview properties
        With dgvinfo
            .AutoResizeColumns()
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .RowsDefaultCellStyle.BackColor = Color.Beige
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
        End With
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If cbodept.SelectedIndex = 0 Then
            loadRec("101")
        ElseIf cbodept.SelectedIndex = 1 Then
            loadRec("102")
        ElseIf cbodept.SelectedIndex = 2 Then
            loadRec("103")
        End If
    End Sub
End Class