using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Equity And Index End Of Day Summary Message
/// </summary>

public partial class EquityAndIndexEndOfDaySummaryMessage
{
    /// <summary>
    ///  Message Type
    /// </summary>
    public string MessageType => Layout.MessageType.Value;

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
    ///  Represents The Total Number Of Contracts Traded For An Option In One Trade Or The Total Number Of Contracts Traded For An Option For The Entire Trading Day
    /// </summary>
    public uint Volume => Layout.Volume.Value;

    /// <summary>
    ///  Represents The Total Number Of Outstanding Option Contracts That Have Not Been Exercised And Have Not Yet Reached Expiration
    /// </summary>
    public uint OpenInterestVolume => Layout.OpenInterestVolume.Value;

    /// <summary>
    ///  Represents The First Price Paid For An Option During The Trading Day
    /// </summary>
    public PremiumPriceDenominatorCode PremiumPriceDenominatorCode => Layout.PremiumPriceDenominatorCode.Value;

    /// <summary>
    ///  Represents The First Price Paid For An Option During The Trading Day
    /// </summary>
    public int OpenPrice => Layout.OpenPrice.Value;

    /// <summary>
    ///  Represents The Highest Price Paid For An Option During The Trading Day
    /// </summary>
    public int HighPrice => Layout.HighPrice.Value;

    /// <summary>
    ///  Represents The Lowest Price Paid For An Option During The Trading Day
    /// </summary>
    public int LowPrice => Layout.LowPrice.Value;

    /// <summary>
    ///  Represents The Last Price Paid For An Option During The Trading Day
    /// </summary>
    public int LastPrice => Layout.LastPrice.Value;

    /// <summary>
    ///  Represents The Change In The Price Of An Option From The Closing Price Of One Day To The Closing Price On The Next Day On Which The Option Is Traded
    /// </summary>
    public int NetChange => Layout.NetChange.Value;

    /// <summary>
    ///  The Underlying Price Denominator Code Field Indicates The Position Of The Floating Decimal Point Within The Underlying Price Field
    /// </summary>
    public UnderlyingPriceDenominatorCode UnderlyingPriceDenominatorCode => Layout.UnderlyingPriceDenominatorCode.Value;

    /// <summary>
    ///  Represents The Price Of The Underlying Security
    /// </summary>
    public long UnderlyingPrice => Layout.UnderlyingPrice.Value;

    /// <summary>
    ///  Represents The Price At Which A Buyer Is Willing To Buy An Option
    /// </summary>
    public int BidPrice => Layout.BidPrice.Value;

    /// <summary>
    ///  Represents The Price At Which A Seller Is Offering To Sell An Option
    /// </summary>
    public int OfferPrice => Layout.OfferPrice.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MessageType MessageType;
        public MessageIndicator MessageIndicator;
        public TransactionId TransactionId;
        public ParticipantReferenceNumber ParticipantReferenceNumber;
        public SecuritySymbol SecuritySymbol;
        public Reserved1 Reserved1;
        public ExpirationBlock ExpirationBlock;
        public StrikePriceDenominatorCode StrikePriceDenominatorCode;
        public StrikePrice StrikePrice;
        public Volume Volume;
        public OpenInterestVolume OpenInterestVolume;
        public PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        public OpenPrice OpenPrice;
        public HighPrice HighPrice;
        public LowPrice LowPrice;
        public LastPrice LastPrice;
        public NetChange NetChange;
        public UnderlyingPriceDenominatorCode UnderlyingPriceDenominatorCode;
        public UnderlyingPrice UnderlyingPrice;
        public BidPrice BidPrice;
        public OfferPrice OfferPrice;
    };
};
