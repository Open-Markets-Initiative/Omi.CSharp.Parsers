using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Md Instrument Definition Eris: MDInstrumentDefinitionEris
    /// </summary>

    public partial class MdInstrumentDefinitionEris
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityGroup12 SecurityGroup12;
            Symbol Symbol;
            SecurityType4 SecurityType4;
            ProductOptional ProductOptional;
            SecurityExchange SecurityExchange;
            MaturityDate MaturityDate;
            Currency Currency;
            MinPriceIncrement MinPriceIncrement;
            SecurityUpdateAction SecurityUpdateAction;
            RateType RateType;
            CouponRate CouponRate;
            UserDefinedInstrument UserDefinedInstrument;
            ApplId ApplId;
        };
    };
}