namespace Cme.Sbe
{
    /// <summary>
    ///  Repo Sub Type: Repo Sub Security Type
    /// </summary>
    public enum RepoSubType : byte
    {
        /// <summary>
        ///  Repo on a single underlying instrument
        /// </summary>
        Special = 0;

        /// <summary>
        ///  General Collateral Repo on a single or basket of eligible underlyings, allocation at BrokerTec
        /// </summary>
        Gc = 1;

        /// <summary>
        ///  General Collateral Repo on a single or basket of eligible underlyings, allocation outside of BrokerTec, such as at the clearer, tri-party agent, etc.
        /// </summary>
        GcForDbv = 2;

    }
}