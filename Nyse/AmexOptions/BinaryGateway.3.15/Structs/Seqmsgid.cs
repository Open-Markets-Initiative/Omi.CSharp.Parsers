using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Seqmsgid
/// </summary>

public partial class Seqmsgid
{
    /// <summary>
    ///  Stream Id
    /// </summary>
    public string StreamId => Layout.StreamId.Value;

    /// <summary>
    ///  Sequence number, starting from 1
    /// </summary>
    public ulong Seq => Layout.Seq.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StreamId StreamId;
        public Seq Seq;
    };
};
