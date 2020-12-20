using System;
using System.Collections;
using heaparessential.Common;

namespace heaparessential.Collections
{
    public delegate void CollectionChange(Object sender, CollectionChangingEventArgs e);

    public class CollectionWithEvents : CollectionBase
    {
        public event EventHandler Clearing;
        public event EventHandler Cleared;
        public event CollectionChange Inserting;
        public event CollectionChange Inserted;
        public event CollectionChange Removing;
        public event CollectionChange Removed;
	
        protected override void OnClear()
        {
            if (Clearing != null)
                Clearing(this, new EventArgs());
        }	

        protected override void OnClearComplete()
        {
            if (Cleared != null)
                Cleared(this, new EventArgs());
        }	

        protected override void OnInsert(int index, object value)
        {
            if (Inserting != null)
                Inserting(this, new CollectionChangingEventArgs(index, value));
        }

        protected override void OnInsertComplete(int index, object value)
        {
            if (Inserted != null)
                Inserted(this, new CollectionChangingEventArgs(index, value));
        }

        protected override void OnRemove(int index, object value)
        {
            if (Removing != null)
                Removing(value, new CollectionChangingEventArgs(index, value));
        }

        protected override void OnRemoveComplete(int index, object value)
        {
            if (Removed != null)
                Removed(this, new CollectionChangingEventArgs(index, value));
        }

        protected int IndexOf(object value)
        {
            return base.List.IndexOf(value);
        }
    }
}
