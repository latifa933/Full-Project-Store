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
    public partial class ctrlProductInfoWithFilter : UserControl
    {
        public event Action<int> OnProductSelected;
        protected virtual void ProductSelected (int productID)
        {
            Action<int> handler = OnProductSelected;
            if(handler != null)
            {
                handler(productID);
            }

        }
        private void databackEvent (object sender,int productID)
        {

        }
        public clsProductCatalog Product
        {
            get { return ctrlProductInfo1.Product; }
        }


        public ctrlProductInfoWithFilter()
        {
            InitializeComponent();
        }

        private void _FindNow()
        {
            switch(cbFilterBy.Text)
            {
                case "ProductID":
                    ctrlProductInfo1.loadProductInfo(int.Parse(txbFilterValue.Text));
                    break;
                case "Product Name":
                    ctrlProductInfo1.loadProductInfo(txbFilterValue.Text);
                    break;

            }
            if(OnProductSelected != null)
            {
                OnProductSelected(ctrlProductInfo1.productID);
            }
            
        }

        private void ctrlProductInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txbFilterValue.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("some fieled are not correct", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FindNow();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbFilterValue.Text = "";
            txbFilterValue.Focus();
        }

        private void txbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }

            if (cbFilterBy.Text == "ProductID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txbFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txbFilterValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbFilterValue, "enter text value");
            }
            else
            {
                errorProvider1.SetError(txbFilterValue, null);
            }
        }
    }
}
