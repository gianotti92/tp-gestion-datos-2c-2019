using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrbaCrucero.Utils
{
    class FormsUtil
    {
        public static void openNewForm(Form from, Form to) {
            from.Hide();
            to.Show();
        }
    }
}
