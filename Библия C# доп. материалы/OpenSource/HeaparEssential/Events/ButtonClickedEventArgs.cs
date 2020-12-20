using System;
using System.Collections.Generic;
using System.Text;

namespace heaparessential.Common
{
    public class ButtonClickedEventArgs: EventArgs
    {
        public ButtonClickedEventArgs(int index)
        {
            this.index = index;
        }

        int index;
        public int Index
        {
            get { return index; }
        }
    }
}
