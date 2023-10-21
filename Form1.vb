Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
        txtdepartment.Enabled = False
        txtfirstname.Enabled = False
        txtlastname.Enabled = False
        txtposition.Enabled = False
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
End Class
