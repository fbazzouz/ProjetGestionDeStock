namespace ProjetGestionDeStock
{
    partial class MainCaissier
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
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation10 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCaissier));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.bunifuFlatButton6 = new ns1.BunifuFlatButton();
            this.Slider = new ns1.BunifuImageButton();
            this.bunifuFlatButton4 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.v = new System.Windows.Forms.Panel();
            this.ajouterproduit1 = new ProjetGestionDeStock.ajouterproduit();
            this.ajouterCommande1 = new ProjetGestionDeStock.ajouterCommande();
            this.lister1 = new ProjetGestionDeStock.lister();
            this.modifierproduit1 = new ProjetGestionDeStock.modifierproduit();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.v.SuspendLayout();
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
            this.PanelMenu.Controls.Add(this.bunifuFlatButton6);
            this.PanelMenu.Controls.Add(this.Slider);
            this.PanelMenu.Controls.Add(this.bunifuFlatButton4);
            this.PanelMenu.Controls.Add(this.bunifuFlatButton2);
            this.PanelMenu.Controls.Add(this.bunifuFlatButton1);
            this.LogoAnimator.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 35);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(221, 624);
            this.PanelMenu.TabIndex = 0;
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "     Lister les produits";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = global::ProjetGestionDeStock.Properties.Resources.List_50px;
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
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 344);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(230, 48);
            this.bunifuFlatButton6.TabIndex = 7;
            this.bunifuFlatButton6.Text = "     Lister les produits";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // Slider
            // 
            this.Slider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LogoAnimator.SetDecoration(this.Slider, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Slider, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Slider, BunifuAnimatorNS.DecorationType.None);
            this.Slider.Image = global::ProjetGestionDeStock.Properties.Resources.menu_alt_512;
            this.Slider.ImageActive = null;
            this.Slider.Location = new System.Drawing.Point(170, 6);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(38, 36);
            this.Slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slider.TabIndex = 1;
            this.Slider.TabStop = false;
            this.Slider.Zoom = 10;
            this.Slider.Click += new System.EventHandler(this.Slider_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "   Ajouter une commande";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Bill_52px;
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
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 297);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(230, 48);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.Text = "   Ajouter une commande";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1, 241);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 194);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(230, 48);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "     Ajouter un produit";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.Header.Controls.Add(this.pictureBox1);
            this.LogoAnimator.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1120, 35);
            this.Header.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.PanelAnimator2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1046, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.LogoAnimator.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation12;
            // 
            // v
            // 
            this.v.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.v.Controls.Add(this.ajouterCommande1);
            this.v.Controls.Add(this.lister1);
            this.v.Controls.Add(this.modifierproduit1);
            this.v.Controls.Add(this.ajouterproduit1);
            this.LogoAnimator.SetDecoration(this.v, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.v, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.v, BunifuAnimatorNS.DecorationType.None);
            this.v.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.v.Location = new System.Drawing.Point(221, 35);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(899, 624);
            this.v.TabIndex = 2;
            // 
            // ajouterproduit1
            // 
            this.ajouterproduit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.PanelAnimator2.SetDecoration(this.ajouterproduit1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.ajouterproduit1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ajouterproduit1, BunifuAnimatorNS.DecorationType.None);
            this.ajouterproduit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ajouterproduit1.ForeColor = System.Drawing.Color.White;
            this.ajouterproduit1.Location = new System.Drawing.Point(0, 0);
            this.ajouterproduit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ajouterproduit1.Name = "ajouterproduit1";
            this.ajouterproduit1.Size = new System.Drawing.Size(899, 624);
            this.ajouterproduit1.TabIndex = 1;
            // 
            // ajouterCommande1
            // 
            this.ajouterCommande1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.PanelAnimator2.SetDecoration(this.ajouterCommande1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.ajouterCommande1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ajouterCommande1, BunifuAnimatorNS.DecorationType.None);
            this.ajouterCommande1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ajouterCommande1.Location = new System.Drawing.Point(0, 0);
            this.ajouterCommande1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ajouterCommande1.Name = "ajouterCommande1";
            this.ajouterCommande1.Size = new System.Drawing.Size(899, 624);
            this.ajouterCommande1.TabIndex = 4;
            // 
            // lister1
            // 
            this.lister1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.PanelAnimator2.SetDecoration(this.lister1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.lister1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.lister1, BunifuAnimatorNS.DecorationType.None);
            this.lister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lister1.ForeColor = System.Drawing.Color.White;
            this.lister1.Location = new System.Drawing.Point(0, 0);
            this.lister1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lister1.Name = "lister1";
            this.lister1.Size = new System.Drawing.Size(899, 624);
            this.lister1.TabIndex = 3;
            // 
            // modifierproduit1
            // 
            this.modifierproduit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.PanelAnimator2.SetDecoration(this.modifierproduit1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.modifierproduit1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.modifierproduit1, BunifuAnimatorNS.DecorationType.None);
            this.modifierproduit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modifierproduit1.Location = new System.Drawing.Point(0, 0);
            this.modifierproduit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modifierproduit1.Name = "modifierproduit1";
            this.modifierproduit1.Size = new System.Drawing.Size(899, 624);
            this.modifierproduit1.TabIndex = 2;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimator.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 1;
            animation11.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 2F;
            animation11.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation11;
            // 
            // PanelAnimator2
            // 
            this.PanelAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator2.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 0F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 0;
            animation10.Padding = new System.Windows.Forms.Padding(0);
            animation10.RotateCoeff = 0F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 0F;
            animation10.TransparencyCoeff = 0F;
            this.PanelAnimator2.DefaultAnimation = animation10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MainCaissier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1120, 659);
            this.Controls.Add(this.v);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.Header);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainCaissier";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.v.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel Header;
        private ns1.BunifuImageButton Slider;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuFlatButton bunifuFlatButton4;
        private ns1.BunifuFlatButton bunifuFlatButton6;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator2;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel v;
        private ajouterproduit ajouterproduit1;
        private modifierproduit modifierproduit1;
        private lister lister1;
        private ajouterCommande ajouterCommande1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

