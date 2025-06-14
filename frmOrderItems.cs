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
    public partial class frmOrderItems : Form
    {
        private int _productID;
        private int _orderID;
        private clsProductCatalog _product;
        private frmMakeOrder _fr;
        private byte _mode;
        private clsOrderItem _item;
        public frmOrderItems(int productID,int orderID,frmMakeOrder fr,byte mode)
        {
            InitializeComponent();
            _productID = productID;
            _orderID = orderID;
            _product = clsProductCatalog.FindProductByID(_productID);
            _fr = fr;
            _mode = mode;
        }

        private void frmOrderItems_Load(object sender, EventArgs e)
        {  if(_mode == 1)
            {
                _item = clsOrderItem.Find(_orderID, _productID);
                if(_item != null)
                {
                    txbQuantity.Text = _item.Quantity.ToString();
                    float amount = int.Parse(txbQuantity.Text) * _product.Price;
                    lblAmount.Text = amount.ToString();
                }
            }

            ctrlProductInfo1.loadProductInfo(_productID);
            lblOrderID.Text = _orderID.ToString();

        }

        private void txbQuantity_TextChanged(object sender, EventArgs e)
        {   if (txbQuantity.Text != "")
            {
                float amount = Convert.ToSingle(txbQuantity.Text) * _product.Price;
                lblAmount.Text = amount.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool _UpdateOrderAmount()
        {
            clsOrder order = clsOrder.FindByID(_orderID);
         
            order.TotalAmount += Convert.ToSingle(lblAmount.Text);
            return (order.save());
                
        }
        private bool _UpdateProductQuantity()
        {
            _product.QuantityInStock = _product.QuantityInStock - int.Parse(txbQuantity.Text);
            if (_product.save())
                return true;
            else return false;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {   if (_mode == 1)
            {
                clsOrder order = clsOrder.FindByID(_orderID);
                int? lastQuantity = _item.Quantity;
                int? newQuantity = int.Parse(txbQuantity.Text);
                float lastAmount = _product.Price * lastQuantity.Value;
                float newAmount = _product.Price * newQuantity.Value;
                float difference = newAmount - lastAmount;
                order.TotalAmount = order.TotalAmount + difference;
                _item.Quantity = int.Parse(txbQuantity.Text);
 
                    if (!order.save())
                    { MessageBox.Show("Error :order is not update ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if(_item.save())
                {
                    MessageBox.Show("Quantity updated successffly", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _fr.frmMakeOrder_Load(null, null);
                }

            }
            else
            {
                clsOrderItem item = new clsOrderItem();
                item.ProductID = _productID;
                item.OrderID = _orderID;
                item.Price = _product.Price;
                item.Quantity = int.Parse(txbQuantity.Text);
                if (item.save())
                {
                    if (_UpdateOrderAmount() && _UpdateProductQuantity())
                    {
                        MessageBox.Show("Item added successffly", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _fr.frmMakeOrder_Load(null, null);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error in Update Order Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error :Item does not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txbQuantity_Validating(object sender, CancelEventArgs e)
        {  if(string.IsNullOrEmpty(txbQuantity.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbQuantity, "this field is required");
                return;
            }
        else
            {
                errorProvider1.SetError(txbQuantity, null);
            }


            if(_product.QuantityInStock < int.Parse(txbQuantity.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbQuantity, "you are depassing the stock quantity");
            }
            else
            {
                errorProvider1.SetError(txbQuantity, null);
            }
        }

        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
