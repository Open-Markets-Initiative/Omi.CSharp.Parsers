using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Interpolation Factor: Number of legs (repeating groups)
/// </summary>

public partial class InterpolationFactor
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
