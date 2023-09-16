using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  D V 01: Number of entries in Market Data message.
    /// </summary>

    public partial class DV01
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}