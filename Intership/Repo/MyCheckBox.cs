using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intership
{

    class MyCheckBox : CheckBox
    {
        protected override bool ShowFocusCues
        {
            //edit checkbox not to focus with tab and show a gray square
            get { return false; }
        }
    }
}
