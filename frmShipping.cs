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
    public partial class frmShipping : Form
    {   public enum enmode { addnew =1,update =2,suivateOrder =3}
        private enmode _mode = enmode.addnew;
        private int _shipingID;
        private clsShipping _shipping;
        private bool _EntreOrder = false;
        private int _orderID;

        public void EnterOrderID()
        {
            lblEnterOrderID.Visible = true;
            txbOrder.Visible = true;
            btnSearch.Visible = true;
            txbOrder.Focus();
          
        }
        public frmShipping(bool EnterOrder)
        {
            InitializeComponent();
            _mode = enmode.suivateOrder;

            EnterOrderID();
          
            
        }
        public frmShipping()
        {
            InitializeComponent();
            _mode = enmode.addnew;
            _shipping = new clsShipping();
        }
        public frmShipping(int shipingID)
        {
            InitializeComponent();
            _shipingID = shipingID;
            _shipping = clsShipping.FindByID(_shipingID);
            _mode = enmode.update;
        }
        private void _ResetDefaultValues()
        {
            
            lblShippingID.Text = "???";
            
            txbCarrierName.Text = "";
            txbTrackingNumber.Text = "";
            cbShippingStatus.SelectedIndex = 0;
            dtpActualDate.Value = DateTime.Now.AddDays(7);

            dtpActualDate.Enabled = false;
            dtpEstimatedDate.Value = DateTime.Now.AddDays(7);

        }
        private void _loadData()
        {
            if(_shipping != null)
            {
                lblShippingID.Text = _shipingID.ToString();
                lblOrderID.Text = _shipping.OrderID.ToString();
                txbCarrierName.Text = _shipping.CarrierName;
                txbTrackingNumber.Text = _shipping.TrackingNumber;
                byte stat = (byte)_shipping.Status;

                cbShippingStatus.SelectedIndex = stat - 1 ;
                dtpEstimatedDate.Value = _shipping.EstimatedDelivryDate;
                if (_shipping.ActualDelivryDate != null)
                    dtpActualDate.Value = _shipping.ActualDelivryDate.Value;
                if (cbShippingStatus.SelectedIndex == 2)
                {
                    btnSave.Enabled = false;
                }


            }
            else
            {
                MessageBox.Show("No shipping exist with ID = " + _shipingID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {    if (_mode == enmode.addnew)
                dtpActualDate.Enabled = false;
            _shipping.OrderID = int.Parse(lblOrderID.Text);
            _shipping.CarrierName = txbCarrierName.Text;
            _shipping.TrackingNumber = txbTrackingNumber.Text;
            _shipping.Status = (clsShipping.enShippingStatus)(cbShippingStatus.SelectedIndex + 1);
            _shipping.EstimatedDelivryDate = dtpEstimatedDate.Value;
            if (_mode == enmode.addnew)
                _shipping.ActualDelivryDate = null;
            else
                _shipping.ActualDelivryDate = dtpActualDate.Value;
            if(_shipping.save())
            {
                lblShippingID.Text = _shipping.ShippingID.ToString();
                MessageBox.Show("data saved successffly", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("data is not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbCarrierName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txbCarrierName.Text))
            {
               // e.Cancel = true;
               // errorProvider1.SetError(txbCarrierName, "enter carrier name");
            }
            else
            {
                errorProvider1.SetError(txbCarrierName, null);
            }
        }

        private void txbTrackingNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txbTrackingNumber.Text))
            {
               // e.Cancel = true;
              //  errorProvider1.SetError(txbTrackingNumber, "enter Tracking number");
            }
            else
            {
                errorProvider1.SetError(txbTrackingNumber, null);
            }
        }

        private void cbShippingStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbShippingStatus.Text))
            {
               // e.Cancel = true;
               // errorProvider1.SetError(cbShippingStatus, "chose Status");
            }
            else
            {
                errorProvider1.SetError(cbShippingStatus, null);
            }
        }

        private void frmShipping_Load(object sender, EventArgs e)
        {   if (_mode == enmode.suivateOrder)
            {
                txbOrder.Focus();
            }
            else
            {
                _ResetDefaultValues();
                if (_mode == enmode.addnew)
                    lblOrderID.Text = clsGlobal.order.OrderID.ToString();
                if (_mode == enmode.update)
                {
                    _loadData();
                }
            }
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtpActualDate.Enabled = true;
            _orderID = int.Parse(txbOrder.Text);
            _shipping = clsShipping.FindByorderID(_orderID);
            if (_shipping == null)
            {
                MessageBox.Show("no shipping exist for OrderID :" + _orderID, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _shipingID = _shipping.ShippingID;
                lblOrderID.Text = _orderID.ToString();

                _loadData();
            }
        }
    }
}
