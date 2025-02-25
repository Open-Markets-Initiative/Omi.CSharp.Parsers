using System.Runtime.InteropServices;

namespace Iex.Deep
{
    /// <summary>
    ///  Security Event Message: The Security Event Message is used to indicate events that apply to a security
    /// </summary>

    public partial class SecurityEventMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SecurityEvent SecurityEvent;
            public Timestamp Timestamp;
            public Symbol Symbol;
        };
    };
}