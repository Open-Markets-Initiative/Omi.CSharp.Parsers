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
    ///  Contains The Index Value Using Last Sale Values Of Index Components
    /// </summary>
    public int IndexValue => Layout.IndexValue.Value;

    /// <summary>
    ///  Four Reserved Bytes
    /// </summary>
    public string Reserved4 => Layout.Reserved4.Value;

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
};
