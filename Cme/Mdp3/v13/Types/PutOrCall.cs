namespace Cme.Mdp3
{
    /// <summary>
    ///  Put Or Call: Indicates whether an option instrument is a put or call
    /// </summary>
    public enum PutOrCall : byte
    {
        /// <summary>
        ///  PutOrCall Fix Tag
        /// </summary>
        Fix = 201,

        /// <summary>
        ///  Put Option
        /// </summary>
        Put = 0,

        /// <summary>
        ///  Call Option
        /// </summary>
        Call = 1,

    }
}