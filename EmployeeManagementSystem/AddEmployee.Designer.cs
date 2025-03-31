namespace EmployeeManagementSystem
{
    partial class AddEmployee
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployee_clear = new System.Windows.Forms.Button();
            this.addEmployee_delete = new System.Windows.Forms.Button();
            this.addEmployee_update = new System.Windows.Forms.Button();
            this.addEmployee_add = new System.Windows.Forms.Button();
            this.addEmployee_import = new System.Windows.Forms.Button();
            this.addEmployee_picture = new System.Windows.Forms.PictureBox();
            this.addEmployee_position = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployee_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmployee_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmployee_fullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addemployee_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.grid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(22, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 219);
            this.panel2.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.grid.Location = new System.Drawing.Point(18, 58);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(773, 144);
            this.grid.TabIndex = 1;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addEmployee_status);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.addEmployee_clear);
            this.panel1.Controls.Add(this.addEmployee_delete);
            this.panel1.Controls.Add(this.addEmployee_update);
            this.panel1.Controls.Add(this.addEmployee_add);
            this.panel1.Controls.Add(this.addEmployee_import);
            this.panel1.Controls.Add(this.addEmployee_picture);
            this.panel1.Controls.Add(this.addEmployee_position);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.addEmployee_phone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addEmployee_gender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addEmployee_fullname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addemployee_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 234);
            this.panel1.TabIndex = 3;
            // 
            // addEmployee_status
            // 
            this.addEmployee_status.FormattingEnabled = true;
            this.addEmployee_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addEmployee_status.Location = new System.Drawing.Point(464, 155);
            this.addEmployee_status.Name = "addEmployee_status";
            this.addEmployee_status.Size = new System.Drawing.Size(134, 24);
            this.addEmployee_status.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Status";
            // 
            // addEmployee_clear
            // 
            this.addEmployee_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.addEmployee_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_clear.Location = new System.Drawing.Point(560, 196);
            this.addEmployee_clear.Name = "addEmployee_clear";
            this.addEmployee_clear.Size = new System.Drawing.Size(91, 30);
            this.addEmployee_clear.TabIndex = 17;
            this.addEmployee_clear.Text = "Clear";
            this.addEmployee_clear.UseVisualStyleBackColor = false;
            this.addEmployee_clear.Click += new System.EventHandler(this.addEmployee_clear_Click);
            // 
            // addEmployee_delete
            // 
            this.addEmployee_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.addEmployee_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_delete.Location = new System.Drawing.Point(429, 196);
            this.addEmployee_delete.Name = "addEmployee_delete";
            this.addEmployee_delete.Size = new System.Drawing.Size(91, 30);
            this.addEmployee_delete.TabIndex = 16;
            this.addEmployee_delete.Text = "Delete";
            this.addEmployee_delete.UseVisualStyleBackColor = false;
            this.addEmployee_delete.Click += new System.EventHandler(this.addEmployee_delete_Click);
            // 
            // addEmployee_update
            // 
            this.addEmployee_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.addEmployee_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_update.Location = new System.Drawing.Point(301, 196);
            this.addEmployee_update.Name = "addEmployee_update";
            this.addEmployee_update.Size = new System.Drawing.Size(91, 30);
            this.addEmployee_update.TabIndex = 15;
            this.addEmployee_update.Text = "Update";
            this.addEmployee_update.UseVisualStyleBackColor = false;
            this.addEmployee_update.Click += new System.EventHandler(this.addEmployee_update_Click);
            // 
            // addEmployee_add
            // 
            this.addEmployee_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.addEmployee_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_add.Location = new System.Drawing.Point(170, 196);
            this.addEmployee_add.Name = "addEmployee_add";
            this.addEmployee_add.Size = new System.Drawing.Size(91, 30);
            this.addEmployee_add.TabIndex = 14;
            this.addEmployee_add.Text = "ADD";
            this.addEmployee_add.UseVisualStyleBackColor = false;
            this.addEmployee_add.Click += new System.EventHandler(this.addEmployee_add_Click);
            // 
            // addEmployee_import
            // 
            this.addEmployee_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.addEmployee_import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_import.Location = new System.Drawing.Point(689, 142);
            this.addEmployee_import.Name = "addEmployee_import";
            this.addEmployee_import.Size = new System.Drawing.Size(91, 30);
            this.addEmployee_import.TabIndex = 13;
            this.addEmployee_import.Text = "Import";
            this.addEmployee_import.UseVisualStyleBackColor = false;
            this.addEmployee_import.Click += new System.EventHandler(this.addEmployee_import_Click);
            // 
            // addEmployee_picture
            // 
            this.addEmployee_picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addEmployee_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_picture.Location = new System.Drawing.Point(689, 39);
            this.addEmployee_picture.Name = "addEmployee_picture";
            this.addEmployee_picture.Size = new System.Drawing.Size(91, 97);
            this.addEmployee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployee_picture.TabIndex = 12;
            this.addEmployee_picture.TabStop = false;
            // 
            // addEmployee_position
            // 
            this.addEmployee_position.FormattingEnabled = true;
            this.addEmployee_position.Items.AddRange(new object[] {
            "Front-End Developer",
            "Back-End Developer",
            "Softare Engineer",
            "Tech Lead",
            "Achitecture"});
            this.addEmployee_position.Location = new System.Drawing.Point(464, 100);
            this.addEmployee_position.Name = "addEmployee_position";
            this.addEmployee_position.Size = new System.Drawing.Size(134, 24);
            this.addEmployee_position.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Position";
            // 
            // addEmployee_phone
            // 
            this.addEmployee_phone.Location = new System.Drawing.Point(464, 39);
            this.addEmployee_phone.Name = "addEmployee_phone";
            this.addEmployee_phone.Size = new System.Drawing.Size(134, 22);
            this.addEmployee_phone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Number";
            // 
            // addEmployee_gender
            // 
            this.addEmployee_gender.FormattingEnabled = true;
            this.addEmployee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.addEmployee_gender.Location = new System.Drawing.Point(135, 161);
            this.addEmployee_gender.Name = "addEmployee_gender";
            this.addEmployee_gender.Size = new System.Drawing.Size(134, 24);
            this.addEmployee_gender.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // addEmployee_fullname
            // 
            this.addEmployee_fullname.Location = new System.Drawing.Point(135, 99);
            this.addEmployee_fullname.Name = "addEmployee_fullname";
            this.addEmployee_fullname.Size = new System.Drawing.Size(134, 22);
            this.addEmployee_fullname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name";
            // 
            // addemployee_id
            // 
            this.addemployee_id.Location = new System.Drawing.Point(135, 39);
            this.addemployee_id.Name = "addemployee_id";
            this.addemployee_id.Size = new System.Drawing.Size(134, 22);
            this.addemployee_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(857, 518);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEmployee_import;
        private System.Windows.Forms.PictureBox addEmployee_picture;
        private System.Windows.Forms.ComboBox addEmployee_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addEmployee_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addEmployee_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmployee_fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addemployee_id;
        private System.Windows.Forms.Button addEmployee_clear;
        private System.Windows.Forms.Button addEmployee_delete;
        private System.Windows.Forms.Button addEmployee_update;
        private System.Windows.Forms.Button addEmployee_add;
        private System.Windows.Forms.ComboBox addEmployee_status;
        private System.Windows.Forms.Label label7;
    }
}
