using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Msg Header
    /// </summary>

    public partial class MsgHeader
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MsgType MsgType;
            MsgLength MsgLength;
        };
    };
}