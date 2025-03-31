using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    internal class employeeData
    {

        public int ID { set; get; }
        public string EmployeeId { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }
        public string Contact { set; get; }
        public string Position { set; get; }
        public string Image { set; get; }
        public int Salary { set; get; }
        public string Status { set; get; }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false;TrustServerCertificate=True");

        public List<employeeData> employeeListData()
        {
            List<employeeData> listdata = new List<employeeData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            employeeData ed = new employeeData();
                            ed.ID = (int)reader["id"];
                            ed.EmployeeId = reader["employee_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.Contact = reader["contact_number"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Image = reader["image"].ToString();
                            ed.Salary = (int)reader["salary"];
                            ed.Status = reader["status"].ToString();

                            listdata.Add(ed);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error :" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }
        public List<employeeData> salaryEmployeeListData()
        {
            List<employeeData> listdata = new List<employeeData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            employeeData ed = new employeeData();
                            ed.EmployeeId = reader["employee_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Salary = (int)reader["salary"];

                            listdata.Add(ed);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error :" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }
    }
}
