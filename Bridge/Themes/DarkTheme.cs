using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge.Interfaces;

namespace Bridge.Themes
{
    internal class DarkTheme : ITheme
    {
        public string GetColor()
        {
            return "Dark Black";
        }
    }
}
