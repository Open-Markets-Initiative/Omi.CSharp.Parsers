namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Reference Id: One Byte Fixed Width Integer
    /// </summary>

    public struct ReferenceId
    {
        /// <summary>
        ///  Fix Tag for Reference Id
        /// </summary>
        public const ushort FixTag = 9633;

        /// <summary>
        ///  Length of Reference Id in bytes
        /// </summary>
        public const int Length = 1;
    }
}