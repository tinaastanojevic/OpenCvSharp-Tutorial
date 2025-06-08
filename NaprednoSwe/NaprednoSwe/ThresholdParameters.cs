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
    public partial class ThresholdParameters : Form
    {
        public event Action<AdaptiveThresholdParameters> ParametersChanged;
        public AdaptiveType adaptiveType;
        public ThresholdParameters(AdaptiveType type)
        {
            InitializeComponent();
            adaptiveType = type;
        }

        private void buttonBlurOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void numericBlockSize_ValueChanged(object sender, EventArgs e)
        {
            int blockSize = (int)numericBlockSize.Value;
            if (blockSize % 2 == 0)
            {
                blockSize--;
            }
            setParameters(blockSize, (float)numericConstantC.Value);
        }

        private void numericConstantC_ValueChanged(object sender, EventArgs e)
        {
            setParameters((int)numericBlockSize.Value, (float)numericConstantC.Value);
        }

        private void setParameters(int blockSize, float constantC)
        {
            var parameters = new AdaptiveThresholdParameters
            {
                Type = adaptiveType,
                BlockSize = blockSize,
                ConstantC = constantC
            };
            ParametersChanged?.Invoke(parameters);
        }
    }
}
