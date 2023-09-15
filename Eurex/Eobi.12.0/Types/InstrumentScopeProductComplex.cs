namespace Eurex.T7
{
    /// <summary>
    ///  Instrument Scope Product Complex:
    /// </summary>
    public enum InstrumentScopeProductComplex : byte
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
        InstrumentScopeProductComplexMaximumValue = 11;

        /// <summary>
        ///  
        /// </summary>
        InstrumentScopeProductComplexMinimumValue = 1;

    }
}