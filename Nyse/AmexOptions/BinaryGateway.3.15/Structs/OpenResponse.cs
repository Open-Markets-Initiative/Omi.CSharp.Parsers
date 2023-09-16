using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Open Response
    /// </summary>

    public partial class OpenResponse
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MsgHeader MsgHeader;
            StreamId StreamId;
            Status Status;
            Access Access;
        };
    };
}