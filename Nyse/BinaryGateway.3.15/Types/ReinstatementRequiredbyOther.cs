namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Reinstatement Requiredby Other: Indicates whether Reinstatement Approval from OTHER Risk User(s) is required for this Risk Entity upon breach
    /// </summary>
    public enum ReinstatementRequiredbyOther : byte
    {
        /// <summary>
        ///  Not Required
        /// </summary>
        NotRequired = 0;

        /// <summary>
        ///  Required
        /// </summary>
        Required = 1;

    }
}