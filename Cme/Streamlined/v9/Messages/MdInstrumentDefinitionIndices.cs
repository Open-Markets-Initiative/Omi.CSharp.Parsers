using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Instrument Definition Indices: MDInstrumentDefinitionIndices
    /// </summary>

    public partial class MdInstrumentDefinitionIndices
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public Symbol Symbol;
            public Product Product;
            public SecurityExchange SecurityExchange;
            public Currency Currency;
            public SecurityUpdateAction SecurityUpdateAction;
            public MdFeedType MdFeedType;
            public ApplId ApplId;
        };
    };
}