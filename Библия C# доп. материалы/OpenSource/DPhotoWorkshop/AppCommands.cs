namespace DPhotoWorkshop
{
    using Microsoft.Windows.Controls.Ribbon;
    using System.Windows;
    using System.Windows.Input;

    public static class AppCommands
    {
        public static RibbonCommand NewCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["NewCommand"]; }
        }

        public static RibbonCommand OpenCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["OpenCommand"]; }
        }

        public static RibbonCommand SaveCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["SaveCommand"]; }
        }

        public static RibbonCommand SaveAsCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["SaveAsCommand"]; }
        }

        public static RibbonCommand ProjectPropertiesCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["ProjectPropertiesCommand"]; }
        }        

        public static RibbonCommand HelpCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["HelpCommand"]; }
        }

        public static RibbonCommand PrintCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["PrintCommand"]; }
        }

        public static RibbonCommand PrintPropCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["PrintPropCommand"]; }
        }
        
        public static RibbonCommand ExitCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["ExitCommand"]; }
        }

        public static RibbonCommand SelectFrameCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["SelectFrameCommand"]; }
        }

        public static RibbonCommand FrameColorSchemeCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["FrameColorSchemeCommand"]; }
        }

        public static RibbonCommand FrameBackgroundCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["FrameBackgroundCommand"]; }
        }

        public static RibbonCommand FrameForeroundCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["FrameForegroundCommand"]; }
        }

        public static RibbonCommand FrameLineWidthCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["FrameLineWidthCommand"]; }
        }

        public static RibbonCommand InsertTextCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["InsertTextCommand"]; }
        }

        public static RibbonCommand TextColorCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["TextColorCommand"]; }
        }

        public static RibbonCommand TextEffectCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["EffectCommand"]; }
        }

        public static RibbonCommand DeleteObjectCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["DeleteObjectCommand"]; }
        }

        public static RibbonCommand ExportAsImageCmd
        {
            get { return (RibbonCommand)Application.Current.Resources["ExportAsImageCommand"]; }
        }        
    }
}
