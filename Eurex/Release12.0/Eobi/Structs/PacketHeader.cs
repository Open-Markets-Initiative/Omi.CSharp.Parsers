using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Packet Header
/// </summary>

public partial class PacketHeader
{
    /// <summary>
    ///  Packet Info
    /// </summary>
    public string PacketInfo => Layout.PacketInfo.Value;

    /// <summary>
    ///  Appl Seq Num
    /// </summary>
    public uint ApplSeqNum => Layout.ApplSeqNum.Value;

    /// <summary>
    ///  Market Segment Id
    /// </summary>
    public int MarketSegmentId => Layout.MarketSegmentId.Value;

    /// <summary>
    ///  Partition Id
    /// </summary>
    public byte PartitionId => Layout.PartitionId.Value;

    /// <summary>
    ///  Completion Indicator
    /// </summary>
    public CompletionIndicator CompletionIndicator => Layout.CompletionIndicator.Value;

    /// <summary>
    ///  Appl Seq Reset Indicator
    /// </summary>
    public ApplSeqResetIndicator ApplSeqResetIndicator => Layout.ApplSeqResetIndicator.Value;

    /// <summary>
    ///  Pad 5
    /// </summary>
    public string Pad5 => Layout.Pad5.Value;

    /// <summary>
    ///  Transact Time
    /// </summary>
    public ulong TransactTime => Layout.TransactTime.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public PacketInfo PacketInfo;
        public ApplSeqNum ApplSeqNum;
        public MarketSegmentId MarketSegmentId;
        public PartitionId PartitionId;
        public CompletionIndicator CompletionIndicator;
        public ApplSeqResetIndicator ApplSeqResetIndicator;
        public Pad5 Pad5;
        public TransactTime TransactTime;
    };
};
