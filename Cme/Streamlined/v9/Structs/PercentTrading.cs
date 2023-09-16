using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Percent Trading: Number of entries in Market Data message
    /// </summary>

    public partial class PercentTrading
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}