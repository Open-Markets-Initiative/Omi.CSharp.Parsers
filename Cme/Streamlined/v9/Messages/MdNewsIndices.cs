using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md News Indices: MDNewsIndices
    /// </summary>

    public partial class MdNewsIndices
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public Headline Headline;
            public OrigTime OrigTime;
            public MdFeedType MdFeedType;
        };
    };
}