using System.Runtime.InteropServices;

namespace Iex.Deep;

/// <summary>
///  Packet
/// </summary>

public partial class Packet
{
    /// <summary>
    ///  Iex Tp Header
    /// </summary>
    public string IexTpHeader => Fields.IexTpHeader.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public IexTpHeader IexTpHeader;
    };

    protected Layout Fields;
};
