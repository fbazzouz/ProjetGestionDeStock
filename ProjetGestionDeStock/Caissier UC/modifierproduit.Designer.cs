﻿namespace ProjetGestionDeStock
{
    partial class modifierproduit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TB_description = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.TB_Marque = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.TB_Prix = new ns1.BunifuMaterialTextbox();
            this.TB_Quantite = new ns1.BunifuMaterialTextbox();
            this.TB_Reference = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomDataGrid1 = new ns1.BunifuCustomDataGrid();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_categorie = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_description
            // 
            this.TB_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.TB_description.ForeColor = System.Drawing.Color.White;
            this.TB_description.Location = new System.Drawing.Point(139, 111);
            this.TB_description.Multiline = true;
            this.TB_description.Name = "TB_description";
            this.TB_description.Size = new System.Drawing.Size(215, 65);
            this.TB_description.TabIndex = 25;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(42, 131);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(97, 19);
            this.bunifuCustomLabel6.TabIndex = 24;
            this.bunifuCustomLabel6.Text = "Description :";
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
            this.TB_Marque.Location = new System.Drawing.Point(496, 65);
            this.TB_Marque.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Marque.Name = "TB_Marque";
            this.TB_Marque.Size = new System.Drawing.Size(181, 33);
            this.TB_Marque.TabIndex = 23;
            this.TB_Marque.Text = " ";
            this.TB_Marque.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(399, 79);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(71, 19);
            this.bunifuCustomLabel5.TabIndex = 22;
            this.bunifuCustomLabel5.Text = "Marque :";
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
            this.TB_Prix.Location = new System.Drawing.Point(143, 65);
            this.TB_Prix.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Prix.Name = "TB_Prix";
            this.TB_Prix.Size = new System.Drawing.Size(181, 33);
            this.TB_Prix.TabIndex = 19;
            this.TB_Prix.Text = " ";
            this.TB_Prix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.TB_Quantite.Location = new System.Drawing.Point(496, 20);
            this.TB_Quantite.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Quantite.Name = "TB_Quantite";
            this.TB_Quantite.Size = new System.Drawing.Size(181, 33);
            this.TB_Quantite.TabIndex = 18;
            this.TB_Quantite.Text = " ";
            this.TB_Quantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TB_Quantite.OnValueChanged += new System.EventHandler(this.TB_Quantite_OnValueChanged);
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
            this.TB_Reference.Location = new System.Drawing.Point(143, 20);
            this.TB_Reference.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Reference.Name = "TB_Reference";
            this.TB_Reference.Size = new System.Drawing.Size(181, 33);
            this.TB_Reference.TabIndex = 17;
            this.TB_Reference.Text = " ";
            this.TB_Reference.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(399, 131);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(84, 19);
            this.bunifuCustomLabel4.TabIndex = 16;
            this.bunifuCustomLabel4.Text = "Catégorie :";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(46, 79);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(44, 19);
            this.bunifuCustomLabel3.TabIndex = 15;
            this.bunifuCustomLabel3.Text = "Prix :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(399, 38);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(78, 19);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "Quantité :";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(46, 36);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(87, 19);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Référence :";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.quantite,
            this.prix,
            this.categorie,
            this.marque,
            this.description});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(71, 192);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bunifuCustomDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(638, 172);
            this.bunifuCustomDataGrid1.TabIndex = 26;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // reference
            // 
            this.reference.DataPropertyName = "reference";
            this.reference.HeaderText = "Référence";
            this.reference.Name = "reference";
            // 
            // quantite
            // 
            this.quantite.DataPropertyName = "quantite_stk";
            this.quantite.HeaderText = "Quantité";
            this.quantite.Name = "quantite";
            // 
            // prix
            // 
            this.prix.DataPropertyName = "prix";
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            // 
            // categorie
            // 
            this.categorie.DataPropertyName = "id_categorie";
            this.categorie.HeaderText = "Catégorie Id";
            this.categorie.Name = "categorie";
            // 
            // marque
            // 
            this.marque.DataPropertyName = "marque";
            this.marque.HeaderText = "Marque";
            this.marque.Name = "marque";
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // CB_categorie
            // 
            this.CB_categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_categorie.FormattingEnabled = true;
            this.CB_categorie.Location = new System.Drawing.Point(496, 131);
            this.CB_categorie.Name = "CB_categorie";
            this.CB_categorie.Size = new System.Drawing.Size(181, 23);
            this.CB_categorie.TabIndex = 20;
            this.CB_categorie.Text = "    Choisissez une catégorie";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(470, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(597, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // modifierproduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
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
            this.Name = "modifierproduit";
            this.Size = new System.Drawing.Size(794, 413);
            this.Load += new System.EventHandler(this.modifierproduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_description;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuMaterialTextbox TB_Marque;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuMaterialTextbox TB_Prix;
        private ns1.BunifuMaterialTextbox TB_Quantite;
        private ns1.BunifuMaterialTextbox TB_Reference;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.ComboBox CB_categorie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}