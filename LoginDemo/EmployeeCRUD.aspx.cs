using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginDemo
{
    public partial class EmployeeCRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void DeleteData()
        {
            int id = Convert.ToInt32(TextBox1.Text);
            EmployeeDataContext ed = new EmployeeDataContext();
            Employee ne = ed.Employees.Single(i => i.empid == id);
            ed.Employees.DeleteOnSubmit(ne);
            ed.SubmitChanges();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
    }
}