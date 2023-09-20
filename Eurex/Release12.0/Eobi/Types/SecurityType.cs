namespace Eurex.Eobi
{
    /// <summary>
    ///  Security Type
    /// </summary>
    public enum SecurityType : byte
    {
        /// <summary>
        ///  Option
        /// </summary>
        Opt = 1,

        /// <summary>
        ///  Future
        /// </summary>
        Fut = 2,

        /// <summary>
        ///  Multi-Leg
        /// </summary>
        Mleg = 3,

        /// <summary>
        ///  
        /// </summary>
        SecurityTypeMaximumValue = 3,

        /// <summary>
        ///  
        /// </summary>
        SecurityTypeMinimumValue = 1,

    }
}