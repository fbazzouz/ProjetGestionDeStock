namespace ProjetGestionDeStock.Agent_UC
{
    partial class A_liver
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
            this.DG_lastproduit = new ns1.BunifuCustomDataGrid();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_lastproduit)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_lastproduit
            // 
            this.DG_lastproduit.AllowUserToAddRows = false;
            this.DG_lastproduit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DG_lastproduit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_lastproduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_lastproduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_lastproduit.BackgroundColor = System.Drawing.Color.White;
            this.DG_lastproduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_lastproduit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_lastproduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_lastproduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_lastproduit.ColumnHeadersHeight = 50;
            this.DG_lastproduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.CIN,
            this.marque,
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
            this.DG_lastproduit.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_lastproduit.DoubleBuffered = true;
            this.DG_lastproduit.EnableHeadersVisualStyles = false;
            this.DG_lastproduit.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            this.DG_lastproduit.HeaderForeColor = System.Drawing.Color.White;
            this.DG_lastproduit.Location = new System.Drawing.Point(4, 38);
            this.DG_lastproduit.Margin = new System.Windows.Forms.Padding(4);
            this.DG_lastproduit.Name = "DG_lastproduit";
            this.DG_lastproduit.ReadOnly = true;
            this.DG_lastproduit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG_lastproduit.RowHeadersVisible = false;
            this.DG_lastproduit.RowTemplate.DividerHeight = 1;
            this.DG_lastproduit.RowTemplate.Height = 40;
            this.DG_lastproduit.RowTemplate.ReadOnly = true;
            this.DG_lastproduit.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_lastproduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_lastproduit.Size = new System.Drawing.Size(1043, 344);
            this.DG_lastproduit.TabIndex = 32;
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
            // marque
            // 
            this.marque.DataPropertyName = "marque";
            this.marque.HeaderText = "La Marque";
            this.marque.Name = "marque";
            this.marque.ReadOnly = true;
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
            // A_liver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DG_lastproduit);
            this.Name = "A_liver";
            this.Size = new System.Drawing.Size(1064, 645);
            ((System.ComponentModel.ISupportInitialize)(this.DG_lastproduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCustomDataGrid DG_lastproduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}
