using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Delete Price Level Message: Upon receipt of this message, client should remove the price level at the specified position in its book for the given market.
/// </summary>

public partial class DeletePriceLevelMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MarketId MarketId;
        public Side Side;
        public PriceLevelPosition PriceLevelPosition;
        public Timestamp Timestamp;
    };
};
