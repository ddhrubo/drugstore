namespace Drug_Store_Manager {
    partial class ControlEmployee {
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
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.employee_grid_view = new System.Windows.Forms.DataGridView();
            this.search_button = new System.Windows.Forms.Button();
            this.name_search_in = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.id_search_in = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(461, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 41);
            this.label13.TabIndex = 56;
            this.label13.Text = "Employees";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 433);
            this.groupBox2.TabIndex = 55;
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
            this.employee_grid_view.Size = new System.Drawing.Size(610, 344);
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
            // ControlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(674, 499);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Name = "ControlEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlEmployee";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView employee_grid_view;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox name_search_in;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox id_search_in;
        private System.Windows.Forms.Label label11;
    }
}