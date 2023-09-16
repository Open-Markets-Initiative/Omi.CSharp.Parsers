using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Close Response
    /// </summary>

    public partial class CloseResponse
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MsgHeader MsgHeader;
            StreamId StreamId;
            Status Status;
        };
    };
}