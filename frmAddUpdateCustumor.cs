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
    public partial class frmAddUpdateCustumor : Form
    {   public enum enMode { addnew =1,update =2};
        private enMode _mode = enMode.addnew;
        private int _CustumorID =-1;
        private clsCustumor _Custumor;
        public frmAddUpdateCustumor()
        {
            InitializeComponent();
            _mode = enMode.addnew;

        }
        public frmAddUpdateCustumor(int custumorID)
        {
            InitializeComponent();
            _CustumorID = custumorID;
            _mode = enMode.update;
        }
        private void _ResetDefaultValues()
        { if(_mode == enMode.addnew)
            {
                lblTitle.Text = "Add New Custumor";
                this.Text = lblTitle.Text;
                _Custumor = new clsCustumor();

            }
        else
            {
                lblTitle.Text = "Update Custumor";
                this.Text = "Update Custumor";

            }
            txbName.Text = "";
            txbEmail.Text = "";
            txbAddress.Text = "";
            txbPhone.Text = "";
            txbUsername.Text = "";
            txbpassword.Text = "";
            txbConfirmpassword.Text = "";

        }
        private void _loadData()
        {
            _Custumor = clsCustumor.Find(_CustumorID);
            if(_Custumor == null)
            {
                MessageBox.Show("No Custumor with ID :" + _CustumorID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblcustumorID.Text = _CustumorID.ToString();
            txbName.Text = _Custumor.Name;
            txbEmail.Text = _Custumor.Email;
            txbPhone.Text = _Custumor.Phone;
            txbAddress.Text = _Custumor.Address;
            txbUsername.Text = _Custumor.Username;
            txbpassword.Text = _Custumor.password;
            txbConfirmpassword.Text = _Custumor.password;


        }
        private void frmAddUpdateCustumor_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if(_mode == enMode.update)
            {
                _loadData();
            }

        }

        private void texbox_Validating(object sender, CancelEventArgs e)
        {
            TextBox txb = (TextBox)sender;
            if(string.IsNullOrEmpty(txb.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txb, "this fieled is required");
            }
            else
            {
                errorProvider1.SetError(txb, null);
            }
        }

        private void txbEmail_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txbEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbEmail, "this fieled is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txbEmail, null);
            }
            if(!clsValidation.ValidateEmail(txbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbEmail, "this fieled is required");

            }
            else
            {
                errorProvider1.SetError(txbEmail, null);
            }

        }

        private void txbConfirmpassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txbConfirmpassword.Text.Trim()))
                {
                e.Cancel = true;
                errorProvider1.SetError(txbConfirmpassword, "this fiels is required");
                return;
                }
            else
            {
                errorProvider1.SetError(txbConfirmpassword, null);

            }
            if(txbConfirmpassword.Text != txbpassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txbConfirmpassword, "Error confirmation password");
            }
            else
            {
                errorProvider1.SetError(txbConfirmpassword, null);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("some fields are incorrect,put the mousse on red icons to see the errors", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Custumor.Name = txbName.Text;
            _Custumor.Email = txbEmail.Text;
            _Custumor.Phone = txbPhone.Text;
            _Custumor.Address = txbAddress.Text;
            _Custumor.Username = txbUsername.Text;
            _Custumor.password = txbpassword.Text;
            if(_Custumor.Save())
            {
                lblTitle.Text = "Update Custumor";
                lblcustumorID.Text = _Custumor.CustumorID.ToString();
                _mode = enMode.update;
                MessageBox.Show("data saved successffly", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error : Data is not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
