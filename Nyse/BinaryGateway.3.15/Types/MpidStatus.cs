namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Mpid Status: Indicates the status of the MPID.
    /// </summary>
    public enum MpidStatus : byte
    {
        /// <summary>
        ///  Active
        /// </summary>
        Active = 1;

        /// <summary>
        ///  Inactive
        /// </summary>
        Inactive = 2;

        /// <summary>
        ///  Prospect
        /// </summary>
        Prospect = 3;

    }
}