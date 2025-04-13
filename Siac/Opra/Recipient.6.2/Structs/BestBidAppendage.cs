using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Best Bid Appendage
/// </summary>

public partial class BestBidAppendage
{
    /// <summary>
    ///  Ascii Character That Identifies The Participant Or Processor That Initiated The Message
    /// </summary>
    public ParticipantId ParticipantId => Fields.ParticipantId.Value;

    /// <summary>
    ///  The Bid Size Identifies The Number Of Contracts Being Bought For An Option At The Bid Price
    /// </summary>
    public char DenominatorCode => Fields.DenominatorCode.Value;

    /// <summary>
    ///  Represents The Price At Which A Buyer Is Willing To Buy An Option
    /// </summary>
    public int Price => Fields.Price.Value;

    /// <summary>
    ///  Identifies The Number Of Contracts Being Bought For An Option At The Price
    /// </summary>
    public uint Size => Fields.Size.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public ParticipantId ParticipantId;
        public DenominatorCode DenominatorCode;
        public Price Price;
        public Size Size;
    };

    protected Layout Fields;
};
