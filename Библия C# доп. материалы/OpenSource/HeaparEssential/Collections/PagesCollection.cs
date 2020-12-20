using System;
using System.Collections.Generic;
using System.Text;
using heaparessential.Controls;

namespace heaparessential.Collections
{
    public class PagesCollection : CollectionWithEvents
    {
        public Page Add(Page value)
        {
            base.List.Add(value as object);

            return value;
        }

        public void AddRange(Page[] values)
        {
            foreach (Page page in values)
                Add(page);
        }

        public void Remove(Page value)
        {
            base.List.Remove(value as object);
        }

        public void Insert(int index, Page value)
        {
            base.List.Insert(index, value as object);
        }

        public bool Contains(Page value)
        {
            return base.List.Contains(value as object);
        }

        public Page this[int index]
        {
            get { return (base.List[index] as Page); }
        }

        public Page this[string title]
        {
            get
            {
                foreach (Page page in base.List)
                    if (page.Title == title)
                        return page;

                return null;
            }
        }

        public int IndexOf(Page value)
        {
            return base.List.IndexOf(value);
        }
    }
}
