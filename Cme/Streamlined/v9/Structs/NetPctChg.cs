using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Net Pct Chg: Number of entries in Market Data message
    /// </summary>

    public partial class NetPctChg
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}