namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Contra Cross Type: 0 = Not Applicable
    /// </summary>
    public enum ContraCrossType : ushort
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0;

        /// <summary>
        ///  Price Improvement Cube
        /// </summary>
        PriceImprovementCube = 5;

        /// <summary>
        ///  Aon Cube Solicitation
        /// </summary>
        AonCubeSolicitation = 7;

        /// <summary>
        ///  Qcc
        /// </summary>
        Qcc = 10;

        /// <summary>
        ///  Customer To Customer Cross
        /// </summary>
        CustomerToCustomerCross = 11;

    }
}