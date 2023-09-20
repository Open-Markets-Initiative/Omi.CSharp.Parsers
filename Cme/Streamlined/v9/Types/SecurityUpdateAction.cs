using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Security Update Action: Zeroed Character Enum
    /// </summary>

    public struct SecurityUpdateAction
    {
        /// <summary>
        ///  Add
        /// </summary>
        public const char Add = 'A';

        /// <summary>
        ///  Delete
        /// </summary>
        public const char Delete = 'D';

        /// <summary>
        ///  Modify
        /// </summary>
        public const char Modify = 'M';

        /// <summary>
        ///  Fix Tag for Security Update Action
        /// </summary>
        public const ushort FixTag = 980;

        /// <summary>
        ///  Length of Security Update Action in bytes
        /// </summary>
        public const int Length = 1;
    }
}