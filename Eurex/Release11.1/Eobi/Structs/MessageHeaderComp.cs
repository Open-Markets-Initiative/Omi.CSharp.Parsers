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
    public ushort BodyLen => Fields.BodyLen.Value;

    /// <summary>
    ///  Template Id
    /// </summary>
    public TemplateId TemplateId => Fields.TemplateId.Value;

    /// <summary>
    ///  Msg Seq Num
    /// </summary>
    public uint MsgSeqNum => Fields.MsgSeqNum.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public BodyLen BodyLen;
        public TemplateId TemplateId;
        public MsgSeqNum MsgSeqNum;
    };

    protected Layout Fields;
};
