using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Interpolation Factor: Number of legs (repeating groups)
    /// </summary>

    public partial class InterpolationFactor
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}