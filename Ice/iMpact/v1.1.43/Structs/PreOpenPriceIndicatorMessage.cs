using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Pre Open Price Indicator Message
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