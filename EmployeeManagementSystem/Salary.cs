using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class Salary : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false;TrustServerCertificate=True");

        public Salary()
        {
            InitializeComponent();

            displayEmployees();
            displayFields();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayEmployees();
            displayFields();
        }

        public void displayFields()
        {
            salary_id.Enabled = false;
            salary_name.Enabled = false;
            salary_position.Enabled = false;
        }

        public void displayEmployees()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listData = ed.salaryEmployeeListData();

            dataGridView1.DataSource = listData;
        }

        private void salary_updatebtn_Click(object sender, EventArgs e)
        {
            if(salary_id.Text == ""
                || salary_name.Text == ""
                || salary_position.Text == ""
                || salary_salary.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Employee Id = " 
                    + salary_id.Text.Trim() + "?" ,"Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(check == DialogResult.Yes)
                {
                    if(connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateDate = "UPDATE employees SET salary = @salary" +
                                ",update_date = @update WHERE employee_id = @id";

                            using(SqlCommand cmd = new SqlCommand(updateDate, connect))
                            {
                                cmd.Parameters.AddWithValue("@salary", salary_salary.Text.Trim());
                                cmd.Parameters.AddWithValue("@update", today);
                                cmd.Parameters.AddWithValue("@id", salary_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayEmployees();

                                MessageBox.Show("UPDATE successfully", "Information message"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }

                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error : " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Canceld", "Information Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void clearFields()
        {
            salary_id.Text = "";
            salary_name.Text = "";
            salary_position.Text = "";
            salary_salary.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salary_id.Text = row.Cells[0].Value.ToString();
                salary_name.Text = row.Cells[1].Value.ToString();
                salary_position.Text = row.Cells[2].Value.ToString();
                salary_salary.Text = row.Cells[3].Value.ToString();
            }
        }

        private void salary_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
