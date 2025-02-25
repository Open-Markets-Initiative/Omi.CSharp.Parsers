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
            public TransactTime TransactTime;
            public MatchEventIndicator MatchEventIndicator;
            public Padding2 Padding2;
        };
    };
}