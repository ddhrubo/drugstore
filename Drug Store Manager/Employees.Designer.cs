namespace Drug_Store_Manager {
    partial class Employees {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.name_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contact_no_in = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.join_date_in = new System.Windows.Forms.DateTimePicker();
            this.password_in = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirm_pass_in = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_employee_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.employee_grid_view = new System.Windows.Forms.DataGridView();
            this.search_button = new System.Windows.Forms.Button();
            this.name_search_in = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.id_search_in = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.id_edit_out_in = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.name_edit_in = new System.Windows.Forms.TextBox();
            this.address_edit_in = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contact_no_edit_in = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_grid_view)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_in
            // 
            this.name_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_in.Location = new System.Drawing.Point(139, 30);
            this.name_in.Name = "name_in";
            this.name_in.Size = new System.Drawing.Size(243, 27);
            this.name_in.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // contact_no_in
            // 
            this.contact_no_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_no_in.Location = new System.Drawing.Point(139, 63);
            this.contact_no_in.Name = "contact_no_in";
            this.contact_no_in.Size = new System.Drawing.Size(243, 27);
            this.contact_no_in.TabIndex = 5;
            this.contact_no_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_input_validation);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contact No";
            // 
            // address_in
            // 
            this.address_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_in.Location = new System.Drawing.Point(139, 129);
            this.address_in.Multiline = true;
            this.address_in.Name = "address_in";
            this.address_in.Size = new System.Drawing.Size(243, 71);
            this.address_in.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Joining Date";
            // 
            // join_date_in
            // 
            this.join_date_in.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.join_date_in.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.join_date_in.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.join_date_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.join_date_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.join_date_in.Location = new System.Drawing.Point(139, 96);
            this.join_date_in.Name = "join_date_in";
            this.join_date_in.Size = new System.Drawing.Size(243, 27);
            this.join_date_in.TabIndex = 46;
            // 
            // password_in
            // 
            this.password_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_in.Location = new System.Drawing.Point(139, 206);
            this.password_in.Name = "password_in";
            this.password_in.PasswordChar = '*';
            this.password_in.Size = new System.Drawing.Size(243, 27);
            this.password_in.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Password";
            // 
            // confirm_pass_in
            // 
            this.confirm_pass_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_pass_in.Location = new System.Drawing.Point(139, 239);
            this.confirm_pass_in.Name = "confirm_pass_in";
            this.confirm_pass_in.PasswordChar = '*';
            this.confirm_pass_in.Size = new System.Drawing.Size(243, 27);
            this.confirm_pass_in.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 49;
            this.label6.Text = "Confirm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_employee_button);
            this.groupBox1.Controls.Add(this.name_in);
            this.groupBox1.Controls.Add(this.confirm_pass_in);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.password_in);
            this.groupBox1.Controls.Add(this.contact_no_in);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.join_date_in);
            this.groupBox1.Controls.Add(this.address_in);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 319);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Employee";
            // 
            // add_employee_button
            // 
            this.add_employee_button.BackColor = System.Drawing.Color.White;
            this.add_employee_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_employee_button.Location = new System.Drawing.Point(244, 272);
            this.add_employee_button.Name = "add_employee_button";
            this.add_employee_button.Size = new System.Drawing.Size(138, 30);
            this.add_employee_button.TabIndex = 51;
            this.add_employee_button.Text = "Add Employee";
            this.add_employee_button.UseVisualStyleBackColor = false;
            this.add_employee_button.Click += new System.EventHandler(this.add_employee_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.employee_grid_view);
            this.groupBox2.Controls.Add(this.search_button);
            this.groupBox2.Controls.Add(this.name_search_in);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.id_search_in);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(426, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 534);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Informations";
            // 
            // employee_grid_view
            // 
            this.employee_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_grid_view.Location = new System.Drawing.Point(18, 83);
            this.employee_grid_view.Name = "employee_grid_view";
            this.employee_grid_view.ReadOnly = true;
            this.employee_grid_view.RowHeadersVisible = false;
            this.employee_grid_view.Size = new System.Drawing.Size(610, 476);
            this.employee_grid_view.TabIndex = 54;
            this.employee_grid_view.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employee_grid_view_CellMouseDoubleClick);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.White;
            this.search_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(405, 33);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(111, 30);
            this.search_button.TabIndex = 52;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // name_search_in
            // 
            this.name_search_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_search_in.Location = new System.Drawing.Point(212, 33);
            this.name_search_in.Name = "name_search_in";
            this.name_search_in.Size = new System.Drawing.Size(187, 27);
            this.name_search_in.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(148, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 52;
            this.label12.Text = "Name";
            // 
            // id_search_in
            // 
            this.id_search_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_search_in.Location = new System.Drawing.Point(46, 33);
            this.id_search_in.Name = "id_search_in";
            this.id_search_in.Size = new System.Drawing.Size(96, 27);
            this.id_search_in.TabIndex = 3;
            this.id_search_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_input_validation);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.id_edit_out_in);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.update_button);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.name_edit_in);
            this.groupBox3.Controls.Add(this.address_edit_in);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.contact_no_edit_in);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 253);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Employee Info";
            // 
            // id_edit_out_in
            // 
            this.id_edit_out_in.AutoSize = true;
            this.id_edit_out_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_edit_out_in.Location = new System.Drawing.Point(135, 37);
            this.id_edit_out_in.Name = "id_edit_out_in";
            this.id_edit_out_in.Size = new System.Drawing.Size(0, 21);
            this.id_edit_out_in.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 21);
            this.label10.TabIndex = 56;
            this.label10.Text = "Id";
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.White;
            this.update_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(244, 204);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(138, 30);
            this.update_button.TabIndex = 52;
            this.update_button.Text = "Update Employee";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 52;
            this.label9.Text = "Address";
            // 
            // name_edit_in
            // 
            this.name_edit_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_edit_in.Location = new System.Drawing.Point(139, 61);
            this.name_edit_in.Name = "name_edit_in";
            this.name_edit_in.Size = new System.Drawing.Size(243, 27);
            this.name_edit_in.TabIndex = 53;
            // 
            // address_edit_in
            // 
            this.address_edit_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_edit_in.Location = new System.Drawing.Point(139, 127);
            this.address_edit_in.Multiline = true;
            this.address_edit_in.Name = "address_edit_in";
            this.address_edit_in.Size = new System.Drawing.Size(243, 71);
            this.address_edit_in.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Name";
            // 
            // contact_no_edit_in
            // 
            this.contact_no_edit_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_no_edit_in.Location = new System.Drawing.Point(139, 94);
            this.contact_no_edit_in.Name = "contact_no_edit_in";
            this.contact_no_edit_in.Size = new System.Drawing.Size(243, 27);
            this.contact_no_edit_in.TabIndex = 55;
            this.contact_no_edit_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_input_validation);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 54;
            this.label8.Text = "Contact No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(864, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 41);
            this.label13.TabIndex = 54;
            this.label13.Text = "Employees";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1083, 602);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_grid_view)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contact_no_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker join_date_in;
        private System.Windows.Forms.TextBox password_in;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox confirm_pass_in;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_employee_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label id_edit_out_in;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox name_edit_in;
        private System.Windows.Forms.TextBox address_edit_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox contact_no_edit_in;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView employee_grid_view;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox name_search_in;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox id_search_in;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}