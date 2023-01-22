using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityTasks
{
    public partial class Home : System.Web.UI.Page
    {
        task22Entities obj = new task22Entities();
        Customer info = new Customer();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/images/");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
            var fullpath =   ("~/images/" + FileUpload1.FileName);;


            var ciID = (from n in obj.cities
                         where n.City1==DropDownList1.SelectedValue 
                         select n.city_id).FirstOrDefault();
            info.CustomerID = Convert.ToInt32(TextBox1.Text);
            info.CustomerName= Convert.ToString(TextBox2.Text);
            info.Age = Convert.ToInt32(TextBox3.Text);
            info.Phone= Convert.ToInt32(TextBox4.Text);
            info.Email= Convert.ToString(TextBox5.Text);
            info.CityID =Convert.ToInt32( ciID);
            info.Photo = Convert.ToString(fullpath);
            obj.Customers.Add(info);
            obj.SaveChanges();
            Response.Redirect("Entity.aspx");
        }
    }
}