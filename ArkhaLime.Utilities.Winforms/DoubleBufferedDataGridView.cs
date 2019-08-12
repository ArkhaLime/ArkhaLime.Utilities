using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkhaLime.Utilities.Winforms
{
    class DoubleBufferedDataGridView:DataGridView
    {

        public DoubleBufferedDataGridView() : base() { }

        public new bool DoubleBuffered
        {
            get
            {
                return base.DoubleBuffered;
            }
            set
            {
                // if not remote desktop session then enable double-buffering optimization
                if (SystemInformation.TerminalServerSession)
                {
                    base.DoubleBuffered = false;
                }
                else
                {
                    base.DoubleBuffered = value;
                }

            }
        }

    }
}
