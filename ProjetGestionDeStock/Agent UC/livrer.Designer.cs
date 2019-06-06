namespace ProjetGestionDeStock.Agent_UC
{
    partial class Livrer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livrer));
            this.DG_livrer = new ns1.BunifuCustomDataGrid();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.BTN_AjouterCategorie = new ns1.BunifuThinButton2();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DG_livrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_livrer
            // 
            this.DG_livrer.AllowUserToAddRows = false;
            this.DG_livrer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DG_livrer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_livrer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_livrer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_livrer.BackgroundColor = System.Drawing.Color.White;
            this.DG_livrer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_livrer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_livrer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_livrer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_livrer.ColumnHeadersHeight = 50;
            this.DG_livrer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.CIN,
            this.adresse,
            this.prix,
            this.quantite,
            this.date});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_livrer.DefaultCellStyle = dataGridViewCellStyle6;
            this.DG_livrer.DoubleBuffered = true;
            this.DG_livrer.EnableHeadersVisualStyles = false;
            this.DG_livrer.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            this.DG_livrer.HeaderForeColor = System.Drawing.Color.White;
            this.DG_livrer.Location = new System.Drawing.Point(13, 165);
            this.DG_livrer.Margin = new System.Windows.Forms.Padding(4);
            this.DG_livrer.Name = "DG_livrer";
            this.DG_livrer.ReadOnly = true;
            this.DG_livrer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG_livrer.RowHeadersVisible = false;
            this.DG_livrer.RowTemplate.DividerHeight = 1;
            this.DG_livrer.RowTemplate.Height = 40;
            this.DG_livrer.RowTemplate.ReadOnly = true;
            this.DG_livrer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_livrer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_livrer.Size = new System.Drawing.Size(809, 158);
            this.DG_livrer.TabIndex = 32;
            this.DG_livrer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_lastproduit_CellContentClick);
            // 
            // reference
            // 
            this.reference.DataPropertyName = "reference";
            this.reference.HeaderText = "Reference";
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            // 
            // CIN
            // 
            this.CIN.DataPropertyName = "CIN";
            this.CIN.HeaderText = "CIN de Client";
            this.CIN.Name = "CIN";
            this.CIN.ReadOnly = true;
            // 
            // adresse
            // 
            this.adresse.DataPropertyName = "adresse";
            this.adresse.HeaderText = "adresse";
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            // 
            // prix
            // 
            this.prix.DataPropertyName = "prix";
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            // 
            // quantite
            // 
            this.quantite.DataPropertyName = "quantite";
            this.quantite.HeaderText = "Quantite";
            this.quantite.Name = "quantite";
            this.quantite.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "La Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(27, 22);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(76, 19);
            this.bunifuCustomLabel2.TabIndex = 33;
            this.bunifuCustomLabel2.Text = "livraison";
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
            this.BTN_AjouterCategorie.ButtonText = "Ajouter";
            this.BTN_AjouterCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AjouterCategorie.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AjouterCategorie.ForeColor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.IdleBorderThickness = 1;
            this.BTN_AjouterCategorie.IdleCornerRadius = 20;
            this.BTN_AjouterCategorie.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.BTN_AjouterCategorie.IdleForecolor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.IdleLineColor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.Location = new System.Drawing.Point(614, 391);
            this.BTN_AjouterCategorie.Margin = new System.Windows.Forms.Padding(6);
            this.BTN_AjouterCategorie.Name = "BTN_AjouterCategorie";
            this.BTN_AjouterCategorie.Size = new System.Drawing.Size(199, 52);
            this.BTN_AjouterCategorie.TabIndex = 46;
            this.BTN_AjouterCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(64, 103);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(204, 19);
            this.bunifuCustomLabel3.TabIndex = 36;
            this.bunifuCustomLabel3.Text = "liste des produits a livrer";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // Livrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.BTN_AjouterCategorie);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.DG_livrer);
            this.Name = "Livrer";
            this.Size = new System.Drawing.Size(836, 511);
            this.Load += new System.EventHandler(this.Livrer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_livrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomDataGrid DG_livrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuThinButton2 BTN_AjouterCategorie;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
    }
}
