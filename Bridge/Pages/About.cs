using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bridge.Interfaces;

namespace Bridge.Pages
{
    internal class About : IWebPage
    {
        protected ITheme theme;

        public About(ITheme theme)
        {
            this.theme = theme;
        }
        public string GetContent()
        {
            return $"About page in {theme.GetColor()}";
        }
    }
}
