using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Final Settlement Futures Price: Number of entries in Market Data message.
    /// </summary>

    public partial class FinalSettlementFuturesPrice
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}