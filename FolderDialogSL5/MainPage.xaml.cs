using System;
using System.Windows;
using System.Windows.Controls;

namespace FolderDialogSL5
{
    public partial class MainPage : UserControl
    {
        #region Constructor
        public MainPage()
        {
            InitializeComponent();
        }
        #endregion

        #region Select Folder Click
        private void SelectFolder_Click(object sender, RoutedEventArgs e)
        {
            FolderDialog fd = new FolderDialog();
            fd.Closed += new EventHandler(cw_Closed);
            fd.Show();
        }
        #endregion

        #region Folder Dialog Closed
        void cw_Closed(object sender, EventArgs e)
        {
            FolderDialog fd = sender as FolderDialog;

            if (fd.DialogResult == true)
            {
                txtPath.Text = fd.txtSelectedFolder.Text;
            }
        }
        #endregion
    }
}
