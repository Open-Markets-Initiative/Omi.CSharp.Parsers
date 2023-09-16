using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Open
    /// </summary>

    public partial class Open
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MsgHeader MsgHeader;
            StreamId StreamId;
            StartSeq StartSeq;
            EndSeq EndSeq;
            Access Access;
            Mode Mode;
        };
    };
}