using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Broken Dates Groups: This group indicates the number of broken dates and references individual broken contracts in user defined tailor made repo. Applicable only to tailor made repos requested by traders with broken dates Block
    /// </summary>

    public partial class BrokenDatesGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}