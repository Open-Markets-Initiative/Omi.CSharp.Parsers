using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Collateral Market Value: CollateralMarketValue
    /// </summary>

    public partial class CollateralMarketValue
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MatchEventIndicator MatchEventIndicator;
            Padding2 Padding2;
        };
    };
}