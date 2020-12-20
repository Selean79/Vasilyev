using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using heaparessential.Common;

namespace heaparessential.Controls
{
    public enum ResizerStyle { Horizontal, Vertical };

    [System.ComponentModel.DesignerCategory("code")]
    [ToolboxBitmap(typeof(HeaparResizer))]
    [DefaultProperty("Style")]
    public partial class HeaparResizer : Control
    {
        bool dragging = false;
        Point startPoint, currPoint;
        Rectangle bound;

        public HeaparResizer()
        {
            InitializeComponent();

            Style = ResizerStyle.Horizontal;
        }

        #region properties

        /// <summary>
        /// Style
        /// </summary>
        ResizerStyle style;
        [DefaultValue("Horizontal"), Description("Select the horizontal or vertical style")]
        public ResizerStyle Style
        {
            get { return style; }
            set 
            { 
                style = value;
                if (style == ResizerStyle.Vertical)
                {
                    Height = 4;
                    if ((Dock != DockStyle.Top) && (Dock != DockStyle.Bottom))
                        Dock = DockStyle.Top;
                    Cursor = Cursors.SizeNS;
                }
                else
                {
                    Width = 4;
                    if ((Dock != DockStyle.Left) && (Dock != DockStyle.Right))
                        Dock = DockStyle.Left;
                    Cursor = Cursors.SizeWE;
                }
            }
        }

        #endregion

        #region unusedprop

        #endregion

        #region methods

        /// <summary>
        /// Paint bevel
        /// </summary>
        /// <param name="g"></param>
        /// <param name="rect"></param>
        void BevelRect(Graphics g, Rectangle rect)
        {
            Pen pen1 = new Pen(SystemColors.ControlLightLight);
            Pen pen2 = new Pen(SystemColors.ControlDark);

            g.DrawLine(pen1, new Point(rect.Left, rect.Top), new Point(rect.Left, rect.Bottom));
            g.DrawLine(pen1, new Point(rect.Left, rect.Top), new Point(rect.Right, rect.Top));

            g.DrawLine(pen2, new Point(rect.Right, rect.Top), new Point(rect.Right, rect.Bottom));
            g.DrawLine(pen2, new Point(rect.Right, rect.Bottom), new Point(rect.Left, rect.Bottom));
        }

        /// <summary>
        /// Resize event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Refresh();
        }

        /// <summary>
        /// Paint control
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (style == ResizerStyle.Vertical)
            {
                int iLeft = (Width - 32) / 2;
                int iTop = (Height - 2) / 2;
                for (int i = 0; i <= 8; i++)
                {
                    BevelRect(e.Graphics, new Rectangle(iLeft, iTop, 2, 2));
                    iLeft += 4;
                }
            }
            if (style == ResizerStyle.Horizontal)
            {
                int iTop = (Height - 32) / 2;
                int iLeft = (Width - 2) / 2;
                for (int i = 0; i <= 8; i++)
                {
                    BevelRect(e.Graphics, new Rectangle(iLeft, iTop, 2, 2));
                    iTop += 4;
                }
            }
        }

        /// <summary>
        /// Mouse down
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            // Mouse down occured inside control
            dragging = true;
            startPoint = PointToScreen(new Point(e.X, e.Y));
            currPoint = startPoint;

            bound = Parent.RectangleToScreen(new Rectangle(0, 0, Parent.ClientSize.Width, Parent.ClientSize.Height));

            DrawIndicator(currPoint);

            base.OnMouseDown(e);
        }

        /// <summary>
        /// Mouse up
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            dragging = false;
            DrawIndicator(currPoint);
            FinishResize();

            base.OnMouseUp(e);
        }

        private void FinishResize()
        {
            foreach (Object c in Parent.Controls)
            {
                if (!(c is Control))
                    continue;

                Control currControl = (Control)c;

                // aligned to left
                if ((currControl.Dock == DockStyle.Left) && (Dock == DockStyle.Left))
                {
                    if (currControl.Left + currControl.Width == Left)
                    {
                        currControl.Width = currControl.Width - (startPoint.X - currPoint.X);
                        return;
                    }
                }

                // aligned to right
                if ((currControl.Dock == DockStyle.Right) && (Dock == DockStyle.Right))
                {
                    if (currControl.Left == Left + Width)
                    {
                        currControl.Width = currControl.Width + (startPoint.X - currPoint.X);
                        return;
                    }
                }

                // aligned to top
                if ((currControl.Dock == DockStyle.Top) && (Dock == DockStyle.Top))
                {
                    if (currControl.Top + currControl.Height == Top)
                    {
                        currControl.Height = currControl.Height - (startPoint.Y - currPoint.Y);
                        return;
                    }
                }

                // aligned to right
                if ((currControl.Dock == DockStyle.Bottom) && (Dock == DockStyle.Bottom))
                {
                    if (currControl.Top == Top + Height)
                    {
                        currControl.Height = currControl.Height + (startPoint.Y - currPoint.Y);
                        return;
                    }
                }
            }            
        }

        /// <summary>
        /// Mouse move 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = PointToScreen(new Point(e.X, e.Y));

                if (Style == ResizerStyle.Horizontal)
                {
                    if (newPoint.X < bound.Left)
                        newPoint.X = bound.Left;
                    if (newPoint.X > bound.Right)
                        newPoint.X = bound.Right;

                }
                if (Style == ResizerStyle.Vertical)
                {
                    if (newPoint.Y < bound.Top)
                        newPoint.Y = bound.Top;
                    if (newPoint.Y > bound.Bottom)
                        newPoint.Y = bound.Bottom;
                }

                DrawIndicator(currPoint);
                currPoint = newPoint;
                DrawIndicator(currPoint);
            }

            base.OnMouseUp(e);
        }

        /// <summary>
        /// Draw indicator line
        /// </summary>
        /// <param name="screenPosition"></param>
        protected void DrawIndicator(Point screenPosition)
        {
            Point delta = new Point(screenPosition.X - startPoint.X, screenPosition.Y - startPoint.Y);

            Rectangle client = RectangleToScreen(this.ClientRectangle);

            if (Style == ResizerStyle.Horizontal)
                client.Offset(delta.X, 0);
            else
                client.Offset(0, delta.Y);

            HeaparSystemDraw.DrawDragRectangle(client, 0);
        }

        #endregion
    }
}