namespace ProjetGestionDeStock
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAgent));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Main = new System.Windows.Forms.Panel();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.Slider = new ns1.BunifuImageButton();
            this.btn2 = new ns1.BunifuFlatButton();
            this.btn1 = new ns1.BunifuFlatButton();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
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
            this.PanelMenu.Controls.Add(this.Slider);
            this.PanelMenu.Controls.Add(this.btn2);
            this.PanelMenu.Controls.Add(this.btn1);
            this.PanelMenu.Controls.Add(this.PB_logo);
            this.LogoAnimator.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 34);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(255, 520);
            this.PanelMenu.TabIndex = 0;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.LogoAnimator.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1067, 34);
            this.Header.TabIndex = 1;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.LogoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation1;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.LogoAnimator.SetDecoration(this.Main, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Main, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Main, BunifuAnimatorNS.DecorationType.None);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Main.Location = new System.Drawing.Point(255, 34);
            this.Main.Margin = new System.Windows.Forms.Padding(4);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(812, 520);
            this.Main.TabIndex = 2;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // PanelAnimator2
            // 
            this.PanelAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator2.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.PanelAnimator2.DefaultAnimation = animation3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Slider
            // 
            this.Slider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LogoAnimator.SetDecoration(this.Slider, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Slider, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Slider, BunifuAnimatorNS.DecorationType.None);
            this.Slider.Image = ((System.Drawing.Image)(resources.GetObject("Slider.Image")));
            this.Slider.ImageActive = null;
            this.Slider.Location = new System.Drawing.Point(209, 7);
            this.Slider.Margin = new System.Windows.Forms.Padding(4);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(27, 32);
            this.Slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slider.TabIndex = 1;
            this.Slider.TabStop = false;
            this.Slider.Zoom = 10;
            this.Slider.Click += new System.EventHandler(this.Slider_Click);
            // 
            // btn2
            // 
            this.btn2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.BorderRadius = 0;
            this.btn2.ButtonText = "confirmer livraison";
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.btn2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btn2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btn2, BunifuAnimatorNS.DecorationType.None);
            this.btn2.DisabledColor = System.Drawing.Color.Gray;
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Iconcolor = System.Drawing.Color.Transparent;
            this.btn2.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Borrow_Book_100px;
            this.btn2.Iconimage_right = null;
            this.btn2.Iconimage_right_Selected = null;
            this.btn2.Iconimage_Selected = null;
            this.btn2.IconMarginLeft = 0;
            this.btn2.IconMarginRight = 0;
            this.btn2.IconRightVisible = true;
            this.btn2.IconRightZoom = 0D;
            this.btn2.IconVisible = true;
            this.btn2.IconZoom = 40D;
            this.btn2.IsTab = true;
            this.btn2.Location = new System.Drawing.Point(-2, 196);
            this.btn2.Margin = new System.Windows.Forms.Padding(5);
            this.btn2.Name = "btn2";
            this.btn2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.btn2.selected = false;
            this.btn2.Size = new System.Drawing.Size(307, 59);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "confirmer livraison";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn2.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btn2.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn1
            // 
            this.btn1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.BorderRadius = 0;
            this.btn1.ButtonText = "produits a livrer";
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.btn1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btn1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btn1, BunifuAnimatorNS.DecorationType.None);
            this.btn1.DisabledColor = System.Drawing.Color.Gray;
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Iconcolor = System.Drawing.Color.Transparent;
            this.btn1.Iconimage = global::ProjetGestionDeStock.Properties.Resources.Book_100px;
            this.btn1.Iconimage_right = null;
            this.btn1.Iconimage_right_Selected = null;
            this.btn1.Iconimage_Selected = null;
            this.btn1.IconMarginLeft = 0;
            this.btn1.IconMarginRight = 0;
            this.btn1.IconRightVisible = true;
            this.btn1.IconRightZoom = 0D;
            this.btn1.IconVisible = true;
            this.btn1.IconZoom = 40D;
            this.btn1.IsTab = true;
            this.btn1.Location = new System.Drawing.Point(0, 140);
            this.btn1.Margin = new System.Windows.Forms.Padding(5);
            this.btn1.Name = "btn1";
            this.btn1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btn1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(90)))), ((int)(((byte)(49)))));
            this.btn1.selected = true;
            this.btn1.Size = new System.Drawing.Size(307, 59);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "produits a livrer";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn1.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btn1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // PB_logo
            // 
            this.PanelAnimator2.SetDecoration(this.PB_logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PB_logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PB_logo, BunifuAnimatorNS.DecorationType.None);
            this.PB_logo.Location = new System.Drawing.Point(4, 7);
            this.PB_logo.Margin = new System.Windows.Forms.Padding(4);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(249, 126);
            this.PB_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_logo.TabIndex = 0;
            this.PB_logo.TabStop = false;
            this.PB_logo.Visible = false;
            // 
            // MainAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.Header);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainAgent";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox PB_logo;
        private ns1.BunifuImageButton Slider;
        private ns1.BunifuFlatButton btn1;
        private ns1.BunifuFlatButton btn2;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private System.Windows.Forms.Panel Main;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator2;
        private ns1.BunifuDragControl bunifuDragControl1;
    }
}

