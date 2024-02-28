namespace Models.Product
{
    /// <summary>
    /// Информация о товаре
    /// </summary>
    public class Product : BaseModel
    {
        /// <summary>
        /// Единица измерения
        /// </summary>
        public UnitType Unit { get; set; }

        /// <summary>
        /// Цена за едницу измерения 
        /// </summary>
        public decimal Price { get; set; }
    }

    /// <summary>
    /// Единица измерения
    /// </summary>
    public enum UnitType
    {
        /// <summary>
        /// Литр
        /// </summary>
        Liter = 1,
        /// <summary>
        /// Штука
        /// </summary>
        Piece = 2,
        /// <summary>
        /// Килограмм
        /// </summary>
        Kilogram = 3,
    }
}
