using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Equity And Index Last Sale Message
/// </summary>

public partial class EquityAndIndexLastSaleMessage
{
    /// <summary>
    ///  Trade Message Type
    /// </summary>
    public TradeMessageType TradeMessageType => Fields.TradeMessageType.Value;

    /// <summary>
    ///  Message Identifier
    /// </summary>
    public char MessageIndicator => Fields.MessageIndicator.Value;

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
    ///  Represents The Total Number Of Contracts Traded For An Option In One Trade Or The Total Number Of Contracts Traded For An Option For The Entire Trading Day
    /// </summary>
    public uint Volume => Fields.Volume.Value;

    /// <summary>
    ///  Represents The First Price Paid For An Option During The Trading Day
    /// </summary>
    public PremiumPriceDenominatorCode PremiumPriceDenominatorCode => Fields.PremiumPriceDenominatorCode.Value;

    /// <summary>
    ///  Represents The Price Of An Option Contract Determined In The Competitive Marketplace Which The Buyer Of The Option Pays To The Option Writer For The Rights Conveyed By The Option Contract
    /// </summary>
    public int PremiumPrice => Fields.PremiumPrice.Value;

    /// <summary>
    ///  For Future Use Filled With Hex 0 X 00
    /// </summary>
    public uint TradeIdentifier => Fields.TradeIdentifier.Value;

    /// <summary>
    ///  Four Reserved Bytes
    /// </summary>
    public string Reserved4 => Fields.Reserved4.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TradeMessageType TradeMessageType;
        public MessageIndicator MessageIndicator;
        public TransactionId TransactionId;
        public ParticipantReferenceNumber ParticipantReferenceNumber;
        public SecuritySymbol SecuritySymbol;
        public Reserved1 Reserved1;
        public ExpirationBlock ExpirationBlock;
        public StrikePriceDenominatorCode StrikePriceDenominatorCode;
        public StrikePrice StrikePrice;
        public Volume Volume;
        public PremiumPriceDenominatorCode PremiumPriceDenominatorCode;
        public PremiumPrice PremiumPrice;
        public TradeIdentifier TradeIdentifier;
        public Reserved4 Reserved4;
    };

    protected Layout Fields;
};
