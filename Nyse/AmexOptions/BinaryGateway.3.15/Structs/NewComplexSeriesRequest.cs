using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  New Complex Series Request
    /// </summary>

    public partial class NewComplexSeriesRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            ClOrdId ClOrdId;
            Mpid Mpid;
        };
    };
}