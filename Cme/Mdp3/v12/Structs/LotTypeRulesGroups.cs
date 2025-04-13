using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Lot Type Rules Groups: Number of entries Block
/// </summary>

public partial class LotTypeRulesGroups
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
