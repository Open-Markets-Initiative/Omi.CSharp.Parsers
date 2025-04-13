using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Short Equity And Index Quote Message
/// </summary>

public partial class ShortEquityAndIndexQuoteMessage
{
    /// <summary>
    ///  Quote Message Type
    /// </summary>
    public QuoteMessageType QuoteMessageType => Fields.QuoteMessageType.Value;

    /// <summary>
    ///  Indicates The Effect The New Quote Has On The Best Bid Andor The Best Offer
    /// </summary>
    public BboIndicator BboIndicator => Fields.BboIndicator.Value;

    /// <summary>
    ///  Reserved For Internal Use Only
    /// </summary>
    public uint TransactionId => Fields.TransactionId.Value;

    /// <summary>
    ///  The Prn Is For Optional Use By The Participant
    /// </summary>
    public uint ParticipantReferenceNumber => Fields.ParticipantReferenceNumber.Value;

    /// <summary>
    ///  Identifies The Unique Symbol Assigned To The Underlying Security
    /// </summary>
    public string SecuritySymbolShort => Fields.SecuritySymbolShort.Value;

    /// <summary>
    ///  Expiration Block
    /// </summary>
    public string ExpirationBlock => Fields.ExpirationBlock.Value;

    /// <summary>
    ///  Represents The Stated Price Per Share For Which The Underlying Security May Be Purchased In The Case Of A Call Or Sold In The Case Of A Put By The Option Holder Upon Exercise Of The Option Contract
    /// </summary>
    public ushort StrikePriceShort => Fields.StrikePriceShort.Value;

    /// <summary>
    ///  Represents The Price At Which A Buyer Is Willing To Buy An Option
    /// </summary>
    public short BidPriceShort => Fields.BidPriceShort.Value;

    /// <summary>
    ///  The Bid Size Identifies The Number Of Contracts Being Bought For An Option At The Bid Price
    /// </summary>
    public ushort BidSizeShort => Fields.BidSizeShort.Value;

    /// <summary>
    ///  Represents The Price At Which A Seller Is Offering To Sell An Option
    /// </summary>
    public short OfferPriceShort => Fields.OfferPriceShort.Value;

    /// <summary>
    ///  The Offer Size Identifies The Number Of Contracts For Sale For An Option At The Offer Price
    /// </summary>
    public ushort OfferSizeShort => Fields.OfferSizeShort.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public QuoteMessageType QuoteMessageType;
        public BboIndicator BboIndicator;
        public TransactionId TransactionId;
        public ParticipantReferenceNumber ParticipantReferenceNumber;
        public SecuritySymbolShort SecuritySymbolShort;
        public ExpirationBlock ExpirationBlock;
        public StrikePriceShort StrikePriceShort;
        public BidPriceShort BidPriceShort;
        public BidSizeShort BidSizeShort;
        public OfferPriceShort OfferPriceShort;
        public OfferSizeShort OfferSizeShort;
    };

    protected Layout Fields;
};
