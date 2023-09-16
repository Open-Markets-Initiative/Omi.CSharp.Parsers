using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Appl Id: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct ApplId
    {
        /// <summary>
        ///  Length of Appl Id in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Appl Id
        /// </summary>
        public const ushort NoValue = 65535;
    }
}