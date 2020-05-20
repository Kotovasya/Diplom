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
using System.Diagnostics;

namespace Client.GUI.Controls
{
    public partial class FileControl : UserControl
    {
        public FileControl()
        {
            InitializeComponent();
        }

        public FileControl(string fileName, string size, string date, bool visibleFolder = false)
            : this()
        {
            FileNameLabel.Text = fileName;
            SizeLabel.Text = size;
            DateLabel.Text = date;
            ShowFolderLabel.Visible = visibleFolder;
        }

        public FileControl(Models.File file, bool visibleFolder = false)
            : this(file.Name, file.Size.ToString(), DateTime.Today.ToString(), visibleFolder)
        {
        }

        private void ShowFolderLabel_Click(object sender, EventArgs e)
        {
            string path = @"C:\1.txt";
            if (File.Exists(path))
            {
                Process.Start(new ProcessStartInfo("1.txt", " /select, " + path));
            }
        }

        private void FileControl_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.AliceBlue;
        }

        private void FileControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void FileControl_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.AliceBlue;
        }
    }
}
