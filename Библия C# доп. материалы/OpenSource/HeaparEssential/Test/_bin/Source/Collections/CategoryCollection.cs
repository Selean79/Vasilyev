using System;
using System.Collections;
using heaparessential.Collections;
using heaparessential.Controls;

namespace heaparessential.Collections
{
    public class CategoryCollection : CollectionWithEvents
    {
        public ButtonsPanel Add(ButtonsPanel value)
        {
            base.List.Add(value as object);

            return value;
        }

        public void AddRange(ButtonsPanel[] values)
        {
            foreach (ButtonsPanel panel in values)
                Add(panel);
        }

        public void Remove(ButtonsPanel value)
        {
            base.List.Remove(value as object);
        }

        public void Insert(int index, ButtonsPanel value)
        {
            base.List.Insert(index, value as object);
        }

        public bool Contains(ButtonsPanel value)
        {
            return base.List.Contains(value as object);
        }

        public ButtonsPanel this[int index]
        {
            get { return (base.List[index] as ButtonsPanel); }
        }

        public int IndexOf(ButtonsPanel value)
        {
            return base.List.IndexOf(value);
        }
    }
}
