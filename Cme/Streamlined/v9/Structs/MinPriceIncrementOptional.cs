using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Min Price Increment Optional: Number of entries in Market Data message.
/// </summary>

public partial class MinPriceIncrementOptional
{
    /// <summary>
    ///  mantissa
    /// </summary>
    public long Mantissa => Layout.Mantissa.Value;

    /// <summary>
    ///  exponent
    /// </summary>
    public sbyte Exponent => Layout.Exponent.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Mantissa Mantissa;
        public Exponent Exponent;
    };
};
