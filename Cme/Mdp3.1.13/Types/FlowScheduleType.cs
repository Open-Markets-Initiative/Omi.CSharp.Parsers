namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Flow Schedule Type: One Byte Fixed Width Integer
    /// </summary>

    public struct FlowScheduleType
    {
        /// <summary>
        ///  Fix Tag for Flow Schedule Type
        /// </summary>
        public const ushort FixTag = 1439;

        /// <summary>
        ///  Length of Flow Schedule Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}