using System.Linq;
using Xunit;

namespace AW.Data.DataBase.Tests
{
    public class DataBaseTests
    {
        Data.DataBase.ApiDb api;

        private void Init()
        {
            api = new Data.DataBase.ApiDb(@$"../../../../db_example.json");

            try
            {
                api.AddNewWorker(new Models.Worker
                {
                    FirstName = "A1",
                    MiddleName = "AA1",
                    LastName = "AAA1",
                    Login = "a1",
                    Password = "1",
                    Role = Models.Enums.Role.Technician
                });
                api.AddNewWorker(new Models.Worker
                {
                    FirstName = "A2",
                    MiddleName = "AA2",
                    LastName = "AAA2",
                    Login = "a2",
                    Password = "2",
                    Role = Models.Enums.Role.Technician
                });
                api.AddNewWorker(new Models.Worker
                {
                    FirstName = "A3",
                    MiddleName = "AA3",
                    LastName = "AAA3",
                    Login = "a3",
                    Password = "3",
                    Role = Models.Enums.Role.Manager
                });
            }
            catch
            {

            }
        }

        private (Models.Order, Models.Order) CreateAndGetOrder()
        {
            Init();

            var order = new Models.Order
            {
                Title = "test",
                Description = "test",
                Price = 100500,
                CreatorId = api.GetAllWorkers().First().Id,
                Status = Models.Enums.Status.Created
            };

            var id = api.AddNewOrder(order);
            var order_2 = api.FindOrderById(id);

            return (order, order_2);
        }

        [Fact]
        public void AddNewOrderTest()
        {
            var orders = CreateAndGetOrder();

            bool b = orders.Item1.Title == orders.Item2.Title && orders.Item1.Description == orders.Item2.Description &&
                     orders.Item1.Price == orders.Item2.Price && orders.Item1.CreatorId == orders.Item2.CreatorId &&
                     orders.Item1.Status == orders.Item2.Status;

            Assert.True(b);
        }

        [Fact]
        public void ChangeOrderStatusTest()
        {
            var orders = CreateAndGetOrder();

            api.ChangeOrderStatus(orders.Item2.Id, Models.Enums.Status.Finished);
            var order = api.FindOrderById(orders.Item2.Id);

            Assert.True(order.Status == Models.Enums.Status.Finished);
        }

        [Fact]
        public void SetWorkerToOrderTest()
        {
            var orders = CreateAndGetOrder();

            api.SerWorkerToOrder(orders.Item2.Id, api.GetAllWorkers().First().Id);
            var order = api.FindOrderById(orders.Item2.Id);

            Assert.True(order.WorkerId == api.GetAllWorkers().First().Id);
        }
    }
}
