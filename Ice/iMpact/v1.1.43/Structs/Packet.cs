using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Packet
/// </summary>

public partial class Packet
{
    /// <summary>
    ///  Packet Header
    /// </summary>
    public string PacketHeader => Fields.PacketHeader.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public PacketHeader PacketHeader;
    };

    protected Layout Fields;
};
