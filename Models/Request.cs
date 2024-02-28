using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models
{
    public class Request
    {
        /// <summary>
        /// Код заявки
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// Код товара
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Код клиента
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Номер заявки
        /// </summary>
        public int RequesNum { get; set; }

        /// <summary>
        /// Требуемое количество
        /// </summary>
        public int RequiredQuantity { get; set; }

        /// <summary>
        /// Дата размещения
        /// </summary>
        public DateTime DateTime { get; set; }

        public override string ToString() => $"{DateTime:dd.MM.yyyy}";
    }
}
