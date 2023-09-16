using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Previous Fixing Rate: Number of legs (repeating groups)
    /// </summary>

    public partial class PreviousFixingRate
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}