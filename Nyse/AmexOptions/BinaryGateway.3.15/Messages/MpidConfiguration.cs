using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Mpid Configuration
    /// </summary>

    public partial class MpidConfiguration
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            TransactTime TransactTime;
            MpidStatus MpidStatus;
            Mpid Mpid;
            Username Username;
            Reserved50 Reserved50;
        };
    };
}