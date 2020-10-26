using System;
using DevExpress.Web.Bootstrap;

namespace ChartApi {
    public partial class SetupInCode : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            //Num
            ChartArgNum.SettingsZoomAndPan.ArgumentAxis = ChartZoomAndPanMode.Both;
            ChartArgNum.SettingsZoomAndPan.ValueAxis = ChartZoomAndPanMode.Both;
            ChartArgNum.SettingsCommonSeries.ArgumentField = "X";
            ChartArgNum.SettingsCommonSeries.Aggregation.Enabled = true;
            ChartArgNum.SeriesCollection.Add(new BootstrapChartBarSeries() { BarPadding = 0.1m, IgnoreEmptyPoints = true, ValueField = "Y1" });
            ChartArgNum.SeriesCollection.Add(new BootstrapChartBarSeries() { BarPadding = 0.2m, IgnoreEmptyPoints = true, ValueField = "Y2" });
            ChartArgNum.ArgumentAxis.ArgumentType = typeof(System.Decimal);
            ChartArgNum.ArgumentAxis.VisualRangeSettings.NumericAxis.StartValue = 0;
            ChartArgNum.ArgumentAxis.VisualRangeSettings.NumericAxis.EndValue = 15;
            
            BootstrapChartValueAxis valueAxisArgNum = new BootstrapChartValueAxis();
            valueAxisArgNum.VisualRangeSettings.NumericAxis.StartValue = 0;
            valueAxisArgNum.VisualRangeSettings.NumericAxis.EndValue = 60;
            ChartArgNum.ValueAxisCollection.Add(valueAxisArgNum);

            ChartArgNum.DataSource = DataProvider.GetDataForArgNumeric();
            ChartArgNum.DataBind();

            //Date
            ChartArgDate.SettingsZoomAndPan.ArgumentAxis = ChartZoomAndPanMode.Both;
            ChartArgDate.SettingsCommonSeries.ArgumentField = "X";
            ChartArgDate.SettingsCommonSeries.Aggregation.Enabled = true;
            ChartArgDate.SeriesCollection.Add(new BootstrapChartBarSeries() { BarPadding = 0.1m, IgnoreEmptyPoints = true, ValueField = "Y" });
            ChartArgDate.ArgumentAxis.ArgumentType = typeof(System.DateTime);
            ChartArgDate.ArgumentAxis.TickInterval = 1;
            ChartArgDate.ArgumentAxis.TickIntervalUnit = VizTimeInterval.Day;
            ChartArgDate.ArgumentAxis.VisualRangeSettings.DateAxis.StartValue = new DateTime(2020, 10, 01);
            ChartArgDate.ArgumentAxis.VisualRangeSettings.DateAxis.EndValue = new DateTime(2020, 10, 25);

            BootstrapChartValueAxis valueAxisArgDate = new BootstrapChartValueAxis();
            valueAxisArgDate.VisualRangeSettings.NumericAxis.StartValue = 0;
            valueAxisArgDate.VisualRangeSettings.NumericAxis.EndValue = 60;
            ChartArgDate.ValueAxisCollection.Add(valueAxisArgDate);

            ChartArgDate.DataSource = DataProvider.GetDataForArgDate();
            ChartArgDate.DataBind();

            //String
            ChartArgString.SettingsZoomAndPan.ArgumentAxis = ChartZoomAndPanMode.Both;
            ChartArgString.SettingsCommonSeries.ArgumentField = "X";
            ChartArgString.SettingsCommonSeries.Aggregation.Enabled = true;
            ChartArgString.SeriesCollection.Add(new BootstrapChartBarSeries() { BarPadding = 0.1m, IgnoreEmptyPoints = true, ValueField = "Y" });
            ChartArgString.ArgumentAxis.ArgumentType = typeof(System.String);
            ChartArgString.ArgumentAxis.VisualRangeSettings.StringAxis.StartValue = "0";
            ChartArgString.ArgumentAxis.VisualRangeSettings.StringAxis.EndValue = "15";

            BootstrapChartValueAxis valueAxisArgString = new BootstrapChartValueAxis();
            valueAxisArgString.VisualRangeSettings.StringAxis.StartValue = "0";
            valueAxisArgString.VisualRangeSettings.StringAxis.EndValue = "60";
            ChartArgString.ValueAxisCollection.Add(valueAxisArgString);

            ChartArgString.DataSource = DataProvider.GetDataForArgString();
            ChartArgString.DataBind();
        }
    }
}