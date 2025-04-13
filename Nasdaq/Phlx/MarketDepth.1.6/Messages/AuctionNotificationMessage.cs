using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Auction Notification Message: This message is also sent as notification that there is an exposed buy (sell) order available for execution at the National Best Offer (Bid).
/// </summary>

public partial class AuctionNotificationMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  Uniquely identifies the Auction for the trading day.
    /// </summary>
    public uint AuctionId => Fields.AuctionId.Value;

    /// <summary>
    ///  Auction Type
    /// </summary>
    public AuctionType AuctionType => Fields.AuctionType.Value;

    /// <summary>
    ///  The total number of contracts that are eligible to be matched at the Current Reference Price. Zero for Order Exposure notifications.
    /// </summary>
    public uint PairedContracts => Fields.PairedContracts.Value;

    /// <summary>
    ///  Indicates the market side of the imbalance
    /// </summary>
    public ImbalanceDirection ImbalanceDirection => Fields.ImbalanceDirection.Value;

    /// <summary>
    ///  Option ID assigned daily, valid for trading day.
    /// </summary>
    public uint OptionId => Fields.OptionId.Value;

    /// <summary>
    ///  The imbalance price.
    /// </summary>
    public int ImbalancePrice => Fields.ImbalancePrice.Value;

    /// <summary>
    ///  The imbalance contracts.
    /// </summary>
    public uint ImbalanceVolume => Fields.ImbalanceVolume.Value;

    /// <summary>
    ///  For Order Exposure only.
    /// </summary>
    public CustomerIndicator CustomerIndicator => Fields.CustomerIndicator.Value;

    /// <summary>
    ///  Reserved for future use
    /// </summary>
    public string Reserved => Fields.Reserved.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public AuctionId AuctionId;
        public AuctionType AuctionType;
        public PairedContracts PairedContracts;
        public ImbalanceDirection ImbalanceDirection;
        public OptionId OptionId;
        public ImbalancePrice ImbalancePrice;
        public ImbalanceVolume ImbalanceVolume;
        public CustomerIndicator CustomerIndicator;
        public Reserved Reserved;
    };

    protected Layout Fields;
};
