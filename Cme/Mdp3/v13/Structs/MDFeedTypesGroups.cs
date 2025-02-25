using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Feed Types Groups: Number of repeating FeedType entries Block
/// </summary>

public partial class MDFeedTypesGroups
{
    /// <summary>
    ///  Repeating group dimensions
    /// </summary>
    public string GroupSize => Layout.GroupSize.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public GroupSize GroupSize;
    };
};
