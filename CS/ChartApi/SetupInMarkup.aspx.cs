using System;

namespace ChartApi {
    public partial class SetupInMarkup : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ChartArgNum.DataSource = DataProvider.GetDataForArgNumeric();
            ChartArgNum.DataBind();

            ChartArgDate.DataSource = DataProvider.GetDataForArgDate();
            ChartArgDate.DataBind();

            ChartArgString.DataSource = DataProvider.GetDataForArgString();
            ChartArgString.DataBind();
        }
    }
}