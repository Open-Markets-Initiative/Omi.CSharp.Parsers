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
            SeqMsgHeader SeqMsgHeader;
            TransactTime TransactTime;
            SymbolId SymbolId;
            NyseSymbol NyseSymbol;
            MarketMaker MarketMaker;
            Mpid Mpid;
            MmType MmType;
            AppointmentStatus AppointmentStatus;
            Reserved50 Reserved50;
        };
    };
}