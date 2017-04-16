using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drug_Store_Manager {
    public partial class Products : Form {
        public Products() {
            InitializeComponent();
            bindProductGridView();
        }

        private void bindProductGridView() {
            string qryString = "select Product.Id as Product_Id, Product.Name as Product_Name, Price, Company.Name as Company_Name, Section.Name as Section_Name from Product, Company, Section where Company_Id=Company.Id and Section_Id=Section.Id";
            DataSet data = DatabaseManager.resultQuery(qryString);
            product_grid_view.DataSource = data.Tables[0];
        }
        private void bindProductGridView(string qryString) {
            DataSet data = DatabaseManager.resultQuery(qryString);
            product_grid_view.DataSource = data.Tables[0];
        }

        private void digit_input_validation(object sender, KeyPressEventArgs e) {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) {
                e.Handled = true;
                //new ToolTip().Show("Digits only!", user_id_in, 0, user_id_in.Height, 1000);
            }
        }

        private void add_product_button_Click(object sender, EventArgs e) {
            if (name_in.Text == "" || price_in.Text == "" )
                return;

            string qryString = "insert into Product (Name,Price,Company_Id,Section_Id)"
                +" values( '"+name_in.Text+"', "+price_in.Text+", "+company_combo_box.SelectedValue.ToString()+", "+section_combo_box.SelectedValue.ToString()+" )";

            DatabaseManager.processQuery(qryString);
            bindProductGridView();
            clear_input_fields();
        }

        private void clear_input_fields() {
            name_in.Text = "";
            price_in.Text = "";
        }

        private void search_product_button_Click(object sender, EventArgs e) {
            string qryString = "select Product.Id as Product_Id, Product.Name as Product_Name, Price, Company.Name as Company_Name, Section.Name as Section_Name from Product, Company, Section where Company_Id=Company.Id and Section_Id=Section.Id";

            if (id_search_in.Text != "") {
                qryString += " and Product.Id="+id_search_in.Text;
            }
            if (name_search_in.Text != "") {
                qryString += " and Product.Name='"+name_search_in.Text+"'";
            }
            if (use_section_check_box.Checked) {
                qryString += " and Product.Section_Id="+section_search_combo_box.SelectedValue.ToString();
            }

            bindProductGridView(qryString);
        }

        private void Products_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'drugStoreDBDataSet.Section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter.Fill(this.drugStoreDBDataSet.Section);
            // TODO: This line of code loads data into the 'drugStoreDBDataSet.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.drugStoreDBDataSet.Company);

        }

        private void product_grid_view_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0)
                return;

            try {
                DataGridViewRow row = product_grid_view.Rows[e.RowIndex];
                id_edit_out_in.Text = row.Cells["Product_Id"].Value.ToString();
                string qryString = "select * from Product where Id=" + id_edit_out_in.Text;
                DataSet data = DatabaseManager.resultQuery(qryString);
                name_edit_in.Text = data.Tables[0].Rows[0]["Name"].ToString();
                price_edit_in.Text = data.Tables[0].Rows[0]["Price"].ToString();
                company_box_edit_in.SelectedValue = data.Tables[0].Rows[0]["Company_Id"];
                section_box_edit_in.SelectedValue = data.Tables[0].Rows[0]["Section_Id"];
            } catch (Exception exep) { }
        }

        private void update_product_button_Click(object sender, EventArgs e) {
            if (id_edit_out_in.Text == "" || name_edit_in.Text == "" || price_edit_in.Text == "")
                return;

            string qryString = "update Product"
                +" set Name='"+name_edit_in.Text+"', Price="+price_edit_in.Text+", Company_Id="+company_box_edit_in.SelectedValue.ToString()+", Section_Id="+section_box_edit_in.SelectedValue.ToString()
                +" where Id="+id_edit_out_in.Text;
            DatabaseManager.processQuery(qryString);

            bindProductGridView();
            clear_edit_field();
        }

        private void clear_edit_field() {
            id_edit_out_in.Text = "";
            name_edit_in.Text = "";
            price_edit_in.Text = "";
        }
    }
}
