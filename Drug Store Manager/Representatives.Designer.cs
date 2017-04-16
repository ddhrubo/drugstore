namespace Drug_Store_Manager {
    partial class Representatives {
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
            this.components = new System.ComponentModel.Container();
            this.name_in = new System.Windows.Forms.TextBox();
            this.representative_grid_view = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.search_representative_button = new System.Windows.Forms.Button();
            this.name_search_in = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.id_search_in = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.add_representative_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.company_combo_box = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugStoreDBDataSet = new Drug_Store_Manager.DrugStoreDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contact_no_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.address_in = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.companyTableAdapter = new Drug_Store_Manager.DrugStoreDBDataSetTableAdapters.CompanyTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.id_edit_out_in = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edit_representative_button = new System.Windows.Forms.Button();
            this.name_edit_in = new System.Windows.Forms.TextBox();
            this.company_box_edit_in = new System.Windows.Forms.ComboBox();
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.contact_no_edit_in = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.address_edit_in = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.representative_grid_view)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugStoreDBDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_in
            // 
            this.name_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_in.Location = new System.Drawing.Point(135, 30);
            this.name_in.Name = "name_in";
            this.name_in.Size = new System.Drawing.Size(247, 27);
            this.name_in.TabIndex = 3;
            // 
            // representative_grid_view
            // 
            this.representative_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.representative_grid_view.Location = new System.Drawing.Point(18, 83);
            this.representative_grid_view.Name = "representative_grid_view";
            this.representative_grid_view.ReadOnly = true;
            this.representative_grid_view.RowHeadersVisible = false;
            this.representative_grid_view.Size = new System.Drawing.Size(610, 426);
            this.representative_grid_view.TabIndex = 54;
            this.representative_grid_view.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.representative_grid_view_CellMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.representative_grid_view);
            this.groupBox2.Controls.Add(this.search_representative_button);
            this.groupBox2.Controls.Add(this.name_search_in);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.id_search_in);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(415, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 523);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Representative Informations";
            // 
            // search_representative_button
            // 
            this.search_representative_button.BackColor = System.Drawing.Color.White;
            this.search_representative_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_representative_button.Location = new System.Drawing.Point(405, 33);
            this.search_representative_button.Name = "search_representative_button";
            this.search_representative_button.Size = new System.Drawing.Size(111, 30);
            this.search_representative_button.TabIndex = 52;
            this.search_representative_button.Text = "Search";
            this.search_representative_button.UseVisualStyleBackColor = false;
            this.search_representative_button.Click += new System.EventHandler(this.search_representative_button_Click);
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
            // add_representative_button
            // 
            this.add_representative_button.BackColor = System.Drawing.Color.White;
            this.add_representative_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_representative_button.Location = new System.Drawing.Point(202, 217);
            this.add_representative_button.Name = "add_representative_button";
            this.add_representative_button.Size = new System.Drawing.Size(180, 30);
            this.add_representative_button.TabIndex = 51;
            this.add_representative_button.Text = "Add Representative";
            this.add_representative_button.UseVisualStyleBackColor = false;
            this.add_representative_button.Click += new System.EventHandler(this.add_representative_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.add_representative_button);
            this.groupBox1.Controls.Add(this.name_in);
            this.groupBox1.Controls.Add(this.company_combo_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.contact_no_in);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.address_in);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 257);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Representative";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Company";
            // 
            // company_combo_box
            // 
            this.company_combo_box.DataSource = this.companyBindingSource;
            this.company_combo_box.DisplayMember = "Name";
            this.company_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.company_combo_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_combo_box.FormattingEnabled = true;
            this.company_combo_box.Location = new System.Drawing.Point(135, 182);
            this.company_combo_box.Name = "company_combo_box";
            this.company_combo_box.Size = new System.Drawing.Size(247, 29);
            this.company_combo_box.TabIndex = 59;
            this.company_combo_box.ValueMember = "Id";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.drugStoreDBDataSet;
            // 
            // drugStoreDBDataSet
            // 
            this.drugStoreDBDataSet.DataSetName = "DrugStoreDBDataSet";
            this.drugStoreDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // contact_no_in
            // 
            this.contact_no_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_no_in.Location = new System.Drawing.Point(135, 63);
            this.contact_no_in.Name = "contact_no_in";
            this.contact_no_in.Size = new System.Drawing.Size(247, 27);
            this.contact_no_in.TabIndex = 5;
            this.contact_no_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_input_validation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // address_in
            // 
            this.address_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_in.Location = new System.Drawing.Point(135, 96);
            this.address_in.Multiline = true;
            this.address_in.Name = "address_in";
            this.address_in.Size = new System.Drawing.Size(247, 71);
            this.address_in.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(777, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(282, 41);
            this.label13.TabIndex = 58;
            this.label13.Text = "Representatives";
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.id_edit_out_in);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.edit_representative_button);
            this.groupBox3.Controls.Add(this.name_edit_in);
            this.groupBox3.Controls.Add(this.company_box_edit_in);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.contact_no_edit_in);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.address_edit_in);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 298);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Representative";
            // 
            // id_edit_out_in
            // 
            this.id_edit_out_in.AutoSize = true;
            this.id_edit_out_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_edit_out_in.Location = new System.Drawing.Point(135, 37);
            this.id_edit_out_in.Name = "id_edit_out_in";
            this.id_edit_out_in.Size = new System.Drawing.Size(0, 21);
            this.id_edit_out_in.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 21);
            this.label10.TabIndex = 60;
            this.label10.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Company";
            // 
            // edit_representative_button
            // 
            this.edit_representative_button.BackColor = System.Drawing.Color.White;
            this.edit_representative_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_representative_button.Location = new System.Drawing.Point(202, 254);
            this.edit_representative_button.Name = "edit_representative_button";
            this.edit_representative_button.Size = new System.Drawing.Size(180, 30);
            this.edit_representative_button.TabIndex = 51;
            this.edit_representative_button.Text = "Edit Representative";
            this.edit_representative_button.UseVisualStyleBackColor = false;
            this.edit_representative_button.Click += new System.EventHandler(this.edit_representative_button_Click);
            // 
            // name_edit_in
            // 
            this.name_edit_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_edit_in.Location = new System.Drawing.Point(135, 67);
            this.name_edit_in.Name = "name_edit_in";
            this.name_edit_in.Size = new System.Drawing.Size(247, 27);
            this.name_edit_in.TabIndex = 3;
            // 
            // company_box_edit_in
            // 
            this.company_box_edit_in.DataSource = this.companyBindingSource1;
            this.company_box_edit_in.DisplayMember = "Name";
            this.company_box_edit_in.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.company_box_edit_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_box_edit_in.FormattingEnabled = true;
            this.company_box_edit_in.Location = new System.Drawing.Point(135, 219);
            this.company_box_edit_in.Name = "company_box_edit_in";
            this.company_box_edit_in.Size = new System.Drawing.Size(247, 29);
            this.company_box_edit_in.TabIndex = 59;
            this.company_box_edit_in.ValueMember = "Id";
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataMember = "Company";
            this.companyBindingSource1.DataSource = this.drugStoreDBDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Contact No";
            // 
            // contact_no_edit_in
            // 
            this.contact_no_edit_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_no_edit_in.Location = new System.Drawing.Point(135, 100);
            this.contact_no_edit_in.Name = "contact_no_edit_in";
            this.contact_no_edit_in.Size = new System.Drawing.Size(247, 27);
            this.contact_no_edit_in.TabIndex = 5;
            this.contact_no_edit_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_input_validation);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Address";
            // 
            // address_edit_in
            // 
            this.address_edit_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_edit_in.Location = new System.Drawing.Point(135, 133);
            this.address_edit_in.Multiline = true;
            this.address_edit_in.Name = "address_edit_in";
            this.address_edit_in.Size = new System.Drawing.Size(247, 71);
            this.address_edit_in.TabIndex = 7;
            // 
            // Representatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1073, 585);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Name = "Representatives";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Representatives";
            this.Load += new System.EventHandler(this.Representatives_Load);
            ((System.ComponentModel.ISupportInitialize)(this.representative_grid_view)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugStoreDBDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_in;
        private System.Windows.Forms.DataGridView representative_grid_view;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button search_representative_button;
        private System.Windows.Forms.TextBox name_search_in;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox id_search_in;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button add_representative_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contact_no_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address_in;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private DrugStoreDBDataSet drugStoreDBDataSet;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DrugStoreDBDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.ComboBox company_combo_box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button edit_representative_button;
        private System.Windows.Forms.TextBox name_edit_in;
        private System.Windows.Forms.ComboBox company_box_edit_in;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox contact_no_edit_in;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox address_edit_in;
        private System.Windows.Forms.Label id_edit_out_in;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource companyBindingSource1;
    }
}