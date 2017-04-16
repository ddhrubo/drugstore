using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drug_Store_Manager {
    public partial class Sections : Form {
        public Sections() {
            InitializeComponent();
            bindSectionGridView();
        }

        private void bindSectionGridView() {
            string qryString = "select Id, Name from Section";
            DataSet data = DatabaseManager.resultQuery(qryString);
            section_grid_view.DataSource = data.Tables[0];
        }
        private void bindSectionGridView(string qryString) {
            DataSet data = DatabaseManager.resultQuery(qryString);
            section_grid_view.DataSource = data.Tables[0];
        }

        private void digit_input_validation(object sender, KeyPressEventArgs e) {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) {
                e.Handled = true;
            }
        }

        private void add_section_button_Click(object sender, EventArgs e) {
            if (name_in.Text == "")
                return;

            string qryString = "insert into Section (Name) values('"+name_in.Text+"')";
            DatabaseManager.processQuery(qryString);

            bindSectionGridView();
            clear_input_fields();
        }

        private void clear_input_fields() {
            name_in.Text = "";
        }

        private void search_button_Click(object sender, EventArgs e) {
            string qryString = "select Id, Name from Section";

            bool option = false;
            if (id_search_in.Text != "") {
                qryString += " where Id="+id_search_in.Text;
                option = true;
            }
            if (name_search_in.Text != "") {
                if (!option) qryString += " where Name='"+name_search_in.Text+"'";
                else qryString += " and Name='" + name_search_in.Text + "'";
                option = true;
            }

            bindSectionGridView(qryString);
        }

        private void section_grid_view_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0)
                return;

            try {
                DataGridViewRow row = section_grid_view.Rows[e.RowIndex];
                id_edit_out_in.Text = row.Cells["Id"].Value.ToString();
                name_edit_in.Text = row.Cells["Name"].Value.ToString();
            } catch (Exception exep) {
            }
        }

        private void update_button_Click(object sender, EventArgs e) {
            if (id_edit_out_in.Text == "" || name_edit_in.Text == "" )
                return;
            string qryString = "update Section"
                + " set Name='"+ name_edit_in.Text +"'  "
                + " where Id=" + id_edit_out_in.Text;
            DatabaseManager.processQuery(qryString);

            bindSectionGridView();
            clear_edit_field();
        }

        private void clear_edit_field() {
            id_edit_out_in.Text = "";
            name_edit_in.Text = "";
        }
    }
}
