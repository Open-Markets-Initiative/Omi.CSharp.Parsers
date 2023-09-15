namespace Cme.Sbe
{
    /// <summary>
    ///  Money Or Par: Money or Par indicates if the GC is filled by par amount or by money amount
    /// </summary>
    public enum MoneyOrPar : byte
    {
        /// <summary>
        ///  Money or Par indicates if the GC is filled by par amount or by money amount
        /// </summary>
        NoValue = 255;

        /// <summary>
        ///  Money Filled
        /// </summary>
        Money = 1;

        /// <summary>
        ///  Par Filled
        /// </summary>
        Par = 2;

    }
}