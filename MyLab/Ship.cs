using MyLab;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    public class Ship : Rectangle
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public Rectangle r1;
        public Ring ring1;
        public Ring ring2;
        public Ring ring3;
        public Triangle triangle1;
        public Triangle triangle2;
        public Triangle triangle3;
        public Triangle triangle4;
        public List<Figure> figures;
        public Ship(int x, int y, int w, int h) : base(x, y, w, h)
        {
            figures = new List<Figure>();

            r1 = new Rectangle(x + 84, y + 118, 157, 71);

            ring1 = new Ring(x + 105, y + 126, 25);
            ring2 = new Ring(x + 146, y + 126, 25);
            ring3 = new Ring(x + 188, y + 126, 25);

            Point point1 = new Point(x, y + 118);
            Point point2 = new Point(x + 84, y + 118);
            Point point3 = new Point(x + 84, y + 189);
            Point[] tri_points_1 = { point3, point1, point2 };
            triangle1 = new Triangle(tri_points_1);

            Point point1_2 = new Point(x + 84, y + 36);
            Point point2_2 = new Point(x + 157, y);
            Point point3_2 = new Point(x + 157, y + 36);
            Point[] tri_points_2 = { point1_2, point2_2, point3_2 };
            triangle2 = new Triangle(tri_points_2);

            Point point1_3 = new Point(x + 158, y + 118);
            Point point2_3 = new Point(x + 158, y);
            Point point3_3 = new Point(x + 259, y + 118);
            Point[] tri_points_3 = { point1_3, point2_3, point3_3 };
            triangle3 = new Triangle(tri_points_3);

            Point point1_4 = new Point(x + 241, y + 189);
            Point point2_4 = new Point(x + 241, y + 118);
            Point point3_4 = new Point(x + 322, y + 118);
            Point[] tri_points_4 = { point1_4, point2_4, point3_4 };
            triangle4 = new Triangle(tri_points_4);
            Figure[] fs = { r1, ring1, ring2, ring3, triangle1, triangle2, triangle3, triangle4 };
            figures.AddRange(fs);
        }
        Graphics g = Init.pictureBox.CreateGraphics();
        public void show()
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                       r1.Show(g, Color.Black);
                        break;
                    case 1:
                        ring1.show(g, Color.Black);
                        break;
                    case 2:
                       ring2.show(g, Color.Black);
                        break;
                    case 3:
                       ring3.show(g, Color.Black);
                        break;
                    case 4:
                        triangle1.show();
                        break;
                    case 5:
                        triangle2.show();
                        break;
                    case 6:
                        triangle3.show();
                        break;
                    case 7:
                        triangle4.show();
                        break;
                }
            }
        }
        public void MoveTo(int x, int y)
        {
            if (Init.Coords_check(this.x+x, this.y+y, 322, 190))
            {
                this.x += x;
                this.y += y;
                for (int i = 0; i < 8; i++)
                {
                    Figure figure = figures[i];
                    if (figure.points != null)
                    {
                        for (int j = 0; j < figure.points.Length; j++)
                        {
                            figure.points[j].X += x;
                            figure.points[j].Y += y;
                        }
                        figure.x = figure.points[0].X;
                        figure.y = figure.points[0].Y;
                    }
                    else
                    {
                        figure.x += x;
                        figure.y += y;
                    }
                }
            }
            else
            {
                MessageBox.Show("Фигура вышла за границы.");
            }
        }
    }
}
