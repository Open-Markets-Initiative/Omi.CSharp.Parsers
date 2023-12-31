using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Seq Msg Header
    /// </summary>

    public partial class SeqMsgHeader
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgType SeqMsgType;
            SeqMsgLength SeqMsgLength;
        };
    };
}