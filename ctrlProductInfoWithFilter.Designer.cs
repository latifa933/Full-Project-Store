namespace ProjectStore
{
    partial class ctrlProductInfoWithFilter
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txbFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.ctrlProductInfo1 = new ProjectStore.ctrlProductInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By :";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.txbFilterValue);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(23, 14);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(731, 68);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Silver;
            this.btnFind.ForeColor = System.Drawing.Color.Red;
            this.btnFind.Location = new System.Drawing.Point(549, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 30);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txbFilterValue
            // 
            this.txbFilterValue.Location = new System.Drawing.Point(338, 19);
            this.txbFilterValue.Name = "txbFilterValue";
            this.txbFilterValue.Size = new System.Drawing.Size(176, 28);
            this.txbFilterValue.TabIndex = 3;
            this.txbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFilterValue_KeyPress);
            this.txbFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txbFilterValue_Validating);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "ProductID",
            "Product Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(125, 19);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(188, 30);
            this.cbFilterBy.TabIndex = 2;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // ctrlProductInfo1
            // 
            this.ctrlProductInfo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlProductInfo1.Location = new System.Drawing.Point(23, 88);
            this.ctrlProductInfo1.Name = "ctrlProductInfo1";
            this.ctrlProductInfo1.Size = new System.Drawing.Size(702, 385);
            this.ctrlProductInfo1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlProductInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlProductInfo1);
            this.Name = "ctrlProductInfoWithFilter";
            this.Size = new System.Drawing.Size(782, 492);
            this.Load += new System.EventHandler(this.ctrlProductInfoWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlProductInfo ctrlProductInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txbFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
