using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Message
    /// </summary>

    public partial class Message
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            ParticipantId ParticipantId;
            MessageCategory MessageCategory;
        };
    };
}