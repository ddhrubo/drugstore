using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drug_Store_Manager {
    public partial class Transactions : Form {
        public Transactions() {
            InitializeComponent();
        }

        private void digit_input_validation(object sender, KeyPressEventArgs e) {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) {
                e.Handled = true;
                //new ToolTip().Show("Digits only!", user_id_in, 0, user_id_in.Height, 1000);
            }
        }

        int Type = 0;
        private void search_button_Click(object sender, EventArgs e) {
            if (type_in.Text == "")
                return;

            string qryString = "";
            if (type_in.Text == "Purchase") {
                Type = 0;

                qryString = "select PurchaseTransaction.Id as Id, Date, Employee.Name as Employee_Name, Representative.Name as Representative_Name from PurchaseTransaction, Employee, Representative where Employee_Id=Employee.Id and Representative_Id=Representative.Id";

                if (transaction_id_in.Text != "") {
                    qryString += " and PurchaseTransaction.Id=" + transaction_id_in.Text;
                } else {
                    qryString += " and '" + start_date_in.Text + "'<=Date and Date<='" + end_date_in.Text + "' ";
                }
            } else if (type_in.Text == "Sell") {
                Type = 1;

                qryString = "select SalesTransaction.Id as Id, Date, Employee.Name as Employee_Name, Customer_Name from SalesTransaction, Employee where Employee_Id=Employee.Id";

                if (transaction_id_in.Text != "") {
                    qryString += " and SalesTransaction.Id=" + transaction_id_in.Text;
                } else {
                    qryString += " and '" + start_date_in.Text + "'<=Date and Date<='" + end_date_in.Text + "' ";
                }
            } else {
                return;
            }

            DataSet data = DatabaseManager.resultQuery(qryString);
            transaction_grid_view.DataSource = data.Tables[0];
        }

        private void transaction_grid_view_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0)
                return;

            try {
                int Transaction_Id = (int) transaction_grid_view.Rows[e.RowIndex].Cells["Id"].Value;

                //MessageBox.Show(Type.ToString()+" "+Transaction_Id.ToString());
                new TransactionInfo(Type, Transaction_Id).Show();
            } catch (Exception exep) { 

            }
        }
    }
}
