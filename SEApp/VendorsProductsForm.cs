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
    public partial class VendorsProductsForm : Form
    {
        private Database connectDB;
        DataTable vendorProData;

        public VendorsProductsForm()
        {
            InitializeComponent();
            connectDB = Database.getConnectString();
        }

        // Sets the Data source of the Data grid with the new data when a filter is applied
        private void setDataSource(DataTable sourcedData)
        {
            dgvVendorProduct.DataSource = null;
            dgvVendorProduct.DataSource = sourcedData;
            dgvVendorProduct.ReadOnly = true;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            // Create an instance of the Dashboard Form
            Dashboard dashboard = new Dashboard();

            dashboard.Show();
            this.Close();
        }

        private void btnVendorsAndProducts_Click(object sender, EventArgs e)
        {
            // Create an instance of the VendorsProductsForm
            VendorsProductsForm vendorsProductsForm = new VendorsProductsForm();

            vendorsProductsForm.Show();
            this.Close();
        }

        private void btnAddOrAdjustVendors_Click(object sender, EventArgs e)
        {
            // Create an instance of the AddAdjustForm
            AddAdjustForm addAdjustForm = new AddAdjustForm();

            addAdjustForm.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            // Create an instance of the SettingsForm
            SettingsForm settingsForm = new SettingsForm();

            settingsForm.Show();
            this.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Create an instance of the LoginForm
            LoginForm loginForm = new LoginForm();

            loginForm.Show();
            this.Close();
        }

        private void VendorsProductsForm_Load(object sender, EventArgs e)
        {
            DataTable vendorProData = connectDB.getVendorProducts(sqlQuery.getVendorProductData);
            vendorProData.Columns.Remove("VendorID1");
            setDataSource(vendorProData);
            
            // TODO: This line of code loads data into the 'vendorProducts.VendorInfo' table. You can move, or remove it, as needed.
            //this.vendorInfoTableAdapter.Fill(this.vendorProducts.VendorInfo);
            // TODO: This line of code loads data into the 'vendorProducts.ProductInfo' table. You can move, or remove it, as needed.
            //this.productInfoTableAdapter.Fill(this.vendorProducts.ProductInfo);

        }

        private void btnActiveVendors_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.activeVendorData);
            
            setDataSource(vendorProData);
            
        }

        private void btnRatings_Click(object sender, EventArgs e)
        {
            vendorProData = connectDB.getVendorProducts(sqlQuery.vendorProRatings);
            setDataSource(vendorProData);
            
        }

        private void btnRevertData_Click(object sender, EventArgs e)
        {
           
            vendorProData = connectDB.getVendorProducts(sqlQuery.getVendorProductData);
            vendorProData.Columns.Remove("VendorID1");
            setDataSource(vendorProData);
            
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            
            vendorProData = connectDB.getVendorProducts(sqlQuery.allVendors);
            setDataSource(vendorProData);
            
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            
            vendorProData = connectDB.getVendorProducts(sqlQuery.allProducts);
            setDataSource(vendorProData);
           
        }

        // Filters the data table shown in the data grid by cloud service type
        private void cmbCloud_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                switch (cmbCloud.SelectedIndex)
                {
                   //Based Cloud
                    case 0:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.basedCloud);
                        break;
                    //Native Cloud
                    case 1:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.nativeCloud);
                        break;
                    //Enabled Cloud
                    case 2:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.enabledCloud);
                        break;
                    // None
                    case 3:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.noCloud);
                        break;
                    default:
                        
                        vendorProData = connectDB.getVendorProducts(sqlQuery.getVendorProductData);
                        break;
                }
                setDataSource(vendorProData);
            }
            catch
            {
                MessageBox.Show("This filter has an encountered an error. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbContactInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmbContactInfo.SelectedIndex)
                {
                    case 0:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.allContact);
                        break;
                    case 1:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.activeContact);
                        break;
                    default:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.allVendors);
                        break;
                }
                setDataSource(vendorProData);

            }
            catch
            {
                MessageBox.Show("This filter has an encountered an error. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCompanyAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmbCompanyAge.SelectedIndex)
                {
                    case 0:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.zeroFiveVendor);
                        break;
                    case 1:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.fiveTenVendor);
                        break;
                    case 2:
                        vendorProData = connectDB.getVendorProducts(sqlQuery.tenVendor);
                        break;
                    default:
                        break;
                }
                setDataSource(vendorProData);
            }
            catch
            {
                MessageBox.Show("This filter has an encountered an error. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Exports the data in the data grid into a pdf document
        // https://www.c-sharpcorner.com/blogs/export-datagridview-data-to-pdf-in-c-sharp
        // Thats the source I used to find and adapt slightly the code
        // This will need to be moved to the backend. Will do this once Ive got the formatting of the pdf correct
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if(dgvVendorProduct.Rows.Count > 0)
            {
                SaveFileDialog saveDT = new SaveFileDialog();
                saveDT.Filter = "PDF (*.pdf)|*.pdf";
                saveDT.FileName = "VendorProductData.pdf";
                bool fileError = false;
                if(saveDT.ShowDialog() == DialogResult.OK)
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
                if(!fileError)
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
