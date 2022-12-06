using PR2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLab
{
    public static class Init
    {
        public static Bitmap bitmap;
        public static PictureBox pictureBox;
        public static Pen pen;
        public static Polygon[] polygon = new Polygon[1];
        public static int polygonCnt = 0;
        public static Triangle[] triangle = new Triangle[1];
        public static int triangleCnt = 0;
        public static Ship[] ship = new Ship[1];
        public static int shipCnt = 0;
        public static bool Coords_check(int x, int y, int w, int h)
        {
            if (!((x < 0) || (y < 0) || (x + w > Init.pictureBox.Width) || (y + h > Init.pictureBox.Height)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Coords_check(Point[] points, int x, int y)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if ((points[i].X + x < 0) || (points[i].Y + y < 0) || (points[i].X + x > Init.pictureBox.Width) ||
                    (points[i].Y + y > Init.pictureBox.Height))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
