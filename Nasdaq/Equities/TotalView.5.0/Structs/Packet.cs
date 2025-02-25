using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Packet
/// </summary>

public partial class Packet
{
    /// <summary>
    ///  Packet Header
    /// </summary>
    public string PacketHeader => Layout.PacketHeader.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public PacketHeader PacketHeader;
    };
};
