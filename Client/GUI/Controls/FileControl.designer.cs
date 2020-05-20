namespace Client.GUI.Controls
{
    partial class FileControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileControl));
            this.DateLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FilePicture = new System.Windows.Forms.PictureBox();
            this.ShowFolderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.ForeColor = System.Drawing.Color.DimGray;
            this.DateLabel.Location = new System.Drawing.Point(243, 55);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(161, 29);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "yesterday";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateLabel.MouseEnter += new System.EventHandler(this.FileControl_MouseEnter);
            this.DateLabel.MouseLeave += new System.EventHandler(this.FileControl_MouseLeave);
            this.DateLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileControl_MouseMove);
            // 
            // SizeLabel
            // 
            this.SizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SizeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.SizeLabel.Location = new System.Drawing.Point(85, 55);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(100, 29);
            this.SizeLabel.TabIndex = 4;
            this.SizeLabel.Text = "1.2 MB";
            this.SizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SizeLabel.MouseEnter += new System.EventHandler(this.FileControl_MouseEnter);
            this.SizeLabel.MouseLeave += new System.EventHandler(this.FileControl_MouseLeave);
            this.SizeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileControl_MouseMove);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FileNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNameLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.FileNameLabel.Location = new System.Drawing.Point(85, 12);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(483, 29);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "File name";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileNameLabel.MouseEnter += new System.EventHandler(this.FileControl_MouseEnter);
            this.FileNameLabel.MouseLeave += new System.EventHandler(this.FileControl_MouseLeave);
            this.FileNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileControl_MouseMove);
            // 
            // FilePicture
            // 
            this.FilePicture.Image = ((System.Drawing.Image)(resources.GetObject("FilePicture.Image")));
            this.FilePicture.Location = new System.Drawing.Point(11, 11);
            this.FilePicture.Name = "FilePicture";
            this.FilePicture.Size = new System.Drawing.Size(64, 64);
            this.FilePicture.TabIndex = 6;
            this.FilePicture.TabStop = false;
            this.FilePicture.MouseEnter += new System.EventHandler(this.FileControl_MouseEnter);
            this.FilePicture.MouseLeave += new System.EventHandler(this.FileControl_MouseLeave);
            this.FilePicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileControl_MouseMove);
            // 
            // ShowFolderLabel
            // 
            this.ShowFolderLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShowFolderLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowFolderLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.ShowFolderLabel.Location = new System.Drawing.Point(449, 55);
            this.ShowFolderLabel.Name = "ShowFolderLabel";
            this.ShowFolderLabel.Size = new System.Drawing.Size(148, 29);
            this.ShowFolderLabel.TabIndex = 7;
            this.ShowFolderLabel.Text = "Показать в папке";
            this.ShowFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowFolderLabel.Visible = false;
            this.ShowFolderLabel.Click += new System.EventHandler(this.ShowFolderLabel_Click);
            this.ShowFolderLabel.MouseEnter += new System.EventHandler(this.FileControl_MouseEnter);
            this.ShowFolderLabel.MouseLeave += new System.EventHandler(this.FileControl_MouseLeave);
            this.ShowFolderLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileControl_MouseMove);
            // 
            // FileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ShowFolderLabel);
            this.Controls.Add(this.FilePicture);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Name = "FileControl";
            this.Size = new System.Drawing.Size(600, 84);
            this.MouseEnter += new System.EventHandler(this.FileControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FileControl_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileControl_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.FilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label DateLabel;
        public System.Windows.Forms.Label SizeLabel;
        public System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.PictureBox FilePicture;
        public System.Windows.Forms.Label ShowFolderLabel;
    }
}
