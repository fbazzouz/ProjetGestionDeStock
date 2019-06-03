namespace ProjetGestionDeStock
{
    partial class MainAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdmin));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.bunifuFlatButton7 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton5 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton6 = new ns1.BunifuFlatButton();
            this.Slider = new ns1.BunifuImageButton();
            this.bunifuFlatButton4 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton3 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Main = new System.Windows.Forms.Panel();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.dashboard1 = new ProjetGestionDeStock.Admin_UC.dashboard();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.PanelMenu.Controls.Add(this.bunifuFlatButton7);
            this.PanelMenu.Controls.Add(this.bunifuFlatButton5);
            this.PanelMenu.Controls.Add(this.bunifuFlatButton6);
            this.PanelMenu.Controls.Add(this.Slider);
            this.PanelMenu.Controls.Add(this.bunifuFlatButton4);
            this.PanelMenu.Controls.Add(this.bunifuFlatButton3);
            this.PanelMenu.Controls.Add(this.bunifuFlatButton2);
            this.PanelMenu.Controls.Add(this.bunifuFlatButton1);
            this.PanelMenu.Controls.Add(this.PB_logo);
            this.LogoAnimator.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 28);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(228, 610);
            this.PanelMenu.TabIndex = 0;
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "     Tableau de bord";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Combo_Chart_96px;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 70D;
            this.bunifuFlatButton7.IsTab = true;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(0, 120);
            this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton7.selected = true;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(230, 48);
            this.bunifuFlatButton7.TabIndex = 9;
            this.bunifuFlatButton7.Text = "     Tableau de bord";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "     Modifier Personnel";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Update_User_96px;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 70D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 393);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(230, 48);
            this.bunifuFlatButton5.TabIndex = 8;
            this.bunifuFlatButton5.Text = "     Modifier Personnel";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "     Ajouter Personnel";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Add_User_Female_100px;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 70D;
            this.bunifuFlatButton6.IsTab = true;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 348);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(230, 48);
            this.bunifuFlatButton6.TabIndex = 7;
            this.bunifuFlatButton6.Text = "     Ajouter Personnel";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Slider
            // 
            this.Slider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.LogoAnimator.SetDecoration(this.Slider, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Slider, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Slider, BunifuAnimatorNS.DecorationType.None);
            this.Slider.Image = global::ProjetGestionDeStock.Properties.Resources.menu_alt_512;
            this.Slider.ImageActive = null;
            this.Slider.Location = new System.Drawing.Point(181, 6);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(41, 38);
            this.Slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slider.TabIndex = 1;
            this.Slider.TabStop = false;
            this.Slider.Zoom = 10;
            this.Slider.Click += new System.EventHandler(this.Slider_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "     Modifier Une categorie";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Update_96px;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 70D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 305);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(230, 48);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.Text = "     Modifier Une categorie";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "     Ajouter Une categorie";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Small_Business_96px;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 70D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 260);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(230, 48);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "     Ajouter Une categorie";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     Modifier un produit";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Clear_Shopping_Cart_96px;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 216);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(230, 48);
            this.bunifuFlatButton2.TabIndex = 3;
            this.bunifuFlatButton2.Text = "     Modifier un produit";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Ajouter un produit";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Add_Shopping_Cart_96px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 169);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(230, 48);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "     Ajouter un produit";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PB_logo
            // 
            this.PanelAnimator2.SetDecoration(this.PB_logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PB_logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PB_logo, BunifuAnimatorNS.DecorationType.None);
            this.PB_logo.Location = new System.Drawing.Point(3, 6);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(187, 102);
            this.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_logo.TabIndex = 0;
            this.PB_logo.TabStop = false;
            this.PB_logo.Visible = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.LogoAnimator.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1145, 28);
            this.Header.TabIndex = 1;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlideAndRotate;
            this.LogoAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(50);
            animation3.RotateCoeff = 0.3F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation3;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Main.Controls.Add(this.dashboard1);
            this.LogoAnimator.SetDecoration(this.Main, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Main, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Main, BunifuAnimatorNS.DecorationType.None);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Main.Location = new System.Drawing.Point(228, 28);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(917, 610);
            this.Main.TabIndex = 2;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // PanelAnimator2
            // 
            this.PanelAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimator2.DefaultAnimation = animation1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.PanelAnimator2.SetDecoration(this.dashboard1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.dashboard1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.dashboard1, BunifuAnimatorNS.DecorationType.None);
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(917, 610);
            this.dashboard1.TabIndex = 0;
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1145, 638);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.Header);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainAdmin";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox PB_logo;
        private ns1.BunifuImageButton Slider;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuFlatButton bunifuFlatButton4;
        private ns1.BunifuFlatButton bunifuFlatButton3;
        private ns1.BunifuFlatButton bunifuFlatButton6;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private System.Windows.Forms.Panel Main;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator2;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuFlatButton bunifuFlatButton7;
        private ns1.BunifuFlatButton bunifuFlatButton5;
        private Admin_UC.dashboard dashboard1;
    }
}

