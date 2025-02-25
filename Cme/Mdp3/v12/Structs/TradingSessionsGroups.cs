using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Trading Sessions Groups: Number of scheduled Trading Dates Block
/// </summary>

public partial class TradingSessionsGroups
{
    /// <summary>
    ///  Repeating group dimensions
    /// </summary>
    public string GroupSize => Layout.GroupSize.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public GroupSize GroupSize;
    };
};
