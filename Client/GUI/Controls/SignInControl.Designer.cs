namespace Client.GUI.Controls
{
    partial class SignInControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInControl));
            this.SignInLabel = new System.Windows.Forms.Label();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.SuspendLayout();
            // 
            // SignInLabel
            // 
            this.SignInLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignInLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.SignInLabel.Location = new System.Drawing.Point(206, 33);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(134, 64);
            this.SignInLabel.TabIndex = 3;
            this.SignInLabel.Text = "Sign In";
            this.SignInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(45, 145);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(475, 44);
            this.bunifuTextbox1.TabIndex = 4;
            this.bunifuTextbox1.text = "Enter Name...";
            // 
            // SignInControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.SignInLabel);
            this.Name = "SignInControl";
            this.Size = new System.Drawing.Size(576, 492);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SignInLabel;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
    }
}
