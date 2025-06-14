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
    public partial class frmConcellOrder : Form
    {
        private int _orderID;

        public frmConcellOrder(int orderID)
        {
            InitializeComponent();
            _orderID = orderID;
        }

        private void frmConcellOrder_Load(object sender, EventArgs e)
        {
            ctrlOrderInfo1.loadOrderInfo(_orderID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        { if (MessageBox.Show("are you sure you want cancell this order", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsOrder order = clsOrder.FindByID(_orderID);
                if (order != null)
                {
                    order.Status = clsOrder.enStatus.Cancelled;
                    if (order.save())
                    {
                        MessageBox.Show("your order is concelled", "Concelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ctrlOrderInfo1.loadOrderInfo(_orderID);
                    }
                    else
                    {
                        MessageBox.Show("Error your order is not concelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

        }
    }
}
