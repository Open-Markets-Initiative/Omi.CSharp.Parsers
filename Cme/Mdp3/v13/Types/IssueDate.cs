using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Issue Date: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct IssueDate
    {
        /// <summary>
        ///  Length of Issue Date in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Issue Date
        /// </summary>
        public const ushort NoValue = 65535;
    }
}