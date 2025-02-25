using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  M D Instrument Definition Eris Leg Groups: Number of legs (repeating groups) Block
/// </summary>

public partial class MDInstrumentDefinitionErisLegGroups
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
