using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Fragment Wrapper Message: When multicast messages become too large to fit within a single packet, their serialized content will be split into byte fragments and sent within this Fragment Wrapper Message
    /// </summary>

    public partial class FragmentWrapperMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TotalLength TotalLength;
            FragmentOffset FragmentOffset;
            FragmentLength FragmentLength;
            FragmentBytes FragmentBytes;
        };
    };
}