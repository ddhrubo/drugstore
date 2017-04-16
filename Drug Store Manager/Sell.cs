using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drug_Store_Manager {
    public partial class Sell : Form {
        public Sell() {
            InitializeComponent();
            initialize_ui_elements();
        }

        DataTable table;
        private void initialize_ui_elements() {
            // get employee
            string qryString = "select Name from Employee where Id=" + Organizer.logged_in_employee.ToString();
            DataSet data = DatabaseManager.resultQuery(qryString);
            employee_name_out.Text = data.Tables[0].Rows[0][0].ToString();

            // table for adding product
            table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Price", typeof(int));
            product_grid_view.DataSource = table;
        }

        private void add_product_button_Click(object sender, EventArgs e) {
            new Stock(this).Show();
        }

        public void addProductProcess(ProductInfo productInfo) {
            //MessageBox.Show(productInfo.Id.ToString());
            //MessageBox.Show(productInfo.Name);

            table.Rows.Add(productInfo.Id, productInfo.Name, productInfo.Quantity, productInfo.Price);
            product_grid_view.DataSource = table;
        }

        private void product_grid_view_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0)
                return;

            int row = e.RowIndex;
            if (row >= table.Rows.Count)
                return;

            try {
                if (MessageBox.Show("Do you wanto to delete this product entry?", "Confirm delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes) {
                    table.Rows.RemoveAt(row);
                }
                product_grid_view.DataSource = table;
            } catch (Exception exep) {
                MessageBox.Show(exep.Message);
            }
        }

        private void sell_button_Click(object sender, EventArgs e) {
            if (name_in.Text == "")
                return;
            if (contact_no_in.Text == "")
                return;
            if (table.Rows.Count == 0)
                return;

            // PurchaseTransaction table entry
            string qryString = "insert into SalesTransaction(Date,Employee_Id,Customer_Name,Customer_Contact_No)"
                + " values( '" + date_in.Text + "', " + Organizer.logged_in_employee.ToString() + ", '" + name_in.Text + "', '" + contact_no_in.Text + "' )";
            DatabaseManager.processQuery(qryString);

            // get transaction id
            qryString = "select MAX(Id) from SalesTransaction";
            DataSet data = DatabaseManager.resultQuery(qryString);
            int transaction_id = Convert.ToInt32(data.Tables[0].Rows[0][0].ToString());
            MessageBox.Show("Sales transaction id is = " + transaction_id.ToString());

            // TransactionProductRecord table entry and Product.Stock value update
            foreach (DataGridViewRow product in product_grid_view.Rows) {
                try {
                    // update stock
                    qryString = "update Product set Stock=Stock-" + product.Cells["Quantity"].Value.ToString() + " where Id=" + product.Cells["Id"].Value.ToString() + " ";
                    DatabaseManager.processQuery(qryString);
                    //MessageBox.Show(qryString);

                    // add to transaction product record
                    qryString = "insert into TransactionProductRecord(Type,Transaction_Id,Product_Id,Quantity,Price)"
                        + " values( 1, " + transaction_id.ToString() + ", " + product.Cells["Id"].Value.ToString() + ", " + product.Cells["Quantity"].Value.ToString() + ", " + product.Cells["Price"].Value.ToString() + " )";
                    DatabaseManager.processQuery(qryString);
                    //MessageBox.Show(qryString);
                } catch (Exception exep) {

                }
            }

            new TransactionInfo(1, transaction_id).Show();
            this.Close();
        }

        private void digit_input_validation(object sender, KeyPressEventArgs e) {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) {
                e.Handled = true;
                //new ToolTip().Show("Digits only!", user_id_in, 0, user_id_in.Height, 1000);
            }
        }
    }
}
