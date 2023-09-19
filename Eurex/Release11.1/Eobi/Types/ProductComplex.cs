namespace Eurex.Eobi
{
    /// <summary>
    ///  Product Complex
    /// </summary>
    public enum ProductComplex : byte
    {
        /// <summary>
        ///  
        /// </summary>
        SimpleInstrument = 1;

        /// <summary>
        ///  
        /// </summary>
        StandardOptionStrategy = 2;

        /// <summary>
        ///  
        /// </summary>
        NonStandardOptionStrategy = 3;

        /// <summary>
        ///  
        /// </summary>
        VolatilityStrategy = 4;

        /// <summary>
        ///  
        /// </summary>
        FuturesSpread = 5;

        /// <summary>
        ///  
        /// </summary>
        InterProductSpread = 6;

        /// <summary>
        ///  
        /// </summary>
        StandardFuturesStrategy = 7;

        /// <summary>
        ///  
        /// </summary>
        PackAndBundle = 8;

        /// <summary>
        ///  
        /// </summary>
        Strip = 9;

        /// <summary>
        ///  
        /// </summary>
        FlexibleInstrument = 10;

        /// <summary>
        ///  
        /// </summary>
        CommodityStrip = 11;

        /// <summary>
        ///  
        /// </summary>
        ProductComplexMaximumValue = 11;

        /// <summary>
        ///  
        /// </summary>
        ProductComplexMinimumValue = 1;

    }
}