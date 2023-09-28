using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  System Text Message
    /// </summary>

    public partial class SystemTextMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TextMessage TextMessage;
            MessageDateTime MessageDateTime;
            TextMessageExtraFld TextMessageExtraFld;
        };
    };
}