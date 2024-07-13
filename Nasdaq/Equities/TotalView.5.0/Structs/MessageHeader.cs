using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Message Header
    /// </summary>

    public partial class MessageHeader
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Length Length;
            MessageType MessageType;
        };
    };
}