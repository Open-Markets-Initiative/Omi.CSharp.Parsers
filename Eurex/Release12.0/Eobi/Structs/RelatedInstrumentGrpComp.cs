using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Related Instrument Grp Comp
    /// </summary>

    public partial class RelatedInstrumentGrpComp
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            RelatedSecurityId RelatedSecurityId;
        };
    };
}