namespace EmployeeManagementSystem
{
    partial class Salary
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.salary_updatebtn = new System.Windows.Forms.Button();
            this.salary_clearbtn = new System.Windows.Forms.Button();
            this.salary_salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salary_position = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salary_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salary_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.salary_updatebtn);
            this.panel1.Controls.Add(this.salary_clearbtn);
            this.panel1.Controls.Add(this.salary_salary);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.salary_position);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.salary_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.salary_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 468);
            this.panel1.TabIndex = 0;
            // 
            // salary_updatebtn
            // 
            this.salary_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.salary_updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_updatebtn.Location = new System.Drawing.Point(23, 364);
            this.salary_updatebtn.Name = "salary_updatebtn";
            this.salary_updatebtn.Size = new System.Drawing.Size(100, 30);
            this.salary_updatebtn.TabIndex = 16;
            this.salary_updatebtn.Text = "Update";
            this.salary_updatebtn.UseVisualStyleBackColor = false;
            this.salary_updatebtn.Click += new System.EventHandler(this.salary_updatebtn_Click);
            // 
            // salary_clearbtn
            // 
            this.salary_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.salary_clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_clearbtn.Location = new System.Drawing.Point(142, 364);
            this.salary_clearbtn.Name = "salary_clearbtn";
            this.salary_clearbtn.Size = new System.Drawing.Size(100, 30);
            this.salary_clearbtn.TabIndex = 15;
            this.salary_clearbtn.Text = "Clear";
            this.salary_clearbtn.UseVisualStyleBackColor = false;
            this.salary_clearbtn.Click += new System.EventHandler(this.salary_clearbtn_Click);
            // 
            // salary_salary
            // 
            this.salary_salary.Location = new System.Drawing.Point(23, 306);
            this.salary_salary.Multiline = true;
            this.salary_salary.Name = "salary_salary";
            this.salary_salary.Size = new System.Drawing.Size(216, 25);
            this.salary_salary.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salary";
            // 
            // salary_position
            // 
            this.salary_position.Location = new System.Drawing.Point(23, 229);
            this.salary_position.Multiline = true;
            this.salary_position.Name = "salary_position";
            this.salary_position.Size = new System.Drawing.Size(216, 25);
            this.salary_position.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Position";
            // 
            // salary_name
            // 
            this.salary_name.Location = new System.Drawing.Point(23, 154);
            this.salary_name.Multiline = true;
            this.salary_name.Name = "salary_name";
            this.salary_name.Size = new System.Drawing.Size(216, 25);
            this.salary_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name";
            // 
            // salary_id
            // 
            this.salary_id.Location = new System.Drawing.Point(23, 78);
            this.salary_id.Multiline = true;
            this.salary_id.Name = "salary_id";
            this.salary_id.Size = new System.Drawing.Size(216, 25);
            this.salary_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(297, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 468);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(8, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 354);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(857, 518);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salary_salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox salary_position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salary_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salary_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button salary_updatebtn;
        private System.Windows.Forms.Button salary_clearbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
