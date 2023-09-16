using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Net Chg Prev Day: Number of entries in Market Data message
    /// </summary>

    public partial class NetChgPrevDay
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}