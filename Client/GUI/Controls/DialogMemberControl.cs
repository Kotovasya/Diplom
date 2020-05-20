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
    public partial class DialogMemberControl : UserControl
    {
        public DialogMemberControl()
        {
            InitializeComponent();
        }

        public DialogMemberControl(Models.User user)
            : this()
        {
            UserNameLabel.Text = user.Name;
            IsOnlineImage.Image = Resources.red_circle_filled_100px;
        }
    }
}
