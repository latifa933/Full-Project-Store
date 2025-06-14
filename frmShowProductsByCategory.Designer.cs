namespace ProjectStore
{
    partial class frmShowProductsByCategory
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
            this.dgvproducts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seePicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvproducts
            // 
            this.dgvproducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducts.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvproducts.Location = new System.Drawing.Point(46, 57);
            this.dgvproducts.Name = "dgvproducts";
            this.dgvproducts.RowHeadersWidth = 51;
            this.dgvproducts.RowTemplate.Height = 24;
            this.dgvproducts.Size = new System.Drawing.Size(1047, 521);
            this.dgvproducts.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productInfoToolStripMenuItem,
            this.seePicturesToolStripMenuItem,
            this.addToMToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // productInfoToolStripMenuItem
            // 
            this.productInfoToolStripMenuItem.Name = "productInfoToolStripMenuItem";
            this.productInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.productInfoToolStripMenuItem.Text = "product Info";
            this.productInfoToolStripMenuItem.Click += new System.EventHandler(this.productInfoToolStripMenuItem_Click);
            // 
            // seePicturesToolStripMenuItem
            // 
            this.seePicturesToolStripMenuItem.Name = "seePicturesToolStripMenuItem";
            this.seePicturesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.seePicturesToolStripMenuItem.Text = "See pictures";
            this.seePicturesToolStripMenuItem.Click += new System.EventHandler(this.seePicturesToolStripMenuItem_Click);
            // 
            // addToMToolStripMenuItem
            // 
            this.addToMToolStripMenuItem.Name = "addToMToolStripMenuItem";
            this.addToMToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addToMToolStripMenuItem.Text = "Add to my order ";
            this.addToMToolStripMenuItem.Click += new System.EventHandler(this.addToMToolStripMenuItem_Click);
            // 
            // frmShowProductsByCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 677);
            this.Controls.Add(this.dgvproducts);
            this.Name = "frmShowProductsByCategory";
            this.Text = "frmShowProductsByCategory";
            this.Load += new System.EventHandler(this.frmShowProductsByCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seePicturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToMToolStripMenuItem;
    }
}