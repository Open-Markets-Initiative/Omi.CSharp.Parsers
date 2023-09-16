using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Security Id Optional: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public struct SecurityIdOptional
    {
        /// <summary>
        ///  Length of Security Id Optional in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Security Id Optional
        /// </summary>
        public const int NoValue = 2147483647;
    }
}