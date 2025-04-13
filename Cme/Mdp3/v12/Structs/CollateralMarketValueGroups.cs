using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Collateral Market Value Groups: Number of data blocks listed in the Incremental message Block
/// </summary>

public partial class CollateralMarketValueGroups
{
    /// <summary>
    ///  Repeating group dimensions
    /// </summary>
    public string GroupSize => Fields.GroupSize.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public GroupSize GroupSize;
    };

    protected Layout Fields;
};
