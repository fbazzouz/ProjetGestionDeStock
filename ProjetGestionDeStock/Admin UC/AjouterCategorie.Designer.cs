namespace ProjetGestionDeStock.Admin_UC
{
    partial class AjouterCategorie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterCategorie));
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.DG_Categories = new ns1.BunifuCustomDataGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockbdDataSet = new ProjetGestionDeStock.stockbdDataSet();
            this.categorieTableAdapter = new ProjetGestionDeStock.stockbdDataSetTableAdapters.categorieTableAdapter();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.TF_NewCategorie = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.BTN_AjouterCategorie = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Categories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockbdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 33);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(179, 19);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "AJOUTER CATEGORIE";
            // 
            // DG_Categories
            // 
            this.DG_Categories.AllowUserToAddRows = false;
            this.DG_Categories.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DG_Categories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Categories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Categories.AutoGenerateColumns = false;
            this.DG_Categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Categories.BackgroundColor = System.Drawing.Color.White;
            this.DG_Categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Categories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_Categories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Categories.ColumnHeadersHeight = 50;
            this.DG_Categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn});
            this.DG_Categories.DataSource = this.categorieBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Categories.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_Categories.DoubleBuffered = true;
            this.DG_Categories.EnableHeadersVisualStyles = false;
            this.DG_Categories.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.DG_Categories.HeaderForeColor = System.Drawing.Color.White;
            this.DG_Categories.Location = new System.Drawing.Point(171, 433);
            this.DG_Categories.Margin = new System.Windows.Forms.Padding(4);
            this.DG_Categories.Name = "DG_Categories";
            this.DG_Categories.ReadOnly = true;
            this.DG_Categories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG_Categories.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DG_Categories.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_Categories.RowTemplate.DividerHeight = 1;
            this.DG_Categories.RowTemplate.Height = 40;
            this.DG_Categories.RowTemplate.ReadOnly = true;
            this.DG_Categories.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Categories.Size = new System.Drawing.Size(813, 266);
            this.DG_Categories.TabIndex = 32;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom du categorie";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "categorie";
            this.categorieBindingSource.DataSource = this.stockbdDataSet;
            // 
            // stockbdDataSet
            // 
            this.stockbdDataSet.DataSetName = "stockbdDataSet";
            this.stockbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(296, 174);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(190, 19);
            this.bunifuCustomLabel1.TabIndex = 33;
            this.bunifuCustomLabel1.Text = "Nom de la catogerie :";
            // 
            // TF_NewCategorie
            // 
            this.TF_NewCategorie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TF_NewCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TF_NewCategorie.ForeColor = System.Drawing.Color.White;
            this.TF_NewCategorie.HintForeColor = System.Drawing.Color.White;
            this.TF_NewCategorie.HintText = "";
            this.TF_NewCategorie.isPassword = false;
            this.TF_NewCategorie.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.TF_NewCategorie.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.TF_NewCategorie.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.TF_NewCategorie.LineThickness = 3;
            this.TF_NewCategorie.Location = new System.Drawing.Point(513, 158);
            this.TF_NewCategorie.Margin = new System.Windows.Forms.Padding(5);
            this.TF_NewCategorie.Name = "TF_NewCategorie";
            this.TF_NewCategorie.Size = new System.Drawing.Size(315, 44);
            this.TF_NewCategorie.TabIndex = 34;
            this.TF_NewCategorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(427, 254);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(290, 19);
            this.bunifuCustomLabel3.TabIndex = 35;
            this.bunifuCustomLabel3.Text = "* Id sera généré automatiquement";
            // 
            // BTN_AjouterCategorie
            // 
            this.BTN_AjouterCategorie.ActiveBorderThickness = 1;
            this.BTN_AjouterCategorie.ActiveCornerRadius = 20;
            this.BTN_AjouterCategorie.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BTN_AjouterCategorie.ActiveForecolor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BTN_AjouterCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.BTN_AjouterCategorie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_AjouterCategorie.BackgroundImage")));
            this.BTN_AjouterCategorie.ButtonText = "Ajouter";
            this.BTN_AjouterCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AjouterCategorie.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AjouterCategorie.ForeColor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.IdleBorderThickness = 1;
            this.BTN_AjouterCategorie.IdleCornerRadius = 20;
            this.BTN_AjouterCategorie.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.BTN_AjouterCategorie.IdleForecolor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.IdleLineColor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.Location = new System.Drawing.Point(829, 306);
            this.BTN_AjouterCategorie.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_AjouterCategorie.Name = "BTN_AjouterCategorie";
            this.BTN_AjouterCategorie.Size = new System.Drawing.Size(228, 64);
            this.BTN_AjouterCategorie.TabIndex = 36;
            this.BTN_AjouterCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_AjouterCategorie.Click += new System.EventHandler(this.BTN_AjouterCategorie_Click);
            // 
            // AjouterCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.BTN_AjouterCategorie);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.TF_NewCategorie);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.DG_Categories);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AjouterCategorie";
            this.Size = new System.Drawing.Size(1171, 785);
            this.Load += new System.EventHandler(this.AjouterCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Categories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockbdDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomDataGrid DG_Categories;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private stockbdDataSet stockbdDataSet;
        private stockbdDataSetTableAdapters.categorieTableAdapter categorieTableAdapter;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuMaterialTextbox TF_NewCategorie;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuThinButton2 BTN_AjouterCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
    }
}
