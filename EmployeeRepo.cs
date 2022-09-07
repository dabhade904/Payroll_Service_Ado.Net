using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class EmployeeRepo
    {
        public string connection = @"(localdb)\MSSQLLocalDB;Initial Catalog=Employee_Payroll;Integrated Security=True";
        SqlConnection cmd = new SqlConnection();

        public void CreateDb()
        {
            EmployeeModel employeeModel = new EmployeeModel();
            using (this.connection)
            {
                string query=@"select EmployeeID,"
            }
        }
    }
}
