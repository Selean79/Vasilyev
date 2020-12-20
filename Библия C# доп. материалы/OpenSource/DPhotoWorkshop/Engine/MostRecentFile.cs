using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.IO;

namespace DPhotoWorkshop.Engine
{
    public class MostRecentFile
    {
        public MostRecentFile(string path, bool isFixed)
        {
            Name = System.IO.Path.GetFileName(path);
            IsFixed = isFixed;
            Path = path;
        }

        public string Name
        {
            get;
            set;
        }

        bool isFixed;
        public bool IsFixed
        {
            get { return isFixed; }
            set { isFixed = value; }
        }

        string path;
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
    }
}
