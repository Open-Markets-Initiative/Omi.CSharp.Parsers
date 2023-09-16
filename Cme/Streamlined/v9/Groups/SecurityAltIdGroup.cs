using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Security Alt Id Group: Number of entries in AltID group.
    /// </summary>

    public partial class SecurityAltIdGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityAltId SecurityAltId;
            SecurityAltIdSource SecurityAltIdSource;
        };
    };
}