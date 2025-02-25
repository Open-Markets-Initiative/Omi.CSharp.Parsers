using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Packet
/// </summary>

public partial class Packet
{
    /// <summary>
    ///  Binary Packet Header
    /// </summary>
    public string BinaryPacketHeader => Layout.BinaryPacketHeader.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public BinaryPacketHeader BinaryPacketHeader;
    };
};
