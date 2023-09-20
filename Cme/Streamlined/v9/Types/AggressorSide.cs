namespace Cme.Streamlined
{
    /// <summary>
    ///  Aggressor Side: Indicates which side is aggressor of the trade. If there is no value present, then there is no aggressor.
    /// </summary>
    public enum AggressorSide : byte
    {
        /// <summary>
        ///  Indicates which side is aggressor of the trade. If there is no value present, then there is no aggressor.
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