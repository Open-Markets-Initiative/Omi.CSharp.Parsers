using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Message
    /// </summary>

    public partial class Message
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MessageHeaderComp MessageHeaderComp;
        };
    };
}