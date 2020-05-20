namespace Client.GUI.Controls
{
    partial class MessageFileControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageFileControl));
            this.FilePicture = new System.Windows.Forms.PictureBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.CancelButton = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.FilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // FilePicture
            // 
            this.FilePicture.Image = ((System.Drawing.Image)(resources.GetObject("FilePicture.Image")));
            this.FilePicture.Location = new System.Drawing.Point(11, 8);
            this.FilePicture.Name = "FilePicture";
            this.FilePicture.Size = new System.Drawing.Size(42, 42);
            this.FilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FilePicture.TabIndex = 8;
            this.FilePicture.TabStop = false;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FileNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNameLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.FileNameLabel.Location = new System.Drawing.Point(75, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(592, 29);
            this.FileNameLabel.TabIndex = 7;
            this.FileNameLabel.Text = "File name";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SizeLabel
            // 
            this.SizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SizeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.SizeLabel.Location = new System.Drawing.Point(76, 29);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(77, 27);
            this.SizeLabel.TabIndex = 9;
            this.SizeLabel.Text = "1.2 MB";
            this.SizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelButton
            // 
            this.CancelButton.ActiveImage = null;
            this.CancelButton.AllowAnimations = true;
            this.CancelButton.AllowBuffering = false;
            this.CancelButton.AllowZooming = true;
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CancelButton.ErrorImage")));
            this.CancelButton.FadeWhenInactive = false;
            this.CancelButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.ImageActive = null;
            this.CancelButton.ImageLocation = null;
            this.CancelButton.ImageMargin = 0;
            this.CancelButton.ImageSize = new System.Drawing.Size(32, 32);
            this.CancelButton.ImageZoomSize = new System.Drawing.Size(32, 32);
            this.CancelButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("CancelButton.InitialImage")));
            this.CancelButton.Location = new System.Drawing.Point(725, 11);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Rotation = 0;
            this.CancelButton.ShowActiveImage = true;
            this.CancelButton.ShowCursorChanges = true;
            this.CancelButton.ShowImageBorders = true;
            this.CancelButton.ShowSizeMarkers = false;
            this.CancelButton.Size = new System.Drawing.Size(32, 32);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.ToolTipText = "";
            this.CancelButton.WaitOnLoad = false;
            this.CancelButton.Zoom = 0;
            this.CancelButton.ZoomSpeed = 10;
            // 
            // MessageFileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.FilePicture);
            this.Controls.Add(this.FileNameLabel);
            this.Name = "MessageFileControl";
            this.Size = new System.Drawing.Size(780, 56);
            ((System.ComponentModel.ISupportInitialize)(this.FilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FilePicture;
        public System.Windows.Forms.Label FileNameLabel;
        public System.Windows.Forms.Label SizeLabel;
        private Bunifu.UI.WinForms.BunifuImageButton CancelButton;
    }
}
