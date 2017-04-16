using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drug_Store_Manager {
    public partial class ControlEmployee : Form {
        public ControlEmployee() {
            InitializeComponent();
            bindEmployeeGridView();
        }

        private void bindEmployeeGridView() {
            string qryString = "select Id, Name, Contact_No, Address, Joining_Date, Status from Employee";
            DataSet data = DatabaseManager.resultQuery(qryString);
            employee_grid_view.DataSource = data.Tables[0];
        }
        private void bindEmployeeGridView(string qryString) {
            DataSet data = DatabaseManager.resultQuery(qryString);
            employee_grid_view.DataSource = data.Tables[0];
        }

        private void digit_input_validation(object sender, KeyPressEventArgs e) {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) {
                e.Handled = true;
                //new ToolTip().Show("Digits only!", user_id_in, 0, user_id_in.Height, 1000);
            }
        }

        private void search_button_Click(object sender, EventArgs e) {
            string qryString = "select Id, Name, Contact_No, Address, Joining_Date, Status from Employee";

            bool option = false;
            if (id_search_in.Text != "") {
                qryString += " where Id=" + id_search_in.Text;
                option = true;
            }
            if (name_search_in.Text != "") {
                if (!option) qryString += " where Name='" + name_search_in.Text + "'";
                else qryString += " and Name='" + name_search_in.Text + "'";
                option = true;
            }

            bindEmployeeGridView(qryString);
        }

        private void employee_grid_view_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0)
                return;

            try {
                DataGridViewRow row = employee_grid_view.Rows[e.RowIndex];
                int Delete_Employee_Id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                string status = row.Cells["Status"].Value.ToString();

                if ( status=="enabled" && MessageBox.Show("Do you wanto to disable this employee login?", "Confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes) {
                    string qryString = "update Employee set Status='disabled' where Id="+Delete_Employee_Id.ToString();
                    DatabaseManager.processQuery(qryString);
                    bindEmployeeGridView();
                } else if (status == "disabled" && MessageBox.Show("Do you wanto to enable this employee login?", "Confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes) {
                    string qryString = "update Employee set Status='enabled' where Id=" + Delete_Employee_Id.ToString();
                    DatabaseManager.processQuery(qryString);
                    bindEmployeeGridView();
                }
            } catch (Exception exep) { 

            }
        }
    }
}
