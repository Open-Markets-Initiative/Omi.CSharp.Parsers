using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  M D Feed Types Group: Number of feed type repeating group entries.
    /// </summary>

    public partial class MDFeedTypesGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MdFeedType3 MdFeedType3;
            public MarketDepth MarketDepth;
        };
    };
}