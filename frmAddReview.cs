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
    public partial class frmAddReview : Form
    {
        public frmAddReview()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddReview_Load(object sender, EventArgs e)
        {
            btnsave.Enabled = false;
            lblReviewDate.Text = DateTime.Now.ToString();
            if(clsGlobal.Custumor != null)
            {
                lblCustumorName.Text = clsGlobal.Custumor.Name;
            }
            else
            {
                MessageBox.Show("you must login first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
                
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {   if(!this.ValidateChildren())
            {
                MessageBox.Show("some filed are incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(ctrlProductInfoWithFilter1.Product != null)
            {
                clsReview review = new clsReview();
                review.ProductID = ctrlProductInfoWithFilter1.Product.ProductID;
                review.CustumorID = clsGlobal.Custumor.CustumorID;
                review.ReviewText = txbReview.Text;
                review.ReviewDate = DateTime.Now;
                review.Rating = Convert.ToByte(cbRating.Text);
                if(review.Save())
                {
                    lblReviewID.Text = review.ReviewID.ToString();
                    MessageBox.Show("Review added successffly", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Review is not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }

        private void ctrlProductInfoWithFilter1_OnProductSelected(int obj)
        { clsProductCatalog product = clsProductCatalog.FindProductByID(obj);
            if (product != null)

                btnsave.Enabled = true;
            else
                btnsave.Enabled = false;
        }

        private void txbReview_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txbReview.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbReview, "please write your review");
            }
            else
            {
                errorProvider1.SetError(txbReview, null);
            }
        }

        private void cbRating_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(cbRating.Text.Trim()))
                {
                e.Cancel = true;
                errorProvider1.SetError(cbRating, "chose your rate");
            }
            else
            {
                errorProvider1.SetError(cbRating, null);
            }

        }
    }
}
