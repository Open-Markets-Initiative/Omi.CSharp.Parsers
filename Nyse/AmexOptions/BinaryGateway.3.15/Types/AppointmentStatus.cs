namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Appointment Status: AppointmentStatus
    /// </summary>
    public enum AppointmentStatus : byte
    {
        /// <summary>
        ///  Not Appointed For Underlying Symbol
        /// </summary>
        NotAppointedForUnderlyingSymbol = 0;

        /// <summary>
        ///  Appointed For Underlying Symbol
        /// </summary>
        AppointedForUnderlyingSymbol = 1;

    }
}