namespace Cme.Sbe
{
    /// <summary>
    ///  Order Update Action: Order book update action to be applied to the order referenced by OrderID
    /// </summary>
    public enum OrderUpdateAction : byte
    {
        /// <summary>
        ///  New
        /// </summary>
        New = 0;

        /// <summary>
        ///  Update
        /// </summary>
        Update = 1;

        /// <summary>
        ///  Delete
        /// </summary>
        Delete = 2;

    }
}