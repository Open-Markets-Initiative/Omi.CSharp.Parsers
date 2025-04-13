namespace Eurex.Eobi
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Pad 6: Fixed Length Data Field
    /// </summary>

    public struct Pad6
    {
        /// <summary>
        ///  Fix Tag for Pad 6
        /// </summary>
        public const ushort FixTag = 25021;

        /// <summary>
        ///  Length of Pad 6 in bytes
        /// </summary>
        public const int Length = 6;
    }
}