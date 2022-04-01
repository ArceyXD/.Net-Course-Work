using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {

        double min, max;
        Rectangle r;
        public Form1()
        {
            InitializeComponent();
        }

        private void paint()
        {
            if (startValue.Text == "" || endValue.Text == "")
            {
                MessageBox.Show("Missing Parameters! Try again.");
                return;
            }
            else if (Double.TryParse(startValue.Text, out min) && Double.TryParse(endValue.Text, out max))
            {
                if (min > max)
                {
                    MessageBox.Show("Start Value cannot be greater than end value.");
                    return;
                }
                Invalidate();
            }
            else
            {
                MessageBox.Show("Invalid Parameters! Try again.");
                return;
            }
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            paint();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
           
            Pen blackPen = new Pen(Color.Black, 3);

            //Area to draw graph
            r = new Rectangle(20, 100, this.ClientSize.Width - 50, this.ClientSize.Height - 150);

        
            Graphics g = e.Graphics;
            g.DrawRectangle(blackPen, r);
            Size size = r.Size;    //Size of the drawing area

            double[] x = new double[size.Width];
            double[] y = new double[size.Width];

            // Divide the total range into a number of points equal to the width
            double total = (max - min) / size.Width;

            // initializing x,y values for the sin function
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = min + (total * i);
                y[i] = Math.Sin(x[i]);
            }

            graphFunction(x, y, g);
        }

        void graphFunction(double[] x, double[] y, Graphics g)
        {
            double minY = minValue(y);
            double maxY = maxValue(y);

            double[] px = new double[x.Length];
            double[] py = new double[y.Length];

            Size size = r.Size;

            for (int ip = 0; ip < x.Length; ip++)
            {
                px[ip] = 20 + (x[ip] - min) / (max - min) * size.Width;
                py[ip] = 100 + (size.Height - ((y[ip] - minY) / (maxY - minY) * size.Height));
            }

            Pen bluePen = new Pen(Color.Blue);

            for (int ip = 1; ip < x.Length; ip+=2)
            {
                g.DrawLine(bluePen, (float)px[ip - 1], (float)py[ip - 1], (float)px[ip], (float)py[ip]);
            }
        }

        double maxValue(double[] x)
        {
            double max = x[0];
            foreach (double a in x)
            {
                if (max < a) max = a;
            }
            return max;
        }

        double minValue(double[] x)
        {
            double min = x[0];
            foreach (double a in x)
            {
                if (min > a) min = a;
            }
            return min;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }


        private void startValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paint();
            }
        }

    }
}