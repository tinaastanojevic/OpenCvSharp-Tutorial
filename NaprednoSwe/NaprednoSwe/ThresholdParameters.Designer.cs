
namespace NaprednoSwe
{
    partial class ThresholdParameters
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericConstantC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericBlockSize = new System.Windows.Forms.NumericUpDown();
            this.buttonBlurOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericConstantC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlockSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericConstantC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericBlockSize);
            this.groupBox1.Location = new System.Drawing.Point(228, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adaptive Threshold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Constant C";
            // 
            // numericConstantC
            // 
            this.numericConstantC.Location = new System.Drawing.Point(91, 73);
            this.numericConstantC.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericConstantC.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numericConstantC.Name = "numericConstantC";
            this.numericConstantC.Size = new System.Drawing.Size(120, 22);
            this.numericConstantC.TabIndex = 10;
            this.numericConstantC.ValueChanged += new System.EventHandler(this.numericConstantC_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Block size";
            // 
            // numericBlockSize
            // 
            this.numericBlockSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericBlockSize.Location = new System.Drawing.Point(91, 30);
            this.numericBlockSize.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericBlockSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericBlockSize.Name = "numericBlockSize";
            this.numericBlockSize.Size = new System.Drawing.Size(120, 22);
            this.numericBlockSize.TabIndex = 0;
            this.numericBlockSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericBlockSize.ValueChanged += new System.EventHandler(this.numericBlockSize_ValueChanged);
            // 
            // buttonBlurOk
            // 
            this.buttonBlurOk.Location = new System.Drawing.Point(601, 249);
            this.buttonBlurOk.Name = "buttonBlurOk";
            this.buttonBlurOk.Size = new System.Drawing.Size(72, 43);
            this.buttonBlurOk.TabIndex = 9;
            this.buttonBlurOk.Text = "Ok";
            this.buttonBlurOk.UseVisualStyleBackColor = true;
            this.buttonBlurOk.Click += new System.EventHandler(this.buttonBlurOk_Click);
            // 
            // ThresholdParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBlurOk);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThresholdParameters";
            this.Text = "ThresholdParameters";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericConstantC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlockSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericConstantC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericBlockSize;
        private System.Windows.Forms.Button buttonBlurOk;
    }
}