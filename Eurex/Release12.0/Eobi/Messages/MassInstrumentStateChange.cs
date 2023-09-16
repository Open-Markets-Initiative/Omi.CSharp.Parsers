using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Mass Instrument State Change
    /// </summary>

    public partial class MassInstrumentStateChange
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            InstrumentScopeProductComplex InstrumentScopeProductComplex;
            SecurityMassStatus SecurityMassStatus;
            SecurityMassTradingStatus SecurityMassTradingStatus;
            MassMarketCondition MassMarketCondition;
            FastMarketIndicator FastMarketIndicator;
            SecurityMassTradingEvent SecurityMassTradingEvent;
            MassSoldOutIndicator MassSoldOutIndicator;
            TesSecurityMassStatus TesSecurityMassStatus;
            TransactTime TransactTime;
            LastFragment LastFragment;
            NoRelatedSym NoRelatedSym;
            Pad6 Pad6;
        };
    };
}