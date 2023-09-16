using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Stream Avail
    /// </summary>

    public partial class StreamAvail
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MsgHeader MsgHeader;
            StreamId StreamId;
            NextSeq NextSeq;
            Access Access;
        };
    };
}