namespace ProjetGestionDeStock.Admin_UC
{
    partial class ModifierCategorie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierCategorie));
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.DG_CategoriesM = new ns1.BunifuCustomDataGrid();
            this.IdC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockbdDataSet1 = new ProjetGestionDeStock.stockbdDataSet1();
            this.categorieTableAdapter = new ProjetGestionDeStock.stockbdDataSet1TableAdapters.categorieTableAdapter();
            this.BTN_ModifierCategorie = new ns1.BunifuThinButton2();
            this.BTN_SupprimerCategorie = new ns1.BunifuThinButton2();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.TF_ModifiedCategorie = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.DD_Recherche = new ns1.BunifuDropdown();
            this.TF_Recherche = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DG_CategoriesM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockbdDataSet1)).BeginInit();
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
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(186, 19);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "MODIFIER CATEGORIE";
            // 
            // DG_CategoriesM
            // 
            this.DG_CategoriesM.AllowUserToAddRows = false;
            this.DG_CategoriesM.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DG_CategoriesM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_CategoriesM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_CategoriesM.AutoGenerateColumns = false;
            this.DG_CategoriesM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_CategoriesM.BackgroundColor = System.Drawing.Color.White;
            this.DG_CategoriesM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_CategoriesM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_CategoriesM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_CategoriesM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_CategoriesM.ColumnHeadersHeight = 50;
            this.DG_CategoriesM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdC,
            this.nomDataGridViewTextBoxColumn});
            this.DG_CategoriesM.DataSource = this.categorieBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_CategoriesM.DefaultCellStyle = dataGridViewCellStyle6;
            this.DG_CategoriesM.DoubleBuffered = true;
            this.DG_CategoriesM.EnableHeadersVisualStyles = false;
            this.DG_CategoriesM.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.DG_CategoriesM.HeaderForeColor = System.Drawing.Color.White;
            this.DG_CategoriesM.Location = new System.Drawing.Point(26, 119);
            this.DG_CategoriesM.Margin = new System.Windows.Forms.Padding(4);
            this.DG_CategoriesM.Name = "DG_CategoriesM";
            this.DG_CategoriesM.ReadOnly = true;
            this.DG_CategoriesM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG_CategoriesM.RowHeadersVisible = false;
            this.DG_CategoriesM.RowTemplate.DividerHeight = 1;
            this.DG_CategoriesM.RowTemplate.Height = 40;
            this.DG_CategoriesM.RowTemplate.ReadOnly = true;
            this.DG_CategoriesM.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_CategoriesM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_CategoriesM.Size = new System.Drawing.Size(1116, 389);
            this.DG_CategoriesM.TabIndex = 33;
            // 
            // IdC
            // 
            this.IdC.DataPropertyName = "Id";
            this.IdC.HeaderText = "Id";
            this.IdC.Name = "IdC";
            this.IdC.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "categorie";
            this.categorieBindingSource.DataSource = this.stockbdDataSet1;
            // 
            // stockbdDataSet1
            // 
            this.stockbdDataSet1.DataSetName = "stockbdDataSet1";
            this.stockbdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // BTN_ModifierCategorie
            // 
            this.BTN_ModifierCategorie.ActiveBorderThickness = 1;
            this.BTN_ModifierCategorie.ActiveCornerRadius = 20;
            this.BTN_ModifierCategorie.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.BTN_ModifierCategorie.ActiveForecolor = System.Drawing.Color.White;
            this.BTN_ModifierCategorie.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.BTN_ModifierCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.BTN_ModifierCategorie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_ModifierCategorie.BackgroundImage")));
            this.BTN_ModifierCategorie.ButtonText = "Modifier";
            this.BTN_ModifierCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ModifierCategorie.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ModifierCategorie.ForeColor = System.Drawing.Color.White;
            this.BTN_ModifierCategorie.IdleBorderThickness = 1;
            this.BTN_ModifierCategorie.IdleCornerRadius = 20;
            this.BTN_ModifierCategorie.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BTN_ModifierCategorie.IdleForecolor = System.Drawing.Color.White;
            this.BTN_ModifierCategorie.IdleLineColor = System.Drawing.Color.White;
            this.BTN_ModifierCategorie.Location = new System.Drawing.Point(914, 639);
            this.BTN_ModifierCategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_ModifierCategorie.Name = "BTN_ModifierCategorie";
            this.BTN_ModifierCategorie.Size = new System.Drawing.Size(228, 64);
            this.BTN_ModifierCategorie.TabIndex = 37;
            this.BTN_ModifierCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_ModifierCategorie.Click += new System.EventHandler(this.BTN_ModifierCategorie_Click);
            // 
            // BTN_SupprimerCategorie
            // 
            this.BTN_SupprimerCategorie.ActiveBorderThickness = 1;
            this.BTN_SupprimerCategorie.ActiveCornerRadius = 20;
            this.BTN_SupprimerCategorie.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BTN_SupprimerCategorie.ActiveForecolor = System.Drawing.Color.White;
            this.BTN_SupprimerCategorie.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BTN_SupprimerCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.BTN_SupprimerCategorie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_SupprimerCategorie.BackgroundImage")));
            this.BTN_SupprimerCategorie.ButtonText = "Supprimer";
            this.BTN_SupprimerCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SupprimerCategorie.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SupprimerCategorie.ForeColor = System.Drawing.Color.White;
            this.BTN_SupprimerCategorie.IdleBorderThickness = 1;
            this.BTN_SupprimerCategorie.IdleCornerRadius = 20;
            this.BTN_SupprimerCategorie.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.BTN_SupprimerCategorie.IdleForecolor = System.Drawing.Color.White;
            this.BTN_SupprimerCategorie.IdleLineColor = System.Drawing.Color.White;
            this.BTN_SupprimerCategorie.Location = new System.Drawing.Point(26, 639);
            this.BTN_SupprimerCategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_SupprimerCategorie.Name = "BTN_SupprimerCategorie";
            this.BTN_SupprimerCategorie.Size = new System.Drawing.Size(228, 64);
            this.BTN_SupprimerCategorie.TabIndex = 38;
            this.BTN_SupprimerCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_SupprimerCategorie.Click += new System.EventHandler(this.BTN_SupprimerCategorie_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(71, 85);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(275, 21);
            this.bunifuCustomLabel1.TabIndex = 39;
            this.bunifuCustomLabel1.Text = "Tous les catégories disponibles :";
            // 
            // TF_ModifiedCategorie
            // 
            this.TF_ModifiedCategorie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TF_ModifiedCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TF_ModifiedCategorie.ForeColor = System.Drawing.Color.White;
            this.TF_ModifiedCategorie.HintForeColor = System.Drawing.Color.White;
            this.TF_ModifiedCategorie.HintText = "";
            this.TF_ModifiedCategorie.isPassword = false;
            this.TF_ModifiedCategorie.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.TF_ModifiedCategorie.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.TF_ModifiedCategorie.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.TF_ModifiedCategorie.LineThickness = 5;
            this.TF_ModifiedCategorie.Location = new System.Drawing.Point(622, 648);
            this.TF_ModifiedCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.TF_ModifiedCategorie.Name = "TF_ModifiedCategorie";
            this.TF_ModifiedCategorie.Size = new System.Drawing.Size(275, 44);
            this.TF_ModifiedCategorie.TabIndex = 41;
            this.TF_ModifiedCategorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(455, 664);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(137, 19);
            this.bunifuCustomLabel3.TabIndex = 40;
            this.bunifuCustomLabel3.Text = "Nouveau nom :";
            // 
            // DD_Recherche
            // 
            this.DD_Recherche.BackColor = System.Drawing.Color.Transparent;
            this.DD_Recherche.BorderRadius = 3;
            this.DD_Recherche.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DD_Recherche.ForeColor = System.Drawing.Color.White;
            this.DD_Recherche.Items = new string[] {
        "Id",
        "Nom"};
            this.DD_Recherche.Location = new System.Drawing.Point(364, 517);
            this.DD_Recherche.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DD_Recherche.Name = "DD_Recherche";
            this.DD_Recherche.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.DD_Recherche.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.DD_Recherche.selectedIndex = 0;
            this.DD_Recherche.Size = new System.Drawing.Size(228, 45);
            this.DD_Recherche.TabIndex = 42;
            // 
            // TF_Recherche
            // 
            this.TF_Recherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TF_Recherche.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TF_Recherche.ForeColor = System.Drawing.Color.White;
            this.TF_Recherche.HintForeColor = System.Drawing.Color.White;
            this.TF_Recherche.HintText = "";
            this.TF_Recherche.isPassword = false;
            this.TF_Recherche.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.TF_Recherche.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.TF_Recherche.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.TF_Recherche.LineThickness = 5;
            this.TF_Recherche.Location = new System.Drawing.Point(613, 518);
            this.TF_Recherche.Margin = new System.Windows.Forms.Padding(4);
            this.TF_Recherche.Name = "TF_Recherche";
            this.TF_Recherche.Size = new System.Drawing.Size(265, 44);
            this.TF_Recherche.TabIndex = 43;
            this.TF_Recherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TF_Recherche.OnValueChanged += new System.EventHandler(this.TF_Recherche_OnValueChanged);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(126, 531);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(220, 19);
            this.bunifuCustomLabel4.TabIndex = 44;
            this.bunifuCustomLabel4.Text = "Recherche par selection :";
            // 
            // ModifierCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.TF_Recherche);
            this.Controls.Add(this.DD_Recherche);
            this.Controls.Add(this.TF_ModifiedCategorie);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.BTN_SupprimerCategorie);
            this.Controls.Add(this.BTN_ModifierCategorie);
            this.Controls.Add(this.DG_CategoriesM);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "ModifierCategorie";
            this.Size = new System.Drawing.Size(1171, 785);
            this.Load += new System.EventHandler(this.ModifierCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_CategoriesM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockbdDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomDataGrid DG_CategoriesM;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private stockbdDataSet1 stockbdDataSet1;
        private stockbdDataSet1TableAdapters.categorieTableAdapter categorieTableAdapter;
        private ns1.BunifuThinButton2 BTN_ModifierCategorie;
        private ns1.BunifuThinButton2 BTN_SupprimerCategorie;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdC;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private ns1.BunifuMaterialTextbox TF_ModifiedCategorie;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuDropdown DD_Recherche;
        private ns1.BunifuMaterialTextbox TF_Recherche;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
    }
}
