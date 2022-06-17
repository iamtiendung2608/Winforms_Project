
namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainLayout = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.ava = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.billBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.roomBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.serviceBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.staffBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.guestBTN = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ava)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MainLayout
            // 
            this.MainLayout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.MainLayout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainLayout.BackgroundImage")));
            this.MainLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainLayout.BorderColor = System.Drawing.Color.Transparent;
            this.MainLayout.BorderRadius = 35;
            this.MainLayout.BorderThickness = 1;
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(146, 6);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.ShowBorders = true;
            this.MainLayout.Size = new System.Drawing.Size(1053, 712);
            this.MainLayout.TabIndex = 1;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.ava);
            this.bunifuPanel1.Controls.Add(this.billBTN);
            this.bunifuPanel1.Controls.Add(this.roomBTN);
            this.bunifuPanel1.Controls.Add(this.serviceBTN);
            this.bunifuPanel1.Controls.Add(this.staffBTN);
            this.bunifuPanel1.Controls.Add(this.guestBTN);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(6, 6);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(140, 712);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // ava
            // 
            this.ava.AllowFocused = false;
            this.ava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ava.AutoSizeHeight = true;
            this.ava.BorderRadius = 53;
            this.ava.Image = ((System.Drawing.Image)(resources.GetObject("ava.Image")));
            this.ava.IsCircle = true;
            this.ava.Location = new System.Drawing.Point(13, -1);
            this.ava.Name = "ava";
            this.ava.Size = new System.Drawing.Size(106, 106);
            this.ava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ava.TabIndex = 6;
            this.ava.TabStop = false;
            this.ava.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // billBTN
            // 
            this.billBTN.AllowAnimations = true;
            this.billBTN.AllowMouseEffects = true;
            this.billBTN.AllowToggling = false;
            this.billBTN.AnimationSpeed = 200;
            this.billBTN.AutoGenerateColors = false;
            this.billBTN.AutoRoundBorders = false;
            this.billBTN.AutoSizeLeftIcon = true;
            this.billBTN.AutoSizeRightIcon = true;
            this.billBTN.BackColor = System.Drawing.Color.Transparent;
            this.billBTN.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.billBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("billBTN.BackgroundImage")));
            this.billBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.billBTN.ButtonText = "Bill";
            this.billBTN.ButtonTextMarginLeft = 0;
            this.billBTN.ColorContrastOnClick = 45;
            this.billBTN.ColorContrastOnHover = 45;
            this.billBTN.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.billBTN.CustomizableEdges = borderEdges1;
            this.billBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.billBTN.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.billBTN.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.billBTN.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.billBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.billBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billBTN.ForeColor = System.Drawing.Color.White;
            this.billBTN.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billBTN.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.billBTN.IconLeftPadding = new System.Windows.Forms.Padding(35, 3, 3, 3);
            this.billBTN.IconMarginLeft = 11;
            this.billBTN.IconPadding = 10;
            this.billBTN.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.billBTN.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.billBTN.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.billBTN.IconSize = 25;
            this.billBTN.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.billBTN.IdleBorderRadius = 35;
            this.billBTN.IdleBorderThickness = 1;
            this.billBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.billBTN.IdleIconLeftImage = global::WindowsFormsApp2.Properties.Resources.bill_xxl;
            this.billBTN.IdleIconRightImage = null;
            this.billBTN.IndicateFocus = false;
            this.billBTN.Location = new System.Drawing.Point(-23, 580);
            this.billBTN.Name = "billBTN";
            this.billBTN.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.billBTN.OnDisabledState.BorderRadius = 35;
            this.billBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.billBTN.OnDisabledState.BorderThickness = 1;
            this.billBTN.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.billBTN.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.billBTN.OnDisabledState.IconLeftImage = null;
            this.billBTN.OnDisabledState.IconRightImage = null;
            this.billBTN.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.billBTN.onHoverState.BorderRadius = 35;
            this.billBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.billBTN.onHoverState.BorderThickness = 1;
            this.billBTN.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.billBTN.onHoverState.ForeColor = System.Drawing.Color.White;
            this.billBTN.onHoverState.IconLeftImage = null;
            this.billBTN.onHoverState.IconRightImage = null;
            this.billBTN.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.billBTN.OnIdleState.BorderRadius = 35;
            this.billBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.billBTN.OnIdleState.BorderThickness = 1;
            this.billBTN.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.billBTN.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.billBTN.OnIdleState.IconLeftImage = global::WindowsFormsApp2.Properties.Resources.bill_xxl;
            this.billBTN.OnIdleState.IconRightImage = null;
            this.billBTN.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.billBTN.OnPressedState.BorderRadius = 35;
            this.billBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.billBTN.OnPressedState.BorderThickness = 1;
            this.billBTN.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.billBTN.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.billBTN.OnPressedState.IconLeftImage = null;
            this.billBTN.OnPressedState.IconRightImage = null;
            this.billBTN.Size = new System.Drawing.Size(201, 39);
            this.billBTN.TabIndex = 5;
            this.billBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.billBTN.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.billBTN.TextMarginLeft = 0;
            this.billBTN.TextPadding = new System.Windows.Forms.Padding(0);
            this.billBTN.UseDefaultRadiusAndThickness = true;
            this.billBTN.Click += new System.EventHandler(this.billBTN_Click);
            // 
            // roomBTN
            // 
            this.roomBTN.AllowAnimations = true;
            this.roomBTN.AllowMouseEffects = true;
            this.roomBTN.AllowToggling = false;
            this.roomBTN.AnimationSpeed = 200;
            this.roomBTN.AutoGenerateColors = false;
            this.roomBTN.AutoRoundBorders = false;
            this.roomBTN.AutoSizeLeftIcon = true;
            this.roomBTN.AutoSizeRightIcon = true;
            this.roomBTN.BackColor = System.Drawing.Color.Transparent;
            this.roomBTN.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.roomBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roomBTN.BackgroundImage")));
            this.roomBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.roomBTN.ButtonText = "Room";
            this.roomBTN.ButtonTextMarginLeft = 0;
            this.roomBTN.ColorContrastOnClick = 45;
            this.roomBTN.ColorContrastOnHover = 45;
            this.roomBTN.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.roomBTN.CustomizableEdges = borderEdges2;
            this.roomBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.roomBTN.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.roomBTN.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.roomBTN.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.roomBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.roomBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBTN.ForeColor = System.Drawing.Color.White;
            this.roomBTN.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBTN.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.roomBTN.IconLeftPadding = new System.Windows.Forms.Padding(35, 3, 3, 3);
            this.roomBTN.IconMarginLeft = 11;
            this.roomBTN.IconPadding = 10;
            this.roomBTN.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roomBTN.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.roomBTN.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.roomBTN.IconSize = 25;
            this.roomBTN.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.roomBTN.IdleBorderRadius = 35;
            this.roomBTN.IdleBorderThickness = 1;
            this.roomBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.roomBTN.IdleIconLeftImage = global::WindowsFormsApp2.Properties.Resources.door_5_xxl;
            this.roomBTN.IdleIconRightImage = null;
            this.roomBTN.IndicateFocus = false;
            this.roomBTN.Location = new System.Drawing.Point(-23, 470);
            this.roomBTN.Name = "roomBTN";
            this.roomBTN.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.roomBTN.OnDisabledState.BorderRadius = 35;
            this.roomBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.roomBTN.OnDisabledState.BorderThickness = 1;
            this.roomBTN.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.roomBTN.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.roomBTN.OnDisabledState.IconLeftImage = null;
            this.roomBTN.OnDisabledState.IconRightImage = null;
            this.roomBTN.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.roomBTN.onHoverState.BorderRadius = 35;
            this.roomBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.roomBTN.onHoverState.BorderThickness = 1;
            this.roomBTN.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.roomBTN.onHoverState.ForeColor = System.Drawing.Color.White;
            this.roomBTN.onHoverState.IconLeftImage = null;
            this.roomBTN.onHoverState.IconRightImage = null;
            this.roomBTN.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.roomBTN.OnIdleState.BorderRadius = 35;
            this.roomBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.roomBTN.OnIdleState.BorderThickness = 1;
            this.roomBTN.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.roomBTN.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.roomBTN.OnIdleState.IconLeftImage = global::WindowsFormsApp2.Properties.Resources.door_5_xxl;
            this.roomBTN.OnIdleState.IconRightImage = null;
            this.roomBTN.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.roomBTN.OnPressedState.BorderRadius = 35;
            this.roomBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.roomBTN.OnPressedState.BorderThickness = 1;
            this.roomBTN.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.roomBTN.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.roomBTN.OnPressedState.IconLeftImage = null;
            this.roomBTN.OnPressedState.IconRightImage = null;
            this.roomBTN.Size = new System.Drawing.Size(201, 39);
            this.roomBTN.TabIndex = 4;
            this.roomBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roomBTN.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.roomBTN.TextMarginLeft = 0;
            this.roomBTN.TextPadding = new System.Windows.Forms.Padding(0);
            this.roomBTN.UseDefaultRadiusAndThickness = true;
            this.roomBTN.Click += new System.EventHandler(this.roomBTN_Click);
            // 
            // serviceBTN
            // 
            this.serviceBTN.AllowAnimations = true;
            this.serviceBTN.AllowMouseEffects = true;
            this.serviceBTN.AllowToggling = false;
            this.serviceBTN.AnimationSpeed = 200;
            this.serviceBTN.AutoGenerateColors = false;
            this.serviceBTN.AutoRoundBorders = false;
            this.serviceBTN.AutoSizeLeftIcon = true;
            this.serviceBTN.AutoSizeRightIcon = true;
            this.serviceBTN.BackColor = System.Drawing.Color.Transparent;
            this.serviceBTN.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.serviceBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("serviceBTN.BackgroundImage")));
            this.serviceBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.serviceBTN.ButtonText = "Service";
            this.serviceBTN.ButtonTextMarginLeft = 0;
            this.serviceBTN.ColorContrastOnClick = 45;
            this.serviceBTN.ColorContrastOnHover = 45;
            this.serviceBTN.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.serviceBTN.CustomizableEdges = borderEdges3;
            this.serviceBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.serviceBTN.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.serviceBTN.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.serviceBTN.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.serviceBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.serviceBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceBTN.ForeColor = System.Drawing.Color.White;
            this.serviceBTN.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceBTN.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.serviceBTN.IconLeftPadding = new System.Windows.Forms.Padding(35, 3, 3, 3);
            this.serviceBTN.IconMarginLeft = 11;
            this.serviceBTN.IconPadding = 10;
            this.serviceBTN.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.serviceBTN.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.serviceBTN.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.serviceBTN.IconSize = 25;
            this.serviceBTN.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.serviceBTN.IdleBorderRadius = 35;
            this.serviceBTN.IdleBorderThickness = 1;
            this.serviceBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.serviceBTN.IdleIconLeftImage = global::WindowsFormsApp2.Properties.Resources._24_hour_service_xxl;
            this.serviceBTN.IdleIconRightImage = null;
            this.serviceBTN.IndicateFocus = false;
            this.serviceBTN.Location = new System.Drawing.Point(-23, 360);
            this.serviceBTN.Name = "serviceBTN";
            this.serviceBTN.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.serviceBTN.OnDisabledState.BorderRadius = 35;
            this.serviceBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.serviceBTN.OnDisabledState.BorderThickness = 1;
            this.serviceBTN.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.serviceBTN.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.serviceBTN.OnDisabledState.IconLeftImage = null;
            this.serviceBTN.OnDisabledState.IconRightImage = null;
            this.serviceBTN.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.serviceBTN.onHoverState.BorderRadius = 35;
            this.serviceBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.serviceBTN.onHoverState.BorderThickness = 1;
            this.serviceBTN.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.serviceBTN.onHoverState.ForeColor = System.Drawing.Color.White;
            this.serviceBTN.onHoverState.IconLeftImage = null;
            this.serviceBTN.onHoverState.IconRightImage = null;
            this.serviceBTN.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.serviceBTN.OnIdleState.BorderRadius = 35;
            this.serviceBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.serviceBTN.OnIdleState.BorderThickness = 1;
            this.serviceBTN.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.serviceBTN.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.serviceBTN.OnIdleState.IconLeftImage = global::WindowsFormsApp2.Properties.Resources._24_hour_service_xxl;
            this.serviceBTN.OnIdleState.IconRightImage = null;
            this.serviceBTN.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.serviceBTN.OnPressedState.BorderRadius = 35;
            this.serviceBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.serviceBTN.OnPressedState.BorderThickness = 1;
            this.serviceBTN.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.serviceBTN.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.serviceBTN.OnPressedState.IconLeftImage = null;
            this.serviceBTN.OnPressedState.IconRightImage = null;
            this.serviceBTN.Size = new System.Drawing.Size(201, 39);
            this.serviceBTN.TabIndex = 3;
            this.serviceBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.serviceBTN.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.serviceBTN.TextMarginLeft = 0;
            this.serviceBTN.TextPadding = new System.Windows.Forms.Padding(0);
            this.serviceBTN.UseDefaultRadiusAndThickness = true;
            this.serviceBTN.Click += new System.EventHandler(this.serviceBTN_Click_1);
            // 
            // staffBTN
            // 
            this.staffBTN.AllowAnimations = true;
            this.staffBTN.AllowMouseEffects = true;
            this.staffBTN.AllowToggling = false;
            this.staffBTN.AnimationSpeed = 200;
            this.staffBTN.AutoGenerateColors = false;
            this.staffBTN.AutoRoundBorders = false;
            this.staffBTN.AutoSizeLeftIcon = true;
            this.staffBTN.AutoSizeRightIcon = true;
            this.staffBTN.BackColor = System.Drawing.Color.Transparent;
            this.staffBTN.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.staffBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("staffBTN.BackgroundImage")));
            this.staffBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.staffBTN.ButtonText = "Staff";
            this.staffBTN.ButtonTextMarginLeft = 0;
            this.staffBTN.ColorContrastOnClick = 45;
            this.staffBTN.ColorContrastOnHover = 45;
            this.staffBTN.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.staffBTN.CustomizableEdges = borderEdges4;
            this.staffBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.staffBTN.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.staffBTN.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.staffBTN.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.staffBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.staffBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBTN.ForeColor = System.Drawing.Color.White;
            this.staffBTN.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBTN.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.staffBTN.IconLeftPadding = new System.Windows.Forms.Padding(35, 3, 3, 3);
            this.staffBTN.IconMarginLeft = 11;
            this.staffBTN.IconPadding = 10;
            this.staffBTN.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.staffBTN.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.staffBTN.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.staffBTN.IconSize = 25;
            this.staffBTN.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.staffBTN.IdleBorderRadius = 35;
            this.staffBTN.IdleBorderThickness = 1;
            this.staffBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.staffBTN.IdleIconLeftImage = global::WindowsFormsApp2.Properties.Resources.workers_xxl;
            this.staffBTN.IdleIconRightImage = null;
            this.staffBTN.IndicateFocus = false;
            this.staffBTN.Location = new System.Drawing.Point(-23, 250);
            this.staffBTN.Name = "staffBTN";
            this.staffBTN.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.staffBTN.OnDisabledState.BorderRadius = 35;
            this.staffBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.staffBTN.OnDisabledState.BorderThickness = 1;
            this.staffBTN.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.staffBTN.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.staffBTN.OnDisabledState.IconLeftImage = null;
            this.staffBTN.OnDisabledState.IconRightImage = null;
            this.staffBTN.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.staffBTN.onHoverState.BorderRadius = 35;
            this.staffBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.staffBTN.onHoverState.BorderThickness = 1;
            this.staffBTN.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.staffBTN.onHoverState.ForeColor = System.Drawing.Color.White;
            this.staffBTN.onHoverState.IconLeftImage = null;
            this.staffBTN.onHoverState.IconRightImage = null;
            this.staffBTN.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.staffBTN.OnIdleState.BorderRadius = 35;
            this.staffBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.staffBTN.OnIdleState.BorderThickness = 1;
            this.staffBTN.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.staffBTN.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.staffBTN.OnIdleState.IconLeftImage = global::WindowsFormsApp2.Properties.Resources.workers_xxl;
            this.staffBTN.OnIdleState.IconRightImage = null;
            this.staffBTN.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.staffBTN.OnPressedState.BorderRadius = 35;
            this.staffBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.staffBTN.OnPressedState.BorderThickness = 1;
            this.staffBTN.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.staffBTN.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.staffBTN.OnPressedState.IconLeftImage = null;
            this.staffBTN.OnPressedState.IconRightImage = null;
            this.staffBTN.Size = new System.Drawing.Size(201, 39);
            this.staffBTN.TabIndex = 2;
            this.staffBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.staffBTN.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.staffBTN.TextMarginLeft = 0;
            this.staffBTN.TextPadding = new System.Windows.Forms.Padding(0);
            this.staffBTN.UseDefaultRadiusAndThickness = true;
            this.staffBTN.Click += new System.EventHandler(this.staffBTN_Click);
            // 
            // guestBTN
            // 
            this.guestBTN.AllowAnimations = true;
            this.guestBTN.AllowMouseEffects = true;
            this.guestBTN.AllowToggling = false;
            this.guestBTN.AnimationSpeed = 200;
            this.guestBTN.AutoGenerateColors = false;
            this.guestBTN.AutoRoundBorders = false;
            this.guestBTN.AutoSizeLeftIcon = true;
            this.guestBTN.AutoSizeRightIcon = true;
            this.guestBTN.BackColor = System.Drawing.Color.Transparent;
            this.guestBTN.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.guestBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guestBTN.BackgroundImage")));
            this.guestBTN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.guestBTN.ButtonText = "Guest";
            this.guestBTN.ButtonTextMarginLeft = 0;
            this.guestBTN.ColorContrastOnClick = 45;
            this.guestBTN.ColorContrastOnHover = 45;
            this.guestBTN.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.guestBTN.CustomizableEdges = borderEdges5;
            this.guestBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guestBTN.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.guestBTN.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guestBTN.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.guestBTN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.guestBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestBTN.ForeColor = System.Drawing.Color.White;
            this.guestBTN.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guestBTN.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.guestBTN.IconLeftPadding = new System.Windows.Forms.Padding(35, 3, 3, 3);
            this.guestBTN.IconMarginLeft = 11;
            this.guestBTN.IconPadding = 10;
            this.guestBTN.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guestBTN.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.guestBTN.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.guestBTN.IconSize = 25;
            this.guestBTN.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.guestBTN.IdleBorderRadius = 35;
            this.guestBTN.IdleBorderThickness = 1;
            this.guestBTN.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.guestBTN.IdleIconLeftImage = global::WindowsFormsApp2.Properties.Resources.user_xxl;
            this.guestBTN.IdleIconRightImage = null;
            this.guestBTN.IndicateFocus = false;
            this.guestBTN.Location = new System.Drawing.Point(-23, 140);
            this.guestBTN.Name = "guestBTN";
            this.guestBTN.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.guestBTN.OnDisabledState.BorderRadius = 35;
            this.guestBTN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.guestBTN.OnDisabledState.BorderThickness = 1;
            this.guestBTN.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.guestBTN.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.guestBTN.OnDisabledState.IconLeftImage = null;
            this.guestBTN.OnDisabledState.IconRightImage = null;
            this.guestBTN.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.guestBTN.onHoverState.BorderRadius = 35;
            this.guestBTN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.guestBTN.onHoverState.BorderThickness = 1;
            this.guestBTN.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.guestBTN.onHoverState.ForeColor = System.Drawing.Color.White;
            this.guestBTN.onHoverState.IconLeftImage = null;
            this.guestBTN.onHoverState.IconRightImage = null;
            this.guestBTN.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.guestBTN.OnIdleState.BorderRadius = 35;
            this.guestBTN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.guestBTN.OnIdleState.BorderThickness = 1;
            this.guestBTN.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.guestBTN.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.guestBTN.OnIdleState.IconLeftImage = global::WindowsFormsApp2.Properties.Resources.user_xxl;
            this.guestBTN.OnIdleState.IconRightImage = null;
            this.guestBTN.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.guestBTN.OnPressedState.BorderRadius = 35;
            this.guestBTN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.guestBTN.OnPressedState.BorderThickness = 1;
            this.guestBTN.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.guestBTN.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.guestBTN.OnPressedState.IconLeftImage = null;
            this.guestBTN.OnPressedState.IconRightImage = null;
            this.guestBTN.Size = new System.Drawing.Size(201, 39);
            this.guestBTN.TabIndex = 1;
            this.guestBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guestBTN.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.guestBTN.TextMarginLeft = 0;
            this.guestBTN.TextPadding = new System.Windows.Forms.Padding(0);
            this.guestBTN.UseDefaultRadiusAndThickness = true;
            this.guestBTN.Click += new System.EventHandler(this.guestBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1205, 724);
            this.Controls.Add(this.MainLayout);
            this.Controls.Add(this.bunifuPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ava)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel MainLayout;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 billBTN;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 roomBTN;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 serviceBTN;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 staffBTN;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 guestBTN;
        private Bunifu.UI.WinForms.BunifuPictureBox ava;
    }
}

