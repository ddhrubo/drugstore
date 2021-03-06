﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drug_Store_Manager {
    public partial class Representatives : Form {
        public Representatives() {
            InitializeComponent();

            bindRepresentativeGridView();
        }

        private void bindRepresentativeGridView() {
            string qryString = "select Representative.Id as Id, Representative.Name as Name, Representative.Contact_No as Contact_No, Company.Name as Company_Name from Representative, Company where Company_Id=Company.Id";
            DataSet data = DatabaseManager.resultQuery(qryString);
            representative_grid_view.DataSource = data.Tables[0];
        }
        private void bindRepresentativeGridView(string qryString) {
            DataSet data = DatabaseManager.resultQuery(qryString);
            representative_grid_view.DataSource = data.Tables[0];
        }

        private void digit_input_validation(object sender, KeyPressEventArgs e) {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) {
                e.Handled = true;
                //new ToolTip().Show("Digits only!", user_id_in, 0, user_id_in.Height, 1000);
            }
        }

        private void add_representative_button_Click(object sender, EventArgs e) {
            if (name_in.Text == "" || contact_no_in.Text == "" || address_in.Text == "")
                return;

            string qryString = "insert into Representative(Name,Contact_No,Address,Company_Id) "
                +"values( '"+name_in.Text+"', '"+contact_no_in.Text+"', '"+address_in.Text+"', "+company_combo_box.SelectedValue.ToString()+" )";
            DatabaseManager.processQuery(qryString);
            bindRepresentativeGridView();
            clear_input_fields();
        }

        private void clear_input_fields() {
            name_in.Text = "";
            contact_no_in.Text = "";
            address_in.Text = "";
        }

        private void search_representative_button_Click(object sender, EventArgs e) {
            string qryString = "select Representative.Id as Id, Representative.Name as Name, Representative.Contact_No as Contact_No, Company.Name as Company_Name from Representative, Company where Company_Id=Company.Id";

            if (id_search_in.Text != "") {
                qryString += " and Representative.Id="+id_search_in.Text;
            }
            if (name_search_in.Text != "") {
                qryString += " and Representative.Name='"+name_search_in.Text+"'";
            }

            bindRepresentativeGridView(qryString);
        }

        private void Representatives_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'drugStoreDBDataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.drugStoreDBDataSet.Company);

        }

        /* Code for editing information */

        private void representative_grid_view_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0)
                return;

            try {
                DataGridViewRow row = representative_grid_view.Rows[e.RowIndex];
                id_edit_out_in.Text = row.Cells["Id"].Value.ToString();
                string qryString = "select * from Representative where Id="+id_edit_out_in.Text;
                DataSet data = DatabaseManager.resultQuery(qryString);
                name_edit_in.Text = data.Tables[0].Rows[0]["Name"].ToString();
                contact_no_edit_in.Text = data.Tables[0].Rows[0]["Contact_No"].ToString();
                address_edit_in.Text = data.Tables[0].Rows[0]["Address"].ToString();
                company_box_edit_in.SelectedValue = data.Tables[0].Rows[0]["Company_Id"];
            } catch (Exception exep) { }
        }

        private void edit_representative_button_Click(object sender, EventArgs e) {
            if (id_edit_out_in.Text == "" || name_edit_in.Text == "" || contact_no_edit_in.Text == "" || address_edit_in.Text == "")
                return;

            string qryString = "update Representative"
                +" set Name='"+name_edit_in.Text+"', Contact_No='"+contact_no_edit_in.Text+"', Address='"+address_edit_in.Text+"', Company_Id="+company_box_edit_in.SelectedValue.ToString()
                +" where Id="+id_edit_out_in.Text;
            DatabaseManager.processQuery(qryString);
            bindRepresentativeGridView();
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
