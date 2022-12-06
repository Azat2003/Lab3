using MyLab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = int.Parse(x_1.Text);
                int y1 = int.Parse(y_1.Text);
                int x2 = int.Parse(x_2.Text);
                int y2 = int.Parse(y_2.Text);
                int x3 = int.Parse(x_3.Text);
                int y3 = int.Parse(y_3.Text);

                Point pt1 = new Point(x1, y1);
                Point pt2 = new Point(x2, y2);
                Point pt3 = new Point(x3, y3);
                Point[] points = {pt1, pt2, pt3};

                if (Init.Coords_check(points, 0, 0))
                {
                    Array.Resize<Triangle>(ref Init.triangle, Init.triangleCnt + 1);
                    Init.triangle[Init.triangleCnt] = new Triangle(points);
                    Init.triangle[Init.triangleCnt].show();

                    Init.triangleCnt++;
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }
    }
}
