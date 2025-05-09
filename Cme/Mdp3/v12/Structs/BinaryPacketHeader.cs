using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Binary Packet Header
/// </summary>

public partial class BinaryPacketHeader
{
    /// <summary>
    ///  Packet Sequence Number
    /// </summary>
    public uint MessageSequenceNumber => Fields.MessageSequenceNumber.Value;

    /// <summary>
    ///  Packet Sending Time
    /// </summary>
    public ulong SendingTime => Fields.SendingTime.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MessageSequenceNumber MessageSequenceNumber;
        public SendingTime SendingTime;
    };

    protected Layout Fields;
};
