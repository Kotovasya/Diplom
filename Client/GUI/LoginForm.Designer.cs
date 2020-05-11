namespace Client.GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SignInButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SingUpButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.SignInButton);
            this.bunifuGradientPanel1.Controls.Add(this.SingUpButton);
            this.bunifuGradientPanel1.Controls.Add(this.DescriptionLabel);
            this.bunifuGradientPanel1.Controls.Add(this.WelcomeLabel);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Azure;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(335, 492);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            // 
            // SignInButton
            // 
            this.SignInButton.ActiveBorderThickness = 2;
            this.SignInButton.ActiveCornerRadius = 20;
            this.SignInButton.ActiveFillColor = System.Drawing.Color.WhiteSmoke;
            this.SignInButton.ActiveForecolor = System.Drawing.Color.RoyalBlue;
            this.SignInButton.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.SignInButton.BackColor = System.Drawing.Color.Transparent;
            this.SignInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignInButton.BackgroundImage")));
            this.SignInButton.ButtonText = "SIGN IN";
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SignInButton.IdleBorderThickness = 2;
            this.SignInButton.IdleCornerRadius = 20;
            this.SignInButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.SignInButton.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.SignInButton.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.SignInButton.Location = new System.Drawing.Point(22, 369);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(129, 47);
            this.SignInButton.TabIndex = 3;
            this.SignInButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SingUpButton
            // 
            this.SingUpButton.ActiveBorderThickness = 2;
            this.SingUpButton.ActiveCornerRadius = 20;
            this.SingUpButton.ActiveFillColor = System.Drawing.Color.WhiteSmoke;
            this.SingUpButton.ActiveForecolor = System.Drawing.Color.RoyalBlue;
            this.SingUpButton.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.SingUpButton.BackColor = System.Drawing.Color.Transparent;
            this.SingUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SingUpButton.BackgroundImage")));
            this.SingUpButton.ButtonText = "SIGN UP";
            this.SingUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingUpButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingUpButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SingUpButton.IdleBorderThickness = 2;
            this.SingUpButton.IdleCornerRadius = 20;
            this.SingUpButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.SingUpButton.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.SingUpButton.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.SingUpButton.Location = new System.Drawing.Point(181, 369);
            this.SingUpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SingUpButton.Name = "SingUpButton";
            this.SingUpButton.Size = new System.Drawing.Size(129, 47);
            this.SingUpButton.TabIndex = 1;
            this.SingUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 227);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(332, 80);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Программное средство для передачи файлов и обменом сообщений";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.WelcomeLabel.Location = new System.Drawing.Point(3, 112);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(329, 115);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Добро пожаловать";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(335, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(576, 492);
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.LoginPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 492);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 SignInButton;
        private Bunifu.Framework.UI.BunifuThinButton2 SingUpButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel LoginPanel;
    }
}