using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Frm_小畫家 : Form
    {
        public Frm_小畫家()
        {
            InitializeComponent();
            SetSize();
        }


        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if(size <= 0) { size = 2; }
                points = new Point[size];
            }

            public void SetPoint(int x,int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x,y);
                index++;
            }

            public void RestPoints()
            {
                index = 0;
            }

            public int GetCountPoints()
            {
                return index;
            }

            public Point[] GetPoints()
            {
                return points;
            }

        }

        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);

        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;

        Pen pen = new Pen(Color.Black, 3f);

        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void Btn_color_Click(object sender, EventArgs e)
        {
            colorDialog1  = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p_showcolor.BackColor = colorDialog1.Color;
                pen.Color = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse=false;
            arrayPoints.RestPoints();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) { return; }

            arrayPoints.SetPoint(e.X, e.Y);
            if(arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen,arrayPoints.GetPoints());
                pictureBox1.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);

            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }
    }
}
