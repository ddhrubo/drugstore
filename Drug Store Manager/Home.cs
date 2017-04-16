using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drug_Store_Manager {
    public partial class Home : Form {
        Form loginForm;
        public Home(Form1 loginForm) {
            this.loginForm = loginForm;
            InitializeComponent();

            loadUI();
        }

        private void loadUI() {
            string qryString = "select Name from Employee where Id="+Organizer.logged_in_employee.ToString();
            DataSet data = DatabaseManager.resultQuery(qryString);
            employee_name_out.Text = data.Tables[0].Rows[0][0].ToString();
            date_out.Text = DateTime.Now.ToLongDateString();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e) {
            loginForm.Visible = true;
        }

        private void employee_buttom_Click(object sender, EventArgs e) {
            new Employees().Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            new Companies().Show();
        }

        private void button4_Click(object sender, EventArgs e) {
            new Sections().Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            new Representatives().Show();
        }

        private void button5_Click(object sender, EventArgs e) {
            new Products().Show();
        }

        private void button6_Click(object sender, EventArgs e) {
            new Stock().Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            new Purchase().Show();
        }

        private void button7_Click(object sender, EventArgs e) {
            new Transactions().Show();
        }

        private void button8_Click(object sender, EventArgs e) {
            new Sell().Show();
        }

        private void button9_Click(object sender, EventArgs e) {
            new AboutUs().Show();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            time_out.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
