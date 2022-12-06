using PR2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLab
{
    public class Polygon : Figure
    {
        public Polygon(Point[] points) : base(points[0].X, points[0].Y)
        {
            this.points = points;
        }
        public void show()
        {
            Graphics g = Init.pictureBox.CreateGraphics();
            g.DrawPolygon(Init.pen, points);
        }
        public void MoveTo(int x, int y)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += x;
                points[i].Y += y;
            }
            this.x = points[0].X;
            this.y = points[0].Y;
        }
        public int[] get()
        {
            int[] sizes = { points[0].X, points[0].Y };
            return sizes;
        }
    }
}
