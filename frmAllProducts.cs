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
    public partial class frmAllProducts : Form
    {
        public frmAllProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAllProducts_Load(object sender, EventArgs e)
        {
            DataTable dtAliments = clsProductCatalog.GetAllProductbyCategory(1);
            dgvAliments.DataSource = dtAliments;
            DataTable dtBaby = clsProductCatalog.GetAllProductbyCategory(2);
            dgvBaby.DataSource = dtBaby;
            DataTable dtElectronic = clsProductCatalog.GetAllProductbyCategory(3);
            dgvElectronic.DataSource = dtElectronic;

            DataTable dtBeauty = clsProductCatalog.GetAllProductbyCategory(4);
            dgvBeauty.DataSource = dtBeauty;

            DataTable dtClothes = clsProductCatalog.GetAllProductbyCategory(5);
            dgvClothes.DataSource = dgvClothes;



        }
    }
}
