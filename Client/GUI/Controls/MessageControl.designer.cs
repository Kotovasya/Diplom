namespace Client.GUI.Controls
{
    partial class MessageControl
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
            this.SenderNameLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.IsReadPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IsReadPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SenderNameLabel
            // 
            this.SenderNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.SenderNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.SenderNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.SenderNameLabel.Location = new System.Drawing.Point(90, 0);
            this.SenderNameLabel.Name = "SenderNameLabel";
            this.SenderNameLabel.Size = new System.Drawing.Size(483, 29);
            this.SenderNameLabel.TabIndex = 4;
            this.SenderNameLabel.Text = "Sender name";
            this.SenderNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.BackColor = System.Drawing.Color.Transparent;
            this.TextLabel.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextLabel.Location = new System.Drawing.Point(94, 29);
            this.TextLabel.MaximumSize = new System.Drawing.Size(635, 4096);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(92, 20);
            this.TextLabel.TabIndex = 5;
            this.TextLabel.Text = "Sender name";
            this.TextLabel.TextChanged += new System.EventHandler(this.TextLabel_TextChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.ForeColor = System.Drawing.Color.Gray;
            this.DateLabel.Location = new System.Drawing.Point(601, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(176, 29);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "yesterday";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IsReadPicture
            // 
            this.IsReadPicture.Image = global::Client.Properties.Resources.message_sending_48px;
            this.IsReadPicture.Location = new System.Drawing.Point(735, 29);
            this.IsReadPicture.Name = "IsReadPicture";
            this.IsReadPicture.Size = new System.Drawing.Size(45, 27);
            this.IsReadPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IsReadPicture.TabIndex = 7;
            this.IsReadPicture.TabStop = false;
            // 
            // MessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.IsReadPicture);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.SenderNameLabel);
            this.Name = "MessageControl";
            this.Size = new System.Drawing.Size(780, 56);
            ((System.ComponentModel.ISupportInitialize)(this.IsReadPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label SenderNameLabel;
        public System.Windows.Forms.Label TextLabel;
        public System.Windows.Forms.Label DateLabel;
        public System.Windows.Forms.PictureBox IsReadPicture;
    }
}
