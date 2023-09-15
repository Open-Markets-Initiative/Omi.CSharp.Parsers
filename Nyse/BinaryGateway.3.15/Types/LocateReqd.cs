namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Locate Reqd: 0 = No LocateReqd, or Not Applicable 1 = LocateReq for SSH orders
    /// </summary>
    public enum LocateReqd : byte
    {
        /// <summary>
        ///  No Locate Reqd
        /// </summary>
        NoLocateReqd = 0;

        /// <summary>
        ///  Locate Req For Ssh Orders
        /// </summary>
        LocateReqForSshOrders = 1;

    }
}