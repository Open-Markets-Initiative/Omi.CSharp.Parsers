using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Open Interest Message
    /// </summary>

    public partial class OpenInterestMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MessageType MessageType;
            MessageIndicator MessageIndicator;
            TransactionId TransactionId;
            ParticipantReferenceNumber ParticipantReferenceNumber;
            SecuritySymbol SecuritySymbol;
            Reserved1 Reserved1;
            ExpirationBlock ExpirationBlock;
            StrikePriceDenominatorCode StrikePriceDenominatorCode;
            StrikePrice StrikePrice;
            OpenInterestVolume OpenInterestVolume;
        };
    };
}