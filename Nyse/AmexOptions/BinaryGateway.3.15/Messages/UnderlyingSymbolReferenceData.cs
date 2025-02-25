using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Underlying Symbol Reference Data
    /// </summary>

    public partial class UnderlyingSymbolReferenceData
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public TransactTime TransactTime;
            public SymbolId SymbolId;
            public NyseSymbol NyseSymbol;
            public ListedMic ListedMic;
            public UnderlyingType UnderlyingType;
            public MaxOrderPrice MaxOrderPrice;
            public MpvClassId MpvClassId;
            public TestSymbolIndicator TestSymbolIndicator;
            public ChannelId ChannelId;
            public LegalWidthMultiplier LegalWidthMultiplier;
        };
    };
}