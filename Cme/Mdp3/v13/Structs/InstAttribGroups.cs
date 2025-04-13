using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Inst Attrib Groups: Number of repeating InstrAttribType entries Block
/// </summary>

public partial class InstAttribGroups
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
