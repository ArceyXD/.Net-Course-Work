using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float[] y = new float[7];
            y[0] = 20;
            y[1] = 40;
            y[2] = 60;
            y[3] = 30;
            y[4] = 10;
            y[5] = 50;
            y[6] = 100;

            Size size = this.ClientSize;

            float maxY = MaxValue(y);

            float bh = size.Height / y.Length;


            float[] bw = new float[y.Length];

            for (int i = 0; i < y.Length; i++)
            {
                bw[i] = size.Width * y[i] / maxY;
            }

            //Draw bars

            g.Clear(Color.White);

            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush greenBrush = new SolidBrush(Color.Green);


            for (int i = 0; i < y.Length; i++)
            {
                float xv = 0;
                float yv = i * bh;

                if (i % 3 == 0)
                {
                    g.FillRectangle(redBrush, xv, yv, bw[i], bh);
                }

                if (i % 3 == 1)
                {
                    g.FillRectangle(blueBrush, xv, yv, bw[i], bh);
                }

                if (i % 3 == 2)
                {
                    g.FillRectangle(greenBrush, xv, yv, bw[i], bh);
                }


            }
        }


        private float MaxValue(float[] x)
        {
            float max = x[0];
            foreach (float a in x) if (max < a) max = a;

            return max;
        }
    }
}