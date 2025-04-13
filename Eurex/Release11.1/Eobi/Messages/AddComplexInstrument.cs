using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Add Complex Instrument
/// </summary>

public partial class AddComplexInstrument
{
    /// <summary>
    ///  Security Id
    /// </summary>
    public long SecurityId => Fields.SecurityId.Value;

    /// <summary>
    ///  Transact Time
    /// </summary>
    public DateTime TransactTime => Fields.TransactTime.Value;

    /// <summary>
    ///  Security Desc
    /// </summary>
    public string SecurityDesc => Fields.SecurityDesc.Value;

    /// <summary>
    ///  Security Sub Type
    /// </summary>
    public int SecuritySubType => Fields.SecuritySubType.Value;

    /// <summary>
    ///  Product Complex
    /// </summary>
    public ProductComplex ProductComplex => Fields.ProductComplex.Value;

    /// <summary>
    ///  Implied Market Indicator
    /// </summary>
    public ImpliedMarketIndicator ImpliedMarketIndicator => Fields.ImpliedMarketIndicator.Value;

    /// <summary>
    ///  Last Fragment
    /// </summary>
    public LastFragment LastFragment => Fields.LastFragment.Value;

    /// <summary>
    ///  Pad 1
    /// </summary>
    public string Pad1 => Fields.Pad1.Value;

    /// <summary>
    ///  Leg Ratio Multiplier
    /// </summary>
    public uint LegRatioMultiplier => Fields.LegRatioMultiplier.Value;

    /// <summary>
    ///  No Legs
    /// </summary>
    public byte NoLegs => Fields.NoLegs.Value;

    /// <summary>
    ///  Pad 3
    /// </summary>
    public string Pad3 => Fields.Pad3.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SecurityId SecurityId;
        public TransactTime TransactTime;
        public SecurityDesc SecurityDesc;
        public SecuritySubType SecuritySubType;
        public ProductComplex ProductComplex;
        public ImpliedMarketIndicator ImpliedMarketIndicator;
        public LastFragment LastFragment;
        public Pad1 Pad1;
        public LegRatioMultiplier LegRatioMultiplier;
        public NoLegs NoLegs;
        public Pad3 Pad3;
    };

    protected Layout Fields;
};
