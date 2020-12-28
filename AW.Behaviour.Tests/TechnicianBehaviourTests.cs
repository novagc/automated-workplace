using System.Linq;
using Xunit;

namespace AW.Behaviour.Tests
{
    public class TechnicianBehaviourTests
    {
        Data.DataBase.ApiDb api;

        private Behavior.TechnicianBehavior Init()
        {
            api = new Data.DataBase.ApiDb(@$"../../../../db_example.json");

            try
            {
                api.AddNewWorker(new Data.Models.Worker
                {
                    FirstName = "A1",
                    MiddleName = "AA1",
                    LastName = "AAA1",
                    Login = "a1",
                    Password = "1",
                    Role = Data.Models.Enums.Role.Technician
                });
                api.AddNewWorker(new Data.Models.Worker
                {
                    FirstName = "A2",
                    MiddleName = "AA2",
                    LastName = "AAA2",
                    Login = "a2",
                    Password = "2",
                    Role = Data.Models.Enums.Role.Technician
                });
                api.AddNewWorker(new Data.Models.Worker
                {
                    FirstName = "A3",
                    MiddleName = "AA3",
                    LastName = "AAA3",
                    Login = "a3",
                    Password = "3",
                    Role = Data.Models.Enums.Role.Manager
                });
            }
            catch
            {

            }

            return new Behavior.TechnicianBehavior(
                            api.GetAllWorkers().Where(x => x.Role == Data.Models.Enums.Role.Technician).ToList()[0], api);
        }

        [Fact]
        public void CreateOrderTest()
        {
            var bhv = Init();
            var id = bhv.CreateOrder("test", "test", 200);

            var order = api.FindOrderById(id);
            bool b = order.Title == "test" && order.Description == "test" &&
                order.Price == 200 && order.CreatorId == bhv.GetWorkerInfo().Id;

            Assert.True(b);
        }

        [Fact]
        public void UpdateOrderInfoTest()
        {
            var bhv = Init();
            var id = bhv.CreateOrder("test", "test", 200);

            bhv.UpdateOrderInfo(id, "test2", "test2", 300);
            var order = api.FindOrderById(id);

            bool b = order.Title == "test2" && order.Description == "test2" && order.Price == 300;
            Assert.True(b);
        }
    }
}
