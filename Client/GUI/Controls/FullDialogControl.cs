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
using System.IO;
using Client.ServiceReference;
using Client.Properties;
using Client.Helpers;

namespace Client.GUI.Controls
{
    public partial class FullDialogControl : UserControl
    {
        private readonly Dialog Dialog;
        private readonly MainForm Owner;
        private readonly ClientModel Model;
        private MessageFileControl AttachmentControl;

        public FullDialogControl()
        {
            InitializeComponent();
        }

        public FullDialogControl(Dialog dialog, MainForm owner, ClientModel model)
            : this()
        {
            Dialog = dialog;
            Owner = owner;
            Model = model;
            DialogNameLabel.Text = dialog.Name;
            MembersCountLabel.Text = string.Format("Участники: {0}", dialog.Users.Count);
            foreach (var message in dialog.Messages)
                MessagesPanel.Controls.Add(new MessageControl(message));
            foreach (User user in dialog.Users)
                MembersPanel.Controls.Add(new DialogMemberControl(user));
            MessagesPanel.VerticalScroll.Value = MessagesPanel.VerticalScroll.Minimum;
        }

        private void MessageTextbox_TextChanged(object sender, EventArgs e)
        {
            if (AttachmentControl != null)
                DialogBottomPanel.Height = 77 + MessageTextbox.Height - 35; // начальная высота DialogBottomPanel + высоту textbox - начальную высоту textbox
            else
                DialogBottomPanel.Height = 77 + AttachmentControl.Height + MessageTextbox.Height - 35; // тоже самое, только еще + высота прикрепленного контрола с файлом
            DialogBottomPanel.Location = new Point(DialogBottomPanel.Location.X, DialogBottomPanel.Location.Y - (DialogBottomPanel.Size.Height - 77));
            MessagesPanel.Height = 555 - DialogBottomPanel.Height;
        }

        private void DropDownButton_Click(object sender, EventArgs e)
        {
            DropDownPanel.Visible = !DropDownPanel.Visible;
        }

        private void DropDownPanel_MouseLeave(object sender, EventArgs e)
        {
            DropDownPanel.Visible = false;
        }
        
        public void AddMessage(Models.Message message)
        {
            MessagesPanel.Controls.Add(new MessageControl(message));
        }

        private void MessagesPanel_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue == MessagesPanel.VerticalScroll.Maximum)
            {
                MessagesPanel.Controls.Prepend(new MessageControl());
                Dialog.Messages.Prepend(new Models.Message());
                // make load messages from dialog
            }
        }

        private void MembersCountLabel_MouseMove(object sender, MouseEventArgs e)
        {
            MembersCountLabel.Font = new Font(MembersCountLabel.Font, FontStyle.Underline);
        }

        private void MembersCountLabel_MouseEnter(object sender, EventArgs e)
        {
            MembersCountLabel.Font = new Font(MembersCountLabel.Font, FontStyle.Underline);
        }

        private void MembersCountLabel_MouseLeave(object sender, EventArgs e)
        {
            MembersCountLabel.Font = new Font(MembersCountLabel.Font, FontStyle.Regular);
        }

        private void MembersCountLabel_Click(object sender, EventArgs e)
        {
            MembersPanel.Visible = true;
        }

        private void GoBackLabel_Click(object sender, EventArgs e)
        {
            Owner.Pages.PageName = "DialogsPage";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchPanel.Visible = true;
        }

        private async void AttachFileButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                DialogResult dialgResult = fbd.ShowDialog();
                if (dialgResult == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    using (FileStream stream = new FileStream(fbd.FileName, FileMode.Open))
                    {
                        Guid? fileId = await Model.UploadFile(stream);
                        if (fileId != null)
                        {
                            AttachmentControl = new MessageFileControl(new Models.File(fileId.Value, stream.Name, (int)stream.Length));
                            DialogBottomPanel.Size = new Size(DialogBottomPanel.Width, DialogBottomPanel.Height + AttachmentControl.Height + 40);
                            AttachmentControl.Location = new Point(DialogBottomPanel.Location.X, AttachFileButton.Location.Y + 20);
                            MessagesPanel.Size = new Size(800, 555 - DialogBottomPanel.Height);
                        }
                        else
                        {
                            CustomMessageBox.Show(string.Format("Не удалось загрузить файл\n{0}", stream.Name), CustomMessageBox.CustomMessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private async void SendMessageButton_Click(object sender, EventArgs e)
        {
            SendMessageRequest request = new SendMessageRequest() { Id = Model.Id, DialogId = Dialog.Id, Text = MessageTextbox.Text };
            MessageControl messageControl = new MessageControl("Kotovasya", DateTime.Today.ToShortTimeString(), request.Text);
            if (AttachmentControl != null)
            {
                request.FileId = AttachmentControl.FileId;
                messageControl.AddFile(AttachmentControl.File);
            }
            MessagesPanel.Controls.Add(messageControl);
            SendMessageResponse response = await Model.Service.SendMessageAsync(request);
            if (response.Result == MessagingResponseId.Successfully)
            {
                messageControl.IsReadPicture.Image = Resources.message_sended_48px;
                Dialog.Messages.Add(new Models.Message(response.Message));
            }
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            // need make search on server
            MessagesPanel.Controls.Clear();
            foreach(var message in Dialog.Messages)
            {
                if (message.Text.Contains(SearchTextbox.Text))
                {
                    MessagesPanel.Controls.Add(new MessageControl(message));
                }
            }
        }

        private void MembersPanel_MouseLeave(object sender, EventArgs e)
        {
            MembersPanel.Visible = false;
        }
    }
}
