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
            SeqMsgHeader SeqMsgHeader;
            TransactTime TransactTime;
            SymbolId SymbolId;
            NyseSymbol NyseSymbol;
            ListedMic ListedMic;
            UnderlyingType UnderlyingType;
            MaxOrderPrice MaxOrderPrice;
            MpvClassId MpvClassId;
            TestSymbolIndicator TestSymbolIndicator;
            ChannelId ChannelId;
            LegalWidthMultiplier LegalWidthMultiplier;
        };
    };
}