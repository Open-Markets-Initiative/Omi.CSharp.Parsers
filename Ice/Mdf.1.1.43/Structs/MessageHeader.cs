using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Message Header
    /// </summary>

    public partial class MessageHeader
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MessageType MessageType;
            Length Length;
        };
    };
}