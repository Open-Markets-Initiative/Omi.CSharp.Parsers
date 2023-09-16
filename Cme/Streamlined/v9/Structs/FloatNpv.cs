using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Float Npv: Number of entries in Market Data message.
    /// </summary>

    public partial class FloatNpv
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}