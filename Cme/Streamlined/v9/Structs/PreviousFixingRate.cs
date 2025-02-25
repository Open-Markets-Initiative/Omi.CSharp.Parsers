using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Previous Fixing Rate: Number of legs (repeating groups)
/// </summary>

public partial class PreviousFixingRate
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
