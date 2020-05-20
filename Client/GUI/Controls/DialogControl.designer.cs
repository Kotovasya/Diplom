namespace Client.GUI.Controls
{
    partial class DialogControl
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
            this.DialogName = new System.Windows.Forms.Label();
            this.LastMessage = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DialogName
            // 
            this.DialogName.BackColor = System.Drawing.Color.Transparent;
            this.DialogName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DialogName.Location = new System.Drawing.Point(77, 0);
            this.DialogName.Name = "DialogName";
            this.DialogName.Size = new System.Drawing.Size(381, 29);
            this.DialogName.TabIndex = 0;
            this.DialogName.Text = "Dialog name";
            this.DialogName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DialogName.MouseEnter += new System.EventHandler(this.DialogControl_MouseEnter);
            this.DialogName.MouseLeave += new System.EventHandler(this.DialogControl_MouseLeave);
            this.DialogName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DialogControl_MouseMove);
            // 
            // LastMessage
            // 
            this.LastMessage.BackColor = System.Drawing.Color.Transparent;
            this.LastMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastMessage.ForeColor = System.Drawing.Color.DimGray;
            this.LastMessage.Location = new System.Drawing.Point(77, 55);
            this.LastMessage.Name = "LastMessage";
            this.LastMessage.Size = new System.Drawing.Size(513, 29);
            this.LastMessage.TabIndex = 1;
            this.LastMessage.Text = "This is text of last message";
            this.LastMessage.MouseEnter += new System.EventHandler(this.DialogControl_MouseEnter);
            this.LastMessage.MouseLeave += new System.EventHandler(this.DialogControl_MouseLeave);
            this.LastMessage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DialogControl_MouseMove);
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.ForeColor = System.Drawing.Color.DimGray;
            this.Date.Location = new System.Drawing.Point(495, 2);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(95, 29);
            this.Date.TabIndex = 2;
            this.Date.Text = "yesterday";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Date.MouseEnter += new System.EventHandler(this.DialogControl_MouseEnter);
            this.Date.MouseLeave += new System.EventHandler(this.DialogControl_MouseLeave);
            this.Date.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DialogControl_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 1);
            this.panel1.TabIndex = 3;
            // 
            // DialogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.LastMessage);
            this.Controls.Add(this.DialogName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "DialogControl";
            this.Size = new System.Drawing.Size(600, 84);
            this.MouseEnter += new System.EventHandler(this.DialogControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DialogControl_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DialogControl_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label DialogName;
        public System.Windows.Forms.Label LastMessage;
        public System.Windows.Forms.Label Date;
    }
}
