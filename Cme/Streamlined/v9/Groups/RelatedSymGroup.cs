using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Related Sym Group: Specifies the number of repeating symbols specified.
/// </summary>

public partial class RelatedSymGroup
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Symbol Symbol;
    };
};
