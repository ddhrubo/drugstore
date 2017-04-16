using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drug_Store_Manager {
    public partial class OwnerHome : Form {
        Form1 loginForm;
        public OwnerHome(Form1 login) {
            InitializeComponent();
            loginForm = login;
            loadUI();
        }

        private void loadUI() {
            string qryString = "select Name from Owner where Id=" + Organizer.logged_in_employee.ToString();
            DataSet data = DatabaseManager.resultQuery(qryString);
            employee_name_out.Text = data.Tables[0].Rows[0][0].ToString();
            date_out.Text = DateTime.Now.ToLongDateString();
        }

        private void OwnerHome_FormClosing(object sender, FormClosingEventArgs e) {
            loginForm.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            time_out.Text = DateTime.Now.ToShortTimeString();
        }

        private void employee_buttom_Click(object sender, EventArgs e) {
            new ControlEmployee().Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            new Report().Show();
        }
    }
}
