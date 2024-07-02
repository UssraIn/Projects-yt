using Projects_yt.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projects_yt.Gui;
namespace Projects_yt
{
    public partial class Main : Form
    {
        private readonly PageManger pageManger;
        public Main()
        {
            InitializeComponent();
            pageManger = new PageManger(this);

            //Load Home Page
            pageManger.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }


        #region Events
        private void button1_Click(object sender, EventArgs e)
        {
            //Load Home Page
            //Avec new memoire c >>
            //pageManger.LoadPage(new Gui.GuiHome.HomeUserControl());

            //Sans new
            pageManger.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }
        #endregion
    }
}
