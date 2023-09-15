namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Covered Or Uncovered: Identifies the Exposed and Covered Side of each order in the Cross
    /// </summary>
    public enum CoveredOrUncovered : byte
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0;

        /// <summary>
        ///  Exposed
        /// </summary>
        Exposed = 1;

        /// <summary>
        ///  Covered
        /// </summary>
        Covered = 2;

    }
}