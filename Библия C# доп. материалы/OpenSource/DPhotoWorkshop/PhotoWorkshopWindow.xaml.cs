using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DPhotoWorkshop.Engine;
using DPhotoWorkshop.Dialogs;
using Microsoft.Win32;
using DPhotoWorkshop.Engine.Borders;
using Microsoft.Windows.Controls.Ribbon;
using Microsoft.Samples.CustomControls;
using System.Collections.ObjectModel;

namespace DPhotoWorkshop
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>        const string 
    public partial class PhotoWorkshopWindow : RibbonWindow
    {
        public const string APP_NAME = "DPhotoWorkshop";

        #region init

        DPhotoEngine engine;
        PrintEngine printer;

        public PhotoWorkshopWindow()
        {
            InitializeComponent();

            engine = new DPhotoEngine(currentImage, currentCanvas);
            printer = new PrintEngine(currentCanvas);

            BindCommands();
            RestoreProgramState();
            ApplyColorShemesToButton();
            engine.TextEngine.SetUIElements(currentFontName, currentFontSize);
            currentFontSize.SelectedIndex = 4;
        }

        void ApplyColorShemesToButton()
        {
            foreach (FrameColorScheme scheme in FrameColorSchemes.FrameColorSchemesList)
            {
                MenuItem item = new MenuItem();
                item.Header = scheme.Name;
                item.Tag = scheme;
                item.Click += new RoutedEventHandler(PhotoBorderColorSchemeItem_Click);
                ColorSchemeDropDownButton.Items.Add(item);
            }
        }

        private void RestoreProgramState()
        {
            (new WindowController(this)).LoadProgramProperties();
        }

        private void SaveProgramState()
        {
            (new WindowController(this)).SaveProgramProperties();
        }

        private void BindCommands()
        {
            #region application

            CommandBinding binding = new CommandBinding(AppCommands.NewCmd, OnNewDocument_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.OpenCmd, OnOpenDocument_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.SaveCmd, OnSaveDocument_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.SaveAsCmd, OnSaveDocumentAs_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.ExportAsImageCmd, OnExportAsImage_Executed, null);
            this.CommandBindings.Add(binding);            
            binding = new CommandBinding(AppCommands.PrintCmd, OnPrintDocument_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.PrintPropCmd, OnPrintProperties_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.HelpCmd, OnHelpApplication_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.ExitCmd, OnCloseApplication_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.ProjectPropertiesCmd, OnProjectPropertiesCommand_Executed, null);
            this.CommandBindings.Add(binding);

            #endregion

            #region common objects

            binding = new CommandBinding(AppCommands.DeleteObjectCmd, DeleteObjectCmdCommand_Executed, null);
            this.CommandBindings.Add(binding);
            
            #endregion

            #region frame

            binding = new CommandBinding(AppCommands.SelectFrameCmd, OnSelectFrame_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.FrameBackgroundCmd, OnSelectFrameBackgroundColor_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.FrameForeroundCmd, OnSelectFrameForegroundColor_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.FrameLineWidthCmd, OnSelectLineWidthForegroundColor_Executed, null);
            this.CommandBindings.Add(binding);

            #endregion

            #region text

            binding = new CommandBinding(AppCommands.InsertTextCmd, OnInsertText_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.TextColorCmd, OnTextChangeColor_Executed, null);
            this.CommandBindings.Add(binding);
            binding = new CommandBinding(AppCommands.TextEffectCmd, OnTextEffectChange_Executed, null);
            this.CommandBindings.Add(binding);

            #endregion
        }

        #endregion

        #region file commands executed

        private void OnNewDocument_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NewProjectWindow newProject = new NewProjectWindow();
            newProject.Owner = this;
            
            bool? result = newProject.ShowDialog();
            if (result != null && result == true)
            {
				engine.CreateFile(newProject.BitmapWidth, newProject.BitmapHeight);
				Title = APP_NAME + " : Untitled Document";
			}
        }

        private void OnOpenDocument_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            dialogOpenFile.Filter = "Supported Files|*.dphw;*.jpg;*.png;*.bmp|D Photo Workshop files|*.dphw|Bitmap files (bmp)|*.bmp|JPEG images|*.jpg|PNG Images|*.png|All files|*.*";
            if (dialogOpenFile.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            engine.OpenFile(dialogOpenFile.FileName);

            Title = APP_NAME + " : " + dialogOpenFile.FileName;

            if (!((MostRecentFiles)MostRecentFilesList.ItemsSource).IsFileExistsInList(dialogOpenFile.FileName))
                ((MostRecentFiles)MostRecentFilesList.ItemsSource).Add(new MostRecentFile(dialogOpenFile.FileName, true));
        }

        private void OnPrintDocument_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            printer.PrintDocument(engine.Filename);
        }

        private void OnPrintProperties_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            printer.ShowPrintPropertiesDialog();
        }

        private void OnCloseApplication_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void ribbonApplicationMenu_MostRecentFileSelected(object sender, MostRecentFileSelectedEventArgs e)
        {
            engine.OpenFile(((MostRecentFile)e.SelectedItem).Path);
            Title = APP_NAME + " : " + engine.Filename;
        }

        private void OnSaveDocument_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (engine.IsPhotoWorkshopProject)
                engine.SaveProjectFile();
            else
                OnSaveDocumentAs_Executed(sender, e);
        }

        private void OnSaveDocumentAs_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.DefaultExt = DPhotoEngine.PROJECT_EXT;
            saveDlg.Filter = "DPhotoWorkshop projects|*" + DPhotoEngine.PROJECT_EXT;
            bool? result = saveDlg.ShowDialog();
            if (result != null && result == true)
            {
                engine.Filename = saveDlg.FileName;
                engine.ShowPropertiesDialog();
                OnSaveDocument_Executed(sender, e);
                if (!((MostRecentFiles)MostRecentFilesList.ItemsSource).IsFileExistsInList(saveDlg.FileName))
                    ((MostRecentFiles)MostRecentFilesList.ItemsSource).Add(new MostRecentFile(saveDlg.FileName, true));
            }
        }

        private void OnExportAsImage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.DefaultExt = "jpg";
            saveDlg.Filter = "Jpeg|*.jpg|PNG|*.png|Windows Bitmap (bmp)|*.bmp";
            bool? result = saveDlg.ShowDialog();
            if (result != null && result == true)
                engine.ExportProjectAsImage(saveDlg.FileName);
        }

        private void OnProjectPropertiesCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            engine.ShowPropertiesDialog();
        }

        #endregion

        #region help command executed

        void OnHelpApplication_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dphotoworkshop.com");
        }

        #endregion

        #region frame commands

        private void PhotoBorderColorSchemeItem_Click(object sender, RoutedEventArgs e)
        {
            if (engine.PhotoFrame == null)
            {
                MessageBox.Show("The image doesn't contain a frame", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (sender is Control)
                engine.PhotoFrame.ApplyColorScheme((FrameColorScheme)((sender as Control).Tag));
        }

        private void OnSelectFrame_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SelectFrameDialog selectFrame = new SelectFrameDialog(engine.PreviewImage);
            selectFrame.Owner = this;
            if (selectFrame.ShowDialog() != true)
                return;
            engine.PhotoFrame = selectFrame.SelectedFrame;
            if (engine.PhotoFrame != null)
                engine.PhotoFrame.Visualize(engine.ImageCanvas, engine.ImageControl.RenderSize.Width, engine.ImageControl.RenderSize.Height);
        }

        private void OnSelectFrameBackgroundColor_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (engine.PhotoFrame != null)
            {
                Color color = engine.PhotoFrame.FillColor;
                if (InputColor(ref color))
                    engine.PhotoFrame.FillColor = color;
            }
            else
                MessageBox.Show("The image doesn't have a frame", "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void OnSelectFrameForegroundColor_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (engine.PhotoFrame != null)
            {
                Color color = engine.PhotoFrame.StrokeColor;
                if (InputColor(ref color))
                    engine.PhotoFrame.StrokeColor = color;
            }
            else
                MessageBox.Show("The image doesn't have a frame", "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void OnSelectLineWidthForegroundColor_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (engine.PhotoFrame == null)
            {
                MessageBox.Show("There is no frame on the picture. Add frame first.", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            InputIntegerValueWindow inputWindow = new InputIntegerValueWindow(this, "Line width", "Input a new line width");
            inputWindow.IntValue = engine.PhotoFrame.StrokeThickness;

            bool? dialogResult = inputWindow.ShowDialog();
            if (dialogResult != null && (bool)dialogResult == true)
            {
                engine.PhotoFrame.StrokeThickness = inputWindow.IntValue;
            }
        }

        private void FrameBackgroundMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Control)
                if (engine.PhotoFrame != null)
                {
                    System.Drawing.Color c = System.Drawing.Color.FromArgb(Convert.ToInt32((sender as Control).Tag));
                    engine.PhotoFrame.FillColor = Color.FromArgb(c.A, c.R, c.G, c.B);
                }
        }

        private void FrameForegroundMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Control)
                if (engine.PhotoFrame != null)
                {
                    System.Drawing.Color c = System.Drawing.Color.FromArgb(Convert.ToInt32((sender as Control).Tag));
                    engine.PhotoFrame.StrokeColor = Color.FromArgb(c.A, c.R, c.G, c.B);
                }
        }

        private void FrameLineWidthMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Control)
                if (engine.PhotoFrame != null)
                {
                    engine.PhotoFrame.StrokeThickness = Convert.ToInt32((sender as Control).Tag);
                }
        }

        #endregion

        #region text commands

        private void OnInsertText_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            InputStringValueWindow inputWindow = new InputStringValueWindow(this, "Input Text", "Type text you want to insert in picture");

            bool? dialogResult = inputWindow.ShowDialog();
            if (dialogResult != null && (bool)dialogResult == true)
                engine.InsertText(inputWindow.StringValue);
        }

        private void currentFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (engine != null)
                {
                    currentFontSize.Text = ((RibbonComboBoxItem)currentFontSize.SelectedItem).Content.ToString();
                    engine.TextEngine.SetFontSize(Convert.ToInt32(currentFontSize.Text));
                    engine.TextEngine.SetFontFamily(((RibbonComboBoxItem)currentFontName.SelectedItem).FontFamily);
                }
            }
            catch (Exception)
            {
            }
        }

        private void currentFontSize_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (engine != null)
                {
                    engine.TextEngine.SetFontSize(Convert.ToInt32(currentFontSize.Text));
                    engine.TextEngine.SetFontFamily(((RibbonComboBoxItem)currentFontName.SelectedItem).FontFamily);
                }
            }
            catch (Exception)
            {
            }
        }

        private void OnTextChangeColor_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Color color = Colors.Black;
            if (currentCanvas.SelectedItems.Count > 0)
                color = currentCanvas.SelectedItems[0].ForegroundColor;
            if (InputColor(ref color))
                engine.TextEngine.SetTextColor(color);
        }

        private void TextColorMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Control)
            {
                System.Drawing.Color c = System.Drawing.Color.FromArgb(Convert.ToInt32((sender as Control).Tag));
                engine.TextEngine.SetTextColor(Color.FromArgb(c.A, c.R, c.G, c.B));
            }
        }

        private void OnTextEffectChange_Executed(object sender, RoutedEventArgs e)
        {
            foreach (DesignerBaseItem item in currentCanvas.SelectedItems)
                item.ApplyEffect(Convert.ToInt32((sender as Control).Tag));
        }

        #endregion

        #region event handlers

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveProgramState();
            if (MostRecentFilesList.ItemsSource != null)
                ((MostRecentFiles)MostRecentFilesList.ItemsSource).SaveList();
        }

        #endregion

        #region private methods

        private bool InputColor(ref Color color)
        {
            ColorPickerDialog colorDlg = new ColorPickerDialog();
            colorDlg.Owner = this;
            colorDlg.ShowInTaskbar = false;
            colorDlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            colorDlg.StartingColor = color;
            bool? dialogResult = colorDlg.ShowDialog();

            if (dialogResult != null && (bool)dialogResult == true)
            {
                color = colorDlg.SelectedColor;
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region common object

        private void DeleteObjectCmdCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            foreach (DesignerBaseItem item in currentCanvas.SelectedItems)
                currentCanvas.Children.Remove(item);
        }

        #endregion
    }
}
