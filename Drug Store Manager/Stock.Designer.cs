namespace Drug_Store_Manager {
    partial class Stock {
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stock_grid_view = new System.Windows.Forms.DataGridView();
            this.search_product_button = new System.Windows.Forms.Button();
            this.name_search_in = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.id_search_in = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.big_label = new System.Windows.Forms.Label();
            this.product_add_group_box = new System.Windows.Forms.GroupBox();
            this.price_in = new System.Windows.Forms.TextBox();
            this.quantity_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_out = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.use_section_check_box = new System.Windows.Forms.CheckBox();
            this.section_combo_box = new System.Windows.Forms.ComboBox();
            this.drugStoreDBDataSet = new Drug_Store_Manager.DrugStoreDBDataSet();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionTableAdapter = new Drug_Store_Manager.DrugStoreDBDataSetTableAdapters.SectionTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_grid_view)).BeginInit();
            this.product_add_group_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugStoreDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.section_combo_box);
            this.groupBox2.Controls.Add(this.use_section_check_box);
            this.groupBox2.Controls.Add(this.stock_grid_view);
            this.groupBox2.Controls.Add(this.search_product_button);
            this.groupBox2.Controls.Add(this.name_search_in);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.id_search_in);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 377);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product and Stock Information";
            // 
            // stock_grid_view
            // 
            this.stock_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_grid_view.Location = new System.Drawing.Point(18, 102);
            this.stock_grid_view.Name = "stock_grid_view";
            this.stock_grid_view.ReadOnly = true;
            this.stock_grid_view.RowHeadersVisible = false;
            this.stock_grid_view.Size = new System.Drawing.Size(733, 260);
            this.stock_grid_view.TabIndex = 54;
            this.stock_grid_view.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stock_grid_view_CellMouseDoubleClick);
            // 
            // search_product_button
            // 
            this.search_product_button.BackColor = System.Drawing.Color.White;
            this.search_product_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_product_button.Location = new System.Drawing.Point(640, 66);
            this.search_product_button.Name = "search_product_button";
            this.search_product_button.Size = new System.Drawing.Size(111, 30);
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
            // big_label
            // 
            this.big_label.AutoSize = true;
            this.big_label.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.big_label.Location = new System.Drawing.Point(12, 9);
            this.big_label.Name = "big_label";
            this.big_label.Size = new System.Drawing.Size(110, 41);
            this.big_label.TabIndex = 59;
            this.big_label.Text = "Stock";
            // 
            // product_add_group_box
            // 
            this.product_add_group_box.Controls.Add(this.price_in);
            this.product_add_group_box.Controls.Add(this.quantity_in);
            this.product_add_group_box.Controls.Add(this.label3);
            this.product_add_group_box.Controls.Add(this.label2);
            this.product_add_group_box.Controls.Add(this.name_out);
            this.product_add_group_box.Controls.Add(this.add_button);
            this.product_add_group_box.Controls.Add(this.label5);
            this.product_add_group_box.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_add_group_box.Location = new System.Drawing.Point(12, 436);
            this.product_add_group_box.Name = "product_add_group_box";
            this.product_add_group_box.Size = new System.Drawing.Size(768, 181);
            this.product_add_group_box.TabIndex = 58;
            this.product_add_group_box.TabStop = false;
            this.product_add_group_box.Text = "Selected Product Information";
            // 
            // price_in
            // 
            this.price_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_in.Location = new System.Drawing.Point(110, 102);
            this.price_in.Name = "price_in";
            this.price_in.Size = new System.Drawing.Size(111, 27);
            this.price_in.TabIndex = 56;
            this.price_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_input_validation);
            // 
            // quantity_in
            // 
            this.quantity_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_in.Location = new System.Drawing.Point(110, 69);
            this.quantity_in.Name = "quantity_in";
            this.quantity_in.Size = new System.Drawing.Size(111, 27);
            this.quantity_in.TabIndex = 55;
            this.quantity_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_input_validation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Quantity";
            // 
            // name_out
            // 
            this.name_out.AutoSize = true;
            this.name_out.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_out.Location = new System.Drawing.Point(106, 34);
            this.name_out.Name = "name_out";
            this.name_out.Size = new System.Drawing.Size(0, 21);
            this.name_out.TabIndex = 53;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.White;
            this.add_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(110, 135);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(111, 30);
            this.add_button.TabIndex = 52;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Name";
            // 
            // use_section_check_box
            // 
            this.use_section_check_box.AutoSize = true;
            this.use_section_check_box.Location = new System.Drawing.Point(417, 36);
            this.use_section_check_box.Name = "use_section_check_box";
            this.use_section_check_box.Size = new System.Drawing.Size(86, 24);
            this.use_section_check_box.TabIndex = 55;
            this.use_section_check_box.Text = "Section:";
            this.use_section_check_box.UseVisualStyleBackColor = true;
            // 
            // section_combo_box
            // 
            this.section_combo_box.DataSource = this.sectionBindingSource;
            this.section_combo_box.DisplayMember = "Name";
            this.section_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.section_combo_box.FormattingEnabled = true;
            this.section_combo_box.Location = new System.Drawing.Point(509, 32);
            this.section_combo_box.Name = "section_combo_box";
            this.section_combo_box.Size = new System.Drawing.Size(242, 28);
            this.section_combo_box.TabIndex = 56;
            this.section_combo_box.ValueMember = "Id";
            // 
            // drugStoreDBDataSet
            // 
            this.drugStoreDBDataSet.DataSetName = "DrugStoreDBDataSet";
            this.drugStoreDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "Section";
            this.sectionBindingSource.DataSource = this.drugStoreDBDataSet;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(792, 629);
            this.Controls.Add(this.product_add_group_box);
            this.Controls.Add(this.big_label);
            this.Controls.Add(this.groupBox2);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_grid_view)).EndInit();
            this.product_add_group_box.ResumeLayout(false);
            this.product_add_group_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugStoreDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView stock_grid_view;
        private System.Windows.Forms.Button search_product_button;
        private System.Windows.Forms.TextBox name_search_in;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox id_search_in;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label big_label;
        private System.Windows.Forms.GroupBox product_add_group_box;
        private System.Windows.Forms.TextBox price_in;
        private System.Windows.Forms.TextBox quantity_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name_out;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox section_combo_box;
        private System.Windows.Forms.CheckBox use_section_check_box;
        private DrugStoreDBDataSet drugStoreDBDataSet;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private DrugStoreDBDataSetTableAdapters.SectionTableAdapter sectionTableAdapter;
    }
}