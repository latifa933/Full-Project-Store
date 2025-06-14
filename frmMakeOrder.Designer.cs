namespace ProjectStore
{
    partial class frmMakeOrder
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
            this.tbOrder = new System.Windows.Forms.TabControl();
            this.tbOrderInfo = new System.Windows.Forms.TabPage();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblCustumorName = new System.Windows.Forms.Label();
            this.lblCustumorID = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrderItems = new System.Windows.Forms.TabPage();
            this.btnBeauty = new System.Windows.Forms.Button();
            this.btnElectronic = new System.Windows.Forms.Button();
            this.btnCothes = new System.Windows.Forms.Button();
            this.btnBaby = new System.Windows.Forms.Button();
            this.btnAliments = new System.Windows.Forms.Button();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowItems = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnShipping = new System.Windows.Forms.Button();
            this.tbOrder.SuspendLayout();
            this.tbOrderInfo.SuspendLayout();
            this.tbOrderItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOrder
            // 
            this.tbOrder.Controls.Add(this.tbOrderInfo);
            this.tbOrder.Controls.Add(this.tbOrderItems);
            this.tbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrder.Location = new System.Drawing.Point(12, 32);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.SelectedIndex = 0;
            this.tbOrder.Size = new System.Drawing.Size(1139, 565);
            this.tbOrder.TabIndex = 0;
            // 
            // tbOrderInfo
            // 
            this.tbOrderInfo.Controls.Add(this.lblTotalAmount);
            this.tbOrderInfo.Controls.Add(this.lblStatus);
            this.tbOrderInfo.Controls.Add(this.lblOrderDate);
            this.tbOrderInfo.Controls.Add(this.lblCustumorName);
            this.tbOrderInfo.Controls.Add(this.lblCustumorID);
            this.tbOrderInfo.Controls.Add(this.lblOrderID);
            this.tbOrderInfo.Controls.Add(this.label6);
            this.tbOrderInfo.Controls.Add(this.label5);
            this.tbOrderInfo.Controls.Add(this.label4);
            this.tbOrderInfo.Controls.Add(this.label3);
            this.tbOrderInfo.Controls.Add(this.label2);
            this.tbOrderInfo.Controls.Add(this.label1);
            this.tbOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderInfo.Location = new System.Drawing.Point(4, 29);
            this.tbOrderInfo.Name = "tbOrderInfo";
            this.tbOrderInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbOrderInfo.Size = new System.Drawing.Size(1131, 532);
            this.tbOrderInfo.TabIndex = 0;
            this.tbOrderInfo.Text = "Order Info";
            this.tbOrderInfo.UseVisualStyleBackColor = true;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(217, 351);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(39, 20);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.Text = "$$$";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(220, 287);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "???";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(213, 214);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(101, 20);
            this.lblOrderDate.TabIndex = 9;
            this.lblOrderDate.Text = "??/??/????";
            // 
            // lblCustumorName
            // 
            this.lblCustumorName.AutoSize = true;
            this.lblCustumorName.Location = new System.Drawing.Point(217, 150);
            this.lblCustumorName.Name = "lblCustumorName";
            this.lblCustumorName.Size = new System.Drawing.Size(39, 20);
            this.lblCustumorName.TabIndex = 8;
            this.lblCustumorName.Text = "???";
            // 
            // lblCustumorID
            // 
            this.lblCustumorID.AutoSize = true;
            this.lblCustumorID.Location = new System.Drawing.Point(213, 99);
            this.lblCustumorID.Name = "lblCustumorID";
            this.lblCustumorID.Size = new System.Drawing.Size(39, 20);
            this.lblCustumorID.TabIndex = 7;
            this.lblCustumorID.Text = "???";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(177, 44);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(39, 20);
            this.lblOrderID.TabIndex = 6;
            this.lblOrderID.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Custumor Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CustumorID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderID :";
            // 
            // tbOrderItems
            // 
            this.tbOrderItems.Controls.Add(this.btnBeauty);
            this.tbOrderItems.Controls.Add(this.btnElectronic);
            this.tbOrderItems.Controls.Add(this.btnCothes);
            this.tbOrderItems.Controls.Add(this.btnBaby);
            this.tbOrderItems.Controls.Add(this.btnAliments);
            this.tbOrderItems.Controls.Add(this.dgvOrderItems);
            this.tbOrderItems.Location = new System.Drawing.Point(4, 29);
            this.tbOrderItems.Name = "tbOrderItems";
            this.tbOrderItems.Padding = new System.Windows.Forms.Padding(3);
            this.tbOrderItems.Size = new System.Drawing.Size(1131, 532);
            this.tbOrderItems.TabIndex = 1;
            this.tbOrderItems.Text = "Order Items";
            this.tbOrderItems.UseVisualStyleBackColor = true;
            // 
            // btnBeauty
            // 
            this.btnBeauty.Location = new System.Drawing.Point(599, 30);
            this.btnBeauty.Name = "btnBeauty";
            this.btnBeauty.Size = new System.Drawing.Size(94, 33);
            this.btnBeauty.TabIndex = 5;
            this.btnBeauty.Text = "Beauty";
            this.btnBeauty.UseVisualStyleBackColor = true;
            this.btnBeauty.Click += new System.EventHandler(this.btnBeauty_Click);
            // 
            // btnElectronic
            // 
            this.btnElectronic.Location = new System.Drawing.Point(446, 30);
            this.btnElectronic.Name = "btnElectronic";
            this.btnElectronic.Size = new System.Drawing.Size(108, 34);
            this.btnElectronic.TabIndex = 4;
            this.btnElectronic.Text = "Electronic";
            this.btnElectronic.UseVisualStyleBackColor = true;
            this.btnElectronic.Click += new System.EventHandler(this.btnElectronic_Click);
            // 
            // btnCothes
            // 
            this.btnCothes.Location = new System.Drawing.Point(317, 30);
            this.btnCothes.Name = "btnCothes";
            this.btnCothes.Size = new System.Drawing.Size(83, 34);
            this.btnCothes.TabIndex = 3;
            this.btnCothes.Text = "Clothes";
            this.btnCothes.UseVisualStyleBackColor = true;
            this.btnCothes.Click += new System.EventHandler(this.btnCothes_Click);
            // 
            // btnBaby
            // 
            this.btnBaby.Location = new System.Drawing.Point(175, 31);
            this.btnBaby.Name = "btnBaby";
            this.btnBaby.Size = new System.Drawing.Size(85, 33);
            this.btnBaby.TabIndex = 2;
            this.btnBaby.Text = "Baby";
            this.btnBaby.UseVisualStyleBackColor = true;
            this.btnBaby.Click += new System.EventHandler(this.btnBaby_Click);
            // 
            // btnAliments
            // 
            this.btnAliments.Location = new System.Drawing.Point(44, 31);
            this.btnAliments.Name = "btnAliments";
            this.btnAliments.Size = new System.Drawing.Size(98, 33);
            this.btnAliments.TabIndex = 1;
            this.btnAliments.Text = "Aliments";
            this.btnAliments.UseVisualStyleBackColor = true;
            this.btnAliments.Click += new System.EventHandler(this.btnAliments_Click);
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvOrderItems.Location = new System.Drawing.Point(44, 86);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RowHeadersWidth = 51;
            this.dgvOrderItems.RowTemplate.Height = 24;
            this.dgvOrderItems.Size = new System.Drawing.Size(1026, 391);
            this.dgvOrderItems.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productInfoToolStripMenuItem,
            this.updateQuantityToolStripMenuItem,
            this.deleteItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 76);
            // 
            // productInfoToolStripMenuItem
            // 
            this.productInfoToolStripMenuItem.Name = "productInfoToolStripMenuItem";
            this.productInfoToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.productInfoToolStripMenuItem.Text = "product Info";
            this.productInfoToolStripMenuItem.Click += new System.EventHandler(this.productInfoToolStripMenuItem_Click);
            // 
            // updateQuantityToolStripMenuItem
            // 
            this.updateQuantityToolStripMenuItem.Name = "updateQuantityToolStripMenuItem";
            this.updateQuantityToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.updateQuantityToolStripMenuItem.Text = "Update Quantity";
            this.updateQuantityToolStripMenuItem.Click += new System.EventHandler(this.updateQuantityToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.deleteItemToolStripMenuItem.Text = "delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // btnShowItems
            // 
            this.btnShowItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowItems.Location = new System.Drawing.Point(252, 619);
            this.btnShowItems.Name = "btnShowItems";
            this.btnShowItems.Size = new System.Drawing.Size(166, 31);
            this.btnShowItems.TabIndex = 12;
            this.btnShowItems.Text = "Show Items";
            this.btnShowItems.UseVisualStyleBackColor = true;
            this.btnShowItems.Click += new System.EventHandler(this.btnShowItems_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(966, 619);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Location = new System.Drawing.Point(68, 619);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(167, 31);
            this.btnCreateOrder.TabIndex = 2;
            this.btnCreateOrder.Text = "Create order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Enabled = false;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(469, 619);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(113, 31);
            this.btnPayment.TabIndex = 13;
            this.btnPayment.Text = "payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShipping
            // 
            this.btnShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipping.Location = new System.Drawing.Point(626, 619);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(99, 30);
            this.btnShipping.TabIndex = 14;
            this.btnShipping.Text = "Shipping";
            this.btnShipping.UseVisualStyleBackColor = true;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
            // 
            // frmMakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 677);
            this.Controls.Add(this.btnShipping);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnShowItems);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbOrder);
            this.Name = "frmMakeOrder";
            this.Text = "frmMakeOrder";
            this.Load += new System.EventHandler(this.frmMakeOrder_Load);
            this.tbOrder.ResumeLayout(false);
            this.tbOrderInfo.ResumeLayout(false);
            this.tbOrderInfo.PerformLayout();
            this.tbOrderItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbOrder;
        private System.Windows.Forms.TabPage tbOrderInfo;
        private System.Windows.Forms.TabPage tbOrderItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblCustumorName;
        private System.Windows.Forms.Label lblCustumorID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowItems;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnBeauty;
        private System.Windows.Forms.Button btnElectronic;
        private System.Windows.Forms.Button btnCothes;
        private System.Windows.Forms.Button btnBaby;
        private System.Windows.Forms.Button btnAliments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnShipping;
    }
}