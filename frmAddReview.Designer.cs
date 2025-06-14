namespace ProjectStore
{
    partial class frmAddReview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctrlProductInfoWithFilter1 = new ProjectStore.ctrlProductInfoWithFilter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReviewID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbReview = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReviewDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCustumorName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlProductInfoWithFilter1
            // 
            this.ctrlProductInfoWithFilter1.Location = new System.Drawing.Point(43, 12);
            this.ctrlProductInfoWithFilter1.Name = "ctrlProductInfoWithFilter1";
            this.ctrlProductInfoWithFilter1.Size = new System.Drawing.Size(782, 492);
            this.ctrlProductInfoWithFilter1.TabIndex = 0;
            this.ctrlProductInfoWithFilter1.OnProductSelected += new System.Action<int>(this.ctrlProductInfoWithFilter1_OnProductSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ReviewID :";
            // 
            // lblReviewID
            // 
            this.lblReviewID.AutoSize = true;
            this.lblReviewID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewID.Location = new System.Drawing.Point(175, 507);
            this.lblReviewID.Name = "lblReviewID";
            this.lblReviewID.Size = new System.Drawing.Size(43, 22);
            this.lblReviewID.TabIndex = 2;
            this.lblReviewID.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Review Text :";
            // 
            // txbReview
            // 
            this.txbReview.Location = new System.Drawing.Point(215, 540);
            this.txbReview.Multiline = true;
            this.txbReview.Name = "txbReview";
            this.txbReview.Size = new System.Drawing.Size(588, 65);
            this.txbReview.TabIndex = 4;
            this.txbReview.Validating += new System.ComponentModel.CancelEventHandler(this.txbReview_Validating);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(672, 674);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(84, 42);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(806, 674);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 42);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 694);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Review Date :";
            // 
            // lblReviewDate
            // 
            this.lblReviewDate.AutoSize = true;
            this.lblReviewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewDate.Location = new System.Drawing.Point(211, 694);
            this.lblReviewDate.Name = "lblReviewDate";
            this.lblReviewDate.Size = new System.Drawing.Size(101, 20);
            this.lblReviewDate.TabIndex = 8;
            this.lblReviewDate.Text = "??/??/????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 660);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rating :";
            // 
            // cbRating
            // 
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbRating.Location = new System.Drawing.Point(215, 658);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(121, 24);
            this.cbRating.TabIndex = 11;
            this.cbRating.Validating += new System.ComponentModel.CancelEventHandler(this.cbRating_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Custumor Name:";
            // 
            // lblCustumorName
            // 
            this.lblCustumorName.AutoSize = true;
            this.lblCustumorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustumorName.Location = new System.Drawing.Point(211, 627);
            this.lblCustumorName.Name = "lblCustumorName";
            this.lblCustumorName.Size = new System.Drawing.Size(39, 20);
            this.lblCustumorName.TabIndex = 13;
            this.lblCustumorName.Text = "???";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 728);
            this.Controls.Add(this.lblCustumorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblReviewDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txbReview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReviewID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlProductInfoWithFilter1);
            this.Name = "frmAddReview";
            this.Text = "frmAddReview";
            this.Load += new System.EventHandler(this.frmAddReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlProductInfoWithFilter ctrlProductInfoWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReviewID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbReview;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReviewDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCustumorName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}