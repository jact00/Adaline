using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adaline
{
    public partial class Form1 : Form
    {
        private List<Data> Data;
        private Adaline Adaline;
        private float CanvasScale;
        private bool Eval;
        public Form1()
        {
            InitializeComponent();
            Data = new List<Data>();
            Adaline = new Adaline(2);
            CanvasScale = 100;
            Eval = false;

            btnEvaluate.Enabled = false;
            btnTrain.Enabled = false;
            tbLearningRate.Value = 0;
            nudAges.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            Data data = new Data(2);
            Point location = Transform(Canvas, e.Location);

            data.X[0] = location.X / CanvasScale - 1;
            data.X[1] = location.Y / CanvasScale - 1;

            if (e.Button == MouseButtons.Left)
                data.Y = 1;
            else
                data.Y = 0;

            Data.Add(data);
            Canvas.Refresh();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {

            float dotSize = 7;

            if (Adaline.W.All(i => i != 0))
            {
                //ax + by - theta = w1x + w2y - w0
                int y1 = (int)Math.Round(CanvasScale * (1 + (Adaline.W[0] - Adaline.W[1]) / Adaline.W[2]));
                int y0 = (int)Math.Round(CanvasScale * (1 + (Adaline.W[0] + Adaline.W[1]) / Adaline.W[2]));
                Point a = Transform(Canvas, new Point(200, y1));
                Point b = Transform(Canvas, new Point(0, y0));

                lbW0.Text = "W0: " + Adaline.W[0].ToString("0.##");
                lbW1.Text = "W1: " + Adaline.W[1].ToString("0.##");
                lbW2.Text = "W2: " + Adaline.W[2].ToString("0.##");
                lbW0.Refresh();
                lbW1.Refresh();
                lbW2.Refresh();

                Pen color = new Pen(Color.DarkGreen, 2);
                e.Graphics.DrawLine(color, a, b);
            }

            if (Eval)
            {
                Console.WriteLine("holi");
                for (int i = 0; i < Canvas.Width; i++)
                {
                    for (int j = 0; j < Canvas.Height; j++)
                    {
                        double[] x = new double[2];
                        x[0] = (double)i / CanvasScale - 1;
                        x[1] = (double)j / CanvasScale - 1;

                        int thirdColor = 130; 
                        double pwx = Adaline.Pw(x);
                        Color color = pwx > 0.5 ? Color.FromArgb(255,thirdColor,(int)(255 - ((pwx - 0.5) * 2 * 255))) : Color.FromArgb((int)(pwx * 2 * 255),thirdColor,255);
                        Brush brush = new SolidBrush(color);
                        Point location = Transform(Canvas, new Point(i, j));

                        e.Graphics.FillRectangle(brush, location.X, location.Y, 1, 1);
                    }
                }
                Eval = false;
            }

            foreach (Data data in Data)
            {
                Brush color = data.Y == 1 ? Brushes.Red : Brushes.Blue;
                Point location = new Point((int)((data.X[0] + 1) * CanvasScale), (int)((data.X[1] + 1) * CanvasScale));
                location = Transform(Canvas, location);

                e.Graphics.FillEllipse(color, location.X - (dotSize / 2), location.Y - (dotSize / 2),
                    dotSize, dotSize);
                e.Graphics.DrawEllipse(Pens.Black, location.X - (dotSize / 2), location.Y - (dotSize / 2),
                    dotSize, dotSize);
            }
        }

        private Point Transform(PictureBox pb, Point p)
        {
            return new Point(p.X, pb.Height - p.Y);
        }

        private void tbLearningRate_ValueChanged(object sender, EventArgs e)
        {
            lbLearningRate.Text = ((double)tbLearningRate.Value / 100).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnEvaluate.Enabled = false;
            btnTrain.Enabled = false;
            tbLearningRate.Value = 0;
            nudAges.Value = 0;
            Data.Clear();
            Adaline = new Adaline(2);

            lbW0.Text = "W0:";
            lbW1.Text = "W1:";
            lbW2.Text = "W2:";
            lbLearningRate.Text = "0";
            lbResult.Text = "";

            Canvas.Refresh();
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Adaline.W[0] = 0.4 * r.NextDouble() - 0.2;
            Adaline.W[1] = 2 * r.NextDouble() - 1;
            Adaline.W[2] = 2 * r.NextDouble() - 1;

            Canvas.Refresh();
            btnTrain.Enabled = true;
            btnEvaluate.Enabled = false;
            lbResult.Text = "";
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            double learningRate = (double)tbLearningRate.Value / 100;
            double minError = (double)tbError.Value / 100;
            int maxAges = (int)nudAges.Value;

            Console.WriteLine(learningRate);
            Console.WriteLine(maxAges);
            Console.WriteLine(minError);

            lbResult.Text = "";
            tbLearningRate.Enabled = false;
            tbError.Enabled = false;
            nudAges.Enabled = false;
            btnReset.Enabled = false;
            btnInitialize.Enabled = false;
            btnTrain.Enabled = false;
            btnEvaluate.Enabled = false;
            Canvas.Enabled = false;

            List<double> errors = Adaline.Train(Data, learningRate, minError, maxAges, Canvas);

            tbLearningRate.Enabled = true;
            tbError.Enabled = true;
            nudAges.Enabled = true;
            btnReset.Enabled = true;
            btnInitialize.Enabled = true;
            btnTrain.Enabled = true;
            Canvas.Enabled = true;

            lbResult.Text = "Total de epocas: " + errors.Count.ToString();
            btnEvaluate.Enabled = true;

            int tp = 0, tn = 0, fp = 0, fn = 0;
            foreach (Data data in Data)
            {
                double pwx = Adaline.Pw(data.X);
                if(pwx > 0.5)
                {
                    if (data.Y == 1) tp++;
                    else fp++;
                }
                else
                {
                    if (data.Y == 0) tn++;
                    else fn++;
                }
            }

            new FormConfusion(fn, tn, fp, tp).Show();
            new FormError(errors).Show();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            Eval = true;
            Canvas.Refresh();
        }

        private void tbError_ValueChanged(object sender, EventArgs e)
        {
            lbError.Text = ((double)tbError.Value / 100).ToString();
        }
    }
}
