namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Mm Type: MMType
    /// </summary>
    public enum MmType : byte
    {
        /// <summary>
        ///  Nyse American Options Market Maker
        /// </summary>
        NyseAmericanOptionsMarketMaker = 1;

        /// <summary>
        ///  Nyse American Options Specialist
        /// </summary>
        NyseAmericanOptionsSpecialist = 2;

        /// <summary>
        ///  Nyse American Options E Specialist
        /// </summary>
        NyseAmericanOptionsESpecialist = 3;

        /// <summary>
        ///  Nyse American Options Domm
        /// </summary>
        NyseAmericanOptionsDomm = 4;

        /// <summary>
        ///  Nyse American Options Specialist And Domm
        /// </summary>
        NyseAmericanOptionsSpecialistAndDomm = 5;

        /// <summary>
        ///  Nyse American Options E Specialist And Domm
        /// </summary>
        NyseAmericanOptionsESpecialistAndDomm = 6;

    }
}