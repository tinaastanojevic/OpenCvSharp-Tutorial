using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaprednoSwe
{
    public enum AdaptiveType
    {
        Mean,
        Gaussian
    }
    public class AdaptiveThresholdParameters
    {
        public AdaptiveType Type { get; set; }
        public float ConstantC { get; set; }
        public int BlockSize { get; set; }
    }
}
