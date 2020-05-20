using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUI.Controls
{
    public partial class MessageFileControl : UserControl
    {
        public Guid FileId;

        public Models.File File;

        public MessageFileControl()
        {
            InitializeComponent();
        }

        public MessageFileControl(string fileName, string size)
            : this()
        {
            FileNameLabel.Text = fileName;
            SizeLabel.Text = size;
        }

        public MessageFileControl(Models.File file)
            : this(file.Name, file.Size.ToString())
        {
            FileId = file.Id;
            File = file;
        }
    }
}
