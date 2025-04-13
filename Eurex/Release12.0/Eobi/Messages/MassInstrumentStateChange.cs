using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Mass Instrument State Change
/// </summary>

public partial class MassInstrumentStateChange
{
    /// <summary>
    ///  Instrument Scope Product Complex
    /// </summary>
    public InstrumentScopeProductComplex InstrumentScopeProductComplex => Fields.InstrumentScopeProductComplex.Value;

    /// <summary>
    ///  Security Mass Status
    /// </summary>
    public SecurityMassStatus SecurityMassStatus => Fields.SecurityMassStatus.Value;

    /// <summary>
    ///  Security Mass Trading Status
    /// </summary>
    public SecurityMassTradingStatus SecurityMassTradingStatus => Fields.SecurityMassTradingStatus.Value;

    /// <summary>
    ///  Mass Market Condition
    /// </summary>
    public MassMarketCondition MassMarketCondition => Fields.MassMarketCondition.Value;

    /// <summary>
    ///  Fast Market Indicator
    /// </summary>
    public FastMarketIndicator FastMarketIndicator => Fields.FastMarketIndicator.Value;

    /// <summary>
    ///  Security Mass Trading Event
    /// </summary>
    public SecurityMassTradingEvent SecurityMassTradingEvent => Fields.SecurityMassTradingEvent.Value;

    /// <summary>
    ///  Mass Sold Out Indicator
    /// </summary>
    public MassSoldOutIndicator MassSoldOutIndicator => Fields.MassSoldOutIndicator.Value;

    /// <summary>
    ///  Tes Security Mass Status
    /// </summary>
    public TesSecurityMassStatus TesSecurityMassStatus => Fields.TesSecurityMassStatus.Value;

    /// <summary>
    ///  Transact Time
    /// </summary>
    public DateTime TransactTime => Fields.TransactTime.Value;

    /// <summary>
    ///  Last Fragment
    /// </summary>
    public LastFragment LastFragment => Fields.LastFragment.Value;

    /// <summary>
    ///  No Related Sym
    /// </summary>
    public byte NoRelatedSym => Fields.NoRelatedSym.Value;

    /// <summary>
    ///  Pad 6
    /// </summary>
    public string Pad6 => Fields.Pad6.Value;

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

    protected Layout Fields;
};
