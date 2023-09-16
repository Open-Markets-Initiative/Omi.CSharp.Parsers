namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Bulk Action: For all sessions
    /// </summary>
    public enum BulkAction : byte
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0;

        /// <summary>
        ///  Cancel Single Leg Only
        /// </summary>
        CancelSingleLegOnly = 1;

        /// <summary>
        ///  Cancel Complex Only
        /// </summary>
        CancelComplexOnly = 2;

        /// <summary>
        ///  Cancel Both Single Leg And Complex
        /// </summary>
        CancelBothSingleLegAndComplex = 3;

        /// <summary>
        ///  Block And Cancel
        /// </summary>
        BlockAndCancel = 4;

        /// <summary>
        ///  Unblock
        /// </summary>
        Unblock = 5;

    }
}