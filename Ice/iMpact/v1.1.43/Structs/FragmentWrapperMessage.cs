using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Fragment Wrapper Message
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