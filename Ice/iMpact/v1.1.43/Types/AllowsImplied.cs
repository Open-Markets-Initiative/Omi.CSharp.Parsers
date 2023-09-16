using System.Runtime.CompilerServices;;

namespace Ice.iMpact
{
    /// <summary>
    ///  Allows Implied
    /// </summary>

    public struct AllowsImplied
    {
        /// <summary>
        ///  Implieds Are Allowed In This Market
        /// </summary>
        public const char Yes = 'Y';

        /// <summary>
        ///  Implieds Are Not Allowed In This Market
        /// </summary>
        public const char No = 'N';

        /// <summary>
        ///  Length of Allows Implied in bytes
        /// </summary>
        public const int Length = 1;
    }
}