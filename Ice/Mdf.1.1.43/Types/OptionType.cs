namespace Ice.iMpact
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Option Type
    /// </summary>

    public struct OptionType
    {
        /// <summary>
        ///  Call Option
        /// </summary>
        public const char Call = 'C';

        /// <summary>
        ///  Put Option
        /// </summary>
        public const char Put = 'P';

        /// <summary>
        ///  Length of Option Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}