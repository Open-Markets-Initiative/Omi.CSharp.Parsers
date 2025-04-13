namespace Eurex.Eobi
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Pad 1: Fixed Length Data Field
    /// </summary>

    public struct Pad1
    {
        /// <summary>
        ///  Fix Tag for Pad 1
        /// </summary>
        public const ushort FixTag = 25016;

        /// <summary>
        ///  Length of Pad 1 in bytes
        /// </summary>
        public const int Length = 1;
    }
}