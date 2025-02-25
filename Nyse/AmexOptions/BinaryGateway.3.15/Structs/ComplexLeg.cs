using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Complex Leg
/// </summary>

public partial class ComplexLeg
{
    /// <summary>
    ///  Identification number assigned to the security.
    /// </summary>
    public uint LegSymbolId => Layout.LegSymbolId.Value;

    /// <summary>
    ///  The ratio of quantity for this individual leg.
    /// </summary>
    public ushort LegRatioQty => Layout.LegRatioQty.Value;

    /// <summary>
    ///  Side
    /// </summary>
    public LegSide LegSide => Layout.LegSide.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public LegSymbolId LegSymbolId;
        public LegRatioQty LegRatioQty;
        public LegSide LegSide;
    };
};
