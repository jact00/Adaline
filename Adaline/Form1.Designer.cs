
namespace Adaline
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.tbLearningRate = new System.Windows.Forms.TrackBar();
            this.nudAges = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbW0 = new System.Windows.Forms.Label();
            this.lbW1 = new System.Windows.Forms.Label();
            this.lbW2 = new System.Windows.Forms.Label();
            this.lbLearningRate = new System.Windows.Forms.Label();
            this.tbError = new System.Windows.Forms.TrackBar();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLearningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbError)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Location = new System.Drawing.Point(12, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(200, 200);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(72, 250);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(424, 115);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(75, 23);
            this.btnInitialize.TabIndex = 2;
            this.btnInitialize.Text = "Inicializar";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(270, 161);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 23);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Text = "Entrenar";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(362, 161);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluate.TabIndex = 4;
            this.btnEvaluate.Text = "Evaluar";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // tbLearningRate
            // 
            this.tbLearningRate.Location = new System.Drawing.Point(301, 31);
            this.tbLearningRate.Maximum = 100;
            this.tbLearningRate.Name = "tbLearningRate";
            this.tbLearningRate.Size = new System.Drawing.Size(169, 45);
            this.tbLearningRate.TabIndex = 5;
            this.tbLearningRate.TickFrequency = 5;
            this.tbLearningRate.ValueChanged += new System.EventHandler(this.tbLearningRate_ValueChanged);
            // 
            // nudAges
            // 
            this.nudAges.Location = new System.Drawing.Point(314, 115);
            this.nudAges.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAges.Name = "nudAges";
            this.nudAges.Size = new System.Drawing.Size(104, 20);
            this.nudAges.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Learning Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Epocas Máximas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Error mínimo:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(239, 208);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 11;
            // 
            // lbW0
            // 
            this.lbW0.AutoSize = true;
            this.lbW0.Location = new System.Drawing.Point(12, 215);
            this.lbW0.Name = "lbW0";
            this.lbW0.Size = new System.Drawing.Size(27, 13);
            this.lbW0.TabIndex = 12;
            this.lbW0.Text = "W0:";
            // 
            // lbW1
            // 
            this.lbW1.AutoSize = true;
            this.lbW1.Location = new System.Drawing.Point(86, 215);
            this.lbW1.Name = "lbW1";
            this.lbW1.Size = new System.Drawing.Size(27, 13);
            this.lbW1.TabIndex = 13;
            this.lbW1.Text = "W1:";
            // 
            // lbW2
            // 
            this.lbW2.AutoSize = true;
            this.lbW2.Location = new System.Drawing.Point(163, 215);
            this.lbW2.Name = "lbW2";
            this.lbW2.Size = new System.Drawing.Size(27, 13);
            this.lbW2.TabIndex = 14;
            this.lbW2.Text = "W2:";
            // 
            // lbLearningRate
            // 
            this.lbLearningRate.AutoSize = true;
            this.lbLearningRate.Location = new System.Drawing.Point(476, 45);
            this.lbLearningRate.Name = "lbLearningRate";
            this.lbLearningRate.Size = new System.Drawing.Size(13, 13);
            this.lbLearningRate.TabIndex = 15;
            this.lbLearningRate.Text = "0";
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(301, 69);
            this.tbError.Maximum = 100;
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(169, 45);
            this.tbError.TabIndex = 16;
            this.tbError.TickFrequency = 5;
            this.tbError.ValueChanged += new System.EventHandler(this.tbError_ValueChanged);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(476, 84);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(13, 13);
            this.lbError.TabIndex = 17;
            this.lbError.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 285);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.lbLearningRate);
            this.Controls.Add(this.lbW2);
            this.Controls.Add(this.lbW1);
            this.Controls.Add(this.lbW0);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudAges);
            this.Controls.Add(this.tbLearningRate);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLearningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.TrackBar tbLearningRate;
        private System.Windows.Forms.NumericUpDown nudAges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbW0;
        private System.Windows.Forms.Label lbW1;
        private System.Windows.Forms.Label lbW2;
        private System.Windows.Forms.Label lbLearningRate;
        private System.Windows.Forms.TrackBar tbError;
        private System.Windows.Forms.Label lbError;
    }
}

