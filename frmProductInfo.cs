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
    public partial class frmProductInfo : Form
    {
        private int _productID;
        public frmProductInfo(int productID)
        {
            InitializeComponent();
            _productID = productID;

        }

        private void frmProductInfo_Load(object sender, EventArgs e)
        {
            ctrlProductInfo1.loadProductInfo(_productID);
        }
    }
}
