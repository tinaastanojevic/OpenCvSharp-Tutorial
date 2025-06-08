
namespace NaprednoSwe
{
    partial class EdgeDetectionParametersForm
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
            this.groupBoxCanny = new System.Windows.Forms.GroupBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.numericThreshold1 = new System.Windows.Forms.NumericUpDown();
            this.numericThreshold2 = new System.Windows.Forms.NumericUpDown();
            this.numericCannyKernel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxLaplacian = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericLaplacianKernel = new System.Windows.Forms.NumericUpDown();
            this.numericDelta = new System.Windows.Forms.NumericUpDown();
            this.numericScale = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxCanny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreshold1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreshold2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCannyKernel)).BeginInit();
            this.groupBoxLaplacian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLaplacianKernel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScale)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCanny
            // 
            this.groupBoxCanny.Controls.Add(this.label3);
            this.groupBoxCanny.Controls.Add(this.label2);
            this.groupBoxCanny.Controls.Add(this.label1);
            this.groupBoxCanny.Controls.Add(this.numericCannyKernel);
            this.groupBoxCanny.Controls.Add(this.numericThreshold2);
            this.groupBoxCanny.Controls.Add(this.numericThreshold1);
            this.groupBoxCanny.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCanny.Name = "groupBoxCanny";
            this.groupBoxCanny.Size = new System.Drawing.Size(444, 170);
            this.groupBoxCanny.TabIndex = 0;
            this.groupBoxCanny.TabStop = false;
            this.groupBoxCanny.Text = "Canny";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(652, 354);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(83, 33);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // numericThreshold1
            // 
            this.numericThreshold1.Location = new System.Drawing.Point(181, 22);
            this.numericThreshold1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericThreshold1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericThreshold1.Name = "numericThreshold1";
            this.numericThreshold1.Size = new System.Drawing.Size(120, 22);
            this.numericThreshold1.TabIndex = 0;
            this.numericThreshold1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericThreshold1.ValueChanged += new System.EventHandler(this.numericThreshold1_ValueChanged);
            // 
            // numericThreshold2
            // 
            this.numericThreshold2.Location = new System.Drawing.Point(181, 62);
            this.numericThreshold2.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericThreshold2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericThreshold2.Name = "numericThreshold2";
            this.numericThreshold2.Size = new System.Drawing.Size(120, 22);
            this.numericThreshold2.TabIndex = 1;
            this.numericThreshold2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericThreshold2.ValueChanged += new System.EventHandler(this.numericThreshold2_ValueChanged);
            // 
            // numericCannyKernel
            // 
            this.numericCannyKernel.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericCannyKernel.Location = new System.Drawing.Point(181, 104);
            this.numericCannyKernel.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericCannyKernel.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericCannyKernel.Name = "numericCannyKernel";
            this.numericCannyKernel.Size = new System.Drawing.Size(120, 22);
            this.numericCannyKernel.TabIndex = 2;
            this.numericCannyKernel.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericCannyKernel.ValueChanged += new System.EventHandler(this.numericCannyKernel_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Threshold1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Threshold2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kernel size";
            // 
            // groupBoxLaplacian
            // 
            this.groupBoxLaplacian.Controls.Add(this.label4);
            this.groupBoxLaplacian.Controls.Add(this.label5);
            this.groupBoxLaplacian.Controls.Add(this.label6);
            this.groupBoxLaplacian.Controls.Add(this.numericLaplacianKernel);
            this.groupBoxLaplacian.Controls.Add(this.numericDelta);
            this.groupBoxLaplacian.Controls.Add(this.numericScale);
            this.groupBoxLaplacian.Location = new System.Drawing.Point(3, 179);
            this.groupBoxLaplacian.Name = "groupBoxLaplacian";
            this.groupBoxLaplacian.Size = new System.Drawing.Size(444, 167);
            this.groupBoxLaplacian.TabIndex = 2;
            this.groupBoxLaplacian.TabStop = false;
            this.groupBoxLaplacian.Text = "Laplacian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kernel size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Delta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Scale";
            // 
            // numericLaplacianKernel
            // 
            this.numericLaplacianKernel.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericLaplacianKernel.Location = new System.Drawing.Point(181, 104);
            this.numericLaplacianKernel.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericLaplacianKernel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLaplacianKernel.Name = "numericLaplacianKernel";
            this.numericLaplacianKernel.Size = new System.Drawing.Size(120, 22);
            this.numericLaplacianKernel.TabIndex = 2;
            this.numericLaplacianKernel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLaplacianKernel.ValueChanged += new System.EventHandler(this.numericLaplacianKernel_ValueChanged);
            // 
            // numericDelta
            // 
            this.numericDelta.Location = new System.Drawing.Point(181, 62);
            this.numericDelta.Name = "numericDelta";
            this.numericDelta.Size = new System.Drawing.Size(120, 22);
            this.numericDelta.TabIndex = 1;
            this.numericDelta.ValueChanged += new System.EventHandler(this.numericDelta_ValueChanged);
            // 
            // numericScale
            // 
            this.numericScale.Location = new System.Drawing.Point(181, 22);
            this.numericScale.Name = "numericScale";
            this.numericScale.Size = new System.Drawing.Size(120, 22);
            this.numericScale.TabIndex = 0;
            this.numericScale.ValueChanged += new System.EventHandler(this.numericScale_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBoxCanny);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxLaplacian);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(159, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(447, 349);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // EdgeDetectionParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonOk);
            this.Name = "EdgeDetectionParametersForm";
            this.Text = "EdgeDetectionParametersForm";
            this.groupBoxCanny.ResumeLayout(false);
            this.groupBoxCanny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreshold1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThreshold2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCannyKernel)).EndInit();
            this.groupBoxLaplacian.ResumeLayout(false);
            this.groupBoxLaplacian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLaplacianKernel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScale)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCanny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericCannyKernel;
        private System.Windows.Forms.NumericUpDown numericThreshold2;
        private System.Windows.Forms.NumericUpDown numericThreshold1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBoxLaplacian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericLaplacianKernel;
        private System.Windows.Forms.NumericUpDown numericDelta;
        private System.Windows.Forms.NumericUpDown numericScale;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}