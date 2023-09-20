namespace Eurex.Eobi
{
    /// <summary>
    ///  Aggressor Side
    /// </summary>
    public enum AggressorSide : byte
    {
        /// <summary>
        ///  Triggered by the buy side
        /// </summary>
        Buy = 1,

        /// <summary>
        ///  Triggered by the sell side
        /// </summary>
        Sell = 2,

        /// <summary>
        ///  
        /// </summary>
        AggressorSideMaximumValue = 2,

        /// <summary>
        ///  
        /// </summary>
        AggressorSideMinimumValue = 1,

    }
}