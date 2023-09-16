using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Start Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct StartDate
    {
        /// <summary>
        ///  Length of Start Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Start Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}