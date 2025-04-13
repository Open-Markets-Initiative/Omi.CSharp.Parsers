using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Leg Contract Multiplier: Number of entries in Market Data message.
/// </summary>

public partial class LegContractMultiplier
{
    /// <summary>
    ///  mantissa
    /// </summary>
    public long Mantissa => Fields.Mantissa.Value;

    /// <summary>
    ///  exponent
    /// </summary>
    public sbyte Exponent => Fields.Exponent.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Mantissa Mantissa;
        public Exponent Exponent;
    };

    protected Layout Fields;
};
