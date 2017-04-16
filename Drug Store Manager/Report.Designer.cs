namespace Drug_Store_Manager {
    partial class Report {
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
            this.label1 = new System.Windows.Forms.Label();
            this.start_date_in = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.end_date_in = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.purchase_button = new System.Windows.Forms.Button();
            this.sales_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.report_box = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.report_tag = new System.Windows.Forms.Label();
            this.amount_tag = new System.Windows.Forms.Label();
            this.amount_out = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.report_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 41);
            this.label13.TabIndex = 55;
            this.label13.Text = "Reports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Start Date";
            // 
            // start_date_in
            // 
            this.start_date_in.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_in.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.start_date_in.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.start_date_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_date_in.Location = new System.Drawing.Point(117, 47);
            this.start_date_in.Name = "start_date_in";
            this.start_date_in.Size = new System.Drawing.Size(243, 27);
            this.start_date_in.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "End Date";
            // 
            // end_date_in
            // 
            this.end_date_in.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_in.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.end_date_in.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.end_date_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_date_in.Location = new System.Drawing.Point(117, 96);
            this.end_date_in.Name = "end_date_in";
            this.end_date_in.Size = new System.Drawing.Size(243, 27);
            this.end_date_in.TabIndex = 59;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sales_button);
            this.groupBox1.Controls.Add(this.purchase_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.end_date_in);
            this.groupBox1.Controls.Add(this.start_date_in);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 296);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Information";
            // 
            // purchase_button
            // 
            this.purchase_button.BackColor = System.Drawing.Color.White;
            this.purchase_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_button.Location = new System.Drawing.Point(117, 147);
            this.purchase_button.Name = "purchase_button";
            this.purchase_button.Size = new System.Drawing.Size(243, 30);
            this.purchase_button.TabIndex = 60;
            this.purchase_button.Text = "Purchase Report";
            this.purchase_button.UseVisualStyleBackColor = false;
            this.purchase_button.Click += new System.EventHandler(this.purchase_button_Click);
            // 
            // sales_button
            // 
            this.sales_button.BackColor = System.Drawing.Color.White;
            this.sales_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_button.Location = new System.Drawing.Point(117, 183);
            this.sales_button.Name = "sales_button";
            this.sales_button.Size = new System.Drawing.Size(243, 30);
            this.sales_button.TabIndex = 61;
            this.sales_button.Text = "Sales Report";
            this.sales_button.UseVisualStyleBackColor = false;
            this.sales_button.Click += new System.EventHandler(this.sales_button_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(19, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 37);
            this.label3.TabIndex = 62;
            this.label3.Text = "Enter start and end date and generate purchase/sales report of that date range\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // report_box
            // 
            this.report_box.Controls.Add(this.amount_out);
            this.report_box.Controls.Add(this.amount_tag);
            this.report_box.Controls.Add(this.report_tag);
            this.report_box.Controls.Add(this.label4);
            this.report_box.Controls.Add(this.button2);
            this.report_box.Location = new System.Drawing.Point(405, 65);
            this.report_box.Name = "report_box";
            this.report_box.Size = new System.Drawing.Size(374, 296);
            this.report_box.TabIndex = 63;
            this.report_box.TabStop = false;
            this.report_box.Text = "Report";
            this.report_box.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(19, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 37);
            this.label4.TabIndex = 62;
            this.label4.Text = "Save report as pdf for full details\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(68, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 30);
            this.button2.TabIndex = 60;
            this.button2.Text = "Save PDF Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // report_tag
            // 
            this.report_tag.AutoSize = true;
            this.report_tag.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_tag.Location = new System.Drawing.Point(15, 35);
            this.report_tag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.report_tag.Name = "report_tag";
            this.report_tag.Size = new System.Drawing.Size(98, 28);
            this.report_tag.TabIndex = 64;
            this.report_tag.Text = "Reports";
            // 
            // amount_tag
            // 
            this.amount_tag.AutoSize = true;
            this.amount_tag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_tag.Location = new System.Drawing.Point(16, 74);
            this.amount_tag.Name = "amount_tag";
            this.amount_tag.Size = new System.Drawing.Size(122, 21);
            this.amount_tag.TabIndex = 63;
            this.amount_tag.Text = "Total Amount:";
            // 
            // amount_out
            // 
            this.amount_out.AutoSize = true;
            this.amount_out.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_out.Location = new System.Drawing.Point(144, 74);
            this.amount_out.Name = "amount_out";
            this.amount_out.Size = new System.Drawing.Size(122, 21);
            this.amount_out.TabIndex = 65;
            this.amount_out.Text = "Total Amount:";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(791, 373);
            this.Controls.Add(this.report_box);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.report_box.ResumeLayout(false);
            this.report_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker start_date_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker end_date_in;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sales_button;
        private System.Windows.Forms.Button purchase_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox report_box;
        private System.Windows.Forms.Label amount_out;
        private System.Windows.Forms.Label amount_tag;
        private System.Windows.Forms.Label report_tag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}