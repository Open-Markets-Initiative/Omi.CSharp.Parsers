using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Settl Price Type: SettlPriceType bit set
    /// </summary>

    public partial class SettlPriceType
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            NullValue NullValue;
            ReservedBits ReservedBits;
            Intraday Intraday;
            Rounded Rounded;
            Actual Actual;
            FinalDaily FinalDaily;
        };
    };
}