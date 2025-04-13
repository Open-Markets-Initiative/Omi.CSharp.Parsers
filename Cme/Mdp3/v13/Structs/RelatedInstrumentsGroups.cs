using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Related Instruments Groups: Number of related instruments group Block
/// </summary>

public partial class RelatedInstrumentsGroups
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
