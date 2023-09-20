namespace Cme.Mdp3
{
    /// <summary>
    ///  Aggressor Side: Indicates which side is the aggressor or if there is no aggressor
    /// </summary>
    public enum AggressorSide : byte
    {
        /// <summary>
        ///  Indicates which side is the aggressor or if there is no aggressor
        /// </summary>
        NoValue = 255,

        /// <summary>
        ///  No Aggressor
        /// </summary>
        NoAggressor = 0,

        /// <summary>
        ///  Buy
        /// </summary>
        Buy = 1,

        /// <summary>
        ///  Sell
        /// </summary>
        Sell = 2,

    }
}