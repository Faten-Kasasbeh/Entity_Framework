using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityTasks
{
    public partial class edit : System.Web.UI.Page
    {
        task22Entities obj = new task22Entities();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int x = Convert.ToInt32(Request.QueryString["id"]);


                var name = (from m in obj.Customers
                            where m.CustomerID == x
                            select m.CustomerName).FirstOrDefault();

                var Email = (from m in obj.Customers
                             where m.CustomerID == x
                             select m.Email).FirstOrDefault();

                var phone = (from m in obj.Customers
                             where m.CustomerID == x
                             select m.Phone).FirstOrDefault();
                TextBox1.Text = name.ToString();
                TextBox2.Text = Email.ToString();
                TextBox3.Text = phone.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["id"]);
            Customer info =obj.Customers.Single(cc=>cc.CustomerID == x);
            //var info = obj.Customers.Find(x);
              info.CustomerName = Convert.ToString(TextBox1.Text);
            info.Phone = Convert.ToInt32(TextBox3.Text);
            info.Email = Convert.ToString(TextBox2.Text);
            obj.Customers.AddOrUpdate(info);
            obj.SaveChanges();
            Response.Redirect("Entity.aspx");


        }
    }
}