using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SEApp
{
    internal class exportPDF
    {
        //Adam:

        // Exports the data in the data grid view to a pdf document
        // This code was lifted from the source below
        // Source:  https://www.c-sharpcorner.com/blogs/export-datagridview-data-to-pdf-in-c-sharp

        public void exportPDFDoc(DataGridView dgvVendorProduct)
        {
            if (dgvVendorProduct.Rows.Count > 0)
            {
                SaveFileDialog saveDT = new SaveFileDialog();

                // Sets the file type to PDF
                saveDT.Filter = "PDF (*.pdf)|*.pdf";

                //Sets the default file name to VendorProductData.pdf
                saveDT.FileName = "VendorProductData.pdf";
                bool fileError = false;
                if (saveDT.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Tries to delete the previous VendorProductData pdf file to allow the newly exported one to take its place
                        File.Delete(saveDT.FileName);
                    }
                    catch (IOException)
                    {
                        // If there is an issue with the export this error message will appear.
                        fileError = true;
                        MessageBox.Show("The is a problem with the export", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        // Creates a PDF Table which is similar to a Data table, with the same number of columns displayed in the Data grid dgvVendorProduct
                        PdfPTable pdfTable = new PdfPTable(dgvVendorProduct.Columns.Count);

                        // Sets the formatting of each cell in the PDF Table.
                        pdfTable.DefaultCell.Padding = 1;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        // Grabs the column headers, displayed in the Data Grid View.
                        foreach (DataGridViewColumn column in dgvVendorProduct.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }
                        // Grabs the data from each row and cell to then be added to the pdfTable, which will then be written to the pdf document
                        foreach (DataGridViewRow row in dgvVendorProduct.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value?.ToString());
                            }
                        }
                        // Opens a file stream to enable a pdf document to be created, written to and then closed.
                        using (FileStream fstream = new FileStream(saveDT.FileName, FileMode.Create))
                        {
                            // Sets the formatting for the PDF Document: A4 and Landscape.
                            Document pdfDoc = new Document(PageSize.A4, 20f, 40f, 60f, 80f);
                            pdfDoc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                            PdfWriter.GetInstance(pdfDoc, fstream);
                            pdfDoc.Open();
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            fstream.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("No records to export", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
