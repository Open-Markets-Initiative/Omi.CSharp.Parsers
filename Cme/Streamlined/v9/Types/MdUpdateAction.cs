namespace Cme.Streamlined;

/// <summary>
///  Md Update Action: Market Data update Action
/// </summary>

public enum MdUpdateAction : byte
{
    /// <summary>
    ///  MDUpdateAction MDUpdateAction Fix Tag
    /// </summary>
    Fix = 279,

    /// <summary>
    ///  New
    /// </summary>
    New = 0,

    /// <summary>
    ///  Change
    /// </summary>
    Change = 1,

    /// <summary>
    ///  Delete
    /// </summary>
    Delete = 2,

    /// <summary>
    ///  Delete Thru
    /// </summary>
    DeleteThru = 3,

    /// <summary>
    ///  Delete From
    /// </summary>
    DeleteFrom = 4,

    /// <summary>
    ///  Overlay
    /// </summary>
    Overlay = 5,

}
