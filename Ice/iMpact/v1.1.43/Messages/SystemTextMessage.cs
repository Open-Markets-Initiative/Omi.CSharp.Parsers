using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  System Text Message: System Text Message
    /// </summary>

    public partial class SystemTextMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public TextMessage TextMessage;
            public MessageDateTime MessageDateTime;
            public TextMessageExtraFld TextMessageExtraFld;
        };
    };
}