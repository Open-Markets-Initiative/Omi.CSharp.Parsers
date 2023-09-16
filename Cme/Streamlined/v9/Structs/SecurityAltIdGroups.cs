using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Security Alt Id Groups: Number of entries in AltID group. Block
    /// </summary>

    public partial class SecurityAltIdGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}