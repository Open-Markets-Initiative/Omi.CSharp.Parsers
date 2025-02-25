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
    public QuoteMessageType QuoteMessageType => Layout.QuoteMessageType.Value;

    /// <summary>
    ///  Indicates The Effect The New Quote Has On The Best Bid Andor The Best Offer
    /// </summary>
    public BboIndicator BboIndicator => Layout.BboIndicator.Value;

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
    public string SecuritySymbolShort => Layout.SecuritySymbolShort.Value;

    /// <summary>
    ///  Expiration Block
    /// </summary>
    public string ExpirationBlock => Layout.ExpirationBlock.Value;

    /// <summary>
    ///  Represents The Stated Price Per Share For Which The Underlying Security May Be Purchased In The Case Of A Call Or Sold In The Case Of A Put By The Option Holder Upon Exercise Of The Option Contract
    /// </summary>
    public ushort StrikePriceShort => Layout.StrikePriceShort.Value;

    /// <summary>
    ///  Represents The Price At Which A Buyer Is Willing To Buy An Option
    /// </summary>
    public short BidPriceShort => Layout.BidPriceShort.Value;

    /// <summary>
    ///  The Bid Size Identifies The Number Of Contracts Being Bought For An Option At The Bid Price
    /// </summary>
    public ushort BidSizeShort => Layout.BidSizeShort.Value;

    /// <summary>
    ///  Represents The Price At Which A Seller Is Offering To Sell An Option
    /// </summary>
    public short OfferPriceShort => Layout.OfferPriceShort.Value;

    /// <summary>
    ///  The Offer Size Identifies The Number Of Contracts For Sale For An Option At The Offer Price
    /// </summary>
    public ushort OfferSizeShort => Layout.OfferSizeShort.Value;

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
};
