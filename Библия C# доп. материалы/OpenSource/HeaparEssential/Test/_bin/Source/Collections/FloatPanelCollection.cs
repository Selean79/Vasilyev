using System;
using System.Collections;
using heaparessential.Collections;
using heaparessential.Controls;

namespace heaparessential.Collections
{
    public class FloatPanelCollection : CollectionWithEvents
    {
        public FloatPanel Add(FloatPanel value)
        {
            base.List.Add(value as object);

            return value;
        }

        public void AddRange(FloatPanel[] values)
        {
            foreach (FloatPanel panel in values)
                Add(panel);
        }

        public void Remove(FloatPanel value)
        {
            base.List.Remove(value as object);
        }

        public void Insert(int index, FloatPanel value)
        {
            base.List.Insert(index, value as object);
        }

        public bool Contains(FloatPanel value)
        {
            return base.List.Contains(value as object);
        }

        public FloatPanel this[int index]
        {
            get { return (base.List[index] as FloatPanel); }
        }

        public int IndexOf(FloatPanel value)
        {
            return base.List.IndexOf(value);
        }
    }
}
