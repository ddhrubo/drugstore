using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drug_Store_Manager {
    public partial class Stock : Form {
        public Stock() {
            InitializeComponent();
            bindStockGridView();
            show_only_stock_ui();
        }

        Purchase purchase_form=null;
        public Stock(Purchase purchaseForm) {
            InitializeComponent();
            bindStockGridView();
            
            purchase_form = purchaseForm;
            this.Text = "Select Product";
            big_label.Text = "Select Product";
        }

        Sell sell_form = null;
        public Stock(Sell sellForm) {
            InitializeComponent();
            bindStockGridView();

            sell_form = sellForm;
            this.Text = "Select Product";
            big_label.Text = "Select Product";
        }

        private void show_only_stock_ui() {
            this.Height = 480;
            product_add_group_box.Visible = false;
        }

        private void bindStockGridView() {
            string qryString = "select Id, Name, Price, Stock from Product";
            DataSet data = DatabaseManager.resultQuery(qryString);
            stock_grid_view.DataSource = data.Tables[0];
        }
        private void bindStockGridView(string qryString) {
            DataSet data = DatabaseManager.resultQuery(qryString);
            stock_grid_view.DataSource = data.Tables[0];
        }

        private void digit_input_validation(object sender, KeyPressEventArgs e) {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) {
                e.Handled = true;
                //new ToolTip().Show("Digits only!", user_id_in, 0, user_id_in.Height, 1000);
            }
        }

        private void search_product_button_Click(object sender, EventArgs e) {
            string qryString = "select Id, Name, Price, Stock from Product";

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
            if (use_section_check_box.Checked) {
                if (!option) qryString += " where Section_Id="+section_combo_box.SelectedValue.ToString();
                else qryString += " and Section_Id=" + section_combo_box.SelectedValue.ToString();
                option = true;
            }

            bindStockGridView(qryString);
        }

        int Product_Id;
        int Stock_Amount;

        private void stock_grid_view_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0) return;

            try {
                DataGridViewRow row = this.stock_grid_view.Rows[e.RowIndex];

                Product_Id = (int)row.Cells["Id"].Value;
                Stock_Amount = (int)row.Cells["Stock"].Value;

                name_out.Text = row.Cells["Name"].Value.ToString();

                if (purchase_form == null && sell_form != null) {
                    price_in.Text = row.Cells["Price"].Value.ToString();
                }

                // setting edit portion

            } catch (Exception exep) {

            }
        }

        private void add_button_Click(object sender, EventArgs e) {
            // general check
            if (name_out.Text == "" || quantity_in.Text == "" || price_in.Text == "")
                return;

            // form specific check

            // form specific return procedure            
            if (purchase_form != null) {
                this.Visible = false;
                purchase_form.addProductProcess(new ProductInfo(Product_Id, name_out.Text, Convert.ToInt32(quantity_in.Text), Convert.ToInt32(price_in.Text)));
                this.Close();
            } else if (sell_form != null) {
                if (Convert.ToInt32(quantity_in.Text) > Stock_Amount) {
                    MessageBox.Show("Entered quantity is more than product quantity currently in stock.");
                    return;
                } else {
                    this.Visible = false;
                    sell_form.addProductProcess(new ProductInfo(Product_Id, name_out.Text, Convert.ToInt32(quantity_in.Text), Convert.ToInt32(price_in.Text)));
                    this.Close();
                }
            }
        }

        private void Stock_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'drugStoreDBDataSet.Section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter.Fill(this.drugStoreDBDataSet.Section);

        }
    }
}
