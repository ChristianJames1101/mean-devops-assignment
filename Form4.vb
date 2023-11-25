Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rptDoc As New ReportDocument
        rptDoc.Load("C:\Users\ITLAB-09\Source\Repos\ChristianJames1101\IT2CCRUD_TUA-O\Intparameter.rpt")
        Dim pfdefs As ParameterFieldDefinitions
        Dim pfdef As ParameterFieldDefinition
        Dim pval As New ParameterValues
        Dim pdval As New ParameterDiscreteValue
        pdval.Value = Convert.ToInt32(Form1.txtid.Text)
        pfdefs = rptDoc.DataDefinition.ParameterFields
        pfdef = pfdefs.Item("empid")
        pval = pfdef.CurrentValues
        pval.Clear()
        pval.Add(pdval)
        pfdef.ApplyCurrentValues(pval)
        CrystalReportViewer1.ReportSource = rptDoc
        CrystalReportViewer1.Refresh()
    End Sub
End Class