namespace Siac.Recipient
{
    /// <summary>
    ///  Session Indicator: 0 X 00 For Regular Trading Session
    /// </summary>
    public enum SessionIndicator : byte
    {
        /// <summary>
        ///  Regular Trading Session
        /// </summary>
        Regular = 0,

        /// <summary>
        ///  Pre Market Extended Hours Trading Session
        /// </summary>
        PreMarket = 88,

    }
}