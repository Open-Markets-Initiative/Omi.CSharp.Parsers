using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Underlying Value Message
    /// </summary>

    public partial class UnderlyingValueMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            UnderlyingValueMessageType UnderlyingValueMessageType;
        };
    };
}