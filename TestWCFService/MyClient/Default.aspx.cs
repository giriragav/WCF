using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyServiceReference;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MyServiceClient srvcClient = new MyServiceClient("BasicHttpBinding_IMyService");
        Label1.Text = srvcClient.GetData(Int32.Parse(TextBox1.Text));
    }
}