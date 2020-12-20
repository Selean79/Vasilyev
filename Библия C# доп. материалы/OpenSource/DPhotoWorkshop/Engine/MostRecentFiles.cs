using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.IO;

namespace DPhotoWorkshop.Engine
{
    public class MostRecentFiles : ObservableCollection<MostRecentFile>
    {
        const int MAX_ITEMS = 10;

        public MostRecentFiles()
        {
            LoadList();
        }

        public void SaveList()
        {
            // open key
            RegistryKey registryKeyOptions = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("CyD Software Labs").CreateSubKey(PhotoWorkshopWindow.APP_NAME).CreateSubKey("RecentFiles");

            for (int i = 0; i < Items.Count; i++)
            {
                registryKeyOptions.SetValue("item" + i.ToString(), Items[i].Path.ToString());
            }
            registryKeyOptions.SetValue("ItemsNumber", Items.Count);
        }

        public void LoadList()
        {
            RegistryKey registryKeyOptions = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("CyD Software Labs").CreateSubKey(PhotoWorkshopWindow.APP_NAME).CreateSubKey("RecentFiles");
            int num = (int)registryKeyOptions.GetValue("ItemsNumber", 0);

            for (int i = 0; i < num; i++)
            {
                string filename = (string)registryKeyOptions.GetValue("item" + i.ToString(), "");
                Add(new MostRecentFile(filename, true));
            }
        }

        public bool IsFileExistsInList(string path)
        {
            foreach (MostRecentFile file in Items)
                if (file.Path == path)
                    return true;

            return false;
        }
    }
}
