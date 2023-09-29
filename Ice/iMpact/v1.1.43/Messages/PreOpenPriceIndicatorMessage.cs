using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Pre Open Price Indicator Message: This message contains the estimate of what the opening price could be, based on the orders in the market or previous settlement price.
    /// </summary>

    public partial class PreOpenPriceIndicatorMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MarketId MarketId;
            PreOpenPrice PreOpenPrice;
            MessageDateTime MessageDateTime;
            HasPreOpenVolume HasPreOpenVolume;
            PreOpenVolume PreOpenVolume;
        };
    };
}