using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects_yt.Gui.GuiHome
{
    public partial class HomeUserControl : UserControl
    {
        // _ private n'est pas public
        // readonly affictation une seule fois 
        private static HomeUserControl _HomeUserControl;
        public HomeUserControl()
        {
            InitializeComponent();
        }
        public static HomeUserControl Instance()
        {
            // ?? si est vide  si non faire new
            return _HomeUserControl ?? (new HomeUserControl());
        }
    }
}
