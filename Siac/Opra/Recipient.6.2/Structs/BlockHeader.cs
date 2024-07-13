using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Block Header
    /// </summary>

    public partial class BlockHeader
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Version Version;
            BlockSize BlockSize;
            DataFeedIndicator DataFeedIndicator;
            RetransmissionIndicator RetransmissionIndicator;
            SessionIndicator SessionIndicator;
            BlockSequenceNumber BlockSequenceNumber;
            MessagesInBlock MessagesInBlock;
            BlockTimestamp BlockTimestamp;
            BlockChecksum BlockChecksum;
        };
    };
}