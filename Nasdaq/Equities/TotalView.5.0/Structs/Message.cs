using System.Runtime.InteropServices;

namespace Nasdaq.TotalView
{
    /// <summary>
    ///  Message
    /// </summary>

    public partial class Message
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MessageHeader MessageHeader;
        };
    };
}