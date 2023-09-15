using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Security Status Workup Order Groups: Number of OrderID entries Block
    /// </summary>

    public partial class SecurityStatusWorkupOrderGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}