namespace Models.Client
{
    /// <summary>
    /// Данные клиента
    /// </summary>
    public class Client : BaseModel
    {
        /// <summary>
        /// Адрес
        /// </summary>
        public string FullAddress { get; set; }

        /// <summary>
        /// Контактное лицо(ФИО)
        /// </summary>
        public string Contact { get; set; }
    }
}
