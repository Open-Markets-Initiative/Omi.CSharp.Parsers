namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Risk Ack Type: RiskAckType
    /// </summary>
    public enum RiskAckType : byte
    {
        /// <summary>
        ///  Solicited Ack
        /// </summary>
        SolicitedAck = 0,

        /// <summary>
        ///  Unsolicited Ack
        /// </summary>
        UnsolicitedAck = 1,

    }
}