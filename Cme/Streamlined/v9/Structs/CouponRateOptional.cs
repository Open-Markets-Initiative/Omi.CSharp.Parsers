using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Coupon Rate Optional: Number of entries in Market Data message.
/// </summary>

public partial class CouponRateOptional
{
    /// <summary>
    ///  mantissa
    /// </summary>
    public int Mantissa32 => Fields.Mantissa32.Value;

    /// <summary>
    ///  exponent
    /// </summary>
    public sbyte Exponent => Fields.Exponent.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Mantissa32 Mantissa32;
        public Exponent Exponent;
    };

    protected Layout Fields;
};
