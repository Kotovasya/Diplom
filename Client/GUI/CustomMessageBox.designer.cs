namespace Client.GUI
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.Image = new System.Windows.Forms.PictureBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.OkButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(338, 31);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(64, 64);
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            // 
            // TextLabel
            // 
            this.TextLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.ForeColor = System.Drawing.Color.Gray;
            this.TextLabel.Location = new System.Drawing.Point(35, 31);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(282, 64);
            this.TextLabel.TabIndex = 12;
            this.TextLabel.Text = "Exception";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OkButton
            // 
            this.OkButton.AllowToggling = false;
            this.OkButton.AnimationSpeed = 200;
            this.OkButton.AutoGenerateColors = false;
            this.OkButton.BackColor = System.Drawing.Color.Transparent;
            this.OkButton.BackColor1 = System.Drawing.Color.White;
            this.OkButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OkButton.BackgroundImage")));
            this.OkButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.OkButton.ButtonText = "ОК";
            this.OkButton.ButtonTextMarginLeft = 0;
            this.OkButton.ColorContrastOnClick = 45;
            this.OkButton.ColorContrastOnHover = 45;
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.OkButton.CustomizableEdges = borderEdges1;
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OkButton.DisabledBorderColor = System.Drawing.Color.Empty;
            this.OkButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.OkButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.OkButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.OkButton.ForeColor = System.Drawing.Color.Gray;
            this.OkButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.IconMarginLeft = 11;
            this.OkButton.IconPadding = 10;
            this.OkButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.OkButton.IdleBorderRadius = 3;
            this.OkButton.IdleBorderThickness = 1;
            this.OkButton.IdleFillColor = System.Drawing.Color.White;
            this.OkButton.IdleIconLeftImage = null;
            this.OkButton.IdleIconRightImage = null;
            this.OkButton.IndicateFocus = false;
            this.OkButton.Location = new System.Drawing.Point(141, 98);
            this.OkButton.Name = "OkButton";
            stateProperties1.BorderColor = System.Drawing.Color.DarkBlue;
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.DarkBlue;
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.OkButton.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.CornflowerBlue;
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.CornflowerBlue;
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.OkButton.OnPressedState = stateProperties2;
            this.OkButton.Size = new System.Drawing.Size(68, 32);
            this.OkButton.TabIndex = 13;
            this.OkButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OkButton.TextMarginLeft = 0;
            this.OkButton.UseDefaultRadiusAndThickness = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 130);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.Text = "CustomMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Label TextLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton OkButton;
    }
}