using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  M D Instrument Definition Spread Leg Groups: Number of Leg entries Block
/// </summary>

public partial class MDInstrumentDefinitionSpreadLegGroups
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
