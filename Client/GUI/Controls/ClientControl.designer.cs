namespace Client.GUI.Controls
{
    partial class ClientControl
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
            this.LastOnlineLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.OnlinePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OnlinePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LastOnlineLabel
            // 
            this.LastOnlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.LastOnlineLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastOnlineLabel.ForeColor = System.Drawing.Color.DimGray;
            this.LastOnlineLabel.Location = new System.Drawing.Point(85, 55);
            this.LastOnlineLabel.Name = "LastOnlineLabel";
            this.LastOnlineLabel.Size = new System.Drawing.Size(199, 29);
            this.LastOnlineLabel.TabIndex = 8;
            this.LastOnlineLabel.Text = "yesterday";
            this.LastOnlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LastOnlineLabel.MouseEnter += new System.EventHandler(this.ClientControl_MouseEnter);
            this.LastOnlineLabel.MouseLeave += new System.EventHandler(this.ClientControl_MouseLeave);
            this.LastOnlineLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientControl_MouseMove);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.UserNameLabel.Location = new System.Drawing.Point(85, 12);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(483, 29);
            this.UserNameLabel.TabIndex = 7;
            this.UserNameLabel.Text = "User name";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserNameLabel.MouseEnter += new System.EventHandler(this.ClientControl_MouseEnter);
            this.UserNameLabel.MouseLeave += new System.EventHandler(this.ClientControl_MouseLeave);
            this.UserNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientControl_MouseMove);
            // 
            // OnlinePicture
            // 
            this.OnlinePicture.Image = global::Client.Properties.Resources.user_offline_60px;
            this.OnlinePicture.Location = new System.Drawing.Point(11, 11);
            this.OnlinePicture.Name = "OnlinePicture";
            this.OnlinePicture.Size = new System.Drawing.Size(64, 64);
            this.OnlinePicture.TabIndex = 9;
            this.OnlinePicture.TabStop = false;
            this.OnlinePicture.MouseEnter += new System.EventHandler(this.ClientControl_MouseEnter);
            this.OnlinePicture.MouseLeave += new System.EventHandler(this.ClientControl_MouseLeave);
            this.OnlinePicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientControl_MouseMove);
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.OnlinePicture);
            this.Controls.Add(this.LastOnlineLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(600, 84);
            this.MouseEnter += new System.EventHandler(this.ClientControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ClientControl_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientControl_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.OnlinePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox OnlinePicture;
        public System.Windows.Forms.Label LastOnlineLabel;
        public System.Windows.Forms.Label UserNameLabel;
    }
}
