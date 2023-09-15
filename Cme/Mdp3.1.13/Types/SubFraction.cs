namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Sub Fraction: One Byte Fixed Width Integer
    /// </summary>

    public struct SubFraction
    {
        /// <summary>
        ///  Fix Tag for Sub Fraction
        /// </summary>
        public const ushort FixTag = 37703;

        /// <summary>
        ///  Length of Sub Fraction in bytes
        /// </summary>
        public const int Length = 1;
    }
}