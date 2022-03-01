
namespace Adaline
{
    partial class FormConfusion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RowNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PredictedNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PredictedYes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNames,
            this.PredictedNo,
            this.PredictedYes,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(32, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(416, 116);
            this.dataGridView1.TabIndex = 0;
            // 
            // RowNames
            // 
            this.RowNames.Frozen = true;
            this.RowNames.HeaderText = "";
            this.RowNames.Name = "RowNames";
            // 
            // PredictedNo
            // 
            this.PredictedNo.HeaderText = "Predicción 0";
            this.PredictedNo.Name = "PredictedNo";
            // 
            // PredictedYes
            // 
            this.PredictedYes.HeaderText = "Predicción 1";
            this.PredictedYes.Name = "PredictedYes";
            // 
            // Total
            // 
            this.Total.HeaderText = "";
            this.Total.Name = "Total";
            // 
            // FormConfusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 186);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormConfusion";
            this.Text = "FormConfusion";
            this.Load += new System.EventHandler(this.FormConfusion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredictedNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredictedYes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}