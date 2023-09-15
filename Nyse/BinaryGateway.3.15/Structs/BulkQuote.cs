using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Bulk Quote
    /// </summary>

    public partial class BulkQuote
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeriesIndex SeriesIndex;
            BitFieldQuoteInst BitFieldQuoteInst;
            PricePrice8 PricePrice8;
            OrderQty OrderQty;
        };
    };
}