using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprog2Project
{
    public class EnableControl
    {


        /// <summary>
        ///  enabled collection of control in the form
        /// </summary>
        /// <param name="list">collection of control</param>
        internal static void ControlEnable(List<Control> list, bool TrueFalse)
        {

            //loop each on of the collection and enabled the editing
            foreach (System.Windows.Forms.Control control in list)
                control.Enabled = TrueFalse;

        }
        internal static void ControlEnable(Control control, bool TrueFalse) => control.Enabled = TrueFalse;
        //--------------------------------------------------------------------------------------------------
 
    } 
}
