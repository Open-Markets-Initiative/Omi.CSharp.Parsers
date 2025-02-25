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
    public BestBidParticipantId BestBidParticipantId => Layout.BestBidParticipantId.Value;

    /// <summary>
    ///  The Bed Bid Denominator Code Field Indicates The Position Of The Floating Decimal Point Within The Best Bid Price Field
    /// </summary>
    public BestBidDenominatorCode BestBidDenominatorCode => Layout.BestBidDenominatorCode.Value;

    /// <summary>
    ///  Represents The Best Price At Which A Buyer Is Willing To Buy An Option
    /// </summary>
    public int BestBidPrice => Layout.BestBidPrice.Value;

    /// <summary>
    ///  The Best Bid Size Identifies The Number Of Contracts Being Bought For An Option At The Best Bid Price
    /// </summary>
    public uint BestBidSize => Layout.BestBidSize.Value;

    /// <summary>
    ///  Identifies The Participant That Entered The Best Bid
    /// </summary>
    public BestOfferParticipantId BestOfferParticipantId => Layout.BestOfferParticipantId.Value;

    /// <summary>
    ///  The Bed Offer Denominator Code Field Indicates The Position Of The Floating Decimal Point Within The Best Offer Price Field
    /// </summary>
    public BestOfferDenominatorCode BestOfferDenominatorCode => Layout.BestOfferDenominatorCode.Value;

    /// <summary>
    ///  Represents The Best Price At Which A Seller Is Offering To Sell An Option
    /// </summary>
    public int BestOfferPrice => Layout.BestOfferPrice.Value;

    /// <summary>
    ///  The Best Offer Size Identifies The Number Of Contracts Being Bought For An Option At The Best Offer Price
    /// </summary>
    public uint BestOfferSize => Layout.BestOfferSize.Value;

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
};
