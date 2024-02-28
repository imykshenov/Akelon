using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Product;
using DocumentFormat.OpenXml;
using Models.Client;
using Models.Request;
using Models.Product;

namespace xmlController
{
    public class XMLConrtoller
    {
        /// <summary>
        /// Импорт
        /// </summary>
        public List<Product> ImportProducts(string filePath) 
        {
            List<Product> products = new List<Product>();
            var workbook = new XLWorkbook(filePath);
            var rows = workbook.Worksheet(1).RangeUsed().RowsUsed().Skip(1);

            foreach (var row in rows)
            {
                var productInfo = new Product()
                {
                    Id = Convert.ToInt32(row.Cell(1).Value.ToString()),
                    Name = row.Cell(2).Value.ToString(),
                    Price = Convert.ToDecimal(row.Cell(4).Value.ToString()),
                };

                switch (row.Cell(3).Value.ToString())
                {
                    case "Литр":
                        productInfo.Unit = UnitType.Liter;
                        break;
                    case "Штука":
                        productInfo.Unit = UnitType.Piece;
                        break;
                    case "Килограмм":
                        productInfo.Unit = UnitType.Kilogram;
                        break;
                }
                products.Add(productInfo);
            }

            return products;
        }
        
        /// <summary>
        /// Импорт клиентов
        /// </summary>
        public List<Client> ImportClients(string filePath) 
        {
            List<Client> products = new List<Client>();
            var workbook = new XLWorkbook(filePath);
            var rows = workbook.Worksheet(2).RangeUsed().RowsUsed().Skip(1);
            foreach (var row in rows)
            {
                var clientInfo = new Client()
                {
                    Id = Convert.ToInt32(row.Cell(1).Value.ToString()),
                    Name = row.Cell(2).Value.ToString(),
                    FullAddress = row.Cell(3).Value.ToString(),
                    Contact = row.Cell(4).Value.ToString(),
                };
                products.Add(clientInfo);
            }

            return products;
        }
        
        /// <summary>
        /// Импорт заявок
        /// </summary>
        public List<Request> ImportRequests(string filePath) 
        {
            List<Request> requests = new List<Request>();
            var workbook = new XLWorkbook(filePath);
            var rows = workbook.Worksheet(3).RangeUsed().RowsUsed().Skip(1);
            foreach (var row in rows)
            {
                var request = new Request()
                {
                    RequestId = Convert.ToInt32(row.Cell(1).Value.ToString()),
                    ProductId = Convert.ToInt32(row.Cell(2).Value.ToString()),
                    ClientId = Convert.ToInt32(row.Cell(3).Value.ToString()),
                    RequesNum = Convert.ToInt32(row.Cell(4).Value.ToString()),
                    RequiredQuantity = Convert.ToInt32(row.Cell(5).Value.ToString()),
                    DateTime = Convert.ToDateTime(row.Cell(6).Value.ToString()) // нужно указать регион
                };
                requests.Add(request);
            }
            return requests;
        }

        /// <summary>
        /// Экспорт
        /// </summary>
        public List<Product> Export(XLWorkbook workbook)
        {
            return new List<Product>();
        }
    }
}
