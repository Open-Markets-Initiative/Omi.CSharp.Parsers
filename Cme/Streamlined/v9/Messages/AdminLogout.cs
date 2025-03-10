using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Admin Logout: AdminLogout
/// </summary>

public partial class AdminLogout
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Text Text;
    };
};
