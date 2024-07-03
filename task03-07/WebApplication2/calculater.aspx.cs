using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class calculater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           double result = Convert.ToDouble(TextBox1.Text) + Convert.ToDouble(TextBox2.Text);
            Result.Text = result.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(TextBox1.Text) - Convert.ToDouble(TextBox2.Text);
            Result.Text = result.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(TextBox1.Text) * Convert.ToDouble(TextBox2.Text);
            Result.Text = result.ToString();
        }
    }
}