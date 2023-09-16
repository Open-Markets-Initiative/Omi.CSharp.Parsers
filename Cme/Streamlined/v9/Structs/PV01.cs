using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  P V 01: Number of entries in Market Data message.
    /// </summary>

    public partial class PV01
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}