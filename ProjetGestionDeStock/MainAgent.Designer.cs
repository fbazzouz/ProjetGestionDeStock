﻿namespace ProjetGestionDeStock
{
    partial class MainAgent
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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAgent));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.btn1 = new ns1.BunifuFlatButton();
            this.Slider = new ns1.BunifuImageButton();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.bunifuCircleProgressbar1 = new ns1.BunifuCircleProgressbar();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.btn2 = new ns1.BunifuFlatButton();
            this.exit = new ns1.BunifuFlatButton();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.Main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.Header.Controls.Add(this.bunifuImageButton1);
            this.LogoAnimator.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(884, 28);
            this.Header.TabIndex = 1;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.LogoAnimator.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation6;
            // 
            // PB_logo
            // 
            this.PanelAnimator2.SetDecoration(this.PB_logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PB_logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PB_logo, BunifuAnimatorNS.DecorationType.None);
            this.PB_logo.Location = new System.Drawing.Point(0, 3);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(224, 117);
            this.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_logo.TabIndex = 0;
            this.PB_logo.TabStop = false;
            this.PB_logo.Visible = false;
            // 
            // btn1
            // 
            this.btn1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.BorderRadius = 0;
            this.btn1.ButtonText = "Produits a livrer";
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.btn1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btn1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btn1, BunifuAnimatorNS.DecorationType.None);
            this.btn1.DisabledColor = System.Drawing.Color.Gray;
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Iconcolor = System.Drawing.Color.Transparent;
            this.btn1.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Add_Shopping_Cart_96px;
            this.btn1.Iconimage_right = null;
            this.btn1.Iconimage_right_Selected = null;
            this.btn1.Iconimage_Selected = null;
            this.btn1.IconMarginLeft = 0;
            this.btn1.IconMarginRight = 0;
            this.btn1.IconRightVisible = true;
            this.btn1.IconRightZoom = 0D;
            this.btn1.IconVisible = true;
            this.btn1.IconZoom = 70D;
            this.btn1.IsTab = true;
            this.btn1.Location = new System.Drawing.Point(2, 114);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.btn1.selected = true;
            this.btn1.Size = new System.Drawing.Size(230, 48);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Produits a livrer";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn1.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btn1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Slider
            // 
            this.Slider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LogoAnimator.SetDecoration(this.Slider, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Slider, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Slider, BunifuAnimatorNS.DecorationType.None);
            this.Slider.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Slider.ErrorImage")));
            this.Slider.Image = ((System.Drawing.Image)(resources.GetObject("Slider.Image")));
            this.Slider.ImageActive = null;
            this.Slider.InitialImage = global::ProjetGestionDeStock.Properties.Resources.menu_alt_512;
            this.Slider.Location = new System.Drawing.Point(181, 7);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(43, 39);
            this.Slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slider.TabIndex = 1;
            this.Slider.TabStop = false;
            this.Slider.Zoom = 10;
            this.Slider.Click += new System.EventHandler(this.Slider_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.PanelMenu.Controls.Add(this.exit);
            this.PanelMenu.Controls.Add(this.Slider);
            this.PanelMenu.Controls.Add(this.btn2);
            this.PanelMenu.Controls.Add(this.btn1);
            this.PanelMenu.Controls.Add(this.PB_logo);
            this.LogoAnimator.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 28);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(230, 550);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.Main.Controls.Add(this.bunifuCircleProgressbar1);
            this.Main.Controls.Add(this.bunifuCustomLabel6);
            this.Main.Controls.Add(this.panel1);
            this.Main.Controls.Add(this.bunifuCustomLabel1);
            this.Main.Controls.Add(this.bunifuCustomLabel2);
            this.LogoAnimator.SetDecoration(this.Main, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Main, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Main, BunifuAnimatorNS.DecorationType.None);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Main.Location = new System.Drawing.Point(230, 28);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(654, 550);
            this.Main.TabIndex = 4;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 100;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.LogoAnimator.SetDecoration(this.bunifuCircleProgressbar1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCircleProgressbar1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.bunifuCircleProgressbar1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(484, 177);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(163, 163);
            this.bunifuCircleProgressbar1.TabIndex = 45;
            this.bunifuCircleProgressbar1.Value = 50;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.PanelAnimator2.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(473, 145);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(149, 17);
            this.bunifuCustomLabel6.TabIndex = 44;
            this.bunifuCustomLabel6.Text = "taux de produit livrer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.LogoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(29, 177);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 180);
            this.panel1.TabIndex = 42;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.PanelAnimator2.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.SeaShell;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(128, 129);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(176, 26);
            this.bunifuCustomLabel5.TabIndex = 43;
            this.bunifuCustomLabel5.Text = "de leurs achats";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.PanelAnimator2.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.SeaShell;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(43, 86);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(333, 26);
            this.bunifuCustomLabel4.TabIndex = 42;
            this.bunifuCustomLabel4.Text = "avant la fin de deux semaines";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.PanelAnimator2.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.SeaShell;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(20, 41);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(379, 26);
            this.bunifuCustomLabel3.TabIndex = 41;
            this.bunifuCustomLabel3.Text = "tous les produits doivent etre livrer ";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.PanelAnimator2.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(112, 145);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(207, 17);
            this.bunifuCustomLabel1.TabIndex = 41;
            this.bunifuCustomLabel1.Text = "welcome to your application";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.PanelAnimator2.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(26, 18);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(48, 17);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "Agent";
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimator.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 1;
            animation5.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 2F;
            animation5.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation5;
            // 
            // PanelAnimator2
            // 
            this.PanelAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator2.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.PanelAnimator2.DefaultAnimation = animation4;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::ProjetGestionDeStock.Properties.Resources.Exit_50px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(835, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn2
            // 
            this.btn2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.BorderRadius = 0;
            this.btn2.ButtonText = "Confirmer livraison";
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.btn2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btn2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btn2, BunifuAnimatorNS.DecorationType.None);
            this.btn2.DisabledColor = System.Drawing.Color.Gray;
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Iconcolor = System.Drawing.Color.Transparent;
            this.btn2.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Bill_52px;
            this.btn2.Iconimage_right = null;
            this.btn2.Iconimage_right_Selected = null;
            this.btn2.Iconimage_Selected = null;
            this.btn2.IconMarginLeft = 0;
            this.btn2.IconMarginRight = 0;
            this.btn2.IconRightVisible = true;
            this.btn2.IconRightZoom = 0D;
            this.btn2.IconVisible = true;
            this.btn2.IconZoom = 70D;
            this.btn2.IsTab = true;
            this.btn2.Location = new System.Drawing.Point(6, 159);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.btn2.selected = false;
            this.btn2.Size = new System.Drawing.Size(230, 48);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Confirmer livraison";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn2.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btn2.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // exit
            // 
            this.exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.BorderRadius = 0;
            this.exit.ButtonText = "Log out";
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.exit, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.exit, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.exit, BunifuAnimatorNS.DecorationType.None);
            this.exit.DisabledColor = System.Drawing.Color.Gray;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.Iconcolor = System.Drawing.Color.Transparent;
            this.exit.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Bill_52px;
            this.exit.Iconimage_right = null;
            this.exit.Iconimage_right_Selected = null;
            this.exit.Iconimage_Selected = null;
            this.exit.IconMarginLeft = 0;
            this.exit.IconMarginRight = 0;
            this.exit.IconRightVisible = true;
            this.exit.IconRightZoom = 0D;
            this.exit.IconVisible = true;
            this.exit.IconZoom = 70D;
            this.exit.IsTab = true;
            this.exit.Location = new System.Drawing.Point(4, 210);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.exit.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.exit.selected = false;
            this.exit.Size = new System.Drawing.Size(230, 48);
            this.exit.TabIndex = 5;
            this.exit.Text = "Log out";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.exit.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MainAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(884, 578);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.Header);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainAgent";
            this.Text = "Form1";
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Header;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator2;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel Main;
        private ns1.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel PanelMenu;
        private ns1.BunifuImageButton Slider;
        private ns1.BunifuFlatButton btn1;
        private System.Windows.Forms.PictureBox PB_logo;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuFlatButton exit;
        private ns1.BunifuFlatButton btn2;
    }
}

