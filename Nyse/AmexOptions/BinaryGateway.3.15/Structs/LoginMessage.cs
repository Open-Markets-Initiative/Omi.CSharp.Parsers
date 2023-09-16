using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Login Message
    /// </summary>

    public partial class LoginMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MsgHeader MsgHeader;
            Username Username;
            Password Password;
            Mic Mic;
            Version Version;
        };
    };
}