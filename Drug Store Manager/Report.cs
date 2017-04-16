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
    public partial class Report : Form {
        public Report() {
            InitializeComponent();
        }

        private void enable_report_ui() {
            report_box.Visible = true;
            button2.Visible = true;
        }

        private void purchase_button_Click(object sender, EventArgs e) {
            Type = 0;
            generate_report();
            report_tag.Text = "Purchase Report";
            enable_report_ui();

            amount_out.Text = ttl_amount.ToString();
            if (ttl_amount == 0)
                button2.Visible = false;
        }

        private void sales_button_Click(object sender, EventArgs e) {
            Type = 1;
            generate_report();
            report_tag.Text = "Sales Report";
            enable_report_ui();

            amount_out.Text = ttl_amount.ToString();
            if (ttl_amount == 0)
                button2.Visible = false;
        }

        int Type, ttl_amount;
        PdfPTable headerTable, productTable, companyTable, employeeTable, representativeTable;
        string qryString;
        private void generate_report() {
            // fonts
            var titleFont = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD);
            var boldTableFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
            var bodyFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL);

            /* Header Table start */
            headerTable = new PdfPTable(2);
            headerTable.HorizontalAlignment = 0;
            headerTable.WidthPercentage = 100;
            headerTable.SetWidths(new float[] { 50, 50 });
            headerTable.SpacingBefore = 30;
            headerTable.SpacingAfter = 30;

            PdfPCell nextCell = new PdfPCell(new Phrase("From", boldTableFont));
            nextCell.HorizontalAlignment = 2;
            nextCell.Border = iTextSharp.text.Rectangle.RIGHT_BORDER;
            headerTable.AddCell(nextCell);

            nextCell = new PdfPCell(new Phrase("To", boldTableFont));
            nextCell.HorizontalAlignment = 0;
            nextCell.Border = iTextSharp.text.Rectangle.LEFT_BORDER;
            headerTable.AddCell(nextCell);

            nextCell = new PdfPCell(new Phrase(start_date_in.Value.ToLongDateString(), bodyFont));
            nextCell.HorizontalAlignment = 2;
            nextCell.Border = iTextSharp.text.Rectangle.RIGHT_BORDER;
            headerTable.AddCell(nextCell);

            nextCell = new PdfPCell(new Phrase(end_date_in.Value.ToLongDateString(), bodyFont));
            nextCell.HorizontalAlignment = 0;
            nextCell.Border = iTextSharp.text.Rectangle.LEFT_BORDER;
            headerTable.AddCell(nextCell);
            /* Header Table end */

            /* Products Table start */
            productTable = new PdfPTable(3);
            productTable.HorizontalAlignment = 0;
            productTable.WidthPercentage = 100;
            productTable.SetWidths( new float[]{ 50, 20, 20 } );
            productTable.DefaultCell.Border = iTextSharp.text.Rectangle.BOX;
            productTable.DefaultCell.HorizontalAlignment = 1;
            productTable.SpacingBefore = 5;
            productTable.SpacingAfter = 30;

            if (Type == 0) {
                qryString = " select Product.Name as Name, SUM(TransactionProductRecord.Quantity) as Quantity, SUM(TransactionProductRecord.Quantity * TransactionProductRecord.Price) as Amount " +
                " from PurchaseTransaction, TransactionProductRecord, Product where '" + start_date_in.Text + "'<=Date and Date<='" + end_date_in.Text + "' " +
                " and Type=0 and Transaction_Id=PurchaseTransaction.Id and Product_Id=Product.Id " +
                " group by Product.Name";
            } else {
                qryString = " select Product.Name as Name, SUM(TransactionProductRecord.Quantity) as Quantity, SUM(TransactionProductRecord.Quantity * TransactionProductRecord.Price) as Amount " +
                " from SalesTransaction, TransactionProductRecord, Product where '" + start_date_in.Text + "'<=Date and Date<='" + end_date_in.Text + "' " +
                " and Type=1 and Transaction_Id=SalesTransaction.Id and Product_Id=Product.Id " +
                " group by Product.Name";
            }
            DataSet data = DatabaseManager.resultQuery(qryString);
            // table headers
            productTable.AddCell( new Phrase("Name",boldTableFont) );
            productTable.AddCell(new Phrase("Quantity", boldTableFont));
            productTable.AddCell(new Phrase("Price(Taka)", boldTableFont));
            // table data
            ttl_amount = 0;
            foreach (DataRow row in data.Tables[0].Rows) {
                PdfPCell nameCell = new PdfPCell(new Phrase( row["Name"].ToString(), bodyFont ));
                nameCell.HorizontalAlignment = 0;
                productTable.AddCell(nameCell);

                productTable.AddCell(new Phrase( row["Quantity"].ToString() , bodyFont));
                productTable.AddCell(new Phrase(row["Amount"].ToString(), bodyFont));

                ttl_amount += Convert.ToInt32(row["Amount"].ToString());
            }
            nextCell = new PdfPCell( new Phrase( "Total amount", boldTableFont ) );
            nextCell.Colspan = 2;
            nextCell.HorizontalAlignment = 2;
            nextCell.Padding = 5;
            nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            productTable.AddCell( nextCell );
            productTable.AddCell( new Phrase( ttl_amount.ToString()+" taka", boldTableFont  ) );
            /* Products Table end */

            /* Company Table start */
            companyTable = new PdfPTable(2);
            companyTable.HorizontalAlignment = 0;
            companyTable.WidthPercentage = 100;
            companyTable.SetWidths(new float[] { 50, 30 });
            companyTable.DefaultCell.Border = iTextSharp.text.Rectangle.BOX;
            companyTable.DefaultCell.HorizontalAlignment = 1;
            companyTable.SpacingBefore = 5;
            companyTable.SpacingAfter = 30;

            if (Type == 0) {
                qryString = " select Company.Name as Name, SUM(TransactionProductRecord.Quantity * TransactionProductRecord.Price) as Amount " +
                " from PurchaseTransaction, TransactionProductRecord, Product, Company where '" + start_date_in.Text + "'<=Date and Date<='" + end_date_in.Text + "' " +
                " and Type=0 and Transaction_Id=PurchaseTransaction.Id and Product_Id=Product.Id and Product.Company_Id=Company.Id " +
                " group by Company.Name";
            } else {
                qryString = " select Company.Name as Name, SUM(TransactionProductRecord.Quantity * TransactionProductRecord.Price) as Amount " +
                " from SalesTransaction, TransactionProductRecord, Product, Company where '" + start_date_in.Text + "'<=Date and Date<='" + end_date_in.Text + "' " +
                " and Type=1 and Transaction_Id=SalesTransaction.Id and Product_Id=Product.Id and Product.Company_Id=Company.Id " +
                " group by Company.Name";
            }
            data = DatabaseManager.resultQuery(qryString);
            // table headers
            companyTable.AddCell(new Phrase("Name", boldTableFont));
            companyTable.AddCell(new Phrase("Amount(Taka)", boldTableFont));
            // table data
            ttl_amount = 0;
            foreach (DataRow row in data.Tables[0].Rows) {
                PdfPCell nameCell = new PdfPCell(new Phrase(row["Name"].ToString(), bodyFont));
                nameCell.HorizontalAlignment = 0;
                companyTable.AddCell(nameCell);

                companyTable.AddCell(new Phrase(row["Amount"].ToString(), bodyFont));

                ttl_amount += Convert.ToInt32(row["Amount"].ToString());
            }
            nextCell = new PdfPCell(new Phrase("Total amount", boldTableFont));
            nextCell.HorizontalAlignment = 2;
            nextCell.Padding = 5;
            nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            companyTable.AddCell(nextCell);
            companyTable.AddCell(new Phrase(ttl_amount.ToString() + " taka", boldTableFont));
            /* Company Table end */

            /* Employee Table start */
            employeeTable = new PdfPTable(2);
            employeeTable.HorizontalAlignment = 0;
            employeeTable.WidthPercentage = 100;
            employeeTable.SetWidths(new float[] { 50, 30 });
            employeeTable.DefaultCell.Border = iTextSharp.text.Rectangle.BOX;
            employeeTable.DefaultCell.HorizontalAlignment = 1;
            employeeTable.SpacingBefore = 5;
            employeeTable.SpacingAfter = 30;

            if (Type == 0) {
                qryString = " select Employee.Name as Name, SUM(TransactionProductRecord.Quantity * TransactionProductRecord.Price) as Amount " +
                " from PurchaseTransaction, TransactionProductRecord, Employee where '" + start_date_in.Text + "'<=Date and Date<='" + end_date_in.Text + "' " +
                " and Type=0 and Transaction_Id=PurchaseTransaction.Id and Employee_Id=Employee.Id " +
                " group by Employee.Name";
            } else {
                qryString = " select Employee.Name as Name, SUM(TransactionProductRecord.Quantity * TransactionProductRecord.Price) as Amount " +
                " from SalesTransaction, TransactionProductRecord, Employee where '" + start_date_in.Text + "'<=Date and Date<='" + end_date_in.Text + "' " +
                " and Type=1 and Transaction_Id=SalesTransaction.Id and Employee_Id=Employee.Id " +
                " group by Employee.Name";
            }
            data = DatabaseManager.resultQuery(qryString);
            // table headers
            employeeTable.AddCell(new Phrase("Name", boldTableFont));
            employeeTable.AddCell(new Phrase("Amount(Taka)", boldTableFont));
            // table data
            ttl_amount = 0;
            foreach (DataRow row in data.Tables[0].Rows) {
                PdfPCell nameCell = new PdfPCell(new Phrase(row["Name"].ToString(), bodyFont));
                nameCell.HorizontalAlignment = 0;
                employeeTable.AddCell(nameCell);

                employeeTable.AddCell(new Phrase(row["Amount"].ToString(), bodyFont));

                ttl_amount += Convert.ToInt32(row["Amount"].ToString());
            }
            nextCell = new PdfPCell(new Phrase("Total amount", boldTableFont));
            nextCell.HorizontalAlignment = 2;
            nextCell.Padding = 5;
            nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            employeeTable.AddCell(nextCell);
            employeeTable.AddCell(new Phrase(ttl_amount.ToString() + " taka", boldTableFont));
            /* Employee Table end */

            if (Type != 0)
                return;

            /* Representative Table start */
            representativeTable = new PdfPTable(2);
            representativeTable.HorizontalAlignment = 0;
            representativeTable.WidthPercentage = 100;
            representativeTable.SetWidths(new float[] { 50, 30 });
            representativeTable.DefaultCell.Border = iTextSharp.text.Rectangle.BOX;
            representativeTable.DefaultCell.HorizontalAlignment = 1;
            representativeTable.SpacingBefore = 5;
            representativeTable.SpacingAfter = 30;

            qryString = " select Representative.Name as Name, SUM(TransactionProductRecord.Quantity * TransactionProductRecord.Price) as Amount " +
                " from PurchaseTransaction, TransactionProductRecord, Representative where '" + start_date_in.Text + "'<=Date and Date<='" + end_date_in.Text + "' " +
                " and Type=0 and Transaction_Id=PurchaseTransaction.Id and Representative_Id=Representative.Id " +
                " group by Representative.Name";
            data = DatabaseManager.resultQuery(qryString);

            // table headers
            representativeTable.AddCell(new Phrase("Name", boldTableFont));
            representativeTable.AddCell(new Phrase("Amount(Taka)", boldTableFont));
            // table data
            ttl_amount = 0;
            foreach (DataRow row in data.Tables[0].Rows) {
                PdfPCell nameCell = new PdfPCell(new Phrase(row["Name"].ToString(), bodyFont));
                nameCell.HorizontalAlignment = 0;
                representativeTable.AddCell(nameCell);

                representativeTable.AddCell(new Phrase(row["Amount"].ToString(), bodyFont));

                ttl_amount += Convert.ToInt32(row["Amount"].ToString());
            }
            nextCell = new PdfPCell(new Phrase("Total amount", boldTableFont));
            nextCell.HorizontalAlignment = 2;
            nextCell.Padding = 5;
            nextCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            representativeTable.AddCell(nextCell);
            representativeTable.AddCell(new Phrase(ttl_amount.ToString() + " taka", boldTableFont));
            /* Representative Table end */
        }

        // save pdf button
        private void button2_Click(object sender, EventArgs e) {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true }) {
                if (sfd.ShowDialog() == DialogResult.OK) {
                    Document doc = new Document(PageSize.A4);

                    try {
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        // logo
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"img\company_logo.png");
                        logo.ScaleAbsolute(200, 90);
                        doc.Add(logo);

                        // fonts
                        var titleFont = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD);
                        var boldTableFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
                        var bodyFont = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL);

                        Paragraph para = new Paragraph(report_tag.Text, titleFont);
                        para.SpacingBefore = 10;
                        doc.Add(para);
                        doc.Add(new Paragraph("Mozumdar Drug Store, Mirpur, Dhaka.", bodyFont));
                        doc.Add( new Paragraph("Issue Date: "+DateTime.Now.ToLongDateString(),bodyFont) );

                        doc.Add(headerTable);

                        doc.Add(new Paragraph("Product wise: ", boldTableFont));
                        doc.Add(productTable);

                        doc.Add(new Paragraph("Company wise: ", boldTableFont));
                        doc.Add(companyTable);

                        doc.Add(new Paragraph("Employee wise: ", boldTableFont));
                        doc.Add(employeeTable);

                        if (Type == 0) {
                            doc.Add(new Paragraph("Representative wise: ", boldTableFont));
                            doc.Add(representativeTable);
                        }

                    } catch (Exception exep) {
                    } finally {
                        doc.Close();
                        MessageBox.Show("Pdf file saved!");
                    }
                }
            }
        }
    }
}
