using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaprednoSwe
{
    public enum EdgeDetectionType
    {
        Canny,
        Laplacian
    }
    public class EdgeDetectionParameters
    {
        public EdgeDetectionType Type { get; set; }

        public int KernelSize { get; set; }

        public double? Threshold1 { get; set; }

        public double? Threshold2 { get; set; }

        public double? Delta { get; set; }
        public double? Scale { get; set; }
    }
}
