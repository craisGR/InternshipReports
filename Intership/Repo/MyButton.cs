using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intership
{
    
    class MyButton : Button
    {
        //edit button not to focus with tab and show a gray square
        protected override bool ShowFocusCues
        {
            get { return false; }
        }
    }
}
