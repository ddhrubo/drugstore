namespace Drug_Store_Manager {
    partial class Purchase {
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
            this.product_grid_view = new System.Windows.Forms.DataGridView();
            this.add_product_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.big_label = new System.Windows.Forms.Label();
            this.date_in = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.representative_combo_box = new System.Windows.Forms.ComboBox();
            this.representativeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugStoreDBDataSet = new Drug_Store_Manager.DrugStoreDBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.employee_name_out = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.purchase_button = new System.Windows.Forms.Button();
            this.representativeTableAdapter = new Drug_Store_Manager.DrugStoreDBDataSetTableAdapters.RepresentativeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid_view)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.representativeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugStoreDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // product_grid_view
            // 
            this.product_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_grid_view.Location = new System.Drawing.Point(17, 26);
            this.product_grid_view.Name = "product_grid_view";
            this.product_grid_view.ReadOnly = true;
            this.product_grid_view.RowHeadersVisible = false;
            this.product_grid_view.Size = new System.Drawing.Size(867, 242);
            this.product_grid_view.TabIndex = 55;
            this.product_grid_view.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.product_grid_view_CellMouseDoubleClick);
            // 
            // add_product_button
            // 
            this.add_product_button.BackColor = System.Drawing.Color.White;
            this.add_product_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_button.Location = new System.Drawing.Point(762, 274);
            this.add_product_button.Name = "add_product_button";
            this.add_product_button.Size = new System.Drawing.Size(122, 30);
            this.add_product_button.TabIndex = 56;
            this.add_product_button.Text = "Add Product";
            this.add_product_button.UseVisualStyleBackColor = false;
            this.add_product_button.Click += new System.EventHandler(this.add_product_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.product_grid_view);
            this.groupBox1.Controls.Add(this.add_product_button);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 313);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // big_label
            // 
            this.big_label.AutoSize = true;
            this.big_label.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.big_label.Location = new System.Drawing.Point(12, 9);
            this.big_label.Name = "big_label";
            this.big_label.Size = new System.Drawing.Size(173, 41);
            this.big_label.TabIndex = 60;
            this.big_label.Text = "Purchase";
            // 
            // date_in
            // 
            this.date_in.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_in.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.date_in.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.date_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_in.Location = new System.Drawing.Point(157, 95);
            this.date_in.Name = "date_in";
            this.date_in.Size = new System.Drawing.Size(267, 27);
            this.date_in.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 61;
            this.label4.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.representative_combo_box);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.employee_name_out);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.date_in);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 151);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Information";
            // 
            // representative_combo_box
            // 
            this.representative_combo_box.DataSource = this.representativeBindingSource;
            this.representative_combo_box.DisplayMember = "Name";
            this.representative_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.representative_combo_box.FormattingEnabled = true;
            this.representative_combo_box.Location = new System.Drawing.Point(157, 60);
            this.representative_combo_box.Name = "representative_combo_box";
            this.representative_combo_box.Size = new System.Drawing.Size(267, 29);
            this.representative_combo_box.TabIndex = 67;
            this.representative_combo_box.ValueMember = "Id";
            // 
            // representativeBindingSource
            // 
            this.representativeBindingSource.DataMember = "Representative";
            this.representativeBindingSource.DataSource = this.drugStoreDBDataSet;
            // 
            // drugStoreDBDataSet
            // 
            this.drugStoreDBDataSet.DataSetName = "DrugStoreDBDataSet";
            this.drugStoreDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Representative:";
            // 
            // employee_name_out
            // 
            this.employee_name_out.AutoSize = true;
            this.employee_name_out.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_name_out.Location = new System.Drawing.Point(153, 33);
            this.employee_name_out.Name = "employee_name_out";
            this.employee_name_out.Size = new System.Drawing.Size(91, 19);
            this.employee_name_out.TabIndex = 64;
            this.employee_name_out.Text = "Employee:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Employee:";
            // 
            // purchase_button
            // 
            this.purchase_button.BackColor = System.Drawing.Color.White;
            this.purchase_button.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_button.Location = new System.Drawing.Point(380, 538);
            this.purchase_button.Name = "purchase_button";
            this.purchase_button.Size = new System.Drawing.Size(159, 50);
            this.purchase_button.TabIndex = 57;
            this.purchase_button.Text = "Purchase";
            this.purchase_button.UseVisualStyleBackColor = false;
            this.purchase_button.Click += new System.EventHandler(this.purchase_button_Click);
            // 
            // representativeTableAdapter
            // 
            this.representativeTableAdapter.ClearBeforeFill = true;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(917, 602);
            this.Controls.Add(this.purchase_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.big_label);
            this.Controls.Add(this.groupBox1);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_grid_view)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.representativeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugStoreDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView product_grid_view;
        private System.Windows.Forms.Button add_product_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label big_label;
        private System.Windows.Forms.DateTimePicker date_in;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label employee_name_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button purchase_button;
        private System.Windows.Forms.ComboBox representative_combo_box;
        private DrugStoreDBDataSet drugStoreDBDataSet;
        private System.Windows.Forms.BindingSource representativeBindingSource;
        private DrugStoreDBDataSetTableAdapters.RepresentativeTableAdapter representativeTableAdapter;


    }
}