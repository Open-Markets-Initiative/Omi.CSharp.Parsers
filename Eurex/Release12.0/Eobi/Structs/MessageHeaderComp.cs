using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Message Header Comp
/// </summary>

public partial class MessageHeaderComp
{
    /// <summary>
    ///  Body Len
    /// </summary>
    public ushort BodyLen => Layout.BodyLen.Value;

    /// <summary>
    ///  Template Id
    /// </summary>
    public TemplateId TemplateId => Layout.TemplateId.Value;

    /// <summary>
    ///  Msg Seq Num
    /// </summary>
    public uint MsgSeqNum => Layout.MsgSeqNum.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public BodyLen BodyLen;
        public TemplateId TemplateId;
        public MsgSeqNum MsgSeqNum;
    };
};
