namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Reinstatement Requiredby Self: Indicates whether Reinstatement Approval from SELF (the Risk User to which this message is sent) is required for this Risk Entity upon breach
    /// </summary>
    public enum ReinstatementRequiredbySelf : byte
    {
        /// <summary>
        ///  Not Required
        /// </summary>
        NotRequired = 0,

        /// <summary>
        ///  Required
        /// </summary>
        Required = 1,

    }
}