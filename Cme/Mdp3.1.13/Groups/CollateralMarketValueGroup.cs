using System.Runtime.InteropServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Collateral Market Value Group: Number of data blocks listed in the Incremental message
    /// </summary>

    public partial class CollateralMarketValueGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            UnderlyingSecurityAltId UnderlyingSecurityAltId;
            UnderlyingSecurityAltIdSource UnderlyingSecurityAltIdSource;
            CollateralMarketPrice CollateralMarketPrice;
            DirtyPrice DirtyPrice;
            UnderlyingInstrumentGuid UnderlyingInstrumentGuid;
            MdStreamId MdStreamId;
            Padding2 Padding2;
        };
    };
}