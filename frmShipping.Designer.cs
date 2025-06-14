namespace ProjectStore
{
    partial class frmShipping
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblShippingID = new System.Windows.Forms.Label();
            this.txbCarrierName = new System.Windows.Forms.TextBox();
            this.txbTrackingNumber = new System.Windows.Forms.TextBox();
            this.cbShippingStatus = new System.Windows.Forms.ComboBox();
            this.dtpEstimatedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpActualDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txbOrder = new System.Windows.Forms.TextBox();
            this.lblEnterOrderID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(260, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shipping";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shipping ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estimated Delivery date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Actual Delivery Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shipping Status :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "c";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tracking Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "c";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Carrier Name :";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(186, 146);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(48, 25);
            this.lblOrderID.TabIndex = 9;
            this.lblOrderID.Text = "???";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Order ID :";
            // 
            // lblShippingID
            // 
            this.lblShippingID.AutoSize = true;
            this.lblShippingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingID.Location = new System.Drawing.Point(186, 86);
            this.lblShippingID.Name = "lblShippingID";
            this.lblShippingID.Size = new System.Drawing.Size(48, 25);
            this.lblShippingID.TabIndex = 11;
            this.lblShippingID.Text = "???";
            // 
            // txbCarrierName
            // 
            this.txbCarrierName.Location = new System.Drawing.Point(228, 206);
            this.txbCarrierName.Name = "txbCarrierName";
            this.txbCarrierName.Size = new System.Drawing.Size(137, 22);
            this.txbCarrierName.TabIndex = 12;
            this.txbCarrierName.Validating += new System.ComponentModel.CancelEventHandler(this.txbCarrierName_Validating);
            // 
            // txbTrackingNumber
            // 
            this.txbTrackingNumber.Location = new System.Drawing.Point(228, 262);
            this.txbTrackingNumber.Name = "txbTrackingNumber";
            this.txbTrackingNumber.Size = new System.Drawing.Size(137, 22);
            this.txbTrackingNumber.TabIndex = 13;
            this.txbTrackingNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txbTrackingNumber_Validating);
            // 
            // cbShippingStatus
            // 
            this.cbShippingStatus.FormattingEnabled = true;
            this.cbShippingStatus.Items.AddRange(new object[] {
            "processing",
            "Out for delivery",
            "Delivred",
            "Return to sender",
            "On Hold",
            "Delayed ",
            "Lost"});
            this.cbShippingStatus.Location = new System.Drawing.Point(228, 320);
            this.cbShippingStatus.Name = "cbShippingStatus";
            this.cbShippingStatus.Size = new System.Drawing.Size(137, 24);
            this.cbShippingStatus.TabIndex = 14;
            this.cbShippingStatus.Validating += new System.ComponentModel.CancelEventHandler(this.cbShippingStatus_Validating);
            // 
            // dtpEstimatedDate
            // 
            this.dtpEstimatedDate.Location = new System.Drawing.Point(307, 382);
            this.dtpEstimatedDate.Name = "dtpEstimatedDate";
            this.dtpEstimatedDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEstimatedDate.TabIndex = 15;
            // 
            // dtpActualDate
            // 
            this.dtpActualDate.Location = new System.Drawing.Point(307, 445);
            this.dtpActualDate.Name = "dtpActualDate";
            this.dtpActualDate.Size = new System.Drawing.Size(200, 22);
            this.dtpActualDate.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(435, 556);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 43);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(566, 556);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 43);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txbOrder
            // 
            this.txbOrder.Location = new System.Drawing.Point(608, 45);
            this.txbOrder.Name = "txbOrder";
            this.txbOrder.Size = new System.Drawing.Size(152, 22);
            this.txbOrder.TabIndex = 19;
            this.txbOrder.Visible = false;
            // 
            // lblEnterOrderID
            // 
            this.lblEnterOrderID.AutoSize = true;
            this.lblEnterOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterOrderID.Location = new System.Drawing.Point(430, 42);
            this.lblEnterOrderID.Name = "lblEnterOrderID";
            this.lblEnterOrderID.Size = new System.Drawing.Size(159, 25);
            this.lblEnterOrderID.TabIndex = 20;
            this.lblEnterOrderID.Text = "Enter order ID :";
            this.lblEnterOrderID.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(687, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 33);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 688);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEnterOrderID);
            this.Controls.Add(this.txbOrder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpActualDate);
            this.Controls.Add(this.dtpEstimatedDate);
            this.Controls.Add(this.cbShippingStatus);
            this.Controls.Add(this.txbTrackingNumber);
            this.Controls.Add(this.txbCarrierName);
            this.Controls.Add(this.lblShippingID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmShipping";
            this.Text = "frmShipping";
            this.Load += new System.EventHandler(this.frmShipping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblShippingID;
        private System.Windows.Forms.TextBox txbCarrierName;
        private System.Windows.Forms.TextBox txbTrackingNumber;
        private System.Windows.Forms.ComboBox cbShippingStatus;
        private System.Windows.Forms.DateTimePicker dtpEstimatedDate;
        private System.Windows.Forms.DateTimePicker dtpActualDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEnterOrderID;
        private System.Windows.Forms.TextBox txbOrder;
    }
}