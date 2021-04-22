

<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="SetupInCode.aspx.vb" Inherits="ChartApi.SetupInCode" %>
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
		</dx:BootstrapChart>

		<dx:BootstrapChart ID="ChartArgDate" runat="server">
		</dx:BootstrapChart>

		<dx:BootstrapChart ID="ChartArgString" runat="server">
		</dx:BootstrapChart>
	</form>
</body>
</html>