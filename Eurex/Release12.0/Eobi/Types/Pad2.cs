namespace Eurex.Eobi
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Pad 2: Fixed Length Data Field
    /// </summary>

    public struct Pad2
    {
        /// <summary>
        ///  Fix Tag for Pad 2
        /// </summary>
        public const ushort FixTag = 25017;

        /// <summary>
        ///  Length of Pad 2 in bytes
        /// </summary>
        public const int Length = 2;
    }
}