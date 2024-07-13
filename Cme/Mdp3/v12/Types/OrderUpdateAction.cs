namespace Cme.Mdp3
{
    /// <summary>
    ///  Order Update Action: Order book update action to be applied to the order referenced by OrderID
    /// </summary>
    public enum OrderUpdateAction : byte
    {
        /// <summary>
        ///  OrderUpdateAction Fix Tag
        /// </summary>
        Fix = 37708,

        /// <summary>
        ///  New
        /// </summary>
        New = 0,

        /// <summary>
        ///  Update
        /// </summary>
        Update = 1,

        /// <summary>
        ///  Delete
        /// </summary>
        Delete = 2,

    }
}