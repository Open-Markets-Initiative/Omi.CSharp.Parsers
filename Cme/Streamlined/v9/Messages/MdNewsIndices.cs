using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Md News Indices: MDNewsIndices
/// </summary>

public partial class MdNewsIndices
{
    /// <summary>
    ///  The headline of a News  message.
    /// </summary>
    public string Headline => Fields.Headline.Value;

    /// <summary>
    ///  Time of message origination expressed as number of nanoseconds since unix epoch
    /// </summary>
    public ulong OrigTime => Fields.OrigTime.Value;

    /// <summary>
    ///  Describes a class of service for a given data feed.
    /// </summary>
    public string MdFeedType => Fields.MdFeedType.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Headline Headline;
        public OrigTime OrigTime;
        public MdFeedType MdFeedType;
    };

    protected Layout Fields;
};
