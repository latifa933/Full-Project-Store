using ProjectStore;
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
    public partial class frmShowProductsByCategory : Form
    {
        private int _categoryID;
        private int _orderID;
        private frmMakeOrder _fr;
        public frmShowProductsByCategory(frmMakeOrder fr,int orderID,int categoryID)
        {
            InitializeComponent();
            _categoryID = categoryID;
            _orderID = orderID;
            _fr = fr;
        }

        private void frmShowProductsByCategory_Load(object sender, EventArgs e)
        {
            DataTable dt = clsProductCatalog.GetAllProductbyCategory(_categoryID);
            dgvproducts.DataSource = dt;
        }

        private void addToMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderItems frm = new frmOrderItems((int)dgvproducts.CurrentRow.Cells[0].Value, _orderID,_fr,0);
            frm.Show();
            
        }

        private void productInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductInfo frm = new frmProductInfo((int)dgvproducts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            
        }

        private void seePicturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeePictures frm = new frmSeePictures((int)dgvproducts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
          

        }
    }
}
