using System;
using System.Collections.Generic;
using System.Linq; //1
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects_yt.Code
{
    internal class PageManger
    {
        private readonly Main main;

        public PageManger(Main main)
        {
            this.main = main;
        }
        public void LoadPage(UserControl PageUserControl)
        {
            //Load old Page
            var oldPage = main.panelcontainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldPage != null)
            {
                main.panelcontainer.Controls.Remove(oldPage);
                oldPage.Dispose();
            }

            //Load New Page 
            PageUserControl.Dock = DockStyle.Fill;
            main.panelcontainer.Controls.Add(PageUserControl);
        }
    }
}
