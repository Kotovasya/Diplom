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
    public partial class LoginForm : Form
    {
        private Point _lastPosition;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = MousePosition.X - _lastPosition.X;
                int dy = MousePosition.Y - _lastPosition.Y;
                Location = new Point(Location.X + dx, Location.Y + dy);
                _lastPosition = MousePosition;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _lastPosition = MousePosition;
            }
        }
    }
}
