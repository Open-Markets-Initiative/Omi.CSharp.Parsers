using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Underlyings Group: Number of underlying instruments
    /// </summary>

    public partial class UnderlyingsGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public UnderlyingSecurityId UnderlyingSecurityId;
            public UnderlyingSymbol UnderlyingSymbol;
        };
    };
}