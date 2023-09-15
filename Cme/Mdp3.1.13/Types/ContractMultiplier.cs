namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Contract Multiplier: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct ContractMultiplier
    {
        /// <summary>
        ///  Length of Contract Multiplier in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Contract Multiplier
        /// </summary>
        public const int NoValue = 2147483647;
    }
}