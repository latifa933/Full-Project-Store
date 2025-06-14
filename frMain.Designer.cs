namespace ProjectStore
{
    partial class frMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.custumorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustumorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustumorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concelOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suivateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousReviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.custumorToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.shippingToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.reviewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1409, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // custumorToolStripMenuItem
            // 
            this.custumorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustumorToolStripMenuItem,
            this.updateCustumorInfoToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.custumorToolStripMenuItem.Name = "custumorToolStripMenuItem";
            this.custumorToolStripMenuItem.Size = new System.Drawing.Size(117, 32);
            this.custumorToolStripMenuItem.Text = "Custumor";
            // 
            // addNewCustumorToolStripMenuItem
            // 
            this.addNewCustumorToolStripMenuItem.Name = "addNewCustumorToolStripMenuItem";
            this.addNewCustumorToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.addNewCustumorToolStripMenuItem.Text = "add new custumor";
            this.addNewCustumorToolStripMenuItem.Click += new System.EventHandler(this.addNewCustumorToolStripMenuItem_Click);
            // 
            // updateCustumorInfoToolStripMenuItem
            // 
            this.updateCustumorInfoToolStripMenuItem.Name = "updateCustumorInfoToolStripMenuItem";
            this.updateCustumorInfoToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.updateCustumorInfoToolStripMenuItem.Text = "update custumor info";
            this.updateCustumorInfoToolStripMenuItem.Click += new System.EventHandler(this.updateCustumorInfoToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.loginToolStripMenuItem.Text = "login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.updateOrderToolStripMenuItem,
            this.concelOrderToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(221, 32);
            this.newOrderToolStripMenuItem.Text = "new order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // updateOrderToolStripMenuItem
            // 
            this.updateOrderToolStripMenuItem.Name = "updateOrderToolStripMenuItem";
            this.updateOrderToolStripMenuItem.Size = new System.Drawing.Size(221, 32);
            this.updateOrderToolStripMenuItem.Text = "update order";
            this.updateOrderToolStripMenuItem.Click += new System.EventHandler(this.updateOrderToolStripMenuItem_Click);
            // 
            // concelOrderToolStripMenuItem
            // 
            this.concelOrderToolStripMenuItem.Name = "concelOrderToolStripMenuItem";
            this.concelOrderToolStripMenuItem.Size = new System.Drawing.Size(221, 32);
            this.concelOrderToolStripMenuItem.Text = "concel order";
            this.concelOrderToolStripMenuItem.Click += new System.EventHandler(this.concelOrderToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.allProductsToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.productsToolStripMenuItem.Text = "products";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.addNewProductToolStripMenuItem.Text = "add new product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // allProductsToolStripMenuItem
            // 
            this.allProductsToolStripMenuItem.Name = "allProductsToolStripMenuItem";
            this.allProductsToolStripMenuItem.Size = new System.Drawing.Size(258, 32);
            this.allProductsToolStripMenuItem.Text = "all products";
            this.allProductsToolStripMenuItem.Click += new System.EventHandler(this.allProductsToolStripMenuItem_Click);
            // 
            // shippingToolStripMenuItem
            // 
            this.shippingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suivateOrderToolStripMenuItem,
            this.myOrderToolStripMenuItem});
            this.shippingToolStripMenuItem.Name = "shippingToolStripMenuItem";
            this.shippingToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.shippingToolStripMenuItem.Text = "Shipping";
            // 
            // suivateOrderToolStripMenuItem
            // 
            this.suivateOrderToolStripMenuItem.Name = "suivateOrderToolStripMenuItem";
            this.suivateOrderToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.suivateOrderToolStripMenuItem.Text = "suivate order";
            this.suivateOrderToolStripMenuItem.Click += new System.EventHandler(this.suivateOrderToolStripMenuItem_Click);
            // 
            // myOrderToolStripMenuItem
            // 
            this.myOrderToolStripMenuItem.Name = "myOrderToolStripMenuItem";
            this.myOrderToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.myOrderToolStripMenuItem.Text = "my order";
            this.myOrderToolStripMenuItem.Click += new System.EventHandler(this.myOrderToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.paymentToolStripMenuItem.Text = "payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // reviewToolStripMenuItem
            // 
            this.reviewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewReviewToolStripMenuItem,
            this.previousReviewsToolStripMenuItem});
            this.reviewToolStripMenuItem.Name = "reviewToolStripMenuItem";
            this.reviewToolStripMenuItem.Size = new System.Drawing.Size(89, 32);
            this.reviewToolStripMenuItem.Text = "review";
            // 
            // createNewReviewToolStripMenuItem
            // 
            this.createNewReviewToolStripMenuItem.Name = "createNewReviewToolStripMenuItem";
            this.createNewReviewToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.createNewReviewToolStripMenuItem.Text = "create new review";
            this.createNewReviewToolStripMenuItem.Click += new System.EventHandler(this.createNewReviewToolStripMenuItem_Click);
            // 
            // previousReviewsToolStripMenuItem
            // 
            this.previousReviewsToolStripMenuItem.Name = "previousReviewsToolStripMenuItem";
            this.previousReviewsToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.previousReviewsToolStripMenuItem.Text = "previous reviews";
            this.previousReviewsToolStripMenuItem.Click += new System.EventHandler(this.previousReviewsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(285, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcom in your Store";
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1409, 696);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frMain_FormClosed);
            this.Load += new System.EventHandler(this.frMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem custumorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem addNewCustumorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustumorInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concelOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shippingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewReviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousReviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suivateOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myOrderToolStripMenuItem;
    }
}

