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
    public string SecuritySymbol => Layout.SecuritySymbol.Value;

    /// <summary>
    ///  One Reserved Byte
    /// </summary>
    public string Reserved1 => Layout.Reserved1.Value;

    /// <summary>
    ///  Expiration Block
    /// </summary>
    public string ExpirationBlock => Layout.ExpirationBlock.Value;

    /// <summary>
    ///  The Strike Price Denominator Code Field Indicates The Position Of The Floating Decimal Point Within The Strike Price Field
    /// </summary>
    public StrikePriceDenominatorCode StrikePriceDenominatorCode => Layout.StrikePriceDenominatorCode.Value;

    /// <summary>
    ///  Represents The Stated Price Per Share For Which The Underlying Security May Be Purchased In The Case Of A Call Or Sold In The Case Of A Put By The Option Holder Upon Exercise Of The Option Contract
    /// </summary>
    public uint StrikePrice => Layout.StrikePrice.Value;

    /// <summary>
    ///  Represents The First Price Paid For An Option During The Trading Day
    /// </summary>
    public PremiumPriceDenominatorCode PremiumPriceDenominatorCode => Layout.PremiumPriceDenominatorCode.Value;

    /// <summary>
    ///  Represents The Price At Which A Buyer Is Willing To Buy An Option
    /// </summary>
    public int BidPrice => Layout.BidPrice.Value;

    /// <summary>
    ///  The Bid Size Identifies The Number Of Contracts Being Bought For An Option At The Bid Price
    /// </summary>
    public uint BidSize => Layout.BidSize.Value;

    /// <summary>
    ///  Represents The Price At Which A Seller Is Offering To Sell An Option
    /// </summary>
    public int OfferPrice => Layout.OfferPrice.Value;

    /// <summary>
    ///  The Offer Size Identifies The Number Of Contracts For Sale For An Option At The Offer Price
    /// </summary>
    public uint OfferSize => Layout.OfferSize.Value;

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
};
