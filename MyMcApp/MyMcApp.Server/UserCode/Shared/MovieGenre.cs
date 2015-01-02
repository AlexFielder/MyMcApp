using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class MovieGenre
    {
        partial void Summary_Compute(ref string result)
        {
            result = Genre.Name;
        }
    }
}
