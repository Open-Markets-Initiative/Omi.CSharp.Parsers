using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Best Offer Appendage
/// </summary>

public partial class BestOfferAppendage
{
    /// <summary>
    ///  Ascii Character That Identifies The Participant Or Processor That Initiated The Message
    /// </summary>
    public ParticipantId ParticipantId => Layout.ParticipantId.Value;

    /// <summary>
    ///  The Bid Size Identifies The Number Of Contracts Being Bought For An Option At The Bid Price
    /// </summary>
    public string DenominatorCode => Layout.DenominatorCode.Value;

    /// <summary>
    ///  Represents The Price At Which A Buyer Is Willing To Buy An Option
    /// </summary>
    public int Price => Layout.Price.Value;

    /// <summary>
    ///  Identifies The Number Of Contracts Being Bought For An Option At The Price
    /// </summary>
    public uint Size => Layout.Size.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public ParticipantId ParticipantId;
        public DenominatorCode DenominatorCode;
        public Price Price;
        public Size Size;
    };
};
