using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Related Instruments Groups: Number of related instruments group Block
    /// </summary>

    public partial class RelatedInstrumentsGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}