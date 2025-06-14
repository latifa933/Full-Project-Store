using ProjectStore;
using ProjectStore.global_classes;
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
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void addNewCustumorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustumor frm = new frmAddUpdateCustumor();
            frm.ShowDialog();
        }

        private void updateCustumorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            frmAddUpdateCustumor frm = new frmAddUpdateCustumor(clsGlobal.Custumor.CustumorID);
            frm.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin(this);
            frm.ShowDialog();
        }
        public bool EneabledUpdateCustumor()
        {
            updateCustumorInfoToolStripMenuItem.Enabled = true;
            return true;
        }
        public bool EneabledUpdateOrder()
        {
            updateOrderToolStripMenuItem.Enabled = true;
            concelOrderToolStripMenuItem.Enabled = true;
            return true;
        }
        private void frMain_Load(object sender, EventArgs e)
        {
            if (clsGlobal.Custumor == null)
                updateCustumorInfoToolStripMenuItem.Enabled = false;
            if(clsGlobal.order == null)
            {
                updateOrderToolStripMenuItem.Enabled = false;
                concelOrderToolStripMenuItem.Enabled = false;
            }
        }

        private void updateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMakeOrder frm = new frmMakeOrder(clsGlobal.order.OrderID);
            frm.ShowDialog();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {   if(clsGlobal.Custumor == null)
            {
                MessageBox.Show("please enter Custumor info to create your order", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmLogin frm2 = new frmLogin(this);
                    frm2.Show();
                return;
            }
            frmMakeOrder frm = new frmMakeOrder(this);
            frm.ShowDialog();
        }

        private void concelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConcellOrder frm = new frmConcellOrder(clsGlobal.order.OrderID);
            frm.ShowDialog();
        }

        private void frMain_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void frMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clsGlobal.order != null)
            {
                clsOrder order = clsOrder.FindByID(clsGlobal.order.OrderID);
                if (order.TotalAmount == 0)
                {
                    if (order.delete())
                        MessageBox.Show("order deleted because there is no item");

                }
            }
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllProducts frm = new frmAllProducts();
            frm.ShowDialog();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateProduct frm = new frmAddUpdateProduct();
            frm.ShowDialog();
        }

        private void createNewReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddReview frm = new frmAddReview();
            frm.ShowDialog();
        }

        private void previousReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlistReview frm = new frmlistReview();
            frm.ShowDialog();

        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {   if (clsGlobal.order != null)
            {
                frmPayment frm = new frmPayment(clsGlobal.order.OrderID);
                frm.ShowDialog();
            }
        else
            {
                MessageBox.Show("create your order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void suivateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShipping frm = new frmShipping(true);
          
            frm.ShowDialog();

           
        }

        private void myOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShipping frm = new frmShipping();
            frm.ShowDialog();
        }
    }
}
