namespace Eurex.Eobi
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Pad 7: Fixed Length Data Field
    /// </summary>

    public sealed class Pad7
    {
        /// <summary>
        ///  Fix Tag for Pad 7
        /// </summary>
        public const ushort FixTag = 25022;

        /// <summary>
        ///  Length of Pad 7 in bytes
        /// </summary>
        public const int Length = 7;
    }
}