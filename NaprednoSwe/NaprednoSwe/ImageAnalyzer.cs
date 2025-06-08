using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaprednoSwe
{
    public partial class ImageAnalyzer : Form
    {

        private OpenFileDialog openFileDialog;
        private Mat originalImage;
        private Bitmap bitmapImage;
        private Mat editedImage;


        public ImageAnalyzer()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            originalImage = new Mat();
            editedImage = new Mat();

        }

        private void openImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string combinedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Resources");
            openFileDialog.InitialDirectory = Path.GetFullPath(combinedPath);

            openFileDialog.Filter = "Photos (*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.jfif;*.webp)|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.jfif;*.webp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = Cv2.ImRead(openFileDialog.FileName);
                bitmapImage = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(originalImage);
                pictureBoxOriginal.Image = bitmapImage;
                pictureBoxEdited.Image = bitmapImage;
            }
            else
            {
                MessageBox.Show("Unable to open an image!");
            }
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxEdited.Image != null)
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Select a location to save the image";

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string folderPath = folderBrowserDialog.SelectedPath;
                        string imageName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                        imageName += ".png";
                        string fullPath = Path.Combine(folderPath, imageName);

                        if (pictureBoxEdited.Image is Bitmap bitmap)
                        {
                            using (Mat mat = OpenCvSharp.Extensions.BitmapConverter.ToMat(bitmap))
                            {
                                Cv2.ImWrite(fullPath, mat);
                            }
                            MessageBox.Show("Image is saved!");
                        }
                    }
                    else
                        MessageBox.Show("No location selected for saving.");
                }
            }
            else
                MessageBox.Show("No image available for saving.");
        }

        private void menuColorModels_Click(object sender, EventArgs e)
        {

        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
                OpenParametersForm(BlurType.Gaussian);
        }

        private void medianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
                OpenParametersForm(BlurType.Median);
        }

        private void boxBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
                OpenParametersForm(BlurType.Box);
        }

        private void OpenParametersForm(BlurType selectedFilter)
        {
            var parametersForm = new BlurParametersForm(selectedFilter);

            parametersForm.ParametersChanged += (parameters) =>
            {
                ApplyBlur(parameters);
            };

            parametersForm.Show();

        }

        private void ApplyBlur(BlurParameters parameters)
        {
            if (isImageAvailable())
            {
                switch (parameters.Type)
                {
                    case BlurType.Gaussian:
                        Cv2.GaussianBlur(originalImage, editedImage, new OpenCvSharp.Size(parameters.KernelSize, parameters.KernelSize), (double)parameters.Sigma);
                        break;
                    case BlurType.Median:
                        Cv2.MedianBlur(originalImage, editedImage, parameters.KernelSize);
                        break;
                    case BlurType.Box:
                        Cv2.Blur(originalImage, editedImage, new OpenCvSharp.Size(parameters.KernelSize, parameters.KernelSize));
                        break;
                }

                setEditedImage();
            }
        }

        private void otsuThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
            {
                Cv2.Threshold(getGrayscale(), editedImage, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);

                setEditedImage();
            }
        }

        private void adaptiveMeanThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
                OpenThresholdParametersForm(AdaptiveType.Mean);
        }
        private void adaptiveThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
                OpenThresholdParametersForm(AdaptiveType.Gaussian);
        }

        private void OpenThresholdParametersForm(AdaptiveType type)
        {
            var thresholdParameterForm = new ThresholdParameters(type);

            thresholdParameterForm.ParametersChanged += (parameters) =>
            {
                ApplyThreshold(parameters);
            };

            thresholdParameterForm.Show();
        }

        private void ApplyThreshold(AdaptiveThresholdParameters parameters)
        {
            Mat grayImage = getGrayscale();

            if (parameters.Type == AdaptiveType.Mean)
                Cv2.AdaptiveThreshold(grayImage, editedImage, 255, AdaptiveThresholdTypes.MeanC, ThresholdTypes.Binary, parameters.BlockSize, parameters.ConstantC);
            else
                Cv2.AdaptiveThreshold(grayImage, editedImage, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, parameters.BlockSize, parameters.ConstantC);

            setEditedImage();
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
            {
                editedImage = getGrayscale();
                setEditedImage();
            }

        }

        private bool isImageAvailable()
        {
            if (originalImage == null || originalImage.Empty())
            {
                MessageBox.Show("No image available for editing.");
                return false;
            }
            return true;
        }

        private void setEditedImage()
        {
            pictureBoxEdited.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(editedImage);
        }

        private void hSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
            {
                Cv2.CvtColor(originalImage, editedImage, ColorConversionCodes.BGR2HSV);
                setEditedImage();
            }

        }

        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
            {
                Cv2.CvtColor(originalImage, editedImage, ColorConversionCodes.BGR2RGB);
                setEditedImage();

            }
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
            {
                OpenEdgeDetectionParametersForm(EdgeDetectionType.Canny);
            }

        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
            {
                OpenEdgeDetectionParametersForm(EdgeDetectionType.Laplacian);
            }
        }

        private void OpenEdgeDetectionParametersForm(EdgeDetectionType type)
        {
            var edgeDetectionParametersForm = new EdgeDetectionParametersForm(type);

            edgeDetectionParametersForm.ParametersChanged += (parameters) =>
            {
                ApplyEdgeDetection(parameters);
            };

            edgeDetectionParametersForm.Show();
        }

        private void ApplyEdgeDetection(EdgeDetectionParameters parameters)
        {
            if (parameters.Type == EdgeDetectionType.Canny)
                Cv2.Canny(getGrayscale(), editedImage, (double)parameters.Threshold1, (double)parameters.Threshold2, parameters.KernelSize);
            else
                Cv2.Laplacian(getGrayscale(), editedImage, MatType.CV_8U, parameters.KernelSize, (double)parameters.Scale, (double)parameters.Delta);

            setEditedImage();
        }

        private Mat getGrayscale()
        {
            Mat gray = new Mat();
            Cv2.CvtColor(originalImage, gray, ColorConversionCodes.BGR2GRAY);
            return gray;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobelHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
            {
                editedImage = sobelHorizontal();
                setEditedImage();
            }
        }

        private Mat sobelHorizontal()
        {
            Mat sobelY = new Mat();
            Cv2.Sobel(getGrayscale(), sobelY, MatType.CV_8U, 0, 1);
            return sobelY;
        }



        private void sobelVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
            {
                editedImage = sobelVertical();
                setEditedImage();
            }
        }
        private Mat sobelVertical()
        {
            Mat sobelX = new Mat();
            Cv2.Sobel(getGrayscale(), sobelX, MatType.CV_8U, 1, 0);
            return sobelX;
        }

        private void sobelCombinedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
            {
                Mat sobelX = sobelVertical();
                Mat sobelY = sobelHorizontal();
                Cv2.AddWeighted(sobelX, 0.5, sobelY, 0.5, 0, editedImage);
                setEditedImage();
            }

        }

        private void findContoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
            {
                Mat contourImage = Mat.Zeros(originalImage.Size(), MatType.CV_8UC3);
                Cv2.FindContours(editedImage, out OpenCvSharp.Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);


                Scalar color = new Scalar(255, 0, 0);
                for (int i = 0; i < contours.Length; i++)
                {

                    Cv2.DrawContours(contourImage, contours, i, color, 2, LineTypes.Link8, hierarchy, 0);
                }

                pictureBoxEdited.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(contourImage);

            }
        }

        private void faceDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageAvailable())
            {
                editedImage = originalImage.Clone();
                string modelPath = Path.Combine(Application.StartupPath, "Models", "haarcascade_frontalface_default.xml");
                if (!File.Exists(modelPath))
                {
                    MessageBox.Show("Face detection model not found!");
                    return;
                }

                var faceCascade = new CascadeClassifier(modelPath);

                Rect[] faces = faceCascade.DetectMultiScale(getGrayscale(), 1.1, 5);

                if (faces.Length == 0)
                {
                    MessageBox.Show("No faces were detected in the image.");
                    return;
                }


                foreach (var face in faces)
                {
                    Cv2.Rectangle(editedImage, face, Scalar.Red, 2);
                }

                setEditedImage();
            }
        }

        private void ImageAnalyzer_FormClosing(object sender, FormClosingEventArgs e)
        {
            originalImage?.Dispose();
            editedImage?.Dispose();
        }
    }
}



