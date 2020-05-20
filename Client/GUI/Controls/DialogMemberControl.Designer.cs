namespace Client.GUI.Controls
{
    partial class DialogMemberControl
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
            this.IsOnlineImage = new System.Windows.Forms.PictureBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IsOnlineImage)).BeginInit();
            this.SuspendLayout();
            // 
            // IsOnlineImage
            // 
            this.IsOnlineImage.Location = new System.Drawing.Point(17, 17);
            this.IsOnlineImage.Name = "IsOnlineImage";
            this.IsOnlineImage.Size = new System.Drawing.Size(32, 32);
            this.IsOnlineImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IsOnlineImage.TabIndex = 0;
            this.IsOnlineImage.TabStop = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserNameLabel.Location = new System.Drawing.Point(79, 24);
            this.UserNameLabel.MaximumSize = new System.Drawing.Size(635, 4096);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(77, 20);
            this.UserNameLabel.TabIndex = 6;
            this.UserNameLabel.Text = "User name";
            // 
            // DialogMemberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.IsOnlineImage);
            this.Name = "DialogMemberControl";
            this.Size = new System.Drawing.Size(429, 70);
            ((System.ComponentModel.ISupportInitialize)(this.IsOnlineImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IsOnlineImage;
        public System.Windows.Forms.Label UserNameLabel;
    }
}
