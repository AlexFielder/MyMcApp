using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using System.Windows.Controls;
namespace LightSwitchApplication
{
    public partial class UsersListDetail
    {
        partial void UsersListDetail_Created()
        {
            //Microsoft.LightSwitch.Threading.Dispatchers.Main.BeginInvoke(() =>
            //    {
            //        var settings = this.FindControl("Picture1");
            //        settings.SetProperty("ResolutionWidth", this.DataWorkspace.ApplicationData.Settings.Details.);
            //        settings.SetProperty("ResolutionHeight", this.DataWorkspace.ApplicationData.SettingsResolutionHeight);
            //        settings.SetProperty("ViewFinderWidth", this.DataWorkspace.ApplicationData.Settings.ViewFinderWidth);
            //        settings.SetProperty("ViewFinderHeight", this.DataWorkspace.ApplicationData.Settings.ViewFinderHeight);
            //    });

        }

        partial void SelectTVFolderRoot_Execute()
        {
            // Write your code here.
            OpenFileDialog ofd = new OpenFileDialog();
            bool? userClickedOk = ofd.ShowDialog();
        }
    }
}
