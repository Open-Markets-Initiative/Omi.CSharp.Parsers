namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Msg Type: Pillar stream message type
    /// </summary>
    public enum MsgType : ushort
    {
        /// <summary>
        ///  Login
        /// </summary>
        Login = 0x0201,

        /// <summary>
        ///  Login Response
        /// </summary>
        LoginResponse = 0x0202,

        /// <summary>
        ///  Stream Avail
        /// </summary>
        StreamAvail = 0x0203,

        /// <summary>
        ///  Heartbeat
        /// </summary>
        Heartbeat = 0x0204,

        /// <summary>
        ///  Open
        /// </summary>
        Open = 0x0205,

        /// <summary>
        ///  Open Response
        /// </summary>
        OpenResponse = 0x0206,

        /// <summary>
        ///  Close
        /// </summary>
        Close = 0x0207,

        /// <summary>
        ///  Close Response
        /// </summary>
        CloseResponse = 0x0208,

        /// <summary>
        ///  Sequenced Message
        /// </summary>
        SeqMsg = 0x0905,

    }
}