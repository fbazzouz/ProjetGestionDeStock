namespace ProjetGestionDeStock
{
    partial class ajouterproduit
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
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.TB_Reference = new ns1.BunifuMaterialTextbox();
            this.TB_Quantite = new ns1.BunifuMaterialTextbox();
            this.TB_Prix = new ns1.BunifuMaterialTextbox();
            this.CB_categorie = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.TB_Marque = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.TB_description = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(21, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(87, 19);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Référence :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(21, 61);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(78, 19);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Quantité :";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(21, 115);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(44, 19);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Prix :";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(15, 308);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(84, 19);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "Catégorie :";
            // 
            // TB_Reference
            // 
            this.TB_Reference.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Reference.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Reference.ForeColor = System.Drawing.Color.White;
            this.TB_Reference.HintForeColor = System.Drawing.Color.Empty;
            this.TB_Reference.HintText = "";
            this.TB_Reference.isPassword = false;
            this.TB_Reference.LineFocusedColor = System.Drawing.Color.White;
            this.TB_Reference.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.TB_Reference.LineMouseHoverColor = System.Drawing.Color.White;
            this.TB_Reference.LineThickness = 3;
            this.TB_Reference.Location = new System.Drawing.Point(118, 2);
            this.TB_Reference.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Reference.Name = "TB_Reference";
            this.TB_Reference.Size = new System.Drawing.Size(181, 33);
            this.TB_Reference.TabIndex = 4;
            this.TB_Reference.Text = " ";
            this.TB_Reference.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TB_Quantite
            // 
            this.TB_Quantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Quantite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TB_Quantite.ForeColor = System.Drawing.Color.White;
            this.TB_Quantite.HintForeColor = System.Drawing.Color.Empty;
            this.TB_Quantite.HintText = "";
            this.TB_Quantite.isPassword = false;
            this.TB_Quantite.LineFocusedColor = System.Drawing.Color.White;
            this.TB_Quantite.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.TB_Quantite.LineMouseHoverColor = System.Drawing.Color.White;
            this.TB_Quantite.LineThickness = 3;
            this.TB_Quantite.Location = new System.Drawing.Point(118, 45);
            this.TB_Quantite.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Quantite.Name = "TB_Quantite";
            this.TB_Quantite.Size = new System.Drawing.Size(181, 33);
            this.TB_Quantite.TabIndex = 5;
            this.TB_Quantite.Text = " ";
            this.TB_Quantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TB_Prix
            // 
            this.TB_Prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Prix.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TB_Prix.ForeColor = System.Drawing.Color.White;
            this.TB_Prix.HintForeColor = System.Drawing.Color.Empty;
            this.TB_Prix.HintText = "";
            this.TB_Prix.isPassword = false;
            this.TB_Prix.LineFocusedColor = System.Drawing.Color.White;
            this.TB_Prix.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.TB_Prix.LineMouseHoverColor = System.Drawing.Color.White;
            this.TB_Prix.LineThickness = 3;
            this.TB_Prix.Location = new System.Drawing.Point(118, 96);
            this.TB_Prix.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Prix.Name = "TB_Prix";
            this.TB_Prix.Size = new System.Drawing.Size(181, 33);
            this.TB_Prix.TabIndex = 6;
            this.TB_Prix.Text = " ";
            this.TB_Prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CB_categorie
            // 
            this.CB_categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_categorie.FormattingEnabled = true;
            this.CB_categorie.Location = new System.Drawing.Point(134, 304);
            this.CB_categorie.Name = "CB_categorie";
            this.CB_categorie.Size = new System.Drawing.Size(181, 23);
            this.CB_categorie.TabIndex = 7;
            this.CB_categorie.Text = "    Choisissez une catégorie";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(20, 169);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(71, 19);
            this.bunifuCustomLabel5.TabIndex = 9;
            this.bunifuCustomLabel5.Text = "Marque :";
            // 
            // TB_Marque
            // 
            this.TB_Marque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Marque.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TB_Marque.ForeColor = System.Drawing.Color.White;
            this.TB_Marque.HintForeColor = System.Drawing.Color.Empty;
            this.TB_Marque.HintText = "";
            this.TB_Marque.isPassword = false;
            this.TB_Marque.LineFocusedColor = System.Drawing.Color.White;
            this.TB_Marque.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.TB_Marque.LineMouseHoverColor = System.Drawing.Color.White;
            this.TB_Marque.LineThickness = 3;
            this.TB_Marque.Location = new System.Drawing.Point(118, 150);
            this.TB_Marque.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Marque.Name = "TB_Marque";
            this.TB_Marque.Size = new System.Drawing.Size(181, 33);
            this.TB_Marque.TabIndex = 10;
            this.TB_Marque.Text = " ";
            this.TB_Marque.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(21, 231);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(97, 19);
            this.bunifuCustomLabel6.TabIndex = 11;
            this.bunifuCustomLabel6.Text = "Description :";
            // 
            // TB_description
            // 
            this.TB_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.TB_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_description.ForeColor = System.Drawing.Color.White;
            this.TB_description.Location = new System.Drawing.Point(120, 213);
            this.TB_description.Multiline = true;
            this.TB_description.Name = "TB_description";
            this.TB_description.Size = new System.Drawing.Size(215, 65);
            this.TB_description.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.button1.Location = new System.Drawing.Point(345, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ajouterproduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_description);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.TB_Marque);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.CB_categorie);
            this.Controls.Add(this.TB_Prix);
            this.Controls.Add(this.TB_Quantite);
            this.Controls.Add(this.TB_Reference);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ajouterproduit";
            this.Size = new System.Drawing.Size(527, 394);
            this.Load += new System.EventHandler(this.ajouterproduit_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuMaterialTextbox TB_Reference;
        private ns1.BunifuMaterialTextbox TB_Quantite;
        private ns1.BunifuMaterialTextbox TB_Prix;
        private System.Windows.Forms.ComboBox CB_categorie;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuMaterialTextbox TB_Marque;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.TextBox TB_description;
        private System.Windows.Forms.Button button1;
    }
}
