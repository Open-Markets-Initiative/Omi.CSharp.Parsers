namespace Eurex.T7
{
    /// <summary>
    ///  Trad Ses Status:
    /// </summary>
    public enum TradSesStatus : byte
    {
        /// <summary>
        ///  
        /// </summary>
        Halted = 1;

        /// <summary>
        ///  
        /// </summary>
        Open = 2;

        /// <summary>
        ///  
        /// </summary>
        Closed = 3;

        /// <summary>
        ///  
        /// </summary>
        TradSesStatusMaximumValue = 3;

        /// <summary>
        ///  
        /// </summary>
        TradSesStatusMinimumValue = 1;

    }
}