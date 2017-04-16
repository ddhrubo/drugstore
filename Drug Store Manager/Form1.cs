using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drug_Store_Manager {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            //JUMP();
        }

        private void log_in_button_Click(object sender, EventArgs e) {
            if (user_id_in.Text == "" || password_in.Text == "") return;
            
            int user_id = Convert.ToInt32(user_id_in.Text);
            string password = password_in.Text;

            string qryString = "select count(Id) from Employee where Id="+user_id.ToString()+" and Password='"+password+"' and Status='enabled'";
            DataSet data = DatabaseManager.resultQuery(qryString);

            if (data.Tables[0].Rows[0][0].ToString() == "0") {
                new ToolTip().Show("Incorrect information!", log_in_button, 0, log_in_button.Height, 1000);
            } else {
                Organizer.logged_in_employee = user_id;
                new Home(this).Show();
                clear_input_field();
                this.Visible = false;
            }
        }

        private void user_id_in_KeyPress(object sender, KeyPressEventArgs e) {
            //JUMP();
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) {
                e.Handled = true;
                new ToolTip().Show("Digits only!", user_id_in, 0, user_id_in.Height, 1000);
            }
        }

        private void JUMP() {
            Organizer.logged_in_employee = 1;
            //new Transactions().Show();
            new OwnerHome(this).Show();
            this.Visible = false;
        }

        private void owner_log_in_Click(object sender, EventArgs e) {
            if (user_id_in.Text == "" || password_in.Text == "") return;

            int user_id = Convert.ToInt32(user_id_in.Text);
            string password = password_in.Text;

            string qryString = "select count(Id) from Owner where Id=" + user_id.ToString() + " and Password='" + password + "'";
            DataSet data = DatabaseManager.resultQuery(qryString);

            if (data.Tables[0].Rows[0][0].ToString() == "0") {
                new ToolTip().Show("Incorrect information!", owner_log_in, 0, owner_log_in.Height, 1000);
            } else {
                Organizer.logged_in_employee = user_id;
                new OwnerHome(this).Show();
                clear_input_field();
                this.Visible = false;
            }
        }

        private void clear_input_field() {
            user_id_in.Text = "";
            password_in.Text = "";
        }
    }
}
