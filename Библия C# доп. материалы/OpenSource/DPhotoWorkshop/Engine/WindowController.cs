using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows;

namespace DPhotoWorkshop.Engine
{
    class WindowController
    {
        Window wnd;

        public WindowController(Window wnd)
        {
            this.wnd = wnd;
        }

        /// <summary>
        /// Load Window Properties
        /// </summary>
        public void LoadProgramProperties()
        {
            RegistryKey registryKeyOptions = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("CyD Software Labs").CreateSubKey(PhotoWorkshopWindow.APP_NAME).CreateSubKey(wnd.Name);
            wnd.Width = Convert.ToDouble(registryKeyOptions.GetValue("width", 700));
            wnd.Height = Convert.ToDouble(registryKeyOptions.GetValue("height", 500));
            wnd.Left = Convert.ToDouble(registryKeyOptions.GetValue("left", 50));
            wnd.Top = Convert.ToDouble(registryKeyOptions.GetValue("top", 50));
            wnd.WindowState = (WindowState)registryKeyOptions.GetValue("WinState", WindowState.Normal);
        }

        /// <summary>
        /// Save Window Properties
        /// </summary>
        public void SaveProgramProperties()
        {
            RegistryKey registryKeyOptions = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("CyD Software Labs").CreateSubKey(PhotoWorkshopWindow.APP_NAME).CreateSubKey(wnd.Name);
            registryKeyOptions.SetValue("WinState", (int)wnd.WindowState);
            if (wnd.WindowState == WindowState.Normal)
            {
                registryKeyOptions.SetValue("width", wnd.Width);
                registryKeyOptions.SetValue("height", wnd.Height);
                registryKeyOptions.SetValue("left", wnd.Left);
                registryKeyOptions.SetValue("top", wnd.Top);
            }
        }
    }
}
