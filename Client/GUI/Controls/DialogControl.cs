using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Models;
using Client.ServiceReference;

namespace Client.GUI.Controls
{
    public partial class DialogControl : UserControl
    {
        public DialogControl()
        {
            InitializeComponent();
        }

        public DialogControl(string dialogName, string lastMessage, string date)
            : this()
        {
            DialogName.Text = dialogName;
            LastMessage.Text = lastMessage;
            Date.Text = date;
        }

        public DialogControl(DialogDto dialog)
            : this(dialog.Name, "", "")
        {
        }

        private void DialogControl_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.AliceBlue;
        }

        private void DialogControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void DialogControl_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.AliceBlue;
        }
    }
}
