using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    internal class SalaryData
    {
        public string EmployeeId { set; get; }
        public string Name { set; get; }
        public string Position { set; get; }
        public int Salary { set; get; }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false;TrustServerCertificate=True");

        public List<SalaryData> salaryEmployeeListData()
        {
            List<SalaryData> listdata = new List<SalaryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE status = 'Active' AND" +
                        " delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData sd = new SalaryData();
                            sd.EmployeeId = reader["employee_id"].ToString();
                            sd.Name = reader["full_name"].ToString();
                            sd.Position = reader["position"].ToString();
                            sd.Salary = (int)reader["salary"];

                            listdata.Add(sd);
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
