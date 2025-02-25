using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Underlying Value Bid And Offer Message
/// </summary>

public partial class UnderlyingValueBidAndOfferMessage
{
    /// <summary>
    ///  Message Identifier
    /// </summary>
    public string MessageIndicator => Layout.MessageIndicator.Value;

    /// <summary>
    ///  Reserved For Internal Use Only
    /// </summary>
    public uint TransactionId => Layout.TransactionId.Value;

    /// <summary>
    ///  The Prn Is For Optional Use By The Participant
    /// </summary>
    public uint ParticipantReferenceNumber => Layout.ParticipantReferenceNumber.Value;

    /// <summary>
    ///  Identifies The Unique Symbol Assigned To The Underlying Security
    /// </summary>
    public string SecuritySymbol => Layout.SecuritySymbol.Value;

    /// <summary>
    ///  One Reserved Byte
    /// </summary>
    public string Reserved1 => Layout.Reserved1.Value;

    /// <summary>
    ///  Contains The Index Value Using Last Sale Values Of Index Components
    /// </summary>
    public IndexValueDenominatorCode IndexValueDenominatorCode => Layout.IndexValueDenominatorCode.Value;

    /// <summary>
    ///  The Bid Index Value Represents The Value Of The Indexs Calculation Formula Using The Current Bid Values Of The Component Securities
    /// </summary>
    public int BidIndexValue => Layout.BidIndexValue.Value;

    /// <summary>
    ///  The Offer Index Value Represents The Value Of The Indexs Calculation Formula Using The Current Offer Values Of The Component Securities
    /// </summary>
    public long OfferIndexValue => Layout.OfferIndexValue.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MessageIndicator MessageIndicator;
        public TransactionId TransactionId;
        public ParticipantReferenceNumber ParticipantReferenceNumber;
        public SecuritySymbol SecuritySymbol;
        public Reserved1 Reserved1;
        public IndexValueDenominatorCode IndexValueDenominatorCode;
        public BidIndexValue BidIndexValue;
        public OfferIndexValue OfferIndexValue;
    };
};
