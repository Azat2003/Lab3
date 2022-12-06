using MyLab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    public partial class Form2 : Form
    {
        int i;
        int numPoints;
        bool flag;
        Point[] points;
        public Form2()
        {
            InitializeComponent();
            this.flag = false;
            this.i = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.flag == false)
            {
                try
                {
                    this.numPoints = int.Parse(dots_count.Text);
                    if (this.numPoints <= 2)
                    {
                        MessageBox.Show("Ошибка ввода.");
                        this.numPoints = 0;
                    }
                    else
                    {
                        this.points = new Point[numPoints];
                        this.flag = true;
                        dots_count.Enabled = false;
                        dot_x.Enabled = true;
                        dot_y.Enabled = true;
                        label3.Text = $"Введите координаты {i + 1} точки:";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка ввода.");
                }
            }
            else
            {
                try
                {
                    int x = int.Parse(dot_x.Text);
                    int y = int.Parse(dot_y.Text);
                    if (i < numPoints - 1)
                    {
                        this.points[i].X = x;
                        this.points[i].Y = y;
                        i += 1;
                        label3.Text = $"Введите координаты {i + 1} точки:";
                    }
                    else
                    {
                        this.points[i].X = x;
                        this.points[i].Y = y;
                        btnAdd.Enabled = false;
                        btnDraw.Enabled = true;
                        this.flag = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка ввода.");
                }
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (Init.Coords_check(points, 0, 0))
            {
                Array.Resize(ref Init.polygon, Init.polygonCnt + 1);
                Init.polygon[Init.polygonCnt] = new Polygon(points);
                Init.polygon[Init.polygonCnt].show();

                Init.polygonCnt++;
                this.Close();
            }
            else
            {
                MessageBox.Show("Фигура вышла за границы.");
                this.Close();
            }
        }
    }
}
