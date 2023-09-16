using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Year: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct Year
    {
        /// <summary>
        ///  Length of Year in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Year
        /// </summary>
        public const ushort NoValue = 65535;
    }
}