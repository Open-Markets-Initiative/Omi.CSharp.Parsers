using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Fragment Wrapper Message: When multicast messages become too large to fit within a single packet, their serialized content will be split into byte fragments and sent within this Fragment Wrapper Message
/// </summary>

public partial class FragmentWrapperMessage
{
    /// <summary>
    ///  The total length of the fragmented message.
    /// </summary>
    public short TotalLength => Fields.TotalLength.Value;

    /// <summary>
    ///  The index of the byte where this fragment starts within the total length of the fragmented message.
    /// </summary>
    public short FragmentOffset => Fields.FragmentOffset.Value;

    /// <summary>
    ///  The number of bytes in this fragment
    /// </summary>
    public short FragmentLength => Fields.FragmentLength.Value;

    /// <summary>
    ///  The serialized bytes of the fragmented message
    /// </summary>
    public string FragmentBytes => Fields.FragmentBytes.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TotalLength TotalLength;
        public FragmentOffset FragmentOffset;
        public FragmentLength FragmentLength;
        public FragmentBytes FragmentBytes;
    };

    protected Layout Fields;
};
