using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Drug_Store_Manager {
    public partial class TransactionInfo : Form {

        int Type, Transaction_Id, Total_Price;

        public TransactionInfo( int type, int transaction_id ) {
            InitializeComponent();

            Type = type;
            Transaction_Id = transaction_id;

            initialize_UI();
        }

        private void initialize_UI() {
            if (Type == 0) {
                /* Hide UI */
                cus_label.Visible = false;
                phone_label.Visible = false;
                customer_name_out.Visible = false;
                phone_no_out.Visible = false;

                /* Puchase Transaction */
                type_out.Text = "Purchase Transaction";
                this.Text = "Purchase Transaction";

                // bind transaction information
                transaction_id_out.Text = Transaction_Id.ToString();
                string qryString = "select Date, Employee.Name as Employee_Name, Representative.Name as Representative_Name from PurchaseTransaction, Employee, Representative where Employee_Id=Employee.Id and Representative_Id=Representative.Id and PurchaseTransaction.Id=" + Transaction_Id.ToString();
                DataSet tran_data = DatabaseManager.resultQuery(qryString);
                date_out.Text = Convert.ToDateTime(tran_data.Tables[0].Rows[0]["Date"].ToString()).ToLongDateString();
                employee_name_out.Text = tran_data.Tables[0].Rows[0]["Employee_Name"].ToString();
                representative_name_out.Text = tran_data.Tables[0].Rows[0]["Representative_Name"].ToString();

                // bind product list
                qryString = "select Product_Id, Product.Name as Product_Name, Quantity, TransactionProductRecord.Price as Price from TransactionProductRecord, Product where Product_Id=Product.Id and Type=" + Type.ToString() + " and Transaction_Id=" + Transaction_Id.ToString() + " ";
                DataSet prod_data = DatabaseManager.resultQuery(qryString);
                product_grid_view.DataSource = prod_data.Tables[0];

                // total price
                Total_Price = 0;
                foreach (DataGridViewRow product in product_grid_view.Rows) {
                    try {
                        Total_Price += ((int)product.Cells["Quantity"].Value) * ((int)product.Cells["Price"].Value);
                    } catch (Exception exep) {

                    }
                }
                total_price_out.Text = Total_Price.ToString() + "  taka only";
            } else {
                /* Sales Transaction*/
                type_out.Text = "Sales Transaction";
                this.Text = "Sales Transaction";

                /* Hide UI */
                representative_name_out.Visible = false;
                rep_label.Visible = false;

                // bind transaction information
                transaction_id_out.Text = Transaction_Id.ToString();
                string qryString = "select Date, Employee.Name as Employee_Name, Customer_Name, Customer_Contact_No from SalesTransaction, Employee where Employee_Id=Employee.Id and SalesTransaction.Id=" + Transaction_Id.ToString();
                DataSet tran_data = DatabaseManager.resultQuery(qryString);
                date_out.Text = Convert.ToDateTime(tran_data.Tables[0].Rows[0]["Date"].ToString()).ToLongDateString();
                employee_name_out.Text = tran_data.Tables[0].Rows[0]["Employee_Name"].ToString();
                customer_name_out.Text = tran_data.Tables[0].Rows[0]["Customer_Name"].ToString();
                phone_no_out.Text = tran_data.Tables[0].Rows[0]["Customer_Contact_No"].ToString();

                // bind product list
                qryString = "select Product_Id, Product.Name as Product_Name, Quantity, TransactionProductRecord.Price as Price from TransactionProductRecord, Product where Product_Id=Product.Id and Type=" + Type.ToString() + " and Transaction_Id=" + Transaction_Id.ToString() + " ";
                DataSet prod_data = DatabaseManager.resultQuery(qryString);
                product_grid_view.DataSource = prod_data.Tables[0];

                // total price
                Total_Price = 0;
                foreach (DataGridViewRow product in product_grid_view.Rows) {
                    try {
                        Total_Price += ((int)product.Cells["Quantity"].Value) * ((int)product.Cells["Price"].Value);
                    } catch (Exception exep) {

                    }
                }
                total_price_out.Text = Total_Price.ToString() + "  taka only";
            }
        }

        private void save_pdf_button_Click(object sender, EventArgs e) {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true }) {
                if (sfd.ShowDialog() == DialogResult.OK) {
                    Document doc = new Document(PageSize.A4);

                    try {
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName,FileMode.Create) );
                        doc.Open();

                        // logo
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"img\company_logo.png");
                        logo.ScaleAbsolute(200,90);
                        doc.Add(logo);
                        
                        // fonts
                        var titleFont = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD);
                        var boldTableFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
                        var bodyFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL);
                        iTextSharp.text.Rectangle pageSize = writer.PageSize;

                        /* Header Table Start */
                        PdfPTable headerTable = new PdfPTable(3);
                        headerTable.HorizontalAlignment = 0;
                        headerTable.WidthPercentage = 100;
                        headerTable.SetWidths(new float[]{3,3,4});
                        headerTable.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        headerTable.SpacingBefore = 10;
                        headerTable.SpacingAfter = 70;
                        
                        // Address Part start
                        PdfPTable addressTable = new PdfPTable(1);
                        addressTable.DefaultCell.Border = iTextSharp.text.Rectangle.BOX;

                        PdfPCell nextCell = new PdfPCell(new Phrase("Mozumdar Drug Store",boldTableFont));
                        nextCell.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER;
                        addressTable.AddCell(nextCell);
                        nextCell = new PdfPCell(new Phrase("Mirpur, Dhaka", bodyFont));
                        nextCell.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER;
                        addressTable.AddCell(nextCell);
                        nextCell = new PdfPCell(new Phrase("Bangladesh", bodyFont));
                        nextCell.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER;
                        addressTable.AddCell(nextCell);

                        PdfPCell addressCell = new PdfPCell(addressTable);
                        if (Type == 0) {
                            addressCell.Rowspan = 5;
                        } else {
                            addressCell.Rowspan = 6;
                        }
                        addressCell.Padding = 0f;
                        headerTable.AddCell(addressCell);
                        // address part end

                        // details part start
                        // title
                        headerTable.AddCell("");
                        nextCell = new PdfPCell(new Phrase(type_out.Text, titleFont));
                        nextCell.HorizontalAlignment = 2;
                        nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        headerTable.AddCell(nextCell);
                        // transaction no
                        nextCell = new PdfPCell(new Phrase("Transaction no:",bodyFont));
                        nextCell.HorizontalAlignment = 2;
                        nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        headerTable.AddCell(nextCell);
                        headerTable.AddCell(new Phrase(transaction_id_out.Text,bodyFont));
                        // date 
                        nextCell = new PdfPCell(new Phrase("Date:", bodyFont));
                        nextCell.HorizontalAlignment = 2;
                        nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        headerTable.AddCell(nextCell);
                        headerTable.AddCell(new Phrase(date_out.Text, bodyFont));
                        // employee name
                        nextCell = new PdfPCell(new Phrase("Employee:", bodyFont));
                        nextCell.HorizontalAlignment = 2;
                        nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        headerTable.AddCell(nextCell);
                        headerTable.AddCell(new Phrase(employee_name_out.Text, bodyFont));
                        if (Type == 0) {
                            // representative name
                            nextCell = new PdfPCell(new Phrase("Representative:", bodyFont));
                            nextCell.HorizontalAlignment = 2;
                            nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            headerTable.AddCell(nextCell);
                            headerTable.AddCell(new Phrase(representative_name_out.Text, bodyFont));
                        } else { 
                            // custoemr name
                            nextCell = new PdfPCell(new Phrase("Customer:", bodyFont));
                            nextCell.HorizontalAlignment = 2;
                            nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            headerTable.AddCell(nextCell);
                            headerTable.AddCell(new Phrase(customer_name_out.Text, bodyFont));
                            // customer phone no
                            nextCell = new PdfPCell(new Phrase("Contact no:", bodyFont));
                            nextCell.HorizontalAlignment = 2;
                            nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            headerTable.AddCell(nextCell);
                            headerTable.AddCell(new Phrase(phone_no_out.Text, bodyFont));
                        }
                        // details part end

                        doc.Add(headerTable);
                        /* Header Table End */

                        /* Body Table Starts */
                        PdfPTable bodyTable = new PdfPTable(4);
                        bodyTable.HorizontalAlignment = 0;
                        bodyTable.WidthPercentage = 100;
                        bodyTable.SetWidths(new float[]{ 20, 50, 20, 30 });
                        bodyTable.DefaultCell.Border = iTextSharp.text.Rectangle.BOX;
                        bodyTable.SpacingAfter = 70;

                        // headers start
                        nextCell = new PdfPCell(new Phrase("Product Id", boldTableFont));
                        nextCell.HorizontalAlignment = 1;
                        bodyTable.AddCell(nextCell);

                        nextCell = new PdfPCell(new Phrase("Name", boldTableFont));
                        nextCell.HorizontalAlignment = 1;
                        bodyTable.AddCell(nextCell);

                        nextCell = new PdfPCell(new Phrase("Quantity", boldTableFont));
                        nextCell.HorizontalAlignment = 1;
                        bodyTable.AddCell(nextCell);

                        nextCell = new PdfPCell(new Phrase("Price per unit(tk)", boldTableFont));
                        nextCell.HorizontalAlignment = 1;
                        bodyTable.AddCell(nextCell);
                        // headers end   
                    
                        // body content start
                        // product list
                        for (int row = 0; row < product_grid_view.Rows.Count; row++) {
                            for (int col = 0; col < product_grid_view.Columns.Count; col++) {
                                if (product_grid_view[col, row].Value != null) {
                                    nextCell = new PdfPCell(new Phrase(product_grid_view[col, row].Value.ToString(), bodyFont));
                                    if (col == 0) nextCell.HorizontalAlignment = 0;
                                    else if (col == 1) nextCell.HorizontalAlignment = 0;
                                    else nextCell.HorizontalAlignment = 1;
                                    bodyTable.AddCell(nextCell);
                                }
                            }
                        }
                        // footer
                        nextCell = new PdfPCell(new Phrase(""));
                        nextCell.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER;
                        nextCell.Colspan = 2;
                        bodyTable.AddCell(nextCell);

                        nextCell = new PdfPCell(new Phrase("Total Price",bodyFont));
                        nextCell.HorizontalAlignment = 1;
                        nextCell.Border = iTextSharp.text.Rectangle.TOP_BORDER;
                        bodyTable.AddCell(nextCell);

                        nextCell = new PdfPCell(new Phrase(total_price_out.Text,boldTableFont));
                        nextCell.HorizontalAlignment = 1;
                        bodyTable.AddCell(nextCell);

                        nextCell = new PdfPCell(new Phrase("**** Please contact the cashier for payment. ****",bodyFont));
                        nextCell.HorizontalAlignment = 1;
                        nextCell.Colspan = 4;
                        bodyTable.AddCell(nextCell);
                        // body content end

                        doc.Add(bodyTable);
                        /* Body Table Ends */

                        /* Footer Table start */
                        PdfPTable footerTable = new PdfPTable(2);
                        footerTable.HorizontalAlignment = 0;
                        footerTable.WidthPercentage = 100;
                        footerTable.SetWidths(new float[] { 50, 50 });
                        footerTable.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        footerTable.SpacingAfter = 70;

                        nextCell = new PdfPCell(new Phrase("Received by:",boldTableFont));
                        nextCell.HorizontalAlignment = 2;
                        nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        footerTable.AddCell(nextCell);

                        nextCell = new PdfPCell(new Phrase("Paid by:", boldTableFont));
                        nextCell.HorizontalAlignment = 2;
                        nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        footerTable.AddCell(nextCell);

                        nextCell = new PdfPCell(new Phrase("(signature and date)", bodyFont));
                        nextCell.HorizontalAlignment = 2;
                        nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        footerTable.AddCell(nextCell);
                        nextCell = new PdfPCell(new Phrase("(signature and date)", bodyFont));
                        nextCell.HorizontalAlignment = 2;
                        nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        footerTable.AddCell(nextCell);

                        doc.Add(footerTable);
                        /* Footer Table end */

                        PdfPTable remark = new PdfPTable(1);
                        remark.HorizontalAlignment = 0;
                        remark.WidthPercentage = 100;
                        remark.DefaultCell.HorizontalAlignment = 1;
                        remark.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        remark.AddCell(new Phrase("*** Please feel free to contact for any enquiry or suggestion ***",bodyFont));
                        doc.Add(remark);
                    } catch (Exception exep) {
                        MessageBox.Show(exep.Message);
                    } finally {
                        doc.Close();
                        MessageBox.Show("Pdf file saved.");
                    }
                }
            }
        }
    }
}
