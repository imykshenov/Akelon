using Logic.ClientLogic;
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
