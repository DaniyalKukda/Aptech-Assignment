namespace inventaryManagementSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxEmail = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.buttonLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.textBoxPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuLabel3);
            this.panel1.Controls.Add(this.bunifuLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 33);
            this.panel1.TabIndex = 0;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(327, 3);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(13, 26);
            this.bunifuLabel3.TabIndex = 9;
            this.bunifuLabel3.Text = "_";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.Click += new System.EventHandler(this.bunifuLabel3_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(351, 4);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(17, 26);
            this.bunifuLabel2.TabIndex = 8;
            this.bunifuLabel2.Text = "X";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.Click += new System.EventHandler(this.bunifuLabel2_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Hand;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(54, 348);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(88, 15);
            this.bunifuLabel1.TabIndex = 6;
            this.bunifuLabel1.Text = "Forgot Password?";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventaryManagementSystem.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(43, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AcceptsReturn = false;
            this.textBoxEmail.AcceptsTab = false;
            this.textBoxEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxEmail.BackgroundImage")));
            this.textBoxEmail.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.textBoxEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.textBoxEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.textBoxEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.textBoxEmail.BorderRadius = 1;
            this.textBoxEmail.BorderThickness = 2;
            this.textBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxEmail.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.DefaultText = "";
            this.textBoxEmail.FillColor = System.Drawing.Color.White;
            this.textBoxEmail.HideSelection = true;
            this.textBoxEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxEmail.IconLeft")));
            this.textBoxEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.IconPadding = 0;
            this.textBoxEmail.IconRight = null;
            this.textBoxEmail.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.textBoxEmail.Location = new System.Drawing.Point(54, 191);
            this.textBoxEmail.MaxLength = 32767;
            this.textBoxEmail.MinimumSize = new System.Drawing.Size(100, 35);
            this.textBoxEmail.Modified = false;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.ReadOnly = false;
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.SelectionLength = 0;
            this.textBoxEmail.SelectionStart = 0;
            this.textBoxEmail.ShortcutsEnabled = true;
            this.textBoxEmail.Size = new System.Drawing.Size(272, 35);
            this.textBoxEmail.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxEmail.TextMarginLeft = 5;
            this.textBoxEmail.TextPlaceholder = "Enter Email Here";
            this.textBoxEmail.UseSystemPasswordChar = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.ActiveBorderThickness = 1;
            this.buttonLogin.ActiveCornerRadius = 20;
            this.buttonLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.buttonLogin.ActiveForecolor = System.Drawing.Color.White;
            this.buttonLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.buttonLogin.BackColor = System.Drawing.Color.Black;
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.ButtonText = "Login";
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonLogin.IdleBorderThickness = 1;
            this.buttonLogin.IdleCornerRadius = 20;
            this.buttonLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.buttonLogin.IdleForecolor = System.Drawing.Color.White;
            this.buttonLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.buttonLogin.Location = new System.Drawing.Point(54, 418);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(272, 50);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLogin.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel4.Location = new System.Drawing.Point(54, 170);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(71, 18);
            this.bunifuLabel4.TabIndex = 8;
            this.bunifuLabel4.Text = "Enter Email";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel5.Location = new System.Drawing.Point(54, 283);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(97, 18);
            this.bunifuLabel5.TabIndex = 9;
            this.bunifuLabel5.Text = "Enter Password";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AcceptsReturn = false;
            this.textBoxPassword.AcceptsTab = false;
            this.textBoxPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxPassword.BackgroundImage")));
            this.textBoxPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.textBoxPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.textBoxPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.textBoxPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.textBoxPassword.BorderRadius = 1;
            this.textBoxPassword.BorderThickness = 2;
            this.textBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxPassword.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.FillColor = System.Drawing.Color.White;
            this.textBoxPassword.HideSelection = true;
            this.textBoxPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxPassword.IconLeft")));
            this.textBoxPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.IconPadding = 0;
            this.textBoxPassword.IconRight = null;
            this.textBoxPassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPassword.Location = new System.Drawing.Point(54, 307);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.MinimumSize = new System.Drawing.Size(100, 35);
            this.textBoxPassword.Modified = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.ReadOnly = false;
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.ShortcutsEnabled = true;
            this.textBoxPassword.Size = new System.Drawing.Size(272, 35);
            this.textBoxPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPassword.TextMarginLeft = 5;
            this.textBoxPassword.TextPlaceholder = "Enter Password Here";
            this.textBoxPassword.UseSystemPasswordChar = false;
            this.textBoxPassword.TextChange += new System.EventHandler(this.bunifuTextBox3_TextChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(380, 514);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonLogin;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox textBoxEmail;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox textBoxPassword;
    }
}

