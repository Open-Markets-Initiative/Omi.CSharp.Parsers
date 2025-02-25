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
            public SeqMsgHeader SeqMsgHeader;
            public TransactTime TransactTime;
            public MpidStatus MpidStatus;
            public Mpid Mpid;
            public Username Username;
            public Reserved50 Reserved50;
        };
    };
}