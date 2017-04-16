using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drug_Store_Manager {
    public partial class Employees : Form {
        public Employees() {
            InitializeComponent();
            bindEmployeeGridView();
        }

        private void add_employee_button_Click(object sender, EventArgs e) {
            if (name_in.Text == "" || contact_no_in.Text == "" || address_in.Text == "" || password_in.Text == "" || confirm_pass_in.Text == "")
                return;
            if (password_in.Text != confirm_pass_in.Text)
                return;

            string qryString = "insert into Employee (Name,Contact_No,Address,Joining_Date,Password)"
                + " values('" + name_in.Text + "','" + contact_no_in.Text + "' , '" + address_in.Text + "', '" + join_date_in.Text + "', '" + password_in.Text + "')";
            //MessageBox.Show(qryString);
            DatabaseManager.processQuery(qryString);
            bindEmployeeGridView();
            clear_input_fields();
        }

        private void bindEmployeeGridView() {
            string qryString = "select Id, Name, Contact_No, Address, Joining_Date from Employee";
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

        private void clear_input_fields() {
            name_in.Text = "";
            contact_no_in.Text = "";
            address_in.Text = "";
            password_in.Text = "";
            confirm_pass_in.Text = "";
        }

        private void search_button_Click(object sender, EventArgs e) {
            string qryString = "select Id, Name, Contact_No, Address, Joining_Date from Employee";

            bool option=false;
            if (id_search_in.Text != "") {
                qryString += " where Id="+id_search_in.Text;
                option = true;
            }
            if (name_search_in.Text != "") {
                if (!option) qryString += " where Name='"+name_search_in.Text+"'";
                else qryString += " and Name='" + name_search_in.Text + "'";
                option = true;
            }

            bindEmployeeGridView(qryString);
        }

        /* info edit code */
        private void employee_grid_view_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0)
                return;

            try {
                DataGridViewRow row = employee_grid_view.Rows[e.RowIndex];
                id_edit_out_in.Text = row.Cells["Id"].Value.ToString();
                name_edit_in.Text = row.Cells["Name"].Value.ToString();
                contact_no_edit_in.Text = row.Cells["Contact_No"].Value.ToString();
                address_edit_in.Text = row.Cells["Address"].Value.ToString();
            } catch (Exception exep) { 
            }
        }

        private void update_button_Click(object sender, EventArgs e) {
            if (id_edit_out_in.Text == "" || name_edit_in.Text == "" || contact_no_edit_in.Text == "" || address_edit_in.Text == "")
                return;
            string qryString = "update Employee"
                +" set Name='"+name_edit_in.Text+"', Contact_No='"+contact_no_edit_in.Text+"', Address='"+address_edit_in.Text+"' "
                +" where Id="+id_edit_out_in.Text;
            DatabaseManager.processQuery(qryString);

            bindEmployeeGridView();
            clear_edit_field();
        }

        private void clear_edit_field() {
            id_edit_out_in.Text = "";
            name_edit_in.Text = "";
            contact_no_edit_in.Text = "";
            address_edit_in.Text = "";
        }
    }
}
