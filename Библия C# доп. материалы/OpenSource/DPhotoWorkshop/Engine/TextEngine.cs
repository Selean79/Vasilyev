using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using Microsoft.Windows.Controls.Ribbon;
using System.Windows;

namespace DPhotoWorkshop.Engine
{
    public class TextEngine
    {
        #region init

        RibbonComboBox currentFontFemily;
        RibbonComboBox currentFontSize;

        public TextEngine(DesignerCanvas canvas)
        {
            Canvas = canvas;
        }

        #endregion

        #region properties

        DesignerCanvas canvas = null;
        public DesignerCanvas Canvas
        {
            get { return canvas; }
            set 
            {
                if (value == null)
                    new Exception("TextEngine: Canvas cannot be null");

                canvas = value;
            }
        }

        #endregion

        #region public methods

        public void SetUIElements(RibbonComboBox сurrentFontFemily, RibbonComboBox сurrentFontSize)
        {
            this.currentFontFemily = сurrentFontFemily;
            this.currentFontSize = сurrentFontSize;

            currentFontSize.SelectedItem = currentFontSize.Items[5];
        }

        public void SetFontFamily(FontFamily fontfamily)
        {
            foreach (DesignerBaseItem item in canvas.SelectedItems)
                item.FontFamily = fontfamily;
        }

        public FontFamily GetSelectedFontFamiy()
        {
            if (((RibbonComboBoxItem)currentFontFemily.SelectedItem) != null)
                return ((RibbonComboBoxItem)currentFontFemily.SelectedItem).FontFamily;
            else
                return null;
        }

        public int GetSelectedFontSize()
        {
            return Convert.ToInt32(currentFontSize.Text);
        }

        public void SetFontSize(int fontsize)
        {
            foreach (DesignerBaseItem item in canvas.SelectedItems)
                item.FontSize = fontsize;
        }

        public void SetTextColor(Color color)
        {
            foreach (DesignerBaseItem item in canvas.SelectedItems)
                item.ForegroundColor = color;
        }

        #endregion
    }
}
