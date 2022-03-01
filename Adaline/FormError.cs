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
    public partial class FormError : Form
    {
        private List<double> Error;
        public FormError(List<double> error)
        {
            InitializeComponent();
            Error = error;
            pictureBox1.Refresh();
            lbMaxAge.Text = Error.Count.ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int space = pictureBox1.Width / (Error.Count);
            Point last = new Point(0, pictureBox1.Height-3);
            e.Graphics.FillEllipse(Brushes.Blue, last.X - (4 / 2), last.Y - (4 / 2),
                    4, 4);
            for (int i = 0; i < Error.Count; i++)
            {
                Point current = new Point((i + 1) * space, pictureBox1.Height-3 - (int)(Error[i] * pictureBox1.Height));

                e.Graphics.DrawLine(Pens.Blue, last, current);
                e.Graphics.FillEllipse(Brushes.Red, current.X - (4 / 2), current.Y - (4 / 2),
                    4, 4);
                last = current;
            }
        }

        private void FormError_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Error.Count; i++)
            {
                int j = dataGridView1.Rows.Add();
                dataGridView1.Rows[j].Cells["Epoca"].Value = i + 1;
                dataGridView1.Rows[j].Cells["Errors"].Value = Error[i];
            }
        }
    }
}
