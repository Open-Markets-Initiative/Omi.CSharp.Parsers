using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Seq Msg
    /// </summary>

    public partial class SeqMsg
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MsgHeader MsgHeader;
            Seqmsgid Seqmsgid;
            Reserved4 Reserved4;
            Timestamp Timestamp;
        };
    };
}