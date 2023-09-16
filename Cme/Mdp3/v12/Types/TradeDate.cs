using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Trade Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct TradeDate
    {
        /// <summary>
        ///  Length of Trade Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Trade Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}