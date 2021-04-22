

<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="SetupInMarkup.aspx.vb" Inherits="ChartApi.SetupInMarkup" %>
<%@ Register Assembly="DevExpress.Web.Bootstrap.v20.2, Version=20.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v20.2, Version=20.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
	<form id="form1" runat="server">
		<dx:BootstrapChart ID="ChartArgNum" runat="server">
			<SettingsZoomAndPan ArgumentAxis="Both" ValueAxis="Both">
			</SettingsZoomAndPan>
			<SettingsCommonSeries ArgumentField="X">
				<Aggregation Enabled="true" />
			</SettingsCommonSeries>
			<SeriesCollection>
				<dx:BootstrapChartBarSeries BarPadding="0.1" IgnoreEmptyPoints="true" ValueField="Y1">
				</dx:BootstrapChartBarSeries>
				<dx:BootstrapChartBarSeries BarPadding="0.2" IgnoreEmptyPoints="true" ValueField="Y2">
				</dx:BootstrapChartBarSeries>
			</SeriesCollection>
			<ArgumentAxis ArgumentType="System.Decimal">
				<VisualRangeSettings>
					<NumericAxis StartValue="0" EndValue="15" />
				</VisualRangeSettings>
			</ArgumentAxis>
			<ValueAxisCollection>
				<dx:BootstrapChartValueAxis>
					<VisualRangeSettings>
						<NumericAxis StartValue="0" EndValue="60" />
					</VisualRangeSettings>
				</dx:BootstrapChartValueAxis>
			</ValueAxisCollection>
		</dx:BootstrapChart>

		<dx:BootstrapChart ID="ChartArgDate" runat="server">
			<SettingsZoomAndPan ArgumentAxis="Both">
			</SettingsZoomAndPan>
			<SettingsCommonSeries ArgumentField="X">
				<Aggregation Enabled="true" />
			</SettingsCommonSeries>
			<SeriesCollection>
				<dx:BootstrapChartBarSeries BarPadding="0.1" IgnoreEmptyPoints="true" ValueField="Y">
				</dx:BootstrapChartBarSeries>
			</SeriesCollection>
			<ArgumentAxis ArgumentType="System.DateTime" TickInterval="1" TickIntervalUnit="Day">
				<VisualRangeSettings>
					<DateAxis StartValue="2020/10/01" EndValue="2020/10/25" />
				</VisualRangeSettings>
			</ArgumentAxis>
			<ValueAxisCollection>
				<dx:BootstrapChartValueAxis>
					<VisualRangeSettings>
						<NumericAxis StartValue="0" EndValue="60" />
					</VisualRangeSettings>
				</dx:BootstrapChartValueAxis>
			</ValueAxisCollection>
		</dx:BootstrapChart>

		<dx:BootstrapChart ID="ChartArgString" runat="server">
			<SettingsZoomAndPan ArgumentAxis="Both">
			</SettingsZoomAndPan>
			<SettingsCommonSeries ArgumentField="X">
				<Aggregation Enabled="true" />
			</SettingsCommonSeries>
			<SeriesCollection>
				<dx:BootstrapChartBarSeries BarPadding="0.1" IgnoreEmptyPoints="true" ValueField="Y">
				</dx:BootstrapChartBarSeries>
			</SeriesCollection>
			<ArgumentAxis ArgumentType="System.String">
				<VisualRangeSettings>
					<StringAxis StartValue="0" EndValue="15" />
				</VisualRangeSettings>
			</ArgumentAxis>
			<ValueAxisCollection>
				<dx:BootstrapChartValueAxis>
					<VisualRangeSettings>
						<StringAxis StartValue="0" EndValue="60" />
					</VisualRangeSettings>
				</dx:BootstrapChartValueAxis>
			</ValueAxisCollection>
		</dx:BootstrapChart>
	</form>
</body>
</html>