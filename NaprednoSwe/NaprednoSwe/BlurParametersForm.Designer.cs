
namespace NaprednoSwe
{
    partial class BlurParametersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericSigma = new System.Windows.Forms.NumericUpDown();
            this.groupBoxGaussianBlur = new System.Windows.Forms.GroupBox();
            this.numericGaussianKernel = new System.Windows.Forms.NumericUpDown();
            this.buttonBlurOk = new System.Windows.Forms.Button();
            this.groupBoxMedian = new System.Windows.Forms.GroupBox();
            this.numericMedianKernelSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxBlur = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericBoxKernel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericSigma)).BeginInit();
            this.groupBoxGaussianBlur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGaussianKernel)).BeginInit();
            this.groupBoxMedian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMedianKernelSize)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxBlur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBoxKernel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kernel size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sigma";
            // 
            // numericSigma
            // 
            this.numericSigma.DecimalPlaces = 2;
            this.numericSigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericSigma.Location = new System.Drawing.Point(118, 73);
            this.numericSigma.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericSigma.Name = "numericSigma";
            this.numericSigma.Size = new System.Drawing.Size(120, 22);
            this.numericSigma.TabIndex = 3;
            this.numericSigma.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numericSigma.ValueChanged += new System.EventHandler(this.numericSigma_ValueChanged);
            // 
            // groupBoxGaussianBlur
            // 
            this.groupBoxGaussianBlur.Controls.Add(this.numericGaussianKernel);
            this.groupBoxGaussianBlur.Controls.Add(this.numericSigma);
            this.groupBoxGaussianBlur.Controls.Add(this.label1);
            this.groupBoxGaussianBlur.Controls.Add(this.label2);
            this.groupBoxGaussianBlur.Location = new System.Drawing.Point(3, 307);
            this.groupBoxGaussianBlur.Name = "groupBoxGaussianBlur";
            this.groupBoxGaussianBlur.Size = new System.Drawing.Size(271, 167);
            this.groupBoxGaussianBlur.TabIndex = 4;
            this.groupBoxGaussianBlur.TabStop = false;
            this.groupBoxGaussianBlur.Text = "Gaussian Blur";
            // 
            // numericGaussianKernel
            // 
            this.numericGaussianKernel.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericGaussianKernel.Location = new System.Drawing.Point(118, 39);
            this.numericGaussianKernel.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numericGaussianKernel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericGaussianKernel.Name = "numericGaussianKernel";
            this.numericGaussianKernel.Size = new System.Drawing.Size(120, 22);
            this.numericGaussianKernel.TabIndex = 5;
            this.numericGaussianKernel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericGaussianKernel.ValueChanged += new System.EventHandler(this.numericGaussianKernel_ValueChanged);
            // 
            // buttonBlurOk
            // 
            this.buttonBlurOk.Location = new System.Drawing.Point(615, 281);
            this.buttonBlurOk.Name = "buttonBlurOk";
            this.buttonBlurOk.Size = new System.Drawing.Size(72, 43);
            this.buttonBlurOk.TabIndex = 4;
            this.buttonBlurOk.Text = "Ok";
            this.buttonBlurOk.UseVisualStyleBackColor = true;
            this.buttonBlurOk.Click += new System.EventHandler(this.buttonBlurOk_Click);
            // 
            // groupBoxMedian
            // 
            this.groupBoxMedian.Controls.Add(this.numericMedianKernelSize);
            this.groupBoxMedian.Controls.Add(this.label3);
            this.groupBoxMedian.Location = new System.Drawing.Point(3, 156);
            this.groupBoxMedian.Name = "groupBoxMedian";
            this.groupBoxMedian.Size = new System.Drawing.Size(271, 145);
            this.groupBoxMedian.TabIndex = 5;
            this.groupBoxMedian.TabStop = false;
            this.groupBoxMedian.Text = "Median Blur";
            // 
            // numericMedianKernelSize
            // 
            this.numericMedianKernelSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericMedianKernelSize.Location = new System.Drawing.Point(118, 59);
            this.numericMedianKernelSize.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numericMedianKernelSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMedianKernelSize.Name = "numericMedianKernelSize";
            this.numericMedianKernelSize.Size = new System.Drawing.Size(120, 22);
            this.numericMedianKernelSize.TabIndex = 6;
            this.numericMedianKernelSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMedianKernelSize.ValueChanged += new System.EventHandler(this.numericMedianKernelSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kernel size";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBoxBlur);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxMedian);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxGaussianBlur);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(255, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(277, 477);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // groupBoxBlur
            // 
            this.groupBoxBlur.Controls.Add(this.label4);
            this.groupBoxBlur.Controls.Add(this.numericBoxKernel);
            this.groupBoxBlur.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBlur.Name = "groupBoxBlur";
            this.groupBoxBlur.Size = new System.Drawing.Size(271, 147);
            this.groupBoxBlur.TabIndex = 7;
            this.groupBoxBlur.TabStop = false;
            this.groupBoxBlur.Text = "Box blur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kernel size";
            // 
            // numericBoxKernel
            // 
            this.numericBoxKernel.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericBoxKernel.Location = new System.Drawing.Point(118, 44);
            this.numericBoxKernel.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numericBoxKernel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBoxKernel.Name = "numericBoxKernel";
            this.numericBoxKernel.Size = new System.Drawing.Size(120, 22);
            this.numericBoxKernel.TabIndex = 7;
            this.numericBoxKernel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBoxKernel.ValueChanged += new System.EventHandler(this.numericBoxKernel_ValueChanged);
            // 
            // BlurParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 739);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonBlurOk);
            this.Name = "BlurParametersForm";
            this.Text = "ParametersForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericSigma)).EndInit();
            this.groupBoxGaussianBlur.ResumeLayout(false);
            this.groupBoxGaussianBlur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGaussianKernel)).EndInit();
            this.groupBoxMedian.ResumeLayout(false);
            this.groupBoxMedian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMedianKernelSize)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxBlur.ResumeLayout(false);
            this.groupBoxBlur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBoxKernel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericSigma;
        private System.Windows.Forms.GroupBox groupBoxGaussianBlur;
        private System.Windows.Forms.Button buttonBlurOk;
        private System.Windows.Forms.NumericUpDown numericGaussianKernel;
        private System.Windows.Forms.GroupBox groupBoxMedian;
        private System.Windows.Forms.NumericUpDown numericMedianKernelSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxBlur;
        private System.Windows.Forms.NumericUpDown numericBoxKernel;
        private System.Windows.Forms.Label label4;
    }
}