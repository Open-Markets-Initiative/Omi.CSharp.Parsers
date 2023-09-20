namespace Cme.Mdp3
{
    /// <summary>
    ///  Open Close Settl Flag: Flag describing IOP and Open Price entries
    /// </summary>
    public enum OpenCloseSettlFlag : byte
    {
        /// <summary>
        ///  Flag describing IOP and Open Price entries
        /// </summary>
        NoValue = 255,

        /// <summary>
        ///  Daily Open Price
        /// </summary>
        DailyOpenPrice = 0,

        /// <summary>
        ///  Indicative Opening Price
        /// </summary>
        IndicativeOpeningPrice = 5,

        /// <summary>
        ///  Latest update to VWAP
        /// </summary>
        IntradayVwap = 100,

        /// <summary>
        ///  Repo Average 8-30 AM
        /// </summary>
        RepoAverage830Am = 101,

        /// <summary>
        ///  Repo Average 10 AM
        /// </summary>
        RepoAverage10Am = 102,

        /// <summary>
        ///  Prev Session Repo Average 10 AM
        /// </summary>
        PrevSessionRepoAverage10Am = 103,

    }
}