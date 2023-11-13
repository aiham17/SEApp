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

        // Exports the data in the data grid view to a pdf document
        // Source:  https://www.c-sharpcorner.com/blogs/export-datagridview-data-to-pdf-in-c-sharp

        public void exportPDFDoc(DataGridView dgvVendorProduct)
        {
            if (dgvVendorProduct.Rows.Count > 0)
            {
                SaveFileDialog saveDT = new SaveFileDialog();
                saveDT.Filter = "PDF (*.pdf)|*.pdf";
                saveDT.FileName = "VendorProductData.pdf";
                bool fileError = false;
                if (saveDT.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Delete(saveDT.FileName);
                    }
                    catch (IOException)
                    {
                        fileError = true;
                        MessageBox.Show("The is a problem with the export", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(dgvVendorProduct.Columns.Count);
                        pdfTable.DefaultCell.Padding = 1;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                        foreach (DataGridViewColumn column in dgvVendorProduct.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }
                        foreach (DataGridViewRow row in dgvVendorProduct.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value?.ToString());
                            }
                        }
                        using (FileStream fstream = new FileStream(saveDT.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4_LANDSCAPE, 20f, 40f, 60f, 80f);
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
