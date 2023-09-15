using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Underlyings Group: Number of underlying instruments
    /// </summary>

    public partial class UnderlyingsGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            UnderlyingSecurityId UnderlyingSecurityId;
            UnderlyingSymbol UnderlyingSymbol;
        };
    };
}