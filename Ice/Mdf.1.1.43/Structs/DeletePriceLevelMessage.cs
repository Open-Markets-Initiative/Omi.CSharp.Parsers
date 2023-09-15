using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Delete Price Level Message
    /// </summary>

    public partial class DeletePriceLevelMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            Side Side;
            PriceLevelPosition PriceLevelPosition;
            Timestamp Timestamp;
        };
    };
}