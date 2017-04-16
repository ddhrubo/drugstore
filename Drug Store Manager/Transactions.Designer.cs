namespace Drug_Store_Manager {
    partial class Transactions {
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
            this.big_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.search_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.type_in = new System.Windows.Forms.ComboBox();
            this.transaction_id_in = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.end_date_in = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.start_date_in = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transaction_grid_view = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // big_label
            // 
            this.big_label.AutoSize = true;
            this.big_label.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.big_label.Location = new System.Drawing.Point(12, 9);
            this.big_label.Name = "big_label";
            this.big_label.Size = new System.Drawing.Size(224, 41);
            this.big_label.TabIndex = 61;
            this.big_label.Text = "Transactions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.search_button);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.type_in);
            this.groupBox2.Controls.Add(this.transaction_id_in);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.end_date_in);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.start_date_in);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 218);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Information";
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.White;
            this.search_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(242, 172);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(111, 30);
            this.search_button.TabIndex = 69;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = "Transaction Type";
            // 
            // type_in
            // 
            this.type_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.type_in.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_in.ForeColor = System.Drawing.SystemColors.WindowText;
            this.type_in.FormattingEnabled = true;
            this.type_in.Items.AddRange(new object[] {
            "Purchase",
            "Sell"});
            this.type_in.Location = new System.Drawing.Point(154, 38);
            this.type_in.Name = "type_in";
            this.type_in.Size = new System.Drawing.Size(199, 29);
            this.type_in.TabIndex = 67;
            // 
            // transaction_id_in
            // 
            this.transaction_id_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_id_in.Location = new System.Drawing.Point(154, 139);
            this.transaction_id_in.Name = "transaction_id_in";
            this.transaction_id_in.Size = new System.Drawing.Size(199, 27);
            this.transaction_id_in.TabIndex = 66;
            this.transaction_id_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_input_validation);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 21);
            this.label11.TabIndex = 65;
            this.label11.Text = "Transaction Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "End date";
            // 
            // end_date_in
            // 
            this.end_date_in.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_in.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.end_date_in.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.end_date_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_date_in.Location = new System.Drawing.Point(154, 106);
            this.end_date_in.Name = "end_date_in";
            this.end_date_in.Size = new System.Drawing.Size(199, 27);
            this.end_date_in.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 61;
            this.label4.Text = "Start date";
            // 
            // start_date_in
            // 
            this.start_date_in.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_in.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.start_date_in.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.start_date_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_date_in.Location = new System.Drawing.Point(154, 73);
            this.start_date_in.Name = "start_date_in";
            this.start_date_in.Size = new System.Drawing.Size(199, 27);
            this.start_date_in.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transaction_grid_view);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 319);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction List";
            // 
            // transaction_grid_view
            // 
            this.transaction_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaction_grid_view.Location = new System.Drawing.Point(6, 26);
            this.transaction_grid_view.Name = "transaction_grid_view";
            this.transaction_grid_view.ReadOnly = true;
            this.transaction_grid_view.RowHeadersVisible = false;
            this.transaction_grid_view.Size = new System.Drawing.Size(773, 287);
            this.transaction_grid_view.TabIndex = 71;
            this.transaction_grid_view.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.transaction_grid_view_CellMouseDoubleClick);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(809, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.big_label);
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transaction_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label big_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker end_date_in;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker start_date_in;
        private System.Windows.Forms.ComboBox type_in;
        private System.Windows.Forms.TextBox transaction_id_in;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView transaction_grid_view;
    }
}