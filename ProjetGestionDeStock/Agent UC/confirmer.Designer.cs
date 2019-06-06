namespace ProjetGestionDeStock.Agent_UC
{
    partial class confirmer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirmer));
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.etat = new ns1.BunifuMaterialTextbox();
            this.DG_livrer = new ns1.BunifuCustomDataGrid();
            this.BTN_AjouterCategorie = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DG_livrer)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(48, 26);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(207, 19);
            this.bunifuCustomLabel3.TabIndex = 37;
            this.bunifuCustomLabel3.Text = "Liste des produits a livrer";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(48, 337);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(136, 19);
            this.bunifuCustomLabel1.TabIndex = 38;
            this.bunifuCustomLabel1.Text = "Etat de livraison";
            // 
            // etat
            // 
            this.etat.BackColor = System.Drawing.Color.White;
            this.etat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.etat.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etat.ForeColor = System.Drawing.Color.Black;
            this.etat.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.etat.HintText = "";
            this.etat.isPassword = false;
            this.etat.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.etat.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.etat.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.etat.LineThickness = 8;
            this.etat.Location = new System.Drawing.Point(298, 322);
            this.etat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.etat.Name = "etat";
            this.etat.Size = new System.Drawing.Size(366, 43);
            this.etat.TabIndex = 43;
            this.etat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DG_livrer
            // 
            this.DG_livrer.AllowUserToAddRows = false;
            this.DG_livrer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DG_livrer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_livrer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_livrer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_livrer.BackgroundColor = System.Drawing.Color.White;
            this.DG_livrer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_livrer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_livrer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_livrer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_livrer.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_livrer.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_livrer.DoubleBuffered = true;
            this.DG_livrer.EnableHeadersVisualStyles = false;
            this.DG_livrer.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.DG_livrer.HeaderForeColor = System.Drawing.Color.White;
            this.DG_livrer.Location = new System.Drawing.Point(75, 49);
            this.DG_livrer.Margin = new System.Windows.Forms.Padding(4);
            this.DG_livrer.Name = "DG_livrer";
            this.DG_livrer.ReadOnly = true;
            this.DG_livrer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG_livrer.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DG_livrer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_livrer.RowTemplate.DividerHeight = 1;
            this.DG_livrer.RowTemplate.Height = 40;
            this.DG_livrer.RowTemplate.ReadOnly = true;
            this.DG_livrer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_livrer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_livrer.Size = new System.Drawing.Size(723, 263);
            this.DG_livrer.TabIndex = 48;
            // 
            // BTN_AjouterCategorie
            // 
            this.BTN_AjouterCategorie.ActiveBorderThickness = 1;
            this.BTN_AjouterCategorie.ActiveCornerRadius = 20;
            this.BTN_AjouterCategorie.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.BTN_AjouterCategorie.ActiveForecolor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.BTN_AjouterCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.BTN_AjouterCategorie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_AjouterCategorie.BackgroundImage")));
            this.BTN_AjouterCategorie.ButtonText = "Modifier";
            this.BTN_AjouterCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AjouterCategorie.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AjouterCategorie.ForeColor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.IdleBorderThickness = 1;
            this.BTN_AjouterCategorie.IdleCornerRadius = 20;
            this.BTN_AjouterCategorie.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.BTN_AjouterCategorie.IdleForecolor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.IdleLineColor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.Location = new System.Drawing.Point(641, 383);
            this.BTN_AjouterCategorie.Margin = new System.Windows.Forms.Padding(6);
            this.BTN_AjouterCategorie.Name = "BTN_AjouterCategorie";
            this.BTN_AjouterCategorie.Size = new System.Drawing.Size(199, 52);
            this.BTN_AjouterCategorie.TabIndex = 47;
            this.BTN_AjouterCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_AjouterCategorie.Click += new System.EventHandler(this.BTN_AjouterCategorie_Click);
            // 
            // confirmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.DG_livrer);
            this.Controls.Add(this.BTN_AjouterCategorie);
            this.Controls.Add(this.etat);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "confirmer";
            this.Size = new System.Drawing.Size(933, 518);
            this.Load += new System.EventHandler(this.confirmer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_livrer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuMaterialTextbox etat;
        private ns1.BunifuThinButton2 BTN_AjouterCategorie;
        private ns1.BunifuCustomDataGrid DG_livrer;
    }
}
