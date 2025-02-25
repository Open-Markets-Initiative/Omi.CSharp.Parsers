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
            public InstrumentScopeProductComplex InstrumentScopeProductComplex;
            public SecurityMassStatus SecurityMassStatus;
            public SecurityMassTradingStatus SecurityMassTradingStatus;
            public MassMarketCondition MassMarketCondition;
            public FastMarketIndicator FastMarketIndicator;
            public SecurityMassTradingEvent SecurityMassTradingEvent;
            public MassSoldOutIndicator MassSoldOutIndicator;
            public TesSecurityMassStatus TesSecurityMassStatus;
            public TransactTime TransactTime;
            public LastFragment LastFragment;
            public NoRelatedSym NoRelatedSym;
            public Pad6 Pad6;
        };
    };
}