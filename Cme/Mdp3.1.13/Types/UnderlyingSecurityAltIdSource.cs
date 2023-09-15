namespace Cme.Sbe
{
    /// <summary>
    ///  Underlying Security Alt Id Source: Identifies class or source of the UnderlyingSecurityAltID (458) value
    /// </summary>
    public enum UnderlyingSecurityAltIdSource : byte
    {
        /// <summary>
        ///  Identifies class or source of the UnderlyingSecurityAltID (458) value
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