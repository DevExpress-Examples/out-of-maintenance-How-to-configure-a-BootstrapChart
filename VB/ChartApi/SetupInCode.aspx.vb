Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.Bootstrap

Namespace ChartApi
	Partial Public Class SetupInCode
		Inherits System.Web.UI.Page
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			'Num
			ChartArgNum.SettingsZoomAndPan.ArgumentAxis = ChartZoomAndPanMode.Both
			ChartArgNum.SettingsZoomAndPan.ValueAxis = ChartZoomAndPanMode.Both
			ChartArgNum.SettingsCommonSeries.ArgumentField = "X"
			ChartArgNum.SettingsCommonSeries.Aggregation.Enabled = True
			ChartArgNum.SeriesCollection.Add(New BootstrapChartBarSeries() With {.BarPadding = 0.1D, .IgnoreEmptyPoints = True, .ValueField = "Y1"})
			ChartArgNum.SeriesCollection.Add(New BootstrapChartBarSeries() With {.BarPadding = 0.2D, .IgnoreEmptyPoints = True, .ValueField = "Y2"})
			ChartArgNum.ArgumentAxis.ArgumentType = GetType(System.Decimal)
			ChartArgNum.ArgumentAxis.VisualRangeSettings.NumericAxis.StartValue = 0
			ChartArgNum.ArgumentAxis.VisualRangeSettings.NumericAxis.EndValue = 15

			Dim valueAxisArgNum As New BootstrapChartValueAxis()
			valueAxisArgNum.VisualRangeSettings.NumericAxis.StartValue = 0
			valueAxisArgNum.VisualRangeSettings.NumericAxis.EndValue = 60
			ChartArgNum.ValueAxisCollection.Add(valueAxisArgNum)

			ChartArgNum.DataSource = DataProvider.GetDataForArgNumeric()
			ChartArgNum.DataBind()

			'Date
			ChartArgDate.SettingsZoomAndPan.ArgumentAxis = ChartZoomAndPanMode.Both
			ChartArgDate.SettingsCommonSeries.ArgumentField = "X"
			ChartArgDate.SettingsCommonSeries.Aggregation.Enabled = True
			ChartArgDate.SeriesCollection.Add(New BootstrapChartBarSeries() With {.BarPadding = 0.1D, .IgnoreEmptyPoints = True, .ValueField = "Y"})
			ChartArgDate.ArgumentAxis.ArgumentType = GetType(System.DateTime)
			ChartArgDate.ArgumentAxis.TickInterval = 1
			ChartArgDate.ArgumentAxis.TickIntervalUnit = VizTimeInterval.Day
			ChartArgDate.ArgumentAxis.VisualRangeSettings.DateAxis.StartValue = New DateTime(2020, 10, 01)
			ChartArgDate.ArgumentAxis.VisualRangeSettings.DateAxis.EndValue = New DateTime(2020, 10, 25)

			Dim valueAxisArgDate As New BootstrapChartValueAxis()
			valueAxisArgDate.VisualRangeSettings.NumericAxis.StartValue = 0
			valueAxisArgDate.VisualRangeSettings.NumericAxis.EndValue = 60
			ChartArgDate.ValueAxisCollection.Add(valueAxisArgDate)

			ChartArgDate.DataSource = DataProvider.GetDataForArgDate()
			ChartArgDate.DataBind()

			'String
			ChartArgString.SettingsZoomAndPan.ArgumentAxis = ChartZoomAndPanMode.Both
			ChartArgString.SettingsCommonSeries.ArgumentField = "X"
			ChartArgString.SettingsCommonSeries.Aggregation.Enabled = True
			ChartArgString.SeriesCollection.Add(New BootstrapChartBarSeries() With {.BarPadding = 0.1D, .IgnoreEmptyPoints = True, .ValueField = "Y"})
			ChartArgString.ArgumentAxis.ArgumentType = GetType(System.String)
			ChartArgString.ArgumentAxis.VisualRangeSettings.StringAxis.StartValue = "0"
			ChartArgString.ArgumentAxis.VisualRangeSettings.StringAxis.EndValue = "15"

			Dim valueAxisArgString As New BootstrapChartValueAxis()
			valueAxisArgString.VisualRangeSettings.StringAxis.StartValue = "0"
			valueAxisArgString.VisualRangeSettings.StringAxis.EndValue = "60"
			ChartArgString.ValueAxisCollection.Add(valueAxisArgString)

			ChartArgString.DataSource = DataProvider.GetDataForArgString()
			ChartArgString.DataBind()
		End Sub
	End Class
End Namespace