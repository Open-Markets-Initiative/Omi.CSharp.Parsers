namespace Ice.iMpact;

/// <summary>
///  Market Type Id: Number of cycles for a contract.
/// </summary>

public enum MarketTypeId : short
{
    /// <summary>
    ///  Financial Gas
    /// </summary>
    FinancialGas = 0,

    /// <summary>
    ///  Financial Power
    /// </summary>
    FinancialPower = 1,

    /// <summary>
    ///  Oil
    /// </summary>
    Oil = 2,

    /// <summary>
    ///  Ipe Natural Gas Futures
    /// </summary>
    IpeNaturalGasFutures = 3,

    /// <summary>
    ///  Ipe Gas Oil Futures
    /// </summary>
    IpeGasOilFutures = 4,

    /// <summary>
    ///  Ipe Brent Futures
    /// </summary>
    IpeBrentFutures = 5,

    /// <summary>
    ///  Ipe Uk Electricity Futures Peak
    /// </summary>
    IpeUkElectricityFuturesPeak = 7,

    /// <summary>
    ///  Ipe Uk Electricity Futures Base
    /// </summary>
    IpeUkElectricityFuturesBase = 8,

    /// <summary>
    ///  Ice Wti Crude Futures
    /// </summary>
    IceWtiCrudeFutures = 9,

    /// <summary>
    ///  G C Newcastle Coal Futures
    /// </summary>
    GCNewcastleCoalFutures = 10,

    /// <summary>
    ///  Ice Brent Wti Futures Spread
    /// </summary>
    IceBrentWtiFuturesSpread = 11,

    /// <summary>
    ///  Ipeecx European Emissions
    /// </summary>
    IpeecxEuropeanEmissions = 12,

    /// <summary>
    ///  Ice Heating Oil Futures
    /// </summary>
    IceHeatingOilFutures = 13,

    /// <summary>
    ///  Ice Heating Oil Wti Futures Crack
    /// </summary>
    IceHeatingOilWtiFuturesCrack = 14,

    /// <summary>
    ///  Ice Nyh Rbob Gasoline Futures
    /// </summary>
    IceNyhRbobGasolineFutures = 15,

    /// <summary>
    ///  Ice Nyh Rbob Gasoline Wti Futures Crack
    /// </summary>
    IceNyhRbobGasolineWtiFuturesCrack = 16,

    /// <summary>
    ///  Ice Rotterdam Coal Futures
    /// </summary>
    IceRotterdamCoalFutures = 17,

    /// <summary>
    ///  Ice Richards Bay Coal Futures
    /// </summary>
    IceRichardsBayCoalFutures = 18,

    /// <summary>
    ///  Ice Rotterdam Richards Bay Coal Futures Spread
    /// </summary>
    IceRotterdamRichardsBayCoalFuturesSpread = 19,

    /// <summary>
    ///  Cocoa
    /// </summary>
    Cocoa = 20,

    /// <summary>
    ///  Coffee C
    /// </summary>
    CoffeeC = 21,

    /// <summary>
    ///  Cotton No 2
    /// </summary>
    CottonNo2 = 22,

    /// <summary>
    ///  Fcoj A
    /// </summary>
    FcojA = 23,

    /// <summary>
    ///  Sugar No 11
    /// </summary>
    SugarNo11 = 24,

    /// <summary>
    ///  Heat Rate Spread
    /// </summary>
    HeatRateSpread = 25,

    /// <summary>
    ///  Us Dollar Index
    /// </summary>
    UsDollarIndex = 26,

    /// <summary>
    ///  Canadian Oilseeds
    /// </summary>
    CanadianOilseeds = 36,

    /// <summary>
    ///  Ecx Cer Futures
    /// </summary>
    EcxCerFutures = 38,

    /// <summary>
    ///  Foreign Exchange
    /// </summary>
    ForeignExchange = 39,

    /// <summary>
    ///  Financial Index Data
    /// </summary>
    FinancialIndexData = 40,

    /// <summary>
    ///  Sugar No 16
    /// </summary>
    SugarNo16 = 41,

    /// <summary>
    ///  Ecx Euacer Futures Spread
    /// </summary>
    EcxEuacerFuturesSpread = 42,

    /// <summary>
    ///  Henry Hub
    /// </summary>
    HenryHub = 44,

    /// <summary>
    ///  Dutch Ttf Gas Futures
    /// </summary>
    DutchTtfGasFutures = 48,

    /// <summary>
    ///  German Natural Gas Futures
    /// </summary>
    GermanNaturalGasFutures = 50,

    /// <summary>
    ///  European Gas Spreads
    /// </summary>
    EuropeanGasSpreads = 51,

    /// <summary>
    ///  Canadian Financial Gas
    /// </summary>
    CanadianFinancialGas = 53,

    /// <summary>
    ///  Ngx Canadian Physical Crude
    /// </summary>
    NgxCanadianPhysicalCrude = 54,

    /// <summary>
    ///  Us Coal Futures
    /// </summary>
    UsCoalFutures = 55,

    /// <summary>
    ///  Fob Indo Subbit Coal Futures
    /// </summary>
    FobIndoSubbitCoalFutures = 57,

    /// <summary>
    ///  Heating Oil Brent Futures Crack
    /// </summary>
    HeatingOilBrentFuturesCrack = 58,

    /// <summary>
    ///  Nyh Rbob Gasoline Brent Futures Crack
    /// </summary>
    NyhRbobGasolineBrentFuturesCrack = 59,

    /// <summary>
    ///  Wet Freight
    /// </summary>
    WetFreight = 60,

    /// <summary>
    ///  Dry Freight
    /// </summary>
    DryFreight = 61,

    /// <summary>
    ///  Ferrous Metals
    /// </summary>
    FerrousMetals = 62,

    /// <summary>
    ///  Platts Variable Oil
    /// </summary>
    PlattsVariableOil = 63,

    /// <summary>
    ///  Nyh Rbob Gasoline Heating Oil Spread
    /// </summary>
    NyhRbobGasolineHeatingOilSpread = 66,

    /// <summary>
    ///  Physical Environmental
    /// </summary>
    PhysicalEnvironmental = 69,

    /// <summary>
    ///  Heating Oil Ls Gasoil Futures Spread
    /// </summary>
    HeatingOilLsGasoilFuturesSpread = 70,

    /// <summary>
    ///  Ls Gasoil Brent Futures Crack
    /// </summary>
    LsGasoilBrentFuturesCrack = 71,

    /// <summary>
    ///  Nyh Rbob Gasoline Ls Gasoil Futures Spread
    /// </summary>
    NyhRbobGasolineLsGasoilFuturesSpread = 72,

    /// <summary>
    ///  Ecx Euaa Futures
    /// </summary>
    EcxEuaaFutures = 84,

    /// <summary>
    ///  Ecx Cereuaa Futures Spread
    /// </summary>
    EcxCereuaaFuturesSpread = 85,

    /// <summary>
    ///  Ecx Euaaeua Futures Spread
    /// </summary>
    EcxEuaaeuaFuturesSpread = 86,

    /// <summary>
    ///  Soybean
    /// </summary>
    Soybean = 89,

    /// <summary>
    ///  Ecx Eua Eib Auction
    /// </summary>
    EcxEuaEibAuction = 92,

    /// <summary>
    ///  Financial Lng
    /// </summary>
    FinancialLng = 93,

    /// <summary>
    ///  Eua Uk Auction
    /// </summary>
    EuaUkAuction = 95,

    /// <summary>
    ///  Euaa Uk Auction
    /// </summary>
    EuaaUkAuction = 96,

    /// <summary>
    ///  Cfr South China Coal Futures
    /// </summary>
    CfrSouthChinaCoalFutures = 97,

    /// <summary>
    ///  Belgian Power Futures
    /// </summary>
    BelgianPowerFutures = 98,

    /// <summary>
    ///  Dutch Power Futures
    /// </summary>
    DutchPowerFutures = 99,

    /// <summary>
    ///  G C Newcastle Fob Indo Subbit Coal Futures Spread
    /// </summary>
    GCNewcastleFobIndoSubbitCoalFuturesSpread = 100,

    /// <summary>
    ///  Richards Bayg C Newcastle Coal Futures Spread
    /// </summary>
    RichardsBaygCNewcastleCoalFuturesSpread = 101,

    /// <summary>
    ///  Fcoj A Mini
    /// </summary>
    FcojAMini = 102,

    /// <summary>
    ///  Cif Us
    /// </summary>
    CifUs = 104,

    /// <summary>
    ///  D 6 Rin
    /// </summary>
    D6Rin = 108,

    /// <summary>
    ///  European Power Spreads
    /// </summary>
    EuropeanPowerSpreads = 111,

    /// <summary>
    ///  Taqa
    /// </summary>
    Taqa = 112,

    /// <summary>
    ///  Belgian Ztp Gas Spot
    /// </summary>
    BelgianZtpGasSpot = 113,

    /// <summary>
    ///  Dutch Ttf Gas Spot
    /// </summary>
    DutchTtfGasSpot = 114,

    /// <summary>
    ///  Dutch Ttf Gas Storage
    /// </summary>
    DutchTtfGasStorage = 115,

    /// <summary>
    ///  European Gas Spot Spreads
    /// </summary>
    EuropeanGasSpotSpreads = 116,

    /// <summary>
    ///  Belgian Ztp Gas Futures
    /// </summary>
    BelgianZtpGasFutures = 117,

    /// <summary>
    ///  Uk Ocm Gas Spot
    /// </summary>
    UkOcmGasSpot = 118,

    /// <summary>
    ///  Belgian Gas Spreads
    /// </summary>
    BelgianGasSpreads = 119,

    /// <summary>
    ///  Financial Olefins
    /// </summary>
    FinancialOlefins = 124,

    /// <summary>
    ///  Financial Monomers
    /// </summary>
    FinancialMonomers = 125,

    /// <summary>
    ///  Platts Variable Oil Urals
    /// </summary>
    PlattsVariableOilUrals = 126,

    /// <summary>
    ///  Endex Spot Market Indices
    /// </summary>
    EndexSpotMarketIndices = 127,

    /// <summary>
    ///  Interest Rate Futures
    /// </summary>
    InterestRateFutures = 131,

    /// <summary>
    ///  Singapore Energy
    /// </summary>
    SingaporeEnergy = 133,

    /// <summary>
    ///  Singapore Financials
    /// </summary>
    SingaporeFinancials = 134,

    /// <summary>
    ///  Singapore Metals
    /// </summary>
    SingaporeMetals = 135,

    /// <summary>
    ///  Italian Natural Gas Futures
    /// </summary>
    ItalianNaturalGasFutures = 136,

    /// <summary>
    ///  Italian Power Futures
    /// </summary>
    ItalianPowerFutures = 137,

    /// <summary>
    ///  Credit Swap Data
    /// </summary>
    CreditSwapData = 139,

    /// <summary>
    ///  Gold Fixing
    /// </summary>
    GoldFixing = 140,

    /// <summary>
    ///  North Sea Partials
    /// </summary>
    NorthSeaPartials = 141,

    /// <summary>
    ///  Eu Financial Power Spreads
    /// </summary>
    EuFinancialPowerSpreads = 142,

    /// <summary>
    ///  Eu Financial Power Futures
    /// </summary>
    EuFinancialPowerFutures = 143,

    /// <summary>
    ///  Oil Cad
    /// </summary>
    OilCad = 144,

    /// <summary>
    ///  Silver Fixing
    /// </summary>
    SilverFixing = 147,

    /// <summary>
    ///  Uk Spark Spread
    /// </summary>
    UkSparkSpread = 149,

    /// <summary>
    ///  Uk Ocm Physical Gas Spot
    /// </summary>
    UkOcmPhysicalGasSpot = 150,

    /// <summary>
    ///  Japan Domestic Waterborne
    /// </summary>
    JapanDomesticWaterborne = 152,

    /// <summary>
    ///  Daily Metals
    /// </summary>
    DailyMetals = 154,

    /// <summary>
    ///  Brix Energia Fin
    /// </summary>
    BrixEnergiaFin = 155,

    /// <summary>
    ///  Japan Domestic Rack
    /// </summary>
    JapanDomesticRack = 156,

    /// <summary>
    ///  Financial Us Lng
    /// </summary>
    FinancialUsLng = 157,

    /// <summary>
    ///  Ice Rotterdam Newcastle Coal Futures Spread
    /// </summary>
    IceRotterdamNewcastleCoalFuturesSpread = 160,

    /// <summary>
    ///  Oil Americas
    /// </summary>
    OilAmericas = 165,

    /// <summary>
    ///  Platts Petrochemical
    /// </summary>
    PlattsPetrochemical = 167,

    /// <summary>
    ///  Permian Wti Futures
    /// </summary>
    PermianWtiFutures = 168,

    /// <summary>
    ///  Endex Equity Indices
    /// </summary>
    EndexEquityIndices = 170,

    /// <summary>
    ///  Endex Single Stock Options
    /// </summary>
    EndexSingleStockOptions = 171,

    /// <summary>
    ///  Ifus Ice Indices
    /// </summary>
    IfusIceIndices = 172,

    /// <summary>
    ///  Platts Asia Bunker
    /// </summary>
    PlattsAsiaBunker = 173,

    /// <summary>
    ///  Sofr Futures
    /// </summary>
    SofrFutures = 177,

    /// <summary>
    ///  Digital Asset Futures
    /// </summary>
    DigitalAssetFutures = 178,

    /// <summary>
    ///  Permian Brent Futures Spread
    /// </summary>
    PermianBrentFuturesSpread = 179,

    /// <summary>
    ///  Permian Wti Futures Spread
    /// </summary>
    PermianWtiFuturesSpread = 180,

    /// <summary>
    ///  Liffe Sti Rs
    /// </summary>
    LiffeStiRs = 200,

    /// <summary>
    ///  Liffe Bonds
    /// </summary>
    LiffeBonds = 202,

    /// <summary>
    ///  Liffe Swapnotes
    /// </summary>
    LiffeSwapnotes = 203,

    /// <summary>
    ///  1
    /// </summary>
    1 = 205,

    /// <summary>
    ///  Metals
    /// </summary>
    Metals = 206,

    /// <summary>
    ///  Ifus Equity Indices
    /// </summary>
    IfusEquityIndices = 207,

    /// <summary>
    ///  Gcf Repo
    /// </summary>
    GcfRepo = 208,

    /// <summary>
    ///  Liffe Three Month Euro And Eonia
    /// </summary>
    LiffeThreeMonthEuroAndEonia = 209,

    /// <summary>
    ///  Eurodollar
    /// </summary>
    Eurodollar = 210,

    /// <summary>
    ///  Liffe Equity Derivatives Non Us Based
    /// </summary>
    LiffeEquityDerivativesNonUsBased = 211,

    /// <summary>
    ///  Liffe Equity Derivatives Us Based
    /// </summary>
    LiffeEquityDerivativesUsBased = 212,

    /// <summary>
    ///  Liffe Index Options
    /// </summary>
    LiffeIndexOptions = 213,

    /// <summary>
    ///  Liffe Index Futures Us Restricted
    /// </summary>
    LiffeIndexFuturesUsRestricted = 214,

    /// <summary>
    ///  Liffe Index Futures Non Us Restricted
    /// </summary>
    LiffeIndexFuturesNonUsRestricted = 215,

    /// <summary>
    ///  Physical Gas
    /// </summary>
    PhysicalGas = 305,

    /// <summary>
    ///  Power
    /// </summary>
    Power = 306,

    /// <summary>
    ///  Ngx Physical Gas
    /// </summary>
    NgxPhysicalGas = 314,

    /// <summary>
    ///  Ngx Financial Power
    /// </summary>
    NgxFinancialPower = 315,

    /// <summary>
    ///  Ngx Financial Gas
    /// </summary>
    NgxFinancialGas = 316,

    /// <summary>
    ///  Financial Ngl
    /// </summary>
    FinancialNgl = 317,

    /// <summary>
    ///  Olefins Polymers
    /// </summary>
    OlefinsPolymers = 318,

    /// <summary>
    ///  Physical Ngl
    /// </summary>
    PhysicalNgl = 319,

    /// <summary>
    ///  Physical Oil
    /// </summary>
    PhysicalOil = 320,

    /// <summary>
    ///  Test Ipe
    /// </summary>
    TestIpe = 600,

    /// <summary>
    ///  Test Nybot
    /// </summary>
    TestNybot = 601,

    /// <summary>
    ///  Test Ndex
    /// </summary>
    TestNdex = 602,

    /// <summary>
    ///  Test Liffeuk 1
    /// </summary>
    TestLiffeuk1 = 603,

    /// <summary>
    ///  Test Liffeuk 2
    /// </summary>
    TestLiffeuk2 = 604,

}
