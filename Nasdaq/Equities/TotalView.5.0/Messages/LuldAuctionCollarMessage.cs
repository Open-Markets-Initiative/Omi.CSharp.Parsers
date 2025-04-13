using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Luld Auction Collar Message: Indicates the auction collar thresholds within which a paused security can reopen following a LULD Trading Pause
/// </summary>

public partial class LuldAuctionCollarMessage
{
    /// <summary>
    ///  Always 0
    /// </summary>
    public ushort StockLocate => Fields.StockLocate.Value;

    /// <summary>
    ///  NASDAQ OMX internal tracking number
    /// </summary>
    public ushort TrackingNumber => Fields.TrackingNumber.Value;

    /// <summary>
    ///  Nanoseconds since midnight.
    /// </summary>
    public string Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  Denotes the security symbol for the issue in the NASDAQ execution system.
    /// </summary>
    public string Stock => Fields.Stock.Value;

    /// <summary>
    ///  Reference price used to set the Auction Collars
    /// </summary>
    public uint AuctionCollarReferencePrice => Fields.AuctionCollarReferencePrice.Value;

    /// <summary>
    ///  Indicates the price of the Upper Auction Collar Threshold
    /// </summary>
    public uint UpperAuctionCollarPrice => Fields.UpperAuctionCollarPrice.Value;

    /// <summary>
    ///  Indicates the price of the Lower Auction Collar Threshold
    /// </summary>
    public uint LowerAuctionCollarPrice => Fields.LowerAuctionCollarPrice.Value;

    /// <summary>
    ///  Indicates the number of the extensions to the Reopening Auction
    /// </summary>
    public uint AuctionCollarExtension => Fields.AuctionCollarExtension.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StockLocate StockLocate;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public Stock Stock;
        public AuctionCollarReferencePrice AuctionCollarReferencePrice;
        public UpperAuctionCollarPrice UpperAuctionCollarPrice;
        public LowerAuctionCollarPrice LowerAuctionCollarPrice;
        public AuctionCollarExtension AuctionCollarExtension;
    };

    protected Layout Fields;
};
