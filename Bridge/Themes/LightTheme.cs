using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge.Interfaces;

namespace Bridge.Themes
{
    internal class LightTheme : ITheme
    {
        public string GetColor()
        {
            return "Off White";
        }
    }
}
