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
    public partial class ctrlOrderInfo : UserControl
    { private int _orderID;
        private clsOrder _order;
        public int OrderID
        {
            get { return _orderID; }
        }
        public clsOrder Order
        {
            get { return _order; }
        }
        public ctrlOrderInfo()
        {
            InitializeComponent();
        } 
        private void _fillItems()
        {
            DataTable dt = clsOrderItem.GetAllOrderItemForOrder(_orderID);
            dgvItems.DataSource = dt;
        }
        public void loadOrderInfo(int orderID)
        {
            _orderID = orderID;
            _order = clsOrder.FindByID(_orderID);
            if(_order != null)
            {
                lblOrderID.Text = _orderID.ToString();
                lblCustumorID.Text = _order.CustumorID.ToString();
                lblCustumorName.Text = _order.CustumorInfo.Name;
                lblOrderDate.Text = _order.OrderDate.ToString();
                lblStatus.Text = _order.StatusText();
                lblAmount.Text = _order.TotalAmount.ToString();
                _fillItems();

            }
            else
            {
                MessageBox.Show("No order found with ID :" + _orderID, "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

       
    }
}
