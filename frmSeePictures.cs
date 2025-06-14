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
    public partial class frmSeePictures : Form
    {
        private int _productID;
        private clsProductImage _image1;
        private clsProductImage _image2;
        private clsProductImage _image3;
        private clsProductImage _image4;



        public frmSeePictures(int productID)
        {
            _productID = productID;
            
            InitializeComponent();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            pbFull.ImageLocation = pb1.ImageLocation;
        }

        private void frmSeePictures_Load(object sender, EventArgs e)
        {
            _image1= clsProductImage.FindbyProductID(_productID,1);
            if (_image1 != null)
            {
                pb1.ImageLocation = _image1.ImageURL;
            }
            else
                pb1.Visible = false;
            _image2 = clsProductImage.FindbyProductID(_productID, 2);
            if (_image2 != null)
            {
                pb2.ImageLocation = _image2.ImageURL;
            }
            else
                pb2.Visible = false;
            _image3 = clsProductImage.FindbyProductID(_productID, 3);
            if (_image3 != null)
            {
                pb3.ImageLocation = _image3.ImageURL;
            }
            else
                pb3.Visible = false;
            _image4 = clsProductImage.FindbyProductID(_productID, 4);
            if (_image4 != null)
            {
                pb4.ImageLocation = _image4.ImageURL;
            }
            else
                pb4.Visible = false;
            pbFull.ImageLocation = pb1.ImageLocation;

        }

        private void pb2_Click(object sender, EventArgs e)
        {
            pbFull.ImageLocation = pb2.ImageLocation;

        }

        private void pb3_Click(object sender, EventArgs e)
        {
            pbFull.ImageLocation = pb3.ImageLocation;
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            pbFull.ImageLocation = pb4.ImageLocation;
        }
    }
}
