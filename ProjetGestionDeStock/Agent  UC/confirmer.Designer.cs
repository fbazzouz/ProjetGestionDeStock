namespace ProjetGestionDeStock.Agent__UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirmer));
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.BTN_AjouterCategorie = new ns1.BunifuThinButton2();
            this.id_p = new System.Windows.Forms.TextBox();
            this.id_c = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(113, 134);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(111, 19);
            this.bunifuCustomLabel3.TabIndex = 42;
            this.bunifuCustomLabel3.Text = "id du produit";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(113, 192);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(101, 19);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "id du Client";
            // 
            // BTN_AjouterCategorie
            // 
            this.BTN_AjouterCategorie.ActiveBorderThickness = 1;
            this.BTN_AjouterCategorie.ActiveCornerRadius = 20;
            this.BTN_AjouterCategorie.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BTN_AjouterCategorie.ActiveForecolor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BTN_AjouterCategorie.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_AjouterCategorie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_AjouterCategorie.BackgroundImage")));
            this.BTN_AjouterCategorie.ButtonText = "confirmer";
            this.BTN_AjouterCategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AjouterCategorie.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AjouterCategorie.ForeColor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.IdleBorderThickness = 1;
            this.BTN_AjouterCategorie.IdleCornerRadius = 20;
            this.BTN_AjouterCategorie.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.BTN_AjouterCategorie.IdleForecolor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.IdleLineColor = System.Drawing.Color.White;
            this.BTN_AjouterCategorie.Location = new System.Drawing.Point(503, 235);
            this.BTN_AjouterCategorie.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_AjouterCategorie.Name = "BTN_AjouterCategorie";
            this.BTN_AjouterCategorie.Size = new System.Drawing.Size(146, 44);
            this.BTN_AjouterCategorie.TabIndex = 46;
            this.BTN_AjouterCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_AjouterCategorie.Click += new System.EventHandler(this.BTN_AjouterCategorie_Click);
            // 
            // id_p
            // 
            this.id_p.BackColor = System.Drawing.Color.WhiteSmoke;
            this.id_p.Location = new System.Drawing.Point(357, 134);
            this.id_p.Name = "id_p";
            this.id_p.Size = new System.Drawing.Size(200, 22);
            this.id_p.TabIndex = 47;
            // 
            // id_c
            // 
            this.id_c.Location = new System.Drawing.Point(357, 186);
            this.id_c.Name = "id_c";
            this.id_c.Size = new System.Drawing.Size(200, 22);
            this.id_c.TabIndex = 48;
            this.id_c.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // confirmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.id_c);
            this.Controls.Add(this.id_p);
            this.Controls.Add(this.BTN_AjouterCategorie);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Name = "confirmer";
            this.Size = new System.Drawing.Size(786, 427);
            this.Load += new System.EventHandler(this.confirmer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuThinButton2 BTN_AjouterCategorie;
        private System.Windows.Forms.TextBox id_p;
        private System.Windows.Forms.MaskedTextBox id_c;
    }
}
