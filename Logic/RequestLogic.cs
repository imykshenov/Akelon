using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xmlController;

namespace Logic.RequestLogic
{
    public class RequestLogic : BaseLogic
    {
        public RequestLogic() { }

        /// <summary>
        /// Получение заказа
        /// </summary>
        /// <param name="Id">Идентификатор заказа</param>
        /// <returns></returns>
        public Request GetRequest(int Id)
        {
            return new Request();
        }

        /// <summary>
        /// Получение списка заказов
        /// </summary>
        /// <returns></returns>
        public List<Request> GetRequests()
        {
            return new List<Request>();
        }

        /// <summary>
        /// Получение золотого клиента
        /// </summary>
        /// <param name="dateTime">год и месяц</param>
        /// <returns></returns>
        public Client GetGoldenConsumer(DateTime dateTime)
        {
            XMLConrtoller conrtoller = new XMLConrtoller();
            var clientsData = conrtoller.ImportClients(filePath);
            var requestsData = conrtoller.ImportRequests(filePath);


            var clientsGroup = requestsData.Where(r => r.DateTime.Year == dateTime.Year && r.DateTime.Month == dateTime.Month)
                               .GroupBy(r => r.ClientId)
                               .OrderByDescending(g => g.Sum(r => r.RequiredQuantity))
                               .First()
                               .Key;

            return clientsData.Where(s=>s.Id == clientsGroup).FirstOrDefault();
        }

        /// <summary>
        /// По наименованию товара выводить информацию о клиентах, заказавших этот товар, с указанием информации по количеству товара, цене и дате заказа
        /// </summary>
        /// <param name="productName">Наименование товара</param>
        public void FindClientOrders(string productName)
        {
            XMLConrtoller conrtoller = new XMLConrtoller();
            var productsData = conrtoller.ImportProducts(filePath);
            var clientsData = conrtoller.ImportClients(filePath);
            var requestsData = conrtoller.ImportRequests(filePath);

            var product = productsData.Where(s => s.Name == productName).FirstOrDefault();

            List<Request> requests = requestsData.Where(s => s.ProductId == product.Id).ToList();
            foreach (Request request in requests)
            {
                var client = clientsData.Where(s => s.Id == request.ClientId).FirstOrDefault();
                Console.WriteLine($"Клиент {client.Name} \nТовар {product.Name} x {request.RequiredQuantity} = {request.RequiredQuantity * product.Price} \nДата {request.DateTime}");
            }
        }
    }
}
