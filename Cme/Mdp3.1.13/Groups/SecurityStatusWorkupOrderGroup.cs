using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Security Status Workup Order Group: Number of OrderID entries
    /// </summary>

    public partial class SecurityStatusWorkupOrderGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            OrderId OrderId;
            Side Side;
            AggressorIndicator AggressorIndicator;
        };
    };
}