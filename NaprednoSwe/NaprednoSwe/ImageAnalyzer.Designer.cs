
namespace NaprednoSwe
{
    partial class ImageAnalyzer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorModels = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otsuThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaptiveThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaptiveMeanThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelCombinedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findContoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faceDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxEdited = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdited)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuColorModels,
            this.blurToolStripMenuItem,
            this.thresholdToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.findContoursToolStripMenuItem,
            this.faceDetectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem1,
            this.saveImageToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // openImageToolStripMenuItem1
            // 
            this.openImageToolStripMenuItem1.Name = "openImageToolStripMenuItem1";
            this.openImageToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.openImageToolStripMenuItem1.Text = "Open Image";
            this.openImageToolStripMenuItem1.Click += new System.EventHandler(this.openImageToolStripMenuItem1_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // menuColorModels
            // 
            this.menuColorModels.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.hSVToolStripMenuItem});
            this.menuColorModels.Name = "menuColorModels";
            this.menuColorModels.Size = new System.Drawing.Size(112, 24);
            this.menuColorModels.Text = "Color Models";
            this.menuColorModels.Click += new System.EventHandler(this.menuColorModels_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // hSVToolStripMenuItem
            // 
            this.hSVToolStripMenuItem.Name = "hSVToolStripMenuItem";
            this.hSVToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.hSVToolStripMenuItem.Text = "HSV";
            this.hSVToolStripMenuItem.Click += new System.EventHandler(this.hSVToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussianBlurToolStripMenuItem,
            this.medianBlurToolStripMenuItem,
            this.boxBlurToolStripMenuItem});
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.blurToolStripMenuItem.Text = "Blur";
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            // 
            // medianBlurToolStripMenuItem
            // 
            this.medianBlurToolStripMenuItem.Name = "medianBlurToolStripMenuItem";
            this.medianBlurToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.medianBlurToolStripMenuItem.Text = "Median Blur";
            this.medianBlurToolStripMenuItem.Click += new System.EventHandler(this.medianBlurToolStripMenuItem_Click);
            // 
            // boxBlurToolStripMenuItem
            // 
            this.boxBlurToolStripMenuItem.Name = "boxBlurToolStripMenuItem";
            this.boxBlurToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.boxBlurToolStripMenuItem.Text = "Box Blur";
            this.boxBlurToolStripMenuItem.Click += new System.EventHandler(this.boxBlurToolStripMenuItem_Click);
            // 
            // thresholdToolStripMenuItem
            // 
            this.thresholdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otsuThresholdToolStripMenuItem,
            this.adaptiveThresholdToolStripMenuItem,
            this.adaptiveMeanThresholdToolStripMenuItem});
            this.thresholdToolStripMenuItem.Name = "thresholdToolStripMenuItem";
            this.thresholdToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.thresholdToolStripMenuItem.Text = "Threshold";
            // 
            // otsuThresholdToolStripMenuItem
            // 
            this.otsuThresholdToolStripMenuItem.Name = "otsuThresholdToolStripMenuItem";
            this.otsuThresholdToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.otsuThresholdToolStripMenuItem.Text = "Otsu Threshold";
            this.otsuThresholdToolStripMenuItem.Click += new System.EventHandler(this.otsuThresholdToolStripMenuItem_Click);
            // 
            // adaptiveThresholdToolStripMenuItem
            // 
            this.adaptiveThresholdToolStripMenuItem.Name = "adaptiveThresholdToolStripMenuItem";
            this.adaptiveThresholdToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.adaptiveThresholdToolStripMenuItem.Text = "Adaptive Gaussian Threshold";
            this.adaptiveThresholdToolStripMenuItem.Click += new System.EventHandler(this.adaptiveThresholdToolStripMenuItem_Click);
            // 
            // adaptiveMeanThresholdToolStripMenuItem
            // 
            this.adaptiveMeanThresholdToolStripMenuItem.Name = "adaptiveMeanThresholdToolStripMenuItem";
            this.adaptiveMeanThresholdToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.adaptiveMeanThresholdToolStripMenuItem.Text = "Adaptive Mean Threshold";
            this.adaptiveMeanThresholdToolStripMenuItem.Click += new System.EventHandler(this.adaptiveMeanThresholdToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cannyToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.laplacianToolStripMenuItem});
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobelHorizontalToolStripMenuItem,
            this.sobelVerticalToolStripMenuItem,
            this.sobelCombinedToolStripMenuItem});
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // sobelHorizontalToolStripMenuItem
            // 
            this.sobelHorizontalToolStripMenuItem.Name = "sobelHorizontalToolStripMenuItem";
            this.sobelHorizontalToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.sobelHorizontalToolStripMenuItem.Text = "Sobel Horizontal";
            this.sobelHorizontalToolStripMenuItem.Click += new System.EventHandler(this.sobelHorizontalToolStripMenuItem_Click);
            // 
            // sobelVerticalToolStripMenuItem
            // 
            this.sobelVerticalToolStripMenuItem.Name = "sobelVerticalToolStripMenuItem";
            this.sobelVerticalToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.sobelVerticalToolStripMenuItem.Text = "Sobel Vertical";
            this.sobelVerticalToolStripMenuItem.Click += new System.EventHandler(this.sobelVerticalToolStripMenuItem_Click);
            // 
            // sobelCombinedToolStripMenuItem
            // 
            this.sobelCombinedToolStripMenuItem.Name = "sobelCombinedToolStripMenuItem";
            this.sobelCombinedToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.sobelCombinedToolStripMenuItem.Text = "Sobel Combined";
            this.sobelCombinedToolStripMenuItem.Click += new System.EventHandler(this.sobelCombinedToolStripMenuItem_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // findContoursToolStripMenuItem
            // 
            this.findContoursToolStripMenuItem.Name = "findContoursToolStripMenuItem";
            this.findContoursToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.findContoursToolStripMenuItem.Text = "Find Contours";
            this.findContoursToolStripMenuItem.Click += new System.EventHandler(this.findContoursToolStripMenuItem_Click);
            // 
            // faceDetectionToolStripMenuItem
            // 
            this.faceDetectionToolStripMenuItem.Name = "faceDetectionToolStripMenuItem";
            this.faceDetectionToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.faceDetectionToolStripMenuItem.Text = "Face Detection";
            this.faceDetectionToolStripMenuItem.Click += new System.EventHandler(this.faceDetectionToolStripMenuItem_Click);
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(410, 452);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 1;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxEdited
            // 
            this.pictureBoxEdited.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxEdited.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEdited.Name = "pictureBoxEdited";
            this.pictureBoxEdited.Size = new System.Drawing.Size(409, 452);
            this.pictureBoxEdited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEdited.TabIndex = 2;
            this.pictureBoxEdited.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxOriginal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxEdited);
            this.splitContainer1.Size = new System.Drawing.Size(820, 452);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // ImageAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 480);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImageAnalyzer";
            this.Text = "Image Analyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageAnalyzer_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdited)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuColorModels;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxEdited;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otsuThresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaptiveThresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaptiveMeanThresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelCombinedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findContoursToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem faceDetectionToolStripMenuItem;
    }
}

