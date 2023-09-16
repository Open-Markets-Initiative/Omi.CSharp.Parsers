using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Related Sym Groups: Indicates the number of repeating symbols specified Block
    /// </summary>

    public partial class RelatedSymGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}