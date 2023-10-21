Imports MySql.Data.MySqlClient
Module BindConnection
    Dim conString As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim sqlQuery As String
    Dim hostname, dbasename, user, pass As String
    Dim fname, lname, pos, dept As String
    Dim adapter As MySqlDataAdapter
    Dim data As DataTable
    Public Sub dbConnect()
        hostname = "127.0.0.1"
        dbasename = "it2coop"
        user = "root"
        pass = "password"
        'check connection
        If Not conString Is Nothing Then
            conString.Close()

            conString.ConnectionString = "server =" & hostname & "; user id=" & user & ";password =" & pass & ";database = " & dbasename & ""
            Try
                conString.Open()
                MessageBox.Show("Connected!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Public Sub AddRec()
        fname = Form1.txtfname.Text
        lname = Form1.txtlname.Text
        pos = Form1.txtpos.Text
        dept = Form1.txtdept.Text
        sqlQuery = "INSERT INTO employee(empfname, emplname, position, dept) VALUES(@fname, @lname, @pos, @dept)"
        'pass query and connection string
        cmd = New MySqlCommand(sqlQuery, conString)
        'assign the parameter value
        cmd.Parameters.AddWithValue("@fname", fname)
        cmd.Parameters.AddWithValue("@lname", lname)
        cmd.Parameters.AddWithValue("@pos", pos)
        cmd.Parameters.AddWithValue("@dept", dept)
        'execute query
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Record added successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ClearTextField()
        End Try
    End Sub
    Private Sub ClearTextField()
        Form1.txtfname.Clear()
        Form1.txtlname.Clear()
        Form1.txtpos.Clear()
        Form1.txtdept.Clear()
    End Sub

    Public Sub FindRecord(empid As String)
        sqlQuery = "SELECT * FROM employee where empid = @empid"
        cmd = New MySqlCommand(sqlQuery, conString)
        cmd.Parameters.AddWithValue("@empid", empid)
        Try
            reader = cmd.ExecuteReader
            If reader.Read Then
                Form1.txtfirstname.Text = reader("empfname").ToString
                Form1.txtlastname.Text = reader("emplname").ToString
                Form1.txtposition.Text = reader("position").ToString
                Form1.txtdepartment.Text = reader("dept").ToString
            Else
                MsgBox("No Record Found!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub
    Public Sub LoadDepartment()
        'load department to cbo dept
        sqlQuery = "SELECT deptname from department"
        Try
            cmd = New MySqlCommand(sqlQuery, conString)
            reader = cmd.ExecuteReader
            While reader.Read()
                Form2.cbodept.Items.Add(reader("deptname").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conString.Close()
        End Try
    End Sub
    Public Sub loadRecord()
        sqlQuery = "SELECT e.emplname, e.empfname, d.deptname FROM employee e join department d on e.dept = d.deptid"
        adapter = New MySqlDataAdapter(sqlQuery, conString)
        Try
            data = New DataTable
            adapter.Fill(data)
            'load the data table record to dgvinfo
            Form2.dgvinfo.DataSource = data
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub loadRec(dept As String)
        sqlQuery = "SELECT e.emplname, e.empfname, d.deptname FROM employee e join department d on e.dept = d.deptid
                        WHERE dept = @dept"
        adapter = New MySqlDataAdapter(sqlQuery, conString)
        adapter.SelectCommand.Parameters.AddWithValue("@dept", dept)
        Try
            data = New DataTable
            adapter.Fill(data)
            'load the data table record to dgvinfo
            Form2.dgvinfo.DataSource = data
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
