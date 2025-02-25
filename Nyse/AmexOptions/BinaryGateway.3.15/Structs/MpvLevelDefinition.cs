using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Mpv Level Definition
/// </summary>

public partial class MpvLevelDefinition
{
    /// <summary>
    ///  Name of the Minimum Price Variant (MPV) Level. Naming
    /// </summary>
    public string MpvLevelName => Layout.MpvLevelName.Value;

    /// <summary>
    ///  Order entry Limit price range for the MPVLevel
    /// </summary>
    public ulong PriceUPrice8 => Layout.PriceUPrice8.Value;

    /// <summary>
    ///  Numeric value of the Quoting Minimum Price Variation for the
    /// </summary>
    public ulong QuotingMpv => Layout.QuotingMpv.Value;

    /// <summary>
    ///  Numeric value of the Trading Minimum Price Variation for the
    /// </summary>
    public ulong TradingMpv => Layout.TradingMpv.Value;

    /// <summary>
    ///  Identification number assigned to the MPVClass
    /// </summary>
    public ushort MpvClassId => Layout.MpvClassId.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MpvLevelName MpvLevelName;
        public PriceUPrice8 PriceUPrice8;
        public QuotingMpv QuotingMpv;
        public TradingMpv TradingMpv;
        public MpvClassId MpvClassId;
    };
};
