using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2016.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Models;
using Models.Product;
using xmlController;
using Logic.ClientLogic;
using Logic.ProductLogic;
using Logic.RequestLogic;

namespace PracticTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientLogic clientLogic = new ClientLogic();
            RequestLogic requestLogic = new RequestLogic();

            requestLogic.FindClientOrders("Чай");
            var client = clientLogic.ChangeClientContact("ООО Надежда", "Новый контакт");
            var goldenConsumer = requestLogic.GetGoldenConsumer(new DateTime(2023,5,1));
        }

    }
}
