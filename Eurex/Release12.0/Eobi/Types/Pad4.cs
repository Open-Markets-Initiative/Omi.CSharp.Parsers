namespace Eurex.Eobi
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Pad 4: Fixed Length Data Field
    /// </summary>

    public sealed class Pad4
    {
        /// <summary>
        ///  Fix Tag for Pad 4
        /// </summary>
        public const ushort FixTag = 25019;

        /// <summary>
        ///  Length of Pad 4 in bytes
        /// </summary>
        public const int Length = 4;
    }
}