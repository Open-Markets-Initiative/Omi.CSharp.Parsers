using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Message Header Comp
    /// </summary>

    public partial class MessageHeaderComp
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            BodyLen BodyLen;
            TemplateId TemplateId;
            MsgSeqNum MsgSeqNum;
        };
    };
}