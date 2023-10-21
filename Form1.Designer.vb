<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtdept = New System.Windows.Forms.TextBox()
        Me.txtpos = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtdepartment = New System.Windows.Forms.TextBox()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.txtdept)
        Me.GroupBox1.Controls.Add(Me.txtpos)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 359)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Record Info"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(175, 284)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(139, 40)
        Me.btnadd.TabIndex = 9
        Me.btnadd.Text = "Add Record"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtdept
        '
        Me.txtdept.Location = New System.Drawing.Point(175, 201)
        Me.txtdept.Name = "txtdept"
        Me.txtdept.Size = New System.Drawing.Size(138, 31)
        Me.txtdept.TabIndex = 8
        '
        'txtpos
        '
        Me.txtpos.Location = New System.Drawing.Point(175, 148)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.Size = New System.Drawing.Size(139, 31)
        Me.txtpos.TabIndex = 7
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(175, 98)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(138, 31)
        Me.txtlname.TabIndex = 6
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(175, 38)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(138, 31)
        Me.txtfname.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Department :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Position :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtid)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btnFind)
        Me.GroupBox2.Controls.Add(Me.txtdepartment)
        Me.GroupBox2.Controls.Add(Me.txtposition)
        Me.GroupBox2.Controls.Add(Me.txtlastname)
        Me.GroupBox2.Controls.Add(Me.txtfirstname)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(419, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 359)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Find Record"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(174, 35)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(138, 31)
        Me.txtid.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Employee ID :"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(175, 299)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(139, 40)
        Me.btnFind.TabIndex = 9
        Me.btnFind.Text = "Find Record"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtdepartment
        '
        Me.txtdepartment.Location = New System.Drawing.Point(175, 242)
        Me.txtdepartment.Name = "txtdepartment"
        Me.txtdepartment.Size = New System.Drawing.Size(138, 31)
        Me.txtdepartment.TabIndex = 8
        '
        'txtposition
        '
        Me.txtposition.Location = New System.Drawing.Point(175, 189)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(139, 31)
        Me.txtposition.TabIndex = 7
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(175, 139)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(138, 31)
        Me.txtlastname.TabIndex = 6
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(174, 85)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(138, 31)
        Me.txtfirstname.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Department :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Position :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Last Name :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "First Name :"
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(319, 403)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(152, 35)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "View Record"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnadd As Button
    Friend WithEvents txtdept As TextBox
    Friend WithEvents txtpos As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents txtdepartment As TextBox
    Friend WithEvents txtposition As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnView As Button
End Class
