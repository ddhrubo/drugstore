namespace Drug_Store_Manager {
    partial class Products {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.section_combo_box = new System.Windows.Forms.ComboBox();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugStoreDBDataSet = new Drug_Store_Manager.DrugStoreDBDataSet();
            this.company_combo_box = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_product_button = new System.Windows.Forms.Button();
            this.name_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price_in = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.section_search_combo_box = new System.Windows.Forms.ComboBox();
            this.sectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.use_section_check_box = new System.Windows.Forms.CheckBox();
            this.product_grid_view = new System.Windows.Forms.DataGridView();
            this.search_product_button = new System.Windows.Forms.Button();
            this.name_search_in = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.id_search_in = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.companyTableAdapter = new Drug_Store_Manager.DrugStoreDBDataSetTableAdapters.CompanyTableAdapter();
            this.sectionTableAdapter = new Drug_Store_Manager.DrugStoreDBDataSetTableAdapters.SectionTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.section_box_edit_in = new System.Windows.Forms.ComboBox();
            this.company_box_edit_in = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.update_product_button = new System.Windows.Forms.Button();
            this.name_edit_in = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.price_edit_in = new System.Windows.Forms.TextBox();
            this.id_edit_out_in = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sectionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugStoreDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid_view)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.section_combo_box);
            this.groupBox1.Controls.Add(this.company_combo_box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.add_product_button);
            this.groupBox1.Controls.Add(this.name_in);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.price_in);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 220);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // section_combo_box
            // 
            this.section_combo_box.DataSource = this.sectionBindingSource;
            this.section_combo_box.DisplayMember = "Name";
            this.section_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.section_combo_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section_combo_box.FormattingEnabled = true;
            this.section_combo_box.Location = new System.Drawing.Point(139, 140);
            this.section_combo_box.Name = "section_combo_box";
            this.section_combo_box.Size = new System.Drawing.Size(243, 29);
            this.section_combo_box.TabIndex = 61;
            this.section_combo_box.ValueMember = "Id";
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "Section";
            this.sectionBindingSource.DataSource = this.drugStoreDBDataSet;
            // 
            // drugStoreDBDataSet
            // 
            this.drugStoreDBDataSet.DataSetName = "DrugStoreDBDataSet";
            this.drugStoreDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // company_combo_box
            // 
            this.company_combo_box.DataSource = this.companyBindingSource;
            this.company_combo_box.DisplayMember = "Name";
            this.company_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.company_combo_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_combo_box.FormattingEnabled = true;
            this.company_combo_box.Location = new System.Drawing.Point(139, 105);
            this.company_combo_box.Name = "company_combo_box";
            this.company_combo_box.Size = new System.Drawing.Size(243, 29);
            this.company_combo_box.TabIndex = 60;
            this.company_combo_box.ValueMember = "Id";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.drugStoreDBDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Company";
            // 
            // add_product_button
            // 
            this.add_product_button.BackColor = System.Drawing.Color.White;
            this.add_product_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_button.Location = new System.Drawing.Point(202, 175);
            this.add_product_button.Name = "add_product_button";
            this.add_product_button.Size = new System.Drawing.Size(180, 30);
            this.add_product_button.TabIndex = 51;
            this.add_product_button.Text = "Add Product";
            this.add_product_button.UseVisualStyleBackColor = false;
            this.add_product_button.Click += new System.EventHandler(this.add_product_button_Click);
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
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price per unit";
            // 
            // price_in
            // 
            this.price_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_in.Location = new System.Drawing.Point(139, 63);
            this.price_in.Name = "price_in";
            this.price_in.Size = new System.Drawing.Size(243, 27);
            this.price_in.TabIndex = 5;
            this.price_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_input_validation);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.section_search_combo_box);
            this.groupBox2.Controls.Add(this.use_section_check_box);
            this.groupBox2.Controls.Add(this.product_grid_view);
            this.groupBox2.Controls.Add(this.search_product_button);
            this.groupBox2.Controls.Add(this.name_search_in);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.id_search_in);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(415, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 526);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Informations";
            // 
            // section_search_combo_box
            // 
            this.section_search_combo_box.DataSource = this.sectionBindingSource1;
            this.section_search_combo_box.DisplayMember = "Name";
            this.section_search_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.section_search_combo_box.FormattingEnabled = true;
            this.section_search_combo_box.Location = new System.Drawing.Point(110, 66);
            this.section_search_combo_box.Name = "section_search_combo_box";
            this.section_search_combo_box.Size = new System.Drawing.Size(221, 28);
            this.section_search_combo_box.TabIndex = 56;
            this.section_search_combo_box.ValueMember = "Id";
            // 
            // sectionBindingSource1
            // 
            this.sectionBindingSource1.DataMember = "Section";
            this.sectionBindingSource1.DataSource = this.drugStoreDBDataSet;
            // 
            // use_section_check_box
            // 
            this.use_section_check_box.AutoSize = true;
            this.use_section_check_box.Location = new System.Drawing.Point(18, 66);
            this.use_section_check_box.Name = "use_section_check_box";
            this.use_section_check_box.Size = new System.Drawing.Size(86, 24);
            this.use_section_check_box.TabIndex = 55;
            this.use_section_check_box.Text = "Section:";
            this.use_section_check_box.UseVisualStyleBackColor = true;
            // 
            // product_grid_view
            // 
            this.product_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_grid_view.Location = new System.Drawing.Point(18, 100);
            this.product_grid_view.Name = "product_grid_view";
            this.product_grid_view.ReadOnly = true;
            this.product_grid_view.RowHeadersVisible = false;
            this.product_grid_view.Size = new System.Drawing.Size(498, 411);
            this.product_grid_view.TabIndex = 54;
            this.product_grid_view.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.product_grid_view_CellMouseDoubleClick);
            // 
            // search_product_button
            // 
            this.search_product_button.BackColor = System.Drawing.Color.White;
            this.search_product_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_product_button.Location = new System.Drawing.Point(337, 64);
            this.search_product_button.Name = "search_product_button";
            this.search_product_button.Size = new System.Drawing.Size(179, 30);
            this.search_product_button.TabIndex = 52;
            this.search_product_button.Text = "Search";
            this.search_product_button.UseVisualStyleBackColor = false;
            this.search_product_button.Click += new System.EventHandler(this.search_product_button_Click);
            // 
            // name_search_in
            // 
            this.name_search_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_search_in.Location = new System.Drawing.Point(212, 33);
            this.name_search_in.Name = "name_search_in";
            this.name_search_in.Size = new System.Drawing.Size(304, 27);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(788, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 41);
            this.label13.TabIndex = 59;
            this.label13.Text = "Products";
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.id_edit_out_in);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.section_box_edit_in);
            this.groupBox3.Controls.Add(this.company_box_edit_in);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.update_product_button);
            this.groupBox3.Controls.Add(this.name_edit_in);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.price_edit_in);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 274);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Product";
            // 
            // section_box_edit_in
            // 
            this.section_box_edit_in.DataSource = this.sectionBindingSource2;
            this.section_box_edit_in.DisplayMember = "Name";
            this.section_box_edit_in.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.section_box_edit_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section_box_edit_in.FormattingEnabled = true;
            this.section_box_edit_in.Location = new System.Drawing.Point(139, 194);
            this.section_box_edit_in.Name = "section_box_edit_in";
            this.section_box_edit_in.Size = new System.Drawing.Size(243, 29);
            this.section_box_edit_in.TabIndex = 61;
            this.section_box_edit_in.ValueMember = "Id";
            // 
            // company_box_edit_in
            // 
            this.company_box_edit_in.DataSource = this.companyBindingSource1;
            this.company_box_edit_in.DisplayMember = "Name";
            this.company_box_edit_in.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.company_box_edit_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_box_edit_in.FormattingEnabled = true;
            this.company_box_edit_in.Location = new System.Drawing.Point(139, 159);
            this.company_box_edit_in.Name = "company_box_edit_in";
            this.company_box_edit_in.Size = new System.Drawing.Size(243, 29);
            this.company_box_edit_in.TabIndex = 60;
            this.company_box_edit_in.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "Section";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Company";
            // 
            // update_product_button
            // 
            this.update_product_button.BackColor = System.Drawing.Color.White;
            this.update_product_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_product_button.Location = new System.Drawing.Point(202, 229);
            this.update_product_button.Name = "update_product_button";
            this.update_product_button.Size = new System.Drawing.Size(180, 30);
            this.update_product_button.TabIndex = 51;
            this.update_product_button.Text = "Update Product";
            this.update_product_button.UseVisualStyleBackColor = false;
            this.update_product_button.Click += new System.EventHandler(this.update_product_button_Click);
            // 
            // name_edit_in
            // 
            this.name_edit_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_edit_in.Location = new System.Drawing.Point(139, 84);
            this.name_edit_in.Name = "name_edit_in";
            this.name_edit_in.Size = new System.Drawing.Size(243, 27);
            this.name_edit_in.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Price per unit";
            // 
            // price_edit_in
            // 
            this.price_edit_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_edit_in.Location = new System.Drawing.Point(139, 117);
            this.price_edit_in.Name = "price_edit_in";
            this.price_edit_in.Size = new System.Drawing.Size(243, 27);
            this.price_edit_in.TabIndex = 5;
            this.price_edit_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_input_validation);
            // 
            // id_edit_out_in
            // 
            this.id_edit_out_in.AutoSize = true;
            this.id_edit_out_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_edit_out_in.Location = new System.Drawing.Point(135, 43);
            this.id_edit_out_in.Name = "id_edit_out_in";
            this.id_edit_out_in.Size = new System.Drawing.Size(0, 21);
            this.id_edit_out_in.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 21);
            this.label10.TabIndex = 62;
            this.label10.Text = "Id";
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataMember = "Company";
            this.companyBindingSource1.DataSource = this.drugStoreDBDataSet;
            // 
            // sectionBindingSource2
            // 
            this.sectionBindingSource2.DataMember = "Section";
            this.sectionBindingSource2.DataSource = this.drugStoreDBDataSet;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(964, 592);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugStoreDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid_view)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_product_button;
        private System.Windows.Forms.TextBox name_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price_in;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView product_grid_view;
        private System.Windows.Forms.Button search_product_button;
        private System.Windows.Forms.TextBox name_search_in;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox id_search_in;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox company_combo_box;
        private DrugStoreDBDataSet drugStoreDBDataSet;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DrugStoreDBDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.ComboBox section_combo_box;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private DrugStoreDBDataSetTableAdapters.SectionTableAdapter sectionTableAdapter;
        private System.Windows.Forms.ComboBox section_search_combo_box;
        private System.Windows.Forms.CheckBox use_section_check_box;
        private System.Windows.Forms.BindingSource sectionBindingSource1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox section_box_edit_in;
        private System.Windows.Forms.ComboBox company_box_edit_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button update_product_button;
        private System.Windows.Forms.TextBox name_edit_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox price_edit_in;
        private System.Windows.Forms.Label id_edit_out_in;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource sectionBindingSource2;
        private System.Windows.Forms.BindingSource companyBindingSource1;
    }
}