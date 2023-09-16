using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Next Floating Payment Amount: Number of entries in Market Data message.
    /// </summary>

    public partial class NextFloatingPaymentAmount
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}