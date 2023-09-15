namespace Cme.Sbe
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Heart Bt Int: One Byte Fixed Width Integer
    /// </summary>

    public struct HeartBtInt
    {
        /// <summary>
        ///  Fix Tag for Heart Bt Int
        /// </summary>
        public const ushort FixTag = 108;

        /// <summary>
        ///  Length of Heart Bt Int in bytes
        /// </summary>
        public const int Length = 1;
    }
}