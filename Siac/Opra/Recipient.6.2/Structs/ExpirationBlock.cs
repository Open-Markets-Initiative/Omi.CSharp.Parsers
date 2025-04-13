using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Expiration Block
/// </summary>

public partial class ExpirationBlock
{
    /// <summary>
    ///  Indicates The Expiration Month And Identifies The Option As A Call Or A Put
    /// </summary>
    public ExpirationMonth ExpirationMonth => Fields.ExpirationMonth.Value;

    /// <summary>
    ///  Contains Hex 0 X 01 To 0 X 1f Decimal 1 To 31 Indicating The Day Of The Month The Series Expires
    /// </summary>
    public byte ExpirationDay => Fields.ExpirationDay.Value;

    /// <summary>
    ///  Contains Hex 0 X 00 To 0 X 63 Decimal 0 To 99 Represents The Year Starting With Year 2000
    /// </summary>
    public byte ExpirationYear => Fields.ExpirationYear.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public ExpirationMonth ExpirationMonth;
        public ExpirationDay ExpirationDay;
        public ExpirationYear ExpirationYear;
    };

    protected Layout Fields;
};
