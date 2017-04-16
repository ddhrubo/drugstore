namespace Drug_Store_Manager {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.user_id_in = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password_in = new System.Windows.Forms.TextBox();
            this.log_in_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.owner_log_in = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Id";
            // 
            // user_id_in
            // 
            this.user_id_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_id_in.Location = new System.Drawing.Point(626, 173);
            this.user_id_in.Name = "user_id_in";
            this.user_id_in.Size = new System.Drawing.Size(210, 27);
            this.user_id_in.TabIndex = 1;
            this.user_id_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_id_in_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // password_in
            // 
            this.password_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_in.Location = new System.Drawing.Point(626, 206);
            this.password_in.Name = "password_in";
            this.password_in.PasswordChar = '*';
            this.password_in.Size = new System.Drawing.Size(210, 27);
            this.password_in.TabIndex = 3;
            // 
            // log_in_button
            // 
            this.log_in_button.BackColor = System.Drawing.Color.White;
            this.log_in_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_in_button.Location = new System.Drawing.Point(677, 239);
            this.log_in_button.Name = "log_in_button";
            this.log_in_button.Size = new System.Drawing.Size(159, 30);
            this.log_in_button.TabIndex = 4;
            this.log_in_button.Text = "Employee Log In";
            this.log_in_button.UseVisualStyleBackColor = false;
            this.log_in_button.Click += new System.EventHandler(this.log_in_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drug Store Manager";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "One stop solution for medicine shops.";
            // 
            // owner_log_in
            // 
            this.owner_log_in.BackColor = System.Drawing.Color.White;
            this.owner_log_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner_log_in.Location = new System.Drawing.Point(677, 275);
            this.owner_log_in.Name = "owner_log_in";
            this.owner_log_in.Size = new System.Drawing.Size(159, 30);
            this.owner_log_in.TabIndex = 7;
            this.owner_log_in.Text = "Owner Log In";
            this.owner_log_in.UseVisualStyleBackColor = false;
            this.owner_log_in.Click += new System.EventHandler(this.owner_log_in_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 355);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(873, 377);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.owner_log_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.log_in_button);
            this.Controls.Add(this.password_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_id_in);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_id_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_in;
        private System.Windows.Forms.Button log_in_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button owner_log_in;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

