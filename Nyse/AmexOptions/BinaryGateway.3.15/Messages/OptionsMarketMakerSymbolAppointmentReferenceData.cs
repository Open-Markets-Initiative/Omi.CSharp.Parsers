using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Options Market Maker Symbol Appointment Reference Data
    /// </summary>

    public partial class OptionsMarketMakerSymbolAppointmentReferenceData
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public TransactTime TransactTime;
            public SymbolId SymbolId;
            public NyseSymbol NyseSymbol;
            public MarketMaker MarketMaker;
            public Mpid Mpid;
            public MmType MmType;
            public AppointmentStatus AppointmentStatus;
            public Reserved50 Reserved50;
        };
    };
}