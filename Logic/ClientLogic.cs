using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xmlController;

namespace Logic.ClientLogic
{

    /// <summary>
    /// Бизнес-логика клиентов
    /// </summary>
    public class ClientLogic : BaseLogic
    {
        public ClientLogic() { }

        /// <summary>
        /// Получение клиента
        /// </summary>
        /// <param name="Id">Идентификатор клиента</param>
        /// <returns></returns>
        public Client GetCLientData(int Id)
        {
            return new Client();
        }

        /// <summary>
        /// Обновление информации о клиенте
        /// </summary>
        /// <param name="Id">Идентификатор клиента</param>
        /// <returns></returns>
        public Client UpdateClient(int Id)
        {
            return new Client();
        }

        /// <summary>
        /// Обновление информации о клиенте
        /// </summary>
        /// <param name="Id">Идентификатор клиента</param>
        /// <returns></returns>
        public Client ChangeClientContact(string companyName, string newContact)
        {
            XMLConrtoller conrtoller = new XMLConrtoller();
            var clientsData = conrtoller.ImportClients(filePath);

            var client = clientsData.Where(s => s.Name == companyName).FirstOrDefault();
            Console.WriteLine($"Запрос на изменение контактного лица клиента.\n" + $"Название организации: {client.Name}\n" + $"ФИО контактного лица: {client.Contact}");
            client.Contact = newContact;
            Console.WriteLine($"Контактного лица клиента изменено.\n" + $"Название организации: {client.Name}\n" + $"ФИО контактного лица: {client.Contact}");
            return client;
        }

    }
}
