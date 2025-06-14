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
    public partial class frmLogin : Form
    {
        private frMain _fr;
        public frmLogin( frMain fr)
        {
            InitializeComponent();
            _fr = fr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                return;
            }
            clsCustumor cus = clsCustumor.Find(txbusername.Text.Trim(), txbpassword.Text.Trim());
            if(cus != null)
            {
                clsGlobal.Custumor = cus;
                _fr.EneabledUpdateCustumor();
                
                frmMakeOrder frm = new frmMakeOrder(_fr);
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbpassword.Text = "";
                txbusername.Text = "";
                txbusername.Focus();
            }
        }
    }
}
