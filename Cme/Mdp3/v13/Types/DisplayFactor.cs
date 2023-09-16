using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Display Factor: 8 Byte Fixed Width Integer with 9 Decimal Place Precision
    /// </summary>

    public struct DisplayFactor
    {
        /// <summary>
        ///  Fix Tag for Display Factor
        /// </summary>
        public const ushort FixTag = 9787;

        /// <summary>
        ///  Length of Display Factor in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Display Factor
        /// </summary>
        public const int Factor = 1000000000;
    }
}