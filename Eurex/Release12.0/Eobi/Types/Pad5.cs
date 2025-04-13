namespace Eurex.Eobi
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Pad 5: Fixed Length Data Field
    /// </summary>

    public struct Pad5
    {
        /// <summary>
        ///  Fix Tag for Pad 5
        /// </summary>
        public const ushort FixTag = 25020;

        /// <summary>
        ///  Length of Pad 5 in bytes
        /// </summary>
        public const int Length = 5;
    }
}