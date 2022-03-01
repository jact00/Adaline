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
    public partial class FormConfusion : Form
    {
        public FormConfusion(int fn, int tn, int fp, int tp)
        {
            InitializeComponent();
            Fill_DataGrid(fn, tn, fp, tp);
        }

        private void FormConfusion_Load(object sender, EventArgs e)
        {

        }

        private void Fill_DataGrid(int fn, int tn, int fp, int tp)
        {
            dataGridView1.Columns["RowNames"].HeaderText = "n = " + (fn+tn+fp+tp).ToString();

            int i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells["RowNames"].Value = "Real 0";
            dataGridView1.Rows[i].Cells["PredictedNo"].Value = tn;
            dataGridView1.Rows[i].Cells["PredictedYes"].Value = fp;
            dataGridView1.Rows[i].Cells["Total"].Value = fp + tn;

            i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells["RowNames"].Value = "Real 1";
            dataGridView1.Rows[i].Cells["PredictedNo"].Value = fn;
            dataGridView1.Rows[i].Cells["PredictedYes"].Value = tp;
            dataGridView1.Rows[i].Cells["Total"].Value = fn + tp;

            i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells["PredictedNo"].Value = fn + tn;
            dataGridView1.Rows[i].Cells["PredictedYes"].Value = tp + fp;
        }
    }
}
