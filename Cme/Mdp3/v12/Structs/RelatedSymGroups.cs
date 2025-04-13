using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Related Sym Groups: Indicates the number of repeating symbols specified Block
/// </summary>

public partial class RelatedSymGroups
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
