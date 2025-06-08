using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaprednoSwe
{
    public partial class BlurParametersForm : Form
    {
        private BlurType currentFilter;

        public event Action<BlurParameters> ParametersChanged;
        public BlurParametersForm(BlurType filter)
        {
            InitializeComponent();
            currentFilter = filter;
            showControls();
        }

        private void showControls()
        {
            if (currentFilter == BlurType.Gaussian)
            {
                groupBoxGaussianBlur.Visible = true;
                groupBoxMedian.Visible = false;
                groupBoxBlur.Visible = false;
            }
            else if (currentFilter==BlurType.Median)
            {
                groupBoxGaussianBlur.Visible = false;
                groupBoxMedian.Visible = true;
                groupBoxBlur.Visible = false;
            }
            else
            {
                groupBoxGaussianBlur.Visible = false;
                groupBoxMedian.Visible = false;
                groupBoxBlur.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int GaussianKernelSize
        {
            get { return (int)numericGaussianKernel.Value; }
        }

        public double GaussianSigma
        {
            get { return (double)numericSigma.Value; }
        }

        public int MedianKernelSize
        {
            get { return (int)numericMedianKernelSize.Value; }
        }

        private void buttonBlurOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void numericMedianKernelSize_ValueChanged(object sender, EventArgs e)
        {
            var parameters = new BlurParameters
            {
                Type = currentFilter,
                KernelSize = (int)numericMedianKernelSize.Value,
            };
            ParametersChanged?.Invoke(parameters);

        }

        private void numericGaussianKernel_ValueChanged(object sender, EventArgs e)
        {
            setGaussianBlurParameters();
        }

        private void numericSigma_ValueChanged(object sender, EventArgs e)
        {
            setGaussianBlurParameters();
        }

        private void setGaussianBlurParameters()
        {
            var parameters = new BlurParameters
            {
                Type = currentFilter,
                KernelSize = (int)numericGaussianKernel.Value,
                Sigma = (double)numericSigma.Value
            };
            ParametersChanged?.Invoke(parameters);
        }

        private void numericBoxKernel_ValueChanged(object sender, EventArgs e)
        {
            var parameters = new BlurParameters
            {
                Type = currentFilter,
                KernelSize = (int)numericBoxKernel.Value,
            };
            ParametersChanged?.Invoke(parameters);
        }
    }
}
