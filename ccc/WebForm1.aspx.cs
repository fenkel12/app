using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ccc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Repeater1.DataSource = BLL.Class1.cxbll();
                this.Repeater1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = BLL.Class1.mh(this.TextBox1.Text);
            this.Repeater1.DataSource = dt;
            this.Repeater1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton li = sender as LinkButton;
            int id =Convert.ToInt32( li.CommandArgument);
           
            DataTable dt = BLL.Class1.GetByidBLL(id);
            int a = Convert.ToInt32(dt.Rows[0]["userType"].ToString());
            if (a == 1)
            {
                //取消
                BLL.Class1.SetVipBll(id, 0);
                //Response.Redirect("WebForm1.aspx");
            }
            if (a == 0)
            {
                //设置
                BLL.Class1.SetVipBll(id, 1);
                //Response.Redirect("WebForm1.aspx");
            }
        }
    }
}