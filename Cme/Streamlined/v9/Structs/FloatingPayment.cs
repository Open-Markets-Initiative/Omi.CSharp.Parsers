using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Floating Payment: Number of entries in Market Data message.
    /// </summary>

    public partial class FloatingPayment
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}