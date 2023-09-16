using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Leg Contract Multiplier: Number of entries in Market Data message.
    /// </summary>

    public partial class LegContractMultiplier
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Mantissa Mantissa;
            Exponent Exponent;
        };
    };
}