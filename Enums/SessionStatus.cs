namespace RetailCorrector
{
    /// <summary>
    /// Статус смены
    /// </summary>
    public enum SessionStatus 
    { 
        /// <summary>
        /// Неизвестно
        /// </summary>
        Unknown = -1,
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
