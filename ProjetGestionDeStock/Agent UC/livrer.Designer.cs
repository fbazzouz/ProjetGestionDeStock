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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_livrer = new ns1.BunifuCustomDataGrid();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_livrer)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_livrer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_livrer.ColumnHeadersHeight = 50;
            this.DG_livrer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.CIN,
            this.adresse,
            this.prix,
            this.quantite,
            this.date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_livrer.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_livrer.DoubleBuffered = true;
            this.DG_livrer.EnableHeadersVisualStyles = false;
            this.DG_livrer.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            this.DG_livrer.HeaderForeColor = System.Drawing.Color.White;
            this.DG_livrer.Location = new System.Drawing.Point(64, 104);
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
            this.DG_livrer.Size = new System.Drawing.Size(1045, 386);
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
            // Livrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.DG_livrer);
            this.Name = "Livrer";
            this.Size = new System.Drawing.Size(1167, 732);
            this.Load += new System.EventHandler(this.Livrer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_livrer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCustomDataGrid DG_livrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}
