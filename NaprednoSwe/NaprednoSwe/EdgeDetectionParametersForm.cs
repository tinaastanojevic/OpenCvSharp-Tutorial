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
    public partial class EdgeDetectionParametersForm : Form
    {
        private EdgeDetectionType currentType;

        public event Action<EdgeDetectionParameters> ParametersChanged;
        public EdgeDetectionParametersForm(EdgeDetectionType type)
        {
            InitializeComponent();
            currentType = type;
            showControls();
        }

        private void showControls()
        {
            if (currentType == EdgeDetectionType.Canny)
            {
                groupBoxCanny.Visible = true;
                groupBoxLaplacian.Visible = false;
         
            }
            else if (currentType == EdgeDetectionType.Laplacian)
            {
                groupBoxCanny.Visible = false;
                groupBoxLaplacian.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericThreshold1_ValueChanged(object sender, EventArgs e)
        {
            sendCannyParameters();
        }

        private void numericThreshold2_ValueChanged(object sender, EventArgs e)
        {
            sendCannyParameters();
        }

        private void numericCannyKernel_ValueChanged(object sender, EventArgs e)
        {
            sendCannyParameters();
        }

        private void sendCannyParameters()
        {
            var parameters = new EdgeDetectionParameters
            {
                Type = currentType,
                KernelSize = (int)numericCannyKernel.Value,
                Threshold1 = (double)numericThreshold1.Value,
                Threshold2 = (double)numericThreshold2.Value
            };
            ParametersChanged?.Invoke(parameters);
        }

        private void numericScale_ValueChanged(object sender, EventArgs e)
        {
            sendLaplacianParameters();
        }

        private void numericDelta_ValueChanged(object sender, EventArgs e)
        {
            sendLaplacianParameters();
        }

        private void numericLaplacianKernel_ValueChanged(object sender, EventArgs e)
        {
            sendLaplacianParameters();
        }

        private void sendLaplacianParameters()
        {
            var parameters = new EdgeDetectionParameters
            {
                Type = currentType,
                KernelSize = (int)numericCannyKernel.Value,
                Delta = (double)numericDelta.Value,
                Scale = (double)numericScale.Value
            };
            ParametersChanged?.Invoke(parameters);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
