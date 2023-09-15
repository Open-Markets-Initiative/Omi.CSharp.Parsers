namespace Ice.iMpact
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Settlement Type
    /// </summary>

    public struct SettlementType
    {
        /// <summary>
        ///  Financial
        /// </summary>
        public const char Financial = '0';

        /// <summary>
        ///  Physical
        /// </summary>
        public const char Physical = '1';

        /// <summary>
        ///  Length of Settlement Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}