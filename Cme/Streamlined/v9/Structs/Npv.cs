using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Npv: Number of entries in Market Data message.
    /// </summary>

    public partial class Npv
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}