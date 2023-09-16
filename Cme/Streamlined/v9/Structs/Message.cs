using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Message
    /// </summary>

    public partial class Message
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MessageSize MessageSize;
            MessageHeader MessageHeader;
        };
    };
}