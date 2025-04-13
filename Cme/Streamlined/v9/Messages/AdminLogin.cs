using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Admin Login: AdminLogin
/// </summary>

public partial class AdminLogin
{
    /// <summary>
    ///  Heartbeat interval (seconds)
    /// </summary>
    public sbyte HeartBtInt => Fields.HeartBtInt.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public HeartBtInt HeartBtInt;
    };

    protected Layout Fields;
};
