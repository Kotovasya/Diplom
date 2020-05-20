using Client.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUI
{
    public partial class CustomMessageBox : Form
    {
        private readonly Dictionary<CustomMessageBoxIcon, Bitmap> Icons;
        public enum CustomMessageBoxIcon
        {
            Successfully = 0,
            Warning = 1,
            Error = 2,
            Information = 3
        }

        public CustomMessageBox()
        {
            InitializeComponent();
            Icons = new Dictionary<CustomMessageBoxIcon, Bitmap>()
            {
                { CustomMessageBoxIcon.Successfully, Resources.ok_96px },
                { CustomMessageBoxIcon.Warning, Resources.warning_96px },
                { CustomMessageBoxIcon.Error, Resources.cancel_96px },
                { CustomMessageBoxIcon.Information, Resources.about_96px }
            };
        }

        public CustomMessageBox(string text, CustomMessageBoxIcon icon)
            : this()
        {
            Image.Image = Icons[icon];
            TextLabel.Text = text;
        }

        public CustomMessageBox(string text, string textButton, CustomMessageBoxIcon icon)
            : this(text, icon)
        {
            OkButton.Text = textButton;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public static void Show(string text, CustomMessageBoxIcon icon)
        {
            CustomMessageBox mb = new CustomMessageBox(text, icon);
            mb.ShowDialog();
        }

        public static void Show(string text, string textButton, CustomMessageBoxIcon icon)
        {
            CustomMessageBox mb = new CustomMessageBox(text, textButton, icon);
            mb.ShowDialog();
        }
    }
}
