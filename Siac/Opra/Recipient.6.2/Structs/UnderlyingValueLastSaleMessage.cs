using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Underlying Value Last Sale Message
/// </summary>

public partial class UnderlyingValueLastSaleMessage
{
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
    ///  Contains The Index Value Using Last Sale Values Of Index Components
    /// </summary>
    public IndexValueDenominatorCode IndexValueDenominatorCode => Fields.IndexValueDenominatorCode.Value;

    /// <summary>
    ///  Contains The Index Value Using Last Sale Values Of Index Components
    /// </summary>
    public int IndexValue => Fields.IndexValue.Value;

    /// <summary>
    ///  Four Reserved Bytes
    /// </summary>
    public string Reserved4 => Fields.Reserved4.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MessageIndicator MessageIndicator;
        public TransactionId TransactionId;
        public ParticipantReferenceNumber ParticipantReferenceNumber;
        public SecuritySymbol SecuritySymbol;
        public Reserved1 Reserved1;
        public IndexValueDenominatorCode IndexValueDenominatorCode;
        public IndexValue IndexValue;
        public Reserved4 Reserved4;
    };

    protected Layout Fields;
};
