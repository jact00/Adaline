using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adaline
{
    class Adaline
    {
        public double[] W { get; set; }
        public Adaline(int n)
        {
            W = new double[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                W[i] = 0;
            }
        }
        public double Pw(double[] x)
        {
            double sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i] * W[i + 1];
            }
            sum -= W[0];

            return 1/(1 + Math.Exp(-sum));
        }

        public List<double> Train(List<Data> trainingData, double learningRate, double minError, int maxAges, PictureBox canvas)
        {
            int count = 0;
            double ageError = 1;
            List<double> errors = new List<double>();

            while (count < maxAges && ageError > minError)
            {
                ageError = 0;
                for (int j = 0; j < trainingData.Count; j++)
                {
                    double pwx = Pw(trainingData[j].X);
                    double error = trainingData[j].Y - pwx;

                    for (int i = 1; i < W.Length; i++)
                    {
                        W[i] = W[i] + (learningRate * error * pwx * (1-pwx) * trainingData[j].X[i - 1]);
                    }
                    W[0] = W[0] - (learningRate * error * pwx * (1-pwx));

                    canvas.Refresh();
                    ageError += error * error;
                }
                ageError /= trainingData.Count;
                errors.Add(ageError);
                count++;
            }

            return errors;
        }
    }
}
