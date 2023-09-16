namespace Cme.Mdp3
{
    /// <summary>
    ///  Security Alt Id Source: Identifies class or source of the SecurityAltID (455) value
    /// </summary>
    public enum SecurityAltIdSource : byte
    {
        /// <summary>
        ///  Identifies class or source of the SecurityAltID (455) value
        /// </summary>
        NoValue = 255;

        /// <summary>
        ///  CUSIP (9 char)
        /// </summary>
        Cusip = 1;

        /// <summary>
        ///  ISIN (12 char)
        /// </summary>
        Isin = 4;

    }
}