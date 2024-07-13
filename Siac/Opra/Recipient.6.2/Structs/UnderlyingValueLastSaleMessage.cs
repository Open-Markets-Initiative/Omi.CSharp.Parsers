using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Underlying Value Last Sale Message
    /// </summary>

    public partial class UnderlyingValueLastSaleMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MessageIndicator MessageIndicator;
            TransactionId TransactionId;
            ParticipantReferenceNumber ParticipantReferenceNumber;
            SecuritySymbol SecuritySymbol;
            Reserved1 Reserved1;
            IndexValueDenominatorCode IndexValueDenominatorCode;
            IndexValue IndexValue;
            Reserved4 Reserved4;
        };
    };
}