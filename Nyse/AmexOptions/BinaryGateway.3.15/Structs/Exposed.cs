using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Exposed
/// </summary>

public partial class Exposed
{
    /// <summary>
    ///  Sub Msg Header
    /// </summary>
    public string SubMsgHeader => Layout.SubMsgHeader.Value;

    /// <summary>
    ///  Identification number assigned to the security
    /// </summary>
    public uint SymbolId => Layout.SymbolId.Value;

    /// <summary>
    ///  Firm Identifier – MPID.
    /// </summary>
    public string Mpid => Layout.Mpid.Value;

    /// <summary>
    ///  This value represents a Market Maker (including LMM, Primary Specialist, Specialist and e-Specialist), agreed upon between the firm and the Exchange.  These firms must provide their MMID along with its associated MPID on all orders intended to receive credit for satisfying their marking making/liquidity obligations.
    /// </summary>
    public string MarketMaker => Layout.MarketMaker.Value;

    /// <summary>
    ///  Customer defined – identifies specific entity/trading desk of customer firm.
    /// </summary>
    public string MpSubId => Layout.MpSubId.Value;

    /// <summary>
    ///  Unique ID of the message as assigned by the firm.
    /// </summary>
    public ulong ClOrdId => Layout.ClOrdId.Value;

    /// <summary>
    ///  Refers to the ClOrdID of a previously entered order.
    /// </summary>
    public ulong OrigClOrdId => Layout.OrigClOrdId.Value;

    /// <summary>
    ///  Order Instructions
    /// </summary>
    public string OrderInstructions => Layout.OrderInstructions.Value;

    /// <summary>
    ///  0.01 - 9,999.99
    /// </summary>
    public long PricePrice8 => Layout.PricePrice8.Value;

    /// <summary>
    ///  1 - 999,999
    /// </summary>
    public uint OrderQty => Layout.OrderQty.Value;

    /// <summary>
    ///  0 = no MinQty
    /// </summary>
    public uint MinQty => Layout.MinQty.Value;

    /// <summary>
    ///  Customer defined up to 10 characters; only printable ASCII characters allowed, excluding comma, semicolon, pipe delimiter, “at” symbol, greater than/less than, ampersand (&) and single/double quotation mark.
    /// </summary>
    public string UserData => Layout.UserData.Value;

    /// <summary>
    ///  Indicates sender’s position of each leg of a Complex order.
    /// </summary>
    public LegOpenClose LegOpenClose => Layout.LegOpenClose.Value;

    /// <summary>
    ///  CUBE Auction identifier supplied by Pillar Market Data to allow GTX responses to target specific CUBE auctions. If provided on non-GTX responses, the order will be rejected.
    /// </summary>
    public ulong AuctionId => Layout.AuctionId.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SubMsgHeader SubMsgHeader;
        public SymbolId SymbolId;
        public Mpid Mpid;
        public MarketMaker MarketMaker;
        public MpSubId MpSubId;
        public ClOrdId ClOrdId;
        public OrigClOrdId OrigClOrdId;
        public OrderInstructions OrderInstructions;
        public PricePrice8 PricePrice8;
        public OrderQty OrderQty;
        public MinQty MinQty;
        public UserData UserData;
        public LegOpenClose LegOpenClose;
        public AuctionId AuctionId;
    };
};
