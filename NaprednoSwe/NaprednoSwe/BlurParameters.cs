using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaprednoSwe
{
    public enum BlurType
    {
        Gaussian,
        Median,
        Box
    }
    public class BlurParameters
    {
        public BlurType Type { get; set; }
        public int KernelSize { get; set; }
        public double? Sigma { get; set; }

        public BlurParameters()
        {
            KernelSize = 3;
            Sigma = 0;
        }
    }
}
