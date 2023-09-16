using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Fed Funds Rate: Number of entries in Market Data message.
    /// </summary>

    public partial class FedFundsRate
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}