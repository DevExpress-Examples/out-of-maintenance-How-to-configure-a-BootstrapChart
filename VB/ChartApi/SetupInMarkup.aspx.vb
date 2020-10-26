Imports Microsoft.VisualBasic
Imports System

Namespace ChartApi
	Partial Public Class SetupInMarkup
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ChartArgNum.DataSource = DataProvider.GetDataForArgNumeric()
			ChartArgNum.DataBind()

			ChartArgDate.DataSource = DataProvider.GetDataForArgDate()
			ChartArgDate.DataBind()

			ChartArgString.DataSource = DataProvider.GetDataForArgString()
			ChartArgString.DataBind()
		End Sub
	End Class
End Namespace