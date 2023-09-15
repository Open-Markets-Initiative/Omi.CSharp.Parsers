using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Related Sym Group: Indicates the number of repeating symbols specified
    /// </summary>

    public partial class RelatedSymGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Symbol Symbol;
            SecurityId SecurityId;
            OrderQty OrderQty;
            QuoteType QuoteType;
            SideOptional SideOptional;
            Padding2 Padding2;
        };
    };
}