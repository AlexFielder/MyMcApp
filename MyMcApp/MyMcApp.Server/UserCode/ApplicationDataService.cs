using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void Settings_CanInsert(ref bool result)
        {
            result = (DataWorkspace.ApplicationData.Settings.FirstOrDefault() == null);
        }

        partial void Settings_CanDelete(ref bool result)
        {
            result = false;
        }
        //internal static Setting SystemSettings;
        //partial void Application_Initialize()
        //{
        //    SystemSettings = DataWorkspace.ApplicationData.Settings.FirstOrDefault();
        //}
    }
}
