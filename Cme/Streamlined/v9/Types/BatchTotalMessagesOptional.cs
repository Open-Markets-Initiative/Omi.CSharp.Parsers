using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Batch Total Messages Optional: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public struct BatchTotalMessagesOptional
    {
        /// <summary>
        ///  Length of Batch Total Messages Optional in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Batch Total Messages Optional
        /// </summary>
        public const ushort NoValue = 65535;
    }
}