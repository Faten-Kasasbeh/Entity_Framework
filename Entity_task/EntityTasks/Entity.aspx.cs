using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace EntityTasks
{
    public partial class Entity : System.Web.UI.Page
    {
        task22Entities obj = new task22Entities();

        protected void Page_Load(object sender, EventArgs e)
        {

            var all = (from m in obj.Customers 
                      join d in obj.cities 
                      on m.CityID equals d.city_id
                      orderby m.Age ascending
            select new { m.CustomerID, m.CustomerName, m.Age, m.Phone, m.Email, city=d.City1, m.Photo }).ToList (); 
             
          
            grd.DataSource = all;
            grd.DataBind();

            
             
             //var x = (from y in ctx.Employees
             //                where y.EmployeeId == z.EmployeeId
             //                select y).FirstOrDefault();
             //       if (x != null)
             //       {
             //           ctx.Employees.DeleteObject(x);
             //           ctx.SaveChanges();
             //       }
                
            


            var num = (from m in obj.Customers select m).Count();
            decimal avg= Convert.ToDecimal((from m in obj.Customers select m.Age).Average());
            int maxx = Convert.ToInt32((from m in obj.Customers select m.Age).Max());

            Label1.Text= num.ToString();
            Label2.Text= avg.ToString();
            Label3.Text= maxx.ToString();

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            var all = from m in obj.Customers
                      join d in obj.cities
                     on m.CityID equals d.city_id
                      where m.CustomerID == id
                      select new { m.CustomerID, m.CustomerName, m.Age, m.Phone, m.Email, city = d.City1 , m.Photo};
            grd.DataSource = all.ToList();
            grd.DataBind();
        
        }
        protected void Button2_Click1(object sender, EventArgs e)
        {
            var all = from m in obj.Customers
                      join d in obj.cities
                     on m.CityID equals d.city_id
                      where m.CustomerName.Contains(TextBox2.Text)
                      select new { m.CustomerID, m.CustomerName, m.Age, m.Phone, m.Email, city = d.City1 ,m.Photo};
            grd.DataSource = all.ToList();
            grd.DataBind();
         
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}