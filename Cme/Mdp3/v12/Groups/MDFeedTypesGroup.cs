using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Feed Types Group: Number of repeating FeedType entries
/// </summary>

public partial class MDFeedTypesGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MdFeedType MdFeedType;
        public MarketDepth MarketDepth;
    };
};
