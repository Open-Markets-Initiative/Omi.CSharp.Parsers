namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Contra Open Close: Indicates sender’s position
    /// </summary>
    public enum ContraOpenClose : byte
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        NotApplicable = 0;

        /// <summary>
        ///  Open
        /// </summary>
        Open = 1;

        /// <summary>
        ///  Close
        /// </summary>
        Close = 2;

    }
}