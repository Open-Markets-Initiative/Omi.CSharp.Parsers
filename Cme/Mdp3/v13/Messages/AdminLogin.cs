using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Admin Login: AdminLogin
    /// </summary>

    public partial class AdminLogin
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            HeartBtInt HeartBtInt;
        };
    };
}