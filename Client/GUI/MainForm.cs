using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Models;
using Client.GUI.Controls;
using Client.ServiceReference;
using Client.Properties;
using Client.Helpers;

namespace Client.GUI
{
    public partial class MainForm : Form
    {

        private readonly ClientModel Model;

        private readonly Dictionary<BunifuButton, TabPage> Relationships;
        private Dictionary<int, DialogControl> DialogControls;
        private Dictionary<Guid, FileControl> FileControls;
        private Dictionary<Guid, ClientControl> UserControls;
        private Dictionary<int, TabPage> DialogPages;

        private bool AllDialogsSelected;
        private bool DownloadFilesSelected;
        private bool AllUsersSelected;

        public MainForm(ClientModel model)
        {
            InitializeComponent();

            #region InitializeModel
            Model = model;
            model.DialogCreated += OnAddDialog;
            model.DialogEdited += OnEditDialog;
            model.DialogDeleted += OnDeleteDialog;
            #endregion

            AllDialogsSelected = false;
            DownloadFilesSelected = false;
            AllUsersSelected = false;

            Relationships = new Dictionary<BunifuButton, TabPage>
            {
                { DialogsButton, DialogsPage },
                { AttachmentsButton, FilesPage },
                { UsersButton, UsersPage },
                { SettingsButton, SettingsPage },
            };
            DialogControls = new Dictionary<int, DialogControl>();
            FileControls = new Dictionary<Guid, FileControl>();
            UserControls = new Dictionary<Guid, ClientControl>();
            DialogPages = new Dictionary<int, TabPage>();
            for (int i = 0; i < 15; i++)
            {
                DialogsPanel.Controls.Prepend(new DialogControl(string.Format("Dialog Name {0}", i), string.Format("Last message sended: {0}", i), "ysterday"));
                FilesPanel.Controls.Prepend(new FileControl(string.Format("File name {0}", i), "1.24 MB", "18.05.2020 10:15", false));
                UsersPanel.Controls.Prepend(new ClientControl(string.Format("User name {0}", i), "Online", true));
            }

            #region FormDockInitialize
            FormDock.SubscribeControlToDragEvents(LeftTopPanel);
            FormDock.SubscribeControlToDragEvents(LeftPanel);
            FormDock.SubscribeControlToDragEvents(TopMainPanel);
            FormDock.SubscribeControlToDragEvents(DialogsTopPanel);
            FormDock.SubscribeControlToDragEvents(DialogsPage);
            FormDock.AllowHidingBottomRegion = false;
            Focus();
            #endregion
        }

        #region DialogsPage

        private void Button_Click(object sender, EventArgs e)
        {
            BunifuButton button = (BunifuButton)sender;
            Indicator.Location = button.Location;
            Pages.Page = Relationships[button];
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void AllDialogsButton_Click(object sender, EventArgs e)
        {
            AllDialogsSelected = true;
            bunifuTransition.HideSync(DialogsButtonsSeparator, false, Animation.Scale);
            Point newPoint = new Point(AllDialogsButton.Location.X, AllDialogsButton.Location.Y + AllDialogsButton.Height);
            DialogsButtonsSeparator.Location = newPoint;
            bunifuTransition.ShowSync(DialogsButtonsSeparator, false, Animation.VertSlide);
        }

        private void UserDialogsButton_Click(object sender, EventArgs e)
        {
            AllDialogsSelected = false;
            bunifuTransition.HideSync(DialogsButtonsSeparator, false, Animation.Scale);
            Point newPoint = new Point(UserDialogsButton.Location.X, UserDialogsButton.Location.Y + UserDialogsButton.Height);
            DialogsButtonsSeparator.Location = newPoint;
            bunifuTransition.ShowSync(DialogsButtonsSeparator, false, Animation.VertSlide);
        }

        private void CreateDialogButton_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void CreateDialogButton_Click(object sender, EventArgs e)
        {
            // make show create dialog form
        }

        private void DialogSearchTextbox_TextChange(object sender, EventArgs e)
        {
            // make search engine in Dialogs
        }

        #endregion

        #region Attachments Page
        private void DownloadFilesButton_Click(object sender, EventArgs e)
        {
            DownloadFilesSelected = true;
            bunifuTransition.HideSync(FilesButtonsSeparator, false, Animation.Scale);
            Point newPoint = new Point(DownloadFilesButton.Location.X, DownloadFilesButton.Location.Y + DownloadFilesButton.Height);
            FilesButtonsSeparator.Location = newPoint;
            bunifuTransition.ShowSync(FilesButtonsSeparator, false, Animation.VertSlide);
        }

        private void UserFilesButton_Click(object sender, EventArgs e)
        {
            DownloadFilesSelected = false;
            bunifuTransition.HideSync(FilesButtonsSeparator, false, Animation.Scale);
            Point newPoint = new Point(UserFilesButton.Location.X, UserFilesButton.Location.Y + UserFilesButton.Height);
            FilesButtonsSeparator.Location = newPoint;
            bunifuTransition.ShowSync(FilesButtonsSeparator, false, Animation.VertSlide);
        }

        private void UploadFileButton_Click(object sender, EventArgs e)
        {
            // make upload file to server
        }

        private void FilesSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            // make search engine for files
        }

        #endregion

        #region Users Page
        private void OnlineUsersButton_Click(object sender, EventArgs e)
        {
            AllUsersSelected = false;
            bunifuTransition.HideSync(UsersButtonsSeparator, false, Animation.Scale);
            Point newPoint = new Point(OnlineUsersButton.Location.X, OnlineUsersButton.Location.Y + OnlineUsersButton.Height);
            UsersButtonsSeparator.Location = newPoint;
            bunifuTransition.ShowSync(UsersButtonsSeparator, false, Animation.VertSlide);
        }

        private void AllUsersButton_Click(object sender, EventArgs e)
        {
            AllUsersSelected = true;
            bunifuTransition.HideSync(UsersButtonsSeparator, false, Animation.Scale);
            Point newPoint = new Point(AllUsersButton.Location.X, AllUsersButton.Location.Y + AllUsersButton.Height);
            UsersButtonsSeparator.Location = newPoint;
            bunifuTransition.ShowSync(UsersButtonsSeparator, false, Animation.VertSlide);
        }

        private void UsersSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            // make users search engine
        }
        #endregion

        #region Settings Page

        #endregion

        #region TopPanel Buttons
        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RestoreWindowAppButton_Click(object sender, EventArgs e)
        {
            if (FormDock.WindowState == Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Normal)
            {
                FormDock.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
                RestoreWindowAppButton.Image = Resources.restore_window_64px;
                Pages.Transition.TimeCoeff = 5;
            }
            else
            {
                RestoreWindowAppButton.Image = Resources.maximized_window_48px;
                FormDock.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Normal;
                Pages.Transition.TimeCoeff = 1;
            }
        }

        private void MinimizedWindowAppButton_Click(object sender, EventArgs e)
        {
            FormDock.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Minimized;
        }

        private void TopPanelButton_MouseMove(object sender, MouseEventArgs e)
        {
            Bunifu.UI.WinForms.BunifuImageButton button = (Bunifu.UI.WinForms.BunifuImageButton)sender;
            button.BackColor = Color.White;
        }

        private void TopPanelButton_MouseEnter(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuImageButton button = (Bunifu.UI.WinForms.BunifuImageButton)sender;
            button.BackColor = Color.White;
        }

        private void TopPanelButton_MouseLeave(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuImageButton button = (Bunifu.UI.WinForms.BunifuImageButton)sender;
            button.BackColor = Color.Transparent;
        }
        #endregion

        #region Model Events

        private void DialogOpen(object sender, EventArgs e)
        {
            DialogControl dialogControl = (DialogControl)sender;
            int idDialog = DialogControls.Single(k => k.Value == dialogControl).Key;
            // Make request to dialog info and open dialog in form
        }

        private void OnAddDialog(object sender, CreateDialogEventArgs args)
        {
            DialogControl dialogControl = new DialogControl(args.Dialog);
            DialogControls.Add(args.Dialog.Id, dialogControl);
            if (AllDialogsSelected)
                DialogsPanel.Controls.Add(dialogControl);
        }

        private void OnEditDialog(object sender, EditDialogEventArgs args)
        {
            DialogControl dialogControl = DialogControls[args.DialogId];
            dialogControl.DialogName.Text = args.EditName;
        }

        private void OnDeleteDialog(object sender, DeleteDialogEventArgs args)
        {
            DialogControl dialogControl = DialogControls[args.DialogId];
            DialogsPanel.Controls.Remove(dialogControl);
            DialogControls.Remove(args.DialogId);
        }

        #endregion
    }
}
