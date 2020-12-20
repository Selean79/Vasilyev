using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Controls.Primitives;

namespace DPhotoWorkshop.Engine
{
    public class DesignerCanvasProperties
    {
        public static Double ButtonsScaleSource = 7;
    }

    public class DesignerCanvas: Canvas
    {
        Point selectionStartPoint;
        bool dragging = false;

        public DesignerCanvas()
        {
            this.AllowDrop = true;
            this.ClipToBounds = true;
            this.SnapsToDevicePixels = true;
        }

        private List<DesignerBaseItem> selectedItems = new List<DesignerBaseItem>();
        public List<DesignerBaseItem> SelectedItems
        {
            get { return selectedItems; }
            set { selectedItems = value; }
        }

        #region private

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);

            if (!(e.Source is DesignerBaseItem))
                ClearSelection();
            this.selectionStartPoint = e.GetPosition(this);
            dragging = true;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.LeftButton != MouseButtonState.Pressed)
            {
                dragging = false;
            }

            if (dragging)
            {
                AdornerLayer adornerLayer = AdornerLayer.GetAdornerLayer(this);
                if (adornerLayer != null)
                {
                    RubberAdorner adorner = new RubberAdorner(this, selectionStartPoint);
                    if (adorner != null)
                        adornerLayer.Add(adorner);
                }
            }
        }

        #endregion

        #region public

        public void ClearSelection()
        {
            foreach (UIElement item in Children)
                if (item is DesignerBaseItem)
                    ((DesignerBaseItem)item).IsSelected = false;
            selectedItems.Clear();
        }

        #endregion
    }
}
