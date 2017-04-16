namespace Drug_Store_Manager {
    partial class Sections {
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
            this.label4 = new System.Windows.Forms.Label();
            this.add_section_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.id_search_in = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.name_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.id_edit_out_in = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.name_edit_in = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.name_search_in = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.section_grid_view = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.section_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(790, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 41);
            this.label4.TabIndex = 61;
            this.label4.Text = "Sections";
            // 
            // add_section_button
            // 
            this.add_section_button.BackColor = System.Drawing.Color.White;
            this.add_section_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_section_button.Location = new System.Drawing.Point(244, 94);
            this.add_section_button.Name = "add_section_button";
            this.add_section_button.Size = new System.Drawing.Size(138, 30);
            this.add_section_button.TabIndex = 51;
            this.add_section_button.Text = "Add Section";
            this.add_section_button.UseVisualStyleBackColor = false;
            this.add_section_button.Click += new System.EventHandler(this.add_section_button_Click);
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
            // name_in
            // 
            this.name_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_in.Location = new System.Drawing.Point(139, 61);
            this.name_in.Name = "name_in";
            this.name_in.Size = new System.Drawing.Size(243, 27);
            this.name_in.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.id_edit_out_in);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.update_button);
            this.groupBox3.Controls.Add(this.name_edit_in);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 174);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Section Info";
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
            this.update_button.Location = new System.Drawing.Point(244, 94);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(138, 30);
            this.update_button.TabIndex = 52;
            this.update_button.Text = "Update Employee";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // name_edit_in
            // 
            this.name_edit_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_edit_in.Location = new System.Drawing.Point(139, 61);
            this.name_edit_in.Name = "name_edit_in";
            this.name_edit_in.Size = new System.Drawing.Size(243, 27);
            this.name_edit_in.TabIndex = 53;
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
            // name_search_in
            // 
            this.name_search_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_search_in.Location = new System.Drawing.Point(212, 33);
            this.name_search_in.Name = "name_search_in";
            this.name_search_in.Size = new System.Drawing.Size(187, 27);
            this.name_search_in.TabIndex = 53;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_section_button);
            this.groupBox1.Controls.Add(this.name_in);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 166);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Section";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.section_grid_view);
            this.groupBox2.Controls.Add(this.search_button);
            this.groupBox2.Controls.Add(this.name_search_in);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.id_search_in);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(415, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 302);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Section Informations";
            // 
            // section_grid_view
            // 
            this.section_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.section_grid_view.Location = new System.Drawing.Point(18, 83);
            this.section_grid_view.Name = "section_grid_view";
            this.section_grid_view.ReadOnly = true;
            this.section_grid_view.RowHeadersVisible = false;
            this.section_grid_view.Size = new System.Drawing.Size(498, 201);
            this.section_grid_view.TabIndex = 54;
            this.section_grid_view.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.section_grid_view_CellMouseDoubleClick);
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(959, 377);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Sections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sections";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.section_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_section_button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox id_search_in;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox name_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label id_edit_out_in;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox name_edit_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name_search_in;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView section_grid_view;
    }
}