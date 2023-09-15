namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Contra Covered Or Uncovered: Identifies the Exposed or Covered Side when the contra side was Cross
    /// </summary>
    public enum ContraCoveredOrUncovered : byte
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