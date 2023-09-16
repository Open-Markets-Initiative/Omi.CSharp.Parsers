using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Collateral Market Value Groups: Number of data blocks listed in the Incremental message Block
    /// </summary>

    public partial class CollateralMarketValueGroups
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            GroupSize GroupSize;
        };
    };
}