using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Alt Min Quote Life: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct AltMinQuoteLife
    {
        /// <summary>
        ///  Length of Alt Min Quote Life in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Alt Min Quote Life
        /// </summary>
        public const uint NoValue = 4294967295;
    }
}