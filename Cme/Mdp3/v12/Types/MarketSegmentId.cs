using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Market Segment Id: One Byte Fixed Width Integer
    /// </summary>

    public struct MarketSegmentId
    {
        /// <summary>
        ///  Fix Tag for Market Segment Id
        /// </summary>
        public const ushort FixTag = 1300;

        /// <summary>
        ///  Length of Market Segment Id in bytes
        /// </summary>
        public const int Length = 1;
    }
}