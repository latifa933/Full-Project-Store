namespace ProjectStore
{
    partial class frmlistReview
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
            this.ctrlProductInfoWithFilter1 = new ProjectStore.ctrlProductInfoWithFilter();
            this.dgvListReview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListReview)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlProductInfoWithFilter1
            // 
            this.ctrlProductInfoWithFilter1.Location = new System.Drawing.Point(12, -9);
            this.ctrlProductInfoWithFilter1.Name = "ctrlProductInfoWithFilter1";
            this.ctrlProductInfoWithFilter1.Size = new System.Drawing.Size(663, 444);
            this.ctrlProductInfoWithFilter1.TabIndex = 0;
            this.ctrlProductInfoWithFilter1.OnProductSelected += new System.Action<int>(this.ctrlProductInfoWithFilter1_OnProductSelected);
            // 
            // dgvListReview
            // 
            this.dgvListReview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListReview.Location = new System.Drawing.Point(12, 441);
            this.dgvListReview.Name = "dgvListReview";
            this.dgvListReview.RowHeadersWidth = 51;
            this.dgvListReview.RowTemplate.Height = 24;
            this.dgvListReview.Size = new System.Drawing.Size(1266, 302);
            this.dgvListReview.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(752, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "List Review For Product";
            // 
            // button1
            // 
            this.button1.Image = global::ProjectStore.Properties.Resources.Close_32;
            this.button1.Location = new System.Drawing.Point(1274, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 39);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmlistReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 755);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListReview);
            this.Controls.Add(this.ctrlProductInfoWithFilter1);
            this.Name = "frmlistReview";
            this.Text = "frmlistReview";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListReview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlProductInfoWithFilter ctrlProductInfoWithFilter1;
        private System.Windows.Forms.DataGridView dgvListReview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}