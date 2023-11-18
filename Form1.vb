Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
        DisableObject()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        AddRec()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        FindRecord(txtid.Text)
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Form2.Show() 'display form 2
        Me.Hide() 'hide form 1
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'confirm before update
        Dim answer As DialogResult = MessageBox.Show("Do you want to update the record?", "Confirmation",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'check if yes
        If answer = DialogResult.Yes Then
            UpdateRecord(txtid.Text, txtfirstname.Text, txtlastname.Text, txtposition.Text, txtdepartment.Text)
        Else
            MsgBox("Update cancelled!", vbInformation, "Update Status")
            TextClear()
            txtid.Clear()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim answer As DialogResult = MessageBox.Show("Do you want to delete the record?", "Confirmation",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'check if yes
        If answer = DialogResult.Yes Then
            DeleteRecord(txtid.Text)
        Else
            MsgBox("Delete cancelled!", vbInformation, "Delete Status")
            TextClear()
            txtid.Clear()
        End If
    End Sub
End Class
