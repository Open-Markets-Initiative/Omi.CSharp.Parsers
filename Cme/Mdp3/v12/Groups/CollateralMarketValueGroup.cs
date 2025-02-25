using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Collateral Market Value Group: Number of data blocks listed in the Incremental message
    /// </summary>

    public partial class CollateralMarketValueGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public UnderlyingSecurityAltId UnderlyingSecurityAltId;
            public UnderlyingSecurityAltIdSource UnderlyingSecurityAltIdSource;
            public CollateralMarketPrice CollateralMarketPrice;
            public DirtyPrice DirtyPrice;
            public UnderlyingInstrumentGuid UnderlyingInstrumentGuid;
            public MdStreamId MdStreamId;
            public Padding2 Padding2;
        };
    };
}