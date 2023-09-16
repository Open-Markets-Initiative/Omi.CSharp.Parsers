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
            Symbol Symbol;
            Product Product;
            SecurityExchange SecurityExchange;
            Currency Currency;
            SecurityUpdateAction SecurityUpdateAction;
            MdFeedType MdFeedType;
            ApplId ApplId;
        };
    };
}