using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Expiration Block
    /// </summary>

    public partial class ExpirationBlock
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            ExpirationMonth ExpirationMonth;
            ExpirationDay ExpirationDay;
            ExpirationYear ExpirationYear;
        };
    };
}