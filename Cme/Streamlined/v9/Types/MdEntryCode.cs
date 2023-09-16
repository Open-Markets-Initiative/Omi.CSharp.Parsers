namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Entry Code: List of conditions describing a index value
    /// </summary>
    public enum MdEntryCode : byte
    {
        /// <summary>
        ///  List of conditions describing a index value
        /// </summary>
        NoValue = 255;

        /// <summary>
        ///  Indicative
        /// </summary>
        Indicative = 1;

        /// <summary>
        ///  PreMarket
        /// </summary>
        PreMarket = 2;

        /// <summary>
        ///  PreliminaryClose
        /// </summary>
        PreliminaryClose = 3;

        /// <summary>
        ///  SessionClose
        /// </summary>
        SessionClose = 4;

        /// <summary>
        ///  Close
        /// </summary>
        Close = 5;

    }
}