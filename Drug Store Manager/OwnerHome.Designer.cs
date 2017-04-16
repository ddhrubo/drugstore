namespace Drug_Store_Manager {
    partial class OwnerHome {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerHome));
            this.time_out = new System.Windows.Forms.Label();
            this.date_out = new System.Windows.Forms.Label();
            this.employee_name_out = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.employee_buttom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // time_out
            // 
            this.time_out.AutoSize = true;
            this.time_out.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(142)))));
            this.time_out.Location = new System.Drawing.Point(5, 73);
            this.time_out.Name = "time_out";
            this.time_out.Size = new System.Drawing.Size(271, 58);
            this.time_out.TabIndex = 29;
            this.time_out.Text = "Employee:";
            // 
            // date_out
            // 
            this.date_out.AutoSize = true;
            this.date_out.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(122)))), ((int)(((byte)(152)))));
            this.date_out.Location = new System.Drawing.Point(14, 54);
            this.date_out.Name = "date_out";
            this.date_out.Size = new System.Drawing.Size(91, 19);
            this.date_out.TabIndex = 28;
            this.date_out.Text = "Employee:";
            // 
            // employee_name_out
            // 
            this.employee_name_out.AutoSize = true;
            this.employee_name_out.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_name_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(122)))), ((int)(((byte)(152)))));
            this.employee_name_out.Location = new System.Drawing.Point(12, 9);
            this.employee_name_out.Name = "employee_name_out";
            this.employee_name_out.Size = new System.Drawing.Size(164, 36);
            this.employee_name_out.TabIndex = 27;
            this.employee_name_out.Text = "Employee:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(312, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 119);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // employee_buttom
            // 
            this.employee_buttom.BackColor = System.Drawing.Color.White;
            this.employee_buttom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.employee_buttom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_buttom.Image = ((System.Drawing.Image)(resources.GetObject("employee_buttom.Image")));
            this.employee_buttom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employee_buttom.Location = new System.Drawing.Point(150, 178);
            this.employee_buttom.Name = "employee_buttom";
            this.employee_buttom.Padding = new System.Windows.Forms.Padding(5);
            this.employee_buttom.Size = new System.Drawing.Size(284, 70);
            this.employee_buttom.TabIndex = 31;
            this.employee_buttom.Text = "  Control Employees";
            this.employee_buttom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employee_buttom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employee_buttom.UseVisualStyleBackColor = false;
            this.employee_buttom.Click += new System.EventHandler(this.employee_buttom_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(150, 254);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(284, 70);
            this.button1.TabIndex = 32;
            this.button1.Text = "  Reports";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OwnerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(595, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employee_buttom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.time_out);
            this.Controls.Add(this.date_out);
            this.Controls.Add(this.employee_name_out);
            this.Name = "OwnerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnerHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OwnerHome_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_out;
        private System.Windows.Forms.Label date_out;
        private System.Windows.Forms.Label employee_name_out;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button employee_buttom;
        private System.Windows.Forms.Button button1;
    }
}