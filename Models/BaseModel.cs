using System;
namespace Models
{
    /// <summary>
    /// Базовая модель
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// Код товара
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
    }
}
