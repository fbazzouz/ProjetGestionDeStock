namespace ProjetGestionDeStock.Admin_UC
{
    partial class modifierPerso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifierPerso));
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.DG_personnel = new ns1.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.TB_nom = new ns1.BunifuMaterialTextbox();
            this.TB_prenom = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.TB_cin = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.TB_login = new ns1.BunifuMaterialTextbox();
            this.LB_login = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.TB_password = new ns1.BunifuMaterialTextbox();
            this.TB_email = new ns1.BunifuMaterialTextbox();
            this.DD_role = new ns1.BunifuDropdown();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.BTN_Modifier = new ns1.BunifuThinButton2();
            this.Btn_Supprimer = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DG_personnel)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(36, 21);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(152, 17);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "MODIFIER PERSONNEL";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.DG_personnel;
            // 
            // DG_personnel
            // 
            this.DG_personnel.AllowUserToAddRows = false;
            this.DG_personnel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DG_personnel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_personnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_personnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_personnel.BackgroundColor = System.Drawing.Color.White;
            this.DG_personnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_personnel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_personnel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_personnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_personnel.ColumnHeadersHeight = 50;
            this.DG_personnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.login,
            this.mdp,
            this.role});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_personnel.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_personnel.DoubleBuffered = true;
            this.DG_personnel.EnableHeadersVisualStyles = false;
            this.DG_personnel.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.DG_personnel.HeaderForeColor = System.Drawing.Color.White;
            this.DG_personnel.Location = new System.Drawing.Point(27, 377);
            this.DG_personnel.Margin = new System.Windows.Forms.Padding(4);
            this.DG_personnel.Name = "DG_personnel";
            this.DG_personnel.ReadOnly = true;
            this.DG_personnel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG_personnel.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DG_personnel.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_personnel.RowTemplate.DividerHeight = 1;
            this.DG_personnel.RowTemplate.Height = 40;
            this.DG_personnel.RowTemplate.ReadOnly = true;
            this.DG_personnel.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_personnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_personnel.Size = new System.Drawing.Size(855, 207);
            this.DG_personnel.TabIndex = 33;
            this.DG_personnel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_personnel_CellClick);
            this.DG_personnel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_personnel_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CIN";
            this.dataGridViewTextBoxColumn5.HeaderText = "CIN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // mdp
            // 
            this.mdp.DataPropertyName = "mdp";
            this.mdp.HeaderText = "Mot de passe";
            this.mdp.Name = "mdp";
            this.mdp.ReadOnly = true;
            // 
            // role
            // 
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(34, 356);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(140, 17);
            this.bunifuCustomLabel3.TabIndex = 34;
            this.bunifuCustomLabel3.Text = "Liste des Personnels";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(119)))), ((int)(((byte)(128)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(49, 90);
            this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(108, 17);
            this.bunifuCustomLabel7.TabIndex = 22;
            this.bunifuCustomLabel7.Text = "Nom Complete :";
            // 
            // TB_nom
            // 
            this.TB_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_nom.Enabled = false;
            this.TB_nom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_nom.ForeColor = System.Drawing.Color.White;
            this.TB_nom.HintForeColor = System.Drawing.Color.Silver;
            this.TB_nom.HintText = "";
            this.TB_nom.isPassword = false;
            this.TB_nom.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.TB_nom.LineIdleColor = System.Drawing.Color.Silver;
            this.TB_nom.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.TB_nom.LineThickness = 3;
            this.TB_nom.Location = new System.Drawing.Point(51, 108);
            this.TB_nom.Margin = new System.Windows.Forms.Padding(6);
            this.TB_nom.Name = "TB_nom";
            this.TB_nom.Size = new System.Drawing.Size(366, 29);
            this.TB_nom.TabIndex = 35;
            this.TB_nom.Text = " ";
            this.TB_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TB_prenom
            // 
            this.TB_prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_prenom.Enabled = false;
            this.TB_prenom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_prenom.ForeColor = System.Drawing.Color.White;
            this.TB_prenom.HintForeColor = System.Drawing.Color.Silver;
            this.TB_prenom.HintText = "";
            this.TB_prenom.isPassword = false;
            this.TB_prenom.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.TB_prenom.LineIdleColor = System.Drawing.Color.Silver;
            this.TB_prenom.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.TB_prenom.LineThickness = 3;
            this.TB_prenom.Location = new System.Drawing.Point(495, 108);
            this.TB_prenom.Margin = new System.Windows.Forms.Padding(6);
            this.TB_prenom.Name = "TB_prenom";
            this.TB_prenom.Size = new System.Drawing.Size(366, 29);
            this.TB_prenom.TabIndex = 36;
            this.TB_prenom.Text = " ";
            this.TB_prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(119)))), ((int)(((byte)(128)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(491, 152);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(50, 17);
            this.bunifuCustomLabel1.TabIndex = 38;
            this.bunifuCustomLabel1.Text = "Email :";
            // 
            // TB_cin
            // 
            this.TB_cin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_cin.Enabled = false;
            this.TB_cin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_cin.ForeColor = System.Drawing.Color.White;
            this.TB_cin.HintForeColor = System.Drawing.Color.Silver;
            this.TB_cin.HintText = "";
            this.TB_cin.isPassword = false;
            this.TB_cin.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.TB_cin.LineIdleColor = System.Drawing.Color.Silver;
            this.TB_cin.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.TB_cin.LineThickness = 3;
            this.TB_cin.Location = new System.Drawing.Point(54, 170);
            this.TB_cin.Margin = new System.Windows.Forms.Padding(6);
            this.TB_cin.Name = "TB_cin";
            this.TB_cin.Size = new System.Drawing.Size(366, 29);
            this.TB_cin.TabIndex = 40;
            this.TB_cin.Text = " ";
            this.TB_cin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(119)))), ((int)(((byte)(128)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(53, 152);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(38, 17);
            this.bunifuCustomLabel4.TabIndex = 39;
            this.bunifuCustomLabel4.Text = "CIN :";
            // 
            // TB_login
            // 
            this.TB_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_login.Enabled = false;
            this.TB_login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_login.ForeColor = System.Drawing.Color.White;
            this.TB_login.HintForeColor = System.Drawing.Color.Silver;
            this.TB_login.HintText = "";
            this.TB_login.isPassword = false;
            this.TB_login.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.TB_login.LineIdleColor = System.Drawing.Color.Silver;
            this.TB_login.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.TB_login.LineThickness = 3;
            this.TB_login.Location = new System.Drawing.Point(51, 240);
            this.TB_login.Margin = new System.Windows.Forms.Padding(6);
            this.TB_login.Name = "TB_login";
            this.TB_login.Size = new System.Drawing.Size(366, 29);
            this.TB_login.TabIndex = 42;
            this.TB_login.Text = " ";
            this.TB_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LB_login
            // 
            this.LB_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_login.AutoSize = true;
            this.LB_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LB_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(119)))), ((int)(((byte)(128)))));
            this.LB_login.Location = new System.Drawing.Point(49, 222);
            this.LB_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_login.Name = "LB_login";
            this.LB_login.Size = new System.Drawing.Size(51, 17);
            this.LB_login.TabIndex = 43;
            this.LB_login.Text = "Login :";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(119)))), ((int)(((byte)(128)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(487, 222);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(77, 17);
            this.bunifuCustomLabel6.TabIndex = 42;
            this.bunifuCustomLabel6.Text = "Password :";
            // 
            // TB_password
            // 
            this.TB_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_password.Enabled = false;
            this.TB_password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_password.ForeColor = System.Drawing.Color.White;
            this.TB_password.HintForeColor = System.Drawing.Color.Silver;
            this.TB_password.HintText = "";
            this.TB_password.isPassword = true;
            this.TB_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.TB_password.LineIdleColor = System.Drawing.Color.Silver;
            this.TB_password.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.TB_password.LineThickness = 3;
            this.TB_password.Location = new System.Drawing.Point(490, 245);
            this.TB_password.Margin = new System.Windows.Forms.Padding(6);
            this.TB_password.Name = "TB_password";
            this.TB_password.Size = new System.Drawing.Size(369, 29);
            this.TB_password.TabIndex = 43;
            this.TB_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TB_email
            // 
            this.TB_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_email.Enabled = false;
            this.TB_email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_email.ForeColor = System.Drawing.Color.White;
            this.TB_email.HintForeColor = System.Drawing.Color.Silver;
            this.TB_email.HintText = "";
            this.TB_email.isPassword = false;
            this.TB_email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.TB_email.LineIdleColor = System.Drawing.Color.Silver;
            this.TB_email.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.TB_email.LineThickness = 3;
            this.TB_email.Location = new System.Drawing.Point(495, 170);
            this.TB_email.Margin = new System.Windows.Forms.Padding(6);
            this.TB_email.Name = "TB_email";
            this.TB_email.Size = new System.Drawing.Size(366, 29);
            this.TB_email.TabIndex = 41;
            this.TB_email.Text = " ";
            this.TB_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DD_role
            // 
            this.DD_role.BackColor = System.Drawing.Color.Transparent;
            this.DD_role.BorderRadius = 3;
            this.DD_role.Enabled = false;
            this.DD_role.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DD_role.ForeColor = System.Drawing.Color.White;
            this.DD_role.Items = new string[] {
        "Admin",
        "Agent",
        "Caissier"};
            this.DD_role.Location = new System.Drawing.Point(58, 308);
            this.DD_role.Margin = new System.Windows.Forms.Padding(6);
            this.DD_role.Name = "DD_role";
            this.DD_role.NomalColor = System.Drawing.Color.Silver;
            this.DD_role.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.DD_role.selectedIndex = -1;
            this.DD_role.Size = new System.Drawing.Size(366, 38);
            this.DD_role.TabIndex = 44;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(119)))), ((int)(((byte)(128)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(54, 279);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(45, 17);
            this.bunifuCustomLabel5.TabIndex = 47;
            this.bunifuCustomLabel5.Text = "Role :";
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.ActiveBorderThickness = 1;
            this.BTN_Modifier.ActiveCornerRadius = 20;
            this.BTN_Modifier.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BTN_Modifier.ActiveForecolor = System.Drawing.Color.White;
            this.BTN_Modifier.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.BTN_Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.BTN_Modifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Modifier.BackgroundImage")));
            this.BTN_Modifier.ButtonText = "Modifier";
            this.BTN_Modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Modifier.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Modifier.ForeColor = System.Drawing.Color.White;
            this.BTN_Modifier.IdleBorderThickness = 1;
            this.BTN_Modifier.IdleCornerRadius = 20;
            this.BTN_Modifier.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.BTN_Modifier.IdleForecolor = System.Drawing.Color.White;
            this.BTN_Modifier.IdleLineColor = System.Drawing.Color.White;
            this.BTN_Modifier.Location = new System.Drawing.Point(460, 297);
            this.BTN_Modifier.Margin = new System.Windows.Forms.Padding(6);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(199, 52);
            this.BTN_Modifier.TabIndex = 45;
            this.BTN_Modifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_AjouterCategorie_Click);
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.ActiveBorderThickness = 1;
            this.Btn_Supprimer.ActiveCornerRadius = 20;
            this.Btn_Supprimer.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.Btn_Supprimer.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Supprimer.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.Btn_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Btn_Supprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Supprimer.BackgroundImage")));
            this.Btn_Supprimer.ButtonText = "Supprimer";
            this.Btn_Supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Supprimer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Supprimer.ForeColor = System.Drawing.Color.White;
            this.Btn_Supprimer.IdleBorderThickness = 1;
            this.Btn_Supprimer.IdleCornerRadius = 20;
            this.Btn_Supprimer.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.Btn_Supprimer.IdleForecolor = System.Drawing.Color.White;
            this.Btn_Supprimer.IdleLineColor = System.Drawing.Color.White;
            this.Btn_Supprimer.Location = new System.Drawing.Point(671, 297);
            this.Btn_Supprimer.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(199, 52);
            this.Btn_Supprimer.TabIndex = 48;
            this.Btn_Supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // modifierPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.Btn_Supprimer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.DD_role);
            this.Controls.Add(this.TB_email);
            this.Controls.Add(this.TB_login);
            this.Controls.Add(this.LB_login);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_cin);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.TB_prenom);
            this.Controls.Add(this.TB_nom);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.DG_personnel);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "modifierPerso";
            this.Size = new System.Drawing.Size(917, 610);
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_personnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuCustomDataGrid DG_personnel;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private ns1.BunifuMaterialTextbox TB_nom;
        private ns1.BunifuMaterialTextbox TB_cin;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuMaterialTextbox TB_prenom;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuDropdown DD_role;
        private ns1.BunifuMaterialTextbox TB_email;
        private ns1.BunifuMaterialTextbox TB_login;
        private ns1.BunifuCustomLabel LB_login;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuMaterialTextbox TB_password;
        private ns1.BunifuThinButton2 BTN_Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdp;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private ns1.BunifuThinButton2 Btn_Supprimer;
    }
}
