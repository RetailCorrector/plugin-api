namespace RetailCorrector
{
    /// <summary>
    /// Статус смены
    /// </summary>
    public enum SessionStatus 
    { 
        /// <summary>
        /// Смена закрыта
        /// </summary>
        Closed, 
        /// <summary>
        /// Смена открыта
        /// </summary>
        Opened, 
        /// <summary>
        /// Смена просрочена (открыта более 24 часов)
        /// </summary>
        Expired 
    }
}
