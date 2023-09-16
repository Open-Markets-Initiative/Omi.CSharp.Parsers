using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Fixed Npv: Number of entries in Market Data message.
    /// </summary>

    public partial class FixedNpv
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}