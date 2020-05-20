using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Properties;

namespace Client.GUI.Controls
{
    public partial class ClientControl : UserControl
    {
        public ClientControl()
        {
            InitializeComponent();
        }

        public ClientControl(string userName, string lastOnline, bool online)
            : this()
        {
            UserNameLabel.Text = userName;
            LastOnlineLabel.Text = lastOnline;
            OnlinePicture.Image = online ? Resources.user_online_60px : Resources.user_offline_60px;
        }

        public ClientControl(Models.User user)
            : this(user.Name, DateTime.Today.ToString(), true)
        {
        }

        private void ClientControl_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.AliceBlue;
        }

        private void ClientControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void ClientControl_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.AliceBlue;
        }
    }
}
