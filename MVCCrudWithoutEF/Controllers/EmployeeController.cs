using MVCCrudWithoutEF.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrudWithoutEF.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
                List<Employee> employeeList = new List<Employee>();
                string CS = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblemp", con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        var employee = new Employee();

                        employee.Id = Convert.ToInt32(rdr["Id"]);
                        employee.Name = rdr["Name"].ToString();
                        employee.Age = rdr["Age"].ToString();
                        employee.Address = rdr["Address"].ToString();
                        employee.ECode = rdr["ECode"].ToString();
                        employee.City =rdr["City"].ToString();
                        employeeList.Add(employee);
                    }
                }
                return View(employeeList);
            
        }

        
    }
}
