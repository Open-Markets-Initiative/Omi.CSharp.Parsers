using System.Runtime.InteropServices;

namespace Iex.Tops;

/// <summary>
///  Short Sale Price Test Status Message: The Short Sale Price Test Message is used to indicate when a short sale price test restriction is in effect for a security.
/// </summary>

public partial class ShortSalePriceTestStatusMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public ShortSalePriceTestStatus ShortSalePriceTestStatus;
        public Timestamp Timestamp;
        public Symbol Symbol;
        public Detail Detail;
    };
};
