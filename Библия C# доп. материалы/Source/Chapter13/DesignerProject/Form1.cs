using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Designer
{
    public partial class Form1 : Form
    {
        List<Rose> roses = new List<Rose>();
        Rose SelectedRose = null;
        Boolean dragging;
        Point startDragPoint;

        public Form1()
        {
            InitializeComponent();
        }

        #region Методы

        Rose GetItemAt(int x, int y)
        {
            foreach (Rose currRose in roses)
            {
                if (
                    currRose.X < x && 
                    currRose.X + currRose.Width > x && 
                    currRose.Y < y && 
                    currRose.Y + currRose.Height > y 
                    )
                    return currRose;
            }
            return null;
        }

        void DrawDraggingShape()
        {
            Point point = designerPanel.PointToScreen(SelectedRose.Location);
            ControlPaint.DrawReversibleFrame(new Rectangle(point, SelectedRose.Size), SystemColors.ButtonFace, FrameStyle.Dashed);
        }

        #endregion

        #region События меню


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roses.Clear();
            designerPanel.Invalidate();
        }

        private void добавитьРозуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rose rose = new Rose("Роза " + roses.Count.ToString(), 0, 0);
            roses.Add(rose);
            designerPanel.Invalidate();
        }

        private void designerPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (Rose rose in roses)
                rose.Draw(e.Graphics);
        }

        private void designerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Rose rose = GetItemAt(e.X, e.Y);
            if (rose != null)
            {
                SelectedRose = rose;
                dragging = true;
                startDragPoint = e.Location;
                DrawDraggingShape();
            }
        }

        private void designerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                dragging = false;
                DrawDraggingShape();
                designerPanel.Invalidate();
            }
        }

        private void designerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                DrawDraggingShape();
                SelectedRose.X = SelectedRose.Location.X + (e.Location.X - startDragPoint.X);
                SelectedRose.Y = SelectedRose.Location.Y + (e.Location.Y - startDragPoint.Y);
                DrawDraggingShape();
                startDragPoint = e.Location;
            }
        }

        #endregion
    }
}
