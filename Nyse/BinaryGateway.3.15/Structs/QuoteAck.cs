using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Quote Ack
    /// </summary>

    public partial class QuoteAck
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeriesIndex SeriesIndex;
            SideU81 SideU81;
            AckType AckType;
            PricePrice8 PricePrice8;
            Quantity Quantity;
            ReasonCode ReasonCode;
            WorkingAwayFromDisplay WorkingAwayFromDisplay;
        };
    };
}