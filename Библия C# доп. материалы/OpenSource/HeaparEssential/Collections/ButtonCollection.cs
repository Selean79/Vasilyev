using System;
using System.Collections;
using heaparessential.Collections;
using heaparessential.Controls;

namespace heaparessential.Collections
{
    public class ButtonCollection : CollectionWithEvents
    {
        public CBButton Add(CBButton value)
        {
            List.Add(value as object);

            return value;
        }

        public void AddRange(CBButton[] values)
        {
            foreach (CBButton page in values)
                Add(page);
        }

        public void Remove(CBButton value)
        {
            List.Remove(value as object);
        }

        public void Insert(int index, CBButton value)
        {
            List.Insert(index, value as object);
        }

        public bool Contains(CBButton value)
        {
            return base.List.Contains(value as object);
        }

        public CBButton this[int index]
        {
            get { return (base.List[index] as CBButton); }
        }

        public CBButton this[string title]
        {
            get
            {
                foreach (CBButton page in base.List)
                    if (page.Title == title)
                        return page;

                return null;
            }
        }

        public int IndexOf(CBButton value)
        {
            return base.List.IndexOf(value);
        }
    }
}
