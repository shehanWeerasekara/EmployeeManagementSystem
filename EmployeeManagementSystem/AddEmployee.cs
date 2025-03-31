using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace EmployeeManagementSystem
{
    public partial class AddEmployee : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false;TrustServerCertificate=True");

        public AddEmployee()
        {
            InitializeComponent();

            //to display data from database to grid view
            displayEmployeeData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            employeeData ed = new employeeData();
            List<employeeData> listData = ed.employeeListData();

            grid.DataSource = listData;
        }

        private void addEmployee_add_Click(object sender, EventArgs e)
        {
            if (addemployee_id.Text == "" 
                || addEmployee_fullname.Text == ""
                || addEmployee_gender.Text == ""
                || addEmployee_phone.Text == "" 
                || addEmployee_position.Text == ""
                || addEmployee_status.Text == ""
                || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    try
                    {
                        

                        string checkEmId = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID AND delete_date IS NULL";

                        using(SqlCommand checkEm = new SqlCommand(checkEmId, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", addemployee_id.Text.Trim());

                            int count = (int)checkEm.ExecuteScalar();

                            if(count >= 1)
                            {
                                MessageBox.Show(addemployee_id.Text.Trim() + " is already taken"
                                , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employees" +
                                    "(employee_id,full_name,gender,contact_number" +
                                    ",position,image,salary,insert_date,status)" +
                                    "VALUES(@employeeID,@fullname,@gender,@contact" +
                                    ",@position,@image,@salary,@insertDate,@status)";

                                string path = Path.Combine(@"C:\Users\USER\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\Directory\"
                                            + addemployee_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmployee_picture.ImageLocation, path, true);


                                using(SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addemployee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullname", addEmployee_fullname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contact", addEmployee_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Added Successfully",
                                        "Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error : " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void addEmployee_import_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
                    dialog.RestoreDirectory = true;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        addEmployee_picture.ImageLocation = dialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = grid.Rows[e.RowIndex];
                addemployee_id.Text = row.Cells[1].Value.ToString();
                addEmployee_fullname.Text = row.Cells[2].Value.ToString();
                addEmployee_gender.Text = row.Cells[3].Value.ToString();
                addEmployee_phone.Text = row.Cells[4].Value.ToString();
                addEmployee_position.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if (imagePath != null)
                {
                    addEmployee_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addEmployee_picture.Image = null;
                }
                addEmployee_status.Text = row.Cells[8].Value.ToString();
            }
        }

        public void clearFields()
        {
            addemployee_id.Text = "";
            addEmployee_fullname.Text = "";
            addEmployee_gender.SelectedIndex = -1;
            addEmployee_phone.Text = "";
            addEmployee_position.SelectedIndex = -1;
            addEmployee_status.SelectedIndex = -1;
            addEmployee_picture.Image = null;
        }

        private void addEmployee_update_Click(object sender, EventArgs e)
        {
            if (addemployee_id.Text == ""
                || addEmployee_fullname.Text == ""
                || addEmployee_gender.Text == ""
                || addEmployee_phone.Text == ""
                || addEmployee_position.Text == ""
                || addEmployee_status.Text == ""
                || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE" +
                    "Employee ID : " + addemployee_id.Text.Trim() + "?" , "Confirmation Message" ,
                    MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                if(check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET full_name = @fullName" +
                            ", gender = @gender, contact_number = @contact " +
                            ", position = @position, update_date = @update" +
                            ", status = @status WHERE employee_id = @id";

                        using(SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullName",addEmployee_fullname.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender",addEmployee_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact",addEmployee_phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@position",addEmployee_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@update",today);
                            cmd.Parameters.AddWithValue("@status",addEmployee_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@id",addemployee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Update Successfully",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Canceled..."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void addEmployee_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addEmployee_delete_Click(object sender, EventArgs e)
        {
            if (addemployee_id.Text == ""
                || addEmployee_fullname.Text == ""
                || addEmployee_gender.Text == ""
                || addEmployee_phone.Text == ""
                || addEmployee_position.Text == ""
                || addEmployee_status.Text == ""
                || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE" +
                    "Employee ID : " + addemployee_id.Text.Trim() + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET delete_date = @delete" +
                            " WHERE employee_id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@delete", today);
                            cmd.Parameters.AddWithValue("@id", addemployee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Update Successfully",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Canceled..."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        //private void dataGridView1(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void grid(object sender, DataGridViewCellEventArgs e)
        //{
        //    if(e.RowIndex != -1)
        //    {
        //        DataGridViewRow row = grid.Rows[e.RowIndex];
        //        addemployee_id.Text = row.Cells[1].Value.ToString();
        //        addEmployee_fullname.Text = row.Cells[2].Value.ToString();
        //        addEmployee_gender.Text = row.Cells[3].Value.ToString();
        //        addEmployee_phone.Text = row.Cells[4].Value.ToString();
        //        addEmployee_position.Text = row.Cells[5].Value.ToString();

        //        string imagePath = row.Cells[6].Value.ToString();

        //        if(imagePath != null)
        //        {
        //            addEmployee_picture.Image = Image.FromFile(imagePath);
        //        }
        //        else
        //        {
        //            addEmployee_picture.Image = null;
        //        }
        //        addEmployee_status.Text = row.Cells[8].Value.ToString();
        //    }
        //}
    }
}
