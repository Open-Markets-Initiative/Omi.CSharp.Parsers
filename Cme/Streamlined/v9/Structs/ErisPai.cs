using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Eris Pai: Number of entries in Market Data message.
    /// </summary>

    public partial class ErisPai
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}