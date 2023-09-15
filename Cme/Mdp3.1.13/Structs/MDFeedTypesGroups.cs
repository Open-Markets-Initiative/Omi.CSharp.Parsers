using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  M D Feed Types Groups: Number of repeating FeedType entries Block
    /// </summary>

    public partial class MDFeedTypesGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}