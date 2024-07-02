using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projects_yt.Properties;
namespace Projects_yt.Code
{
    public static class MessageCollections
    {
        // Message
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCaption,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Dialog
    }
}
