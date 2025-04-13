using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Best Bid And Offer Appendage
/// </summary>

public partial class BestBidAndOfferAppendage
{
    /// <summary>
    ///  Identifies The Participant That Entered The Best Bid
    /// </summary>
    public BestBidParticipantId BestBidParticipantId => Fields.BestBidParticipantId.Value;

    /// <summary>
    ///  The Bed Bid Denominator Code Field Indicates The Position Of The Floating Decimal Point Within The Best Bid Price Field
    /// </summary>
    public BestBidDenominatorCode BestBidDenominatorCode => Fields.BestBidDenominatorCode.Value;

    /// <summary>
    ///  Represents The Best Price At Which A Buyer Is Willing To Buy An Option
    /// </summary>
    public int BestBidPrice => Fields.BestBidPrice.Value;

    /// <summary>
    ///  The Best Bid Size Identifies The Number Of Contracts Being Bought For An Option At The Best Bid Price
    /// </summary>
    public uint BestBidSize => Fields.BestBidSize.Value;

    /// <summary>
    ///  Identifies The Participant That Entered The Best Bid
    /// </summary>
    public BestOfferParticipantId BestOfferParticipantId => Fields.BestOfferParticipantId.Value;

    /// <summary>
    ///  The Bed Offer Denominator Code Field Indicates The Position Of The Floating Decimal Point Within The Best Offer Price Field
    /// </summary>
    public BestOfferDenominatorCode BestOfferDenominatorCode => Fields.BestOfferDenominatorCode.Value;

    /// <summary>
    ///  Represents The Best Price At Which A Seller Is Offering To Sell An Option
    /// </summary>
    public int BestOfferPrice => Fields.BestOfferPrice.Value;

    /// <summary>
    ///  The Best Offer Size Identifies The Number Of Contracts Being Bought For An Option At The Best Offer Price
    /// </summary>
    public uint BestOfferSize => Fields.BestOfferSize.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public BestBidParticipantId BestBidParticipantId;
        public BestBidDenominatorCode BestBidDenominatorCode;
        public BestBidPrice BestBidPrice;
        public BestBidSize BestBidSize;
        public BestOfferParticipantId BestOfferParticipantId;
        public BestOfferDenominatorCode BestOfferDenominatorCode;
        public BestOfferPrice BestOfferPrice;
        public BestOfferSize BestOfferSize;
    };

    protected Layout Fields;
};
