using System;
using System.Collections.Generic;
using System.Text;

namespace heaparessential.Common
{
    public class CollectionChangingEventArgs : EventArgs
    {
        public CollectionChangingEventArgs(int index, object value)
        {
            this.index = index;
            this.value = value;
        }

        int index;
        public int Index
        {
            get { return index; }
        }

        Object value;
        public Object Value
        {
            get { return value; }
        }
    }
}
