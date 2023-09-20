using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Dirty Price: 8 Byte Fixed Width Integer with 9 Decimal Place Precision
    /// </summary>

    public struct DirtyPrice
    {
        /// <summary>
        ///  Fix Tag for Dirty Price
        /// </summary>
        public const ushort FixTag = 37001;

        /// <summary>
        ///  Length of Dirty Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Dirty Price
        /// </summary>
        public const int Factor = 1000000000;
    }
}