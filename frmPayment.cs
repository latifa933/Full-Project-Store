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
    public partial class frmPayment : Form
    {
        private int _orderID;
        private clsOrder _order;
        public frmPayment(int order)
        {
            InitializeComponent();
            _orderID = order;
        }
        
    

        private void cbPaymentMethod_Validating(object sender, CancelEventArgs e)
        {
           if(string.IsNullOrEmpty(cbPaymentMethod.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(cbPaymentMethod, "chose payment method");
            }
            else
            {

                errorProvider1.SetError(cbPaymentMethod, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            _order = clsOrder.FindByID(_orderID);
            if(_order != null)
            {
                lblOrderID.Text = _order.OrderID.ToString();
                lblCustumorName.Text = _order.CustumorInfo.Name;
                lblDate.Text = DateTime.Now.ToString();
                lblAmount.Text = _order.TotalAmount.ToString();

            }
            else
            {
                MessageBox.Show("order is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsPayment payment1 = clsPayment.FindByOrderID(_orderID);
            if(payment1 != null)
            {
                MessageBox.Show("you cannot pass the payment,this order ID:" + -_orderID + "has aleardy pass the payment with payment ID:" + payment1.PaymentID, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                this.Close();
                return;
            }



            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some filed are incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsPayment payment = new clsPayment();
            payment.OrderID = _orderID;
            payment.PaymentMethod = cbPaymentMethod.Text;
            payment.Amount = _order.TotalAmount;
            payment.TransactionDate = DateTime.Now;
            if(payment.save())
            {
                MessageBox.Show("payment is passed successffly", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblpaymeID.Text = payment.PaymentID.ToString();
            }
            else
            {
                MessageBox.Show("Echec payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
