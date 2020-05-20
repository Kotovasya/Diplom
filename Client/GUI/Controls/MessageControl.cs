using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Client.GUI.Controls
{
    public partial class MessageControl : UserControl
    {
        private MessageFileControl FileControl;

        public MessageControl()
        {
            InitializeComponent();
        }

        public MessageControl(string sender, string date, string text)
            :this()
        {
            SenderNameLabel.Text = sender;
            DateLabel.Text = date;
            TextLabel.Text = text;
            this.Size = new Size(56 + TextLabel.Size.Height - 20, 780);
        }

        public MessageControl(Models.Message message)
            : this(message.Sender.Name, DateTime.Today.ToString(), message.Text)
        {
        }

        private void TextLabel_TextChanged(object sender, EventArgs e)
        {
            if (FileControl != null)
            {
                this.Size = new Size(56 + TextLabel.Height - 20 + FileControl.Height, 780);
                FileControl.Location = new Point(0, this.Height - FileControl.Height);
            }
            else     
                this.Size = new Size(56 + TextLabel.Height - 20, 780);
        }

        public void AddFile(Models.File file)
        {
            FileControl = new MessageFileControl(file.Name, file.Size.ToString());
        }
    }
}
