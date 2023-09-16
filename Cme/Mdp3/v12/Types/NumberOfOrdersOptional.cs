using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Number Of Orders Optional: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct NumberOfOrdersOptional
    {
        /// <summary>
        ///  Length of Number Of Orders Optional in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Number Of Orders Optional
        /// </summary>
        public const int NoValue = 2147483647;
    }
}