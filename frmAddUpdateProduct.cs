using StoreBisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectStore
{
    public partial class frmAddUpdateProduct : Form
    {   public enum enmode { addnew =1,update =2}
        private enmode _mode;
        private clsProductCatalog _product;
        private int _productID =-1;
        public frmAddUpdateProduct(int productID)
        {
            InitializeComponent();
            _productID = productID;
            _mode = enmode.update;
        }
        public frmAddUpdateProduct()
        {
            InitializeComponent();
            _mode = enmode.addnew;

        }
        private void _FillCategoryInCombobox()
        {
            DataTable dt = clsProductCategory.GetAllCategories();
            foreach(DataRow row in dt.Rows)
            {
                cbCategory.Items.Add(row["CategoryName"]);
            }
        }
        private void _ResetDefaultValues()
        {
            _FillCategoryInCombobox();
            if (_mode == enmode.addnew)
            {
                lblTitle.Text = "Add new Product";
                _product = new clsProductCatalog();

            }

            else
                lblTitle.Text = "Update Product";

            lblProductID.Text = "???";
            txbProductName.Text = "";
            txbDescription.Text = "";
            txbPrice.Text = "";
            txbquantity.Text = "";
            cbCategory.SelectedIndex = cbCategory.FindString("Aliments");
        }

        private void _loadData()
        {   
            _product = clsProductCatalog.FindProductByID(_productID);
            if(_product == null)
            {
                MessageBox.Show("product with ID :" + _productID + " is not Found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
                
            }
           
            lblProductID.Text = _productID.ToString();
            txbProductName.Text = _product.ProductName;
            txbDescription.Text = _product.description;
            txbPrice.Text = _product.Price.ToString();
            txbquantity.Text = _product.QuantityInStock.ToString();
            cbCategory.SelectedIndex = cbCategory.FindString(_product.categoryInfo.categoryName);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateProduct_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_mode == enmode.update)
                _loadData();
        }
        private void texbox_Validating(object sender, CancelEventArgs e)
        {
            TextBox txb = (TextBox)sender;
            if(string.IsNullOrEmpty(txb.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txb, "this fieled is required");
            }
            else
            {
                errorProvider1.SetError(txb, null);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some filed are not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
