using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Admin Login: AdminLogin
/// </summary>

public partial class AdminLogin
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public HeartBtInt HeartBtInt;
    };
};
