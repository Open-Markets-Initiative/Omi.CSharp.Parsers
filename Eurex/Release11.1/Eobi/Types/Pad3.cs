namespace Eurex.Eobi
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Pad 3: Fixed Length Data Field
    /// </summary>

    public sealed class Pad3
    {
        /// <summary>
        ///  Fix Tag for Pad 3
        /// </summary>
        public const ushort FixTag = 25018;

        /// <summary>
        ///  Length of Pad 3 in bytes
        /// </summary>
        public const int Length = 3;
    }
}