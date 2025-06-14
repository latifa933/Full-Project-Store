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
    public partial class frmMakeOrder : Form
    {   public enum enmode { addnew =1,update =2}
        private enmode _mode = enmode.addnew;
        private int _orderID;
        private clsOrder _Order;
        private frMain _fr;
        public frmMakeOrder(frMain fr)
        {
            InitializeComponent();
            _mode = enmode.addnew;
            _fr = fr;
        }
        public frmMakeOrder(int orderID)
        {
            InitializeComponent();
            _orderID = orderID;
            _mode = enmode.update;
        }
        private void _loadData()
        {
           if(_mode == enmode.addnew)
            {
                tbOrderItems.Enabled = false;
                btnShowItems.Enabled = false;
                lblCustumorID.Text = clsGlobal.Custumor.CustumorID.ToString();
                lblCustumorName.Text = clsGlobal.Custumor.Name;
                lblOrderDate.Text = DateTime.Now.ToString();
                lblTotalAmount.Text = "0$";
                lblStatus.Text = clsOrder.enStatus.Pending.ToString();
            }
           else
            {   _Order = clsOrder.FindByID(_orderID);
                if(_Order != null)
                {
                    btnCreateOrder.Enabled = false;
                    lblOrderID.Text = _orderID.ToString();
                    lblCustumorID.Text = _Order.CustumorID.ToString();
                    lblCustumorName.Text = _Order.CustumorInfo.Name;
                    lblOrderDate.Text = _Order.OrderDate.ToString();
                    lblStatus.Text = _Order.StatusText();
                    lblTotalAmount.Text = _Order.TotalAmount.ToString();
                    DataTable dt = clsOrderItem.GetAllOrderItemForOrder(_orderID);
                    dgvOrderItems.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No order found with ID " + _orderID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void frmMakeOrder_Load(object sender, EventArgs e)
        {
            _loadData();
        }
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            _Order = new clsOrder();
            _Order.CustumorID = clsGlobal.Custumor.CustumorID;
            _Order.OrderDate = DateTime.Now;
            _Order.Status = clsOrder.enStatus.Pending;
            _Order.TotalAmount = 0;
            if(_Order.save())
            {
                _orderID = _Order.OrderID;
                lblOrderID.Text = _Order.OrderID.ToString();
                _mode = enmode.update;
                MessageBox.Show("order created successffuly,you can add your items", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnShowItems.Enabled = true;
                btnCreateOrder.Enabled = false;
                tbOrderItems.Enabled = true;
                clsGlobal.order = _Order;
                _fr.EneabledUpdateOrder();
                btnPayment.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("order is not created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowItems_Click(object sender, EventArgs e)
        {
            tbOrder.SelectedIndex = 1;
        }

        private void btnAliments_Click(object sender, EventArgs e)
        {
            frmShowProductsByCategory frm = new frmShowProductsByCategory(this,_orderID,1);
            frm.ShowDialog();
        }

        private void btnBaby_Click(object sender, EventArgs e)
        {
            frmShowProductsByCategory frm = new frmShowProductsByCategory(this,_orderID,2);
            frm.ShowDialog();
        }

        private void btnCothes_Click(object sender, EventArgs e)
        {
            frmShowProductsByCategory frm = new frmShowProductsByCategory(this,_orderID,5);
            frm.ShowDialog();
        }

        private void btnElectronic_Click(object sender, EventArgs e)
        {
            frmShowProductsByCategory frm = new frmShowProductsByCategory(this,_orderID,3);
            frm.ShowDialog();
        }

        private void btnBeauty_Click(object sender, EventArgs e)
        {
            frmShowProductsByCategory frm = new frmShowProductsByCategory(this,_orderID,4);
            frm.ShowDialog();
        }

        private void productInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductInfo frm = new frmProductInfo((int)dgvOrderItems.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void updateQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderItems frm = new frmOrderItems((int)dgvOrderItems.CurrentRow.Cells[1].Value, (int)dgvOrderItems.CurrentRow.Cells[0].Value,this, 1);
            frm.ShowDialog();
        }

       

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if( MessageBox.Show("are you sure you want delete this item", "delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                float amount = Convert.ToSingle( dgvOrderItems.CurrentRow.Cells[4].Value);
                _Order.TotalAmount = _Order.TotalAmount - amount;
                if ( clsOrderItem.deleteOrderItem((int)dgvOrderItems.CurrentRow.Cells[0].Value, (int)dgvOrderItems.CurrentRow.Cells[1].Value) && _Order.save())
                {
                    MessageBox.Show("item deleted successffly", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this._loadData();
                    

                }
                else
                {
                    MessageBox.Show("item is not deleted !!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


        }
        public bool EnabledPayment
        {
            get { return btnPayment.Enabled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(_Order != null && _Order.TotalAmount >0)
            {
                frmPayment frm = new frmPayment(_orderID);
                frm.ShowDialog();
            }
          else
            {
                MessageBox.Show("you cant pass to payment now,chose an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            frmShipping frm = new frmShipping();
            frm.ShowDialog();
        }
    }
}
