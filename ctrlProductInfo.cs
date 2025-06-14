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
    public partial class ctrlProductInfo : UserControl
    {

        private int _prodID;
        private clsProductCatalog _product;
        public ctrlProductInfo()
        {
            InitializeComponent();
        }
        public int productID
        {
            get
            {
                return _prodID;
            }
        }
        public clsProductCatalog Product
        {
            get { return _product; }
        }
        private void _LoadPictures()
        {
            clsProductImage image1 = clsProductImage.FindbyProductID(_prodID,1);
            if (image1 != null)
                pic1.ImageLocation = image1.ImageURL;
            clsProductImage image2 = clsProductImage.FindbyProductID(_prodID, 2);
            if (image2 != null)
                pic2.ImageLocation = image2.ImageURL;
            clsProductImage image3 = clsProductImage.FindbyProductID(_prodID, 3);
            if (image3 != null)
                pic3.ImageLocation = image3.ImageURL;
            clsProductImage image4 = clsProductImage.FindbyProductID(_prodID, 4);
            if (image4 != null)
                pic4.ImageLocation = image4.ImageURL;
        }
        public void loadProductInfo(int productID)
        {
            _prodID = productID;
            _product = clsProductCatalog.FindProductByID(productID);
            if(_product != null)
            {
                lblProductID.Text = _product.ProductID.ToString();
                lblProductName.Text = _product.ProductName;
                lblDescription.Text = _product.description;
                lblPrice.Text = _product.Price.ToString();
                lblQuantityInStock.Text = _product.QuantityInStock.ToString();
                lblCategori.Text = _product.categoryInfo.categoryName;
                _LoadPictures();
            }
            else
            {
                MessageBox.Show("product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefualtValue();
                return;
            }

        }
        private void _ResetDefualtValue()
        {
            lblProductID.Text = "???";
            lblProductName.Text = "????";
            lblDescription.Text = "????";
            lblPrice.Text = "$$$";
            lblQuantityInStock.Text = "???";
            lblCategori.Text = "????";
            pic1.ImageLocation = null;
            pic2.ImageLocation = null;
            pic3.ImageLocation = null;
            pic4.ImageLocation = null;
        }
        public void loadProductInfo(string productName)
        {
            _product = clsProductCatalog.FindProductByName(productName);

            if (_product != null)
            {
                _prodID = _product.ProductID;
                lblProductID.Text = _product.ProductID.ToString();
                lblProductName.Text = _product.ProductName;
                lblDescription.Text = _product.description;
                lblPrice.Text = _product.Price.ToString();
                lblQuantityInStock.Text = _product.QuantityInStock.ToString();
                lblCategori.Text = _product.categoryInfo.categoryName;
                _LoadPictures();
            }
            else
            {
                MessageBox.Show("product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefualtValue();
                return;
            }

        }



    }
}
