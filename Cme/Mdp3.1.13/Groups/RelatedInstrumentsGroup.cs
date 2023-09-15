using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Related Instruments Group: Number of related instruments group
    /// </summary>

    public partial class RelatedInstrumentsGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            RelatedSecurityId RelatedSecurityId;
            RelatedSymbol RelatedSymbol;
        };
    };
}