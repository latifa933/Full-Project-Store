namespace ProjectStore
{
    partial class frmAllProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbAliments = new System.Windows.Forms.TabPage();
            this.tbBaby = new System.Windows.Forms.TabPage();
            this.tbClothes = new System.Windows.Forms.TabPage();
            this.tbElectronic = new System.Windows.Forms.TabPage();
            this.tbBeauty = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvAliments = new System.Windows.Forms.DataGridView();
            this.dgvBaby = new System.Windows.Forms.DataGridView();
            this.dgvClothes = new System.Windows.Forms.DataGridView();
            this.dgvElectronic = new System.Windows.Forms.DataGridView();
            this.dgvBeauty = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tbAliments.SuspendLayout();
            this.tbBaby.SuspendLayout();
            this.tbClothes.SuspendLayout();
            this.tbElectronic.SuspendLayout();
            this.tbBeauty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAliments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClothes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectronic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeauty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(517, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Products";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbAliments);
            this.tabControl1.Controls.Add(this.tbBaby);
            this.tabControl1.Controls.Add(this.tbClothes);
            this.tabControl1.Controls.Add(this.tbElectronic);
            this.tabControl1.Controls.Add(this.tbBeauty);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 116);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1327, 601);
            this.tabControl1.TabIndex = 1;
            // 
            // tbAliments
            // 
            this.tbAliments.Controls.Add(this.dgvAliments);
            this.tbAliments.Location = new System.Drawing.Point(4, 29);
            this.tbAliments.Name = "tbAliments";
            this.tbAliments.Padding = new System.Windows.Forms.Padding(3);
            this.tbAliments.Size = new System.Drawing.Size(1319, 568);
            this.tbAliments.TabIndex = 0;
            this.tbAliments.Text = "Aliments";
            this.tbAliments.UseVisualStyleBackColor = true;
            // 
            // tbBaby
            // 
            this.tbBaby.Controls.Add(this.dgvBaby);
            this.tbBaby.Location = new System.Drawing.Point(4, 29);
            this.tbBaby.Name = "tbBaby";
            this.tbBaby.Padding = new System.Windows.Forms.Padding(3);
            this.tbBaby.Size = new System.Drawing.Size(1319, 568);
            this.tbBaby.TabIndex = 1;
            this.tbBaby.Text = "Baby";
            this.tbBaby.UseVisualStyleBackColor = true;
            // 
            // tbClothes
            // 
            this.tbClothes.Controls.Add(this.dgvClothes);
            this.tbClothes.Location = new System.Drawing.Point(4, 29);
            this.tbClothes.Name = "tbClothes";
            this.tbClothes.Size = new System.Drawing.Size(1319, 568);
            this.tbClothes.TabIndex = 2;
            this.tbClothes.Text = "Clothes";
            this.tbClothes.UseVisualStyleBackColor = true;
            // 
            // tbElectronic
            // 
            this.tbElectronic.Controls.Add(this.dgvElectronic);
            this.tbElectronic.Location = new System.Drawing.Point(4, 29);
            this.tbElectronic.Name = "tbElectronic";
            this.tbElectronic.Size = new System.Drawing.Size(1319, 568);
            this.tbElectronic.TabIndex = 3;
            this.tbElectronic.Text = "Electronic";
            this.tbElectronic.UseVisualStyleBackColor = true;
            // 
            // tbBeauty
            // 
            this.tbBeauty.Controls.Add(this.dgvBeauty);
            this.tbBeauty.Location = new System.Drawing.Point(4, 29);
            this.tbBeauty.Name = "tbBeauty";
            this.tbBeauty.Size = new System.Drawing.Size(1319, 568);
            this.tbBeauty.TabIndex = 4;
            this.tbBeauty.Text = "Beauty & health";
            this.tbBeauty.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1203, 734);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvAliments
            // 
            this.dgvAliments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAliments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAliments.Location = new System.Drawing.Point(15, 22);
            this.dgvAliments.Name = "dgvAliments";
            this.dgvAliments.RowHeadersWidth = 51;
            this.dgvAliments.RowTemplate.Height = 24;
            this.dgvAliments.Size = new System.Drawing.Size(1205, 511);
            this.dgvAliments.TabIndex = 0;
            // 
            // dgvBaby
            // 
            this.dgvBaby.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBaby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaby.Location = new System.Drawing.Point(32, 34);
            this.dgvBaby.Name = "dgvBaby";
            this.dgvBaby.RowHeadersWidth = 51;
            this.dgvBaby.RowTemplate.Height = 24;
            this.dgvBaby.Size = new System.Drawing.Size(1242, 495);
            this.dgvBaby.TabIndex = 0;
            // 
            // dgvClothes
            // 
            this.dgvClothes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClothes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClothes.Location = new System.Drawing.Point(38, 21);
            this.dgvClothes.Name = "dgvClothes";
            this.dgvClothes.RowHeadersWidth = 51;
            this.dgvClothes.RowTemplate.Height = 24;
            this.dgvClothes.Size = new System.Drawing.Size(1224, 529);
            this.dgvClothes.TabIndex = 0;
            // 
            // dgvElectronic
            // 
            this.dgvElectronic.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvElectronic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElectronic.Location = new System.Drawing.Point(24, 25);
            this.dgvElectronic.Name = "dgvElectronic";
            this.dgvElectronic.RowHeadersWidth = 51;
            this.dgvElectronic.RowTemplate.Height = 24;
            this.dgvElectronic.Size = new System.Drawing.Size(1270, 515);
            this.dgvElectronic.TabIndex = 0;
            // 
            // dgvBeauty
            // 
            this.dgvBeauty.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBeauty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeauty.Location = new System.Drawing.Point(23, 20);
            this.dgvBeauty.Name = "dgvBeauty";
            this.dgvBeauty.RowHeadersWidth = 51;
            this.dgvBeauty.RowTemplate.Height = 24;
            this.dgvBeauty.Size = new System.Drawing.Size(1269, 526);
            this.dgvBeauty.TabIndex = 0;
            // 
            // frmAllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 779);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmAllProducts";
            this.Text = "frmAllProducts";
            this.Load += new System.EventHandler(this.frmAllProducts_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbAliments.ResumeLayout(false);
            this.tbBaby.ResumeLayout(false);
            this.tbClothes.ResumeLayout(false);
            this.tbElectronic.ResumeLayout(false);
            this.tbBeauty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAliments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClothes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectronic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeauty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbAliments;
        private System.Windows.Forms.TabPage tbBaby;
        private System.Windows.Forms.TabPage tbClothes;
        private System.Windows.Forms.TabPage tbElectronic;
        private System.Windows.Forms.TabPage tbBeauty;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvAliments;
        private System.Windows.Forms.DataGridView dgvBaby;
        private System.Windows.Forms.DataGridView dgvClothes;
        private System.Windows.Forms.DataGridView dgvElectronic;
        private System.Windows.Forms.DataGridView dgvBeauty;
    }
}