using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Long Equity And Index Quote Message
/// </summary>

public partial class LongEquityAndIndexQuoteMessage
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
    public string SecuritySymbol => Fields.SecuritySymbol.Value;

    /// <summary>
    ///  One Reserved Byte
    /// </summary>
    public string Reserved1 => Fields.Reserved1.Value;

    /// <summary>
    ///  Expiration Block
    /// </summary>
    public string ExpirationBlock => Fields.ExpirationBlock.Value;

    /// <summary>
    ///  The Strike Price Denominator Code Field Indicates The Position Of The Floating Decimal Point Within The Strike Price Field
    /// </summary>
    public StrikePriceDenominatorCode StrikePriceDenominatorCode => Fields.StrikePriceDenominatorCode.Value;

    /// <summary>
    ///  Represents The Stated Price Per Share For Which The Underlying Security May Be Purchased In The Case Of A Call Or Sold In The Case Of A Put By The Option Holder Upon Exercise Of The Option Contract
    /// </summary>
    public uint StrikePrice => Fields.StrikePrice.Value;

    /// <summary>
    ///  Represents The First Price Paid For An Option During The Trading Day
    /// </summary>
    public PremiumPriceDenominatorCode PremiumPriceDenominatorCode => Fields.PremiumPriceDenominatorCode.Value;

    /// <summary>
    ///  Represents The Price At Which A Buyer Is Willing To Buy An Option
    /// </summary>
    public int BidPrice => Fields.BidPrice.Value;

    /// <summary>
    ///  The Bid Size Identifies The Number Of Contracts Being Bought For An Option At The Bid Price
    /// </summary>
    public uint BidSize => Fields.BidSize.Value;

    /// <summary>
    ///  Represents The Price At Which A Seller Is Offering To Sell An Option
    /// </summary>
    public int OfferPrice => Fields.OfferPrice.Value;

    /// <summary>
    ///  The Offer Size Identifies The Number Of Contracts For Sale For An Option At The Offer Price
    /// </summary>
    public uint OfferSize => Fields.OfferSize.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public QuoteMessageType QuoteMessageType;
        public BboIndicator BboIndicator;
        public TransactionId TransactionId;
        public ParticipantReferenceNumber ParticipantReferenceNumber;
        public SecuritySymbol SecuritySymbol;
        public Reserved1 Reserved1;
        public ExpirationBlock ExpirationBlock;
        public StrikePriceDenominatorCode StrikePriceDenominatorCode;
        public StrikePrice StrikePrice;
        public PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        public BidPrice BidPrice;
        public BidSize BidSize;
        public OfferPrice OfferPrice;
        public OfferSize OfferSize;
    };

    protected Layout Fields;
};
