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
    public ushort StockLocate => Layout.StockLocate.Value;

    /// <summary>
    ///  NASDAQ OMX internal tracking number
    /// </summary>
    public ushort TrackingNumber => Layout.TrackingNumber.Value;

    /// <summary>
    ///  Nanoseconds since midnight.
    /// </summary>
    public string Timestamp => Layout.Timestamp.Value;

    /// <summary>
    ///  Denotes the security symbol for the issue in the NASDAQ execution system.
    /// </summary>
    public string Stock => Layout.Stock.Value;

    /// <summary>
    ///  Reference price used to set the Auction Collars
    /// </summary>
    public uint AuctionCollarReferencePrice => Layout.AuctionCollarReferencePrice.Value;

    /// <summary>
    ///  Indicates the price of the Upper Auction Collar Threshold
    /// </summary>
    public uint UpperAuctionCollarPrice => Layout.UpperAuctionCollarPrice.Value;

    /// <summary>
    ///  Indicates the price of the Lower Auction Collar Threshold
    /// </summary>
    public uint LowerAuctionCollarPrice => Layout.LowerAuctionCollarPrice.Value;

    /// <summary>
    ///  Indicates the number of the extensions to the Reopening Auction
    /// </summary>
    public uint AuctionCollarExtension => Layout.AuctionCollarExtension.Value;

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
};
