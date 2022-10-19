using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge.Interfaces;

namespace Bridge.Pages
{
    internal class Careers : IWebPage
    {
        protected ITheme theme;

        public Careers(ITheme theme)
        {
            this.theme = theme;
        }
        public string GetContent()
        {
            return $"Careers page in {theme.GetColor()}";
        }
    }
}
