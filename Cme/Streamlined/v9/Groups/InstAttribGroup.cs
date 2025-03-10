using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Inst Attrib Group: Number of repeating InstrAttribType entries.
/// </summary>

public partial class InstAttribGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public InstAttribType InstAttribType;
        public InstAttribValue InstAttribValue;
    };
};
