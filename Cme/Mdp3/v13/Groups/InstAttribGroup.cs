using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Inst Attrib Group: Number of repeating InstrAttribType entries
/// </summary>

public partial class InstAttribGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public InstAttribValue InstAttribValue;
    };
};
