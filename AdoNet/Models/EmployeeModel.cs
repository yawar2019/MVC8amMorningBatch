using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace AdoNet.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }

    public class EmployeeModel
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Harini;Integrated Security=true;");

        public List<Employee> GetEmployee()
        {
            List<Employee> listobj = new List<Employee>();
            SqlCommand cmd = new SqlCommand("sp_getemployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Employee obj = new Employee();
                obj.EmpId = Convert.ToInt32(dr[0]);
                obj.EmpName = Convert.ToString(dr[1]);
                obj.EmpSalary = Convert.ToInt32(dr[2]);
                listobj.Add(obj);
            }
            return listobj;
        }

        public int SaveEmployee(Employee obj)
        {
            SqlCommand cmd = new SqlCommand("sp_insertemployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@empname", obj.EmpName);
            cmd.Parameters.AddWithValue("@empsalary", obj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public Employee GetEmployeeById(int? id)
        {
            Employee obj = new Employee();
            SqlCommand cmd = new SqlCommand("sp_getEmployeebyId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               
                obj.EmpId = Convert.ToInt32(dr[0]);
                obj.EmpName = Convert.ToString(dr[1]);
                obj.EmpSalary = Convert.ToInt32(dr[2]);
                 
            }
            return obj;
        }

        

             public int EditEmployee(Employee obj)
        {
            SqlCommand cmd = new SqlCommand("sp_updateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@empid", obj.EmpId);
            cmd.Parameters.AddWithValue("@empname", obj.EmpName);
            cmd.Parameters.AddWithValue("@empsalary", obj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}