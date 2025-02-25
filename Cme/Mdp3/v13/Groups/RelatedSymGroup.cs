using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Related Sym Group: Indicates the number of repeating symbols specified
    /// </summary>

    public partial class RelatedSymGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public Symbol Symbol;
            public SecurityId SecurityId;
            public OrderQty OrderQty;
            public QuoteType QuoteType;
            public SideOptional SideOptional;
            public Padding2 Padding2;
        };
    };
}