namespace Eurex.Eobi
{
    /// <summary>
    ///  Tes Trad Ses Status
    /// </summary>
    public enum TesTradSesStatus : byte
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
        PreClose = 5;

        /// <summary>
        ///  
        /// </summary>
        TesTradSesStatusMaximumValue = 5;

        /// <summary>
        ///  
        /// </summary>
        TesTradSesStatusMinimumValue = 1;

    }
}