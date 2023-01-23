using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityTasks
{
    public partial class delete : System.Web.UI.Page
    {
        task22Entities obj = new task22Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
          
            int x =Convert.ToInt32( Request.QueryString["id"]);

            var all = (from m in obj.Customers
                       join d in obj.cities
                       on m.CityID equals d.city_id
                        where m.CustomerID== x
select new { m.CustomerID, m.CustomerName, m.Age, m.Phone, m.Email, city = d.City1, m.Photo }).ToList();

            grd.DataSource = all;
            grd.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                        int x =Convert.ToInt32( Request.QueryString["id"]);

            var all = (from m in obj.Customers
                       join d in obj.cities
                       on m.CityID equals d.city_id
                       where m.CustomerID == x
                       select m ).FirstOrDefault();

           
                obj.Customers.Remove(all);
                obj.SaveChanges();
            Response.Redirect("Entity.aspx");
            }
        }
    }
