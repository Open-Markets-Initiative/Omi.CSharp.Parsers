using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Open Interest Message
/// </summary>

public partial class OpenInterestMessage
{
    /// <summary>
    ///  Message Type
    /// </summary>
    public char MessageType => Fields.MessageType.Value;

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
    ///  Represents The Total Number Of Outstanding Option Contracts That Have Not Been Exercised And Have Not Yet Reached Expiration
    /// </summary>
    public uint OpenInterestVolume => Fields.OpenInterestVolume.Value;

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
        public OpenInterestVolume OpenInterestVolume;
    };

    protected Layout Fields;
};
