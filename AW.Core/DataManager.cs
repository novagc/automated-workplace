using AW.Auth;
using AW.Auth.Basic;
using AW.Behavior.Builder;
using AW.Data.DataBase;
using AW.Data.Models;
using AW.Data.Models.Enums;
using System.IO;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace AW.Core
{
    public class DataManager
    {
        private Behavior.Basic.Behavior _bh;
        private Authenticator auth;

        public DataManager(string login, string password)
        {
            var _db = new ApiDb($"{Directory.GetCurrentDirectory()}/configs/db.json");

#if DEBUG
            try
            {
                _db.AddNewWorker(new Worker
                {
                    FirstName = "A1",
                    MiddleName = "AA1",
                    LastName = "AAA1",
                    Login = "a1",
                    Password = "1",
                    Role = Role.Technician
                });
                _db.AddNewWorker(new Worker
                {
                    FirstName = "A2",
                    MiddleName = "AA2",
                    LastName = "AAA2",
                    Login = "a2",
                    Password = "2",
                    Role = Role.Technician
                });
                _db.AddNewWorker(new Worker
                {
                    FirstName = "A3",
                    MiddleName = "AA3",
                    LastName = "AAA3",
                    Login = "a3",
                    Password = "3",
                    Role = Role.Manager
                });
            }
            catch
            {

            }
#endif

            auth = new SimpleAuthenticator(_db);

            if (!auth.Verify(login, password))
            {
                throw new AuthenticationException("Неверный логин или пароль");
            }

            _bh = new BehaviorFactory().Factory(login, _db);
        }

        public Task<Order[]> GetOrdersAsync() => Task.Factory.StartNew(() => _bh.GetOrders());

        public Task<Worker[]> GetWorkersAsync() => Task.Factory.StartNew(() => _bh.GetWorkers());

        public Task<int> CreateOrderAsync(string title, string description, uint price) 
            => Task.Factory.StartNew(() => _bh.CreateOrder(title, description, price));

        public Task SetWorkerAsync(int orderId, int workerId) => Task.Factory.StartNew(() => _bh.SetWorker(orderId, workerId));

        public Task AcceptOrderAsync(int orderId) => Task.Factory.StartNew(() => _bh.AcceptOrder(orderId));

        public Task FinishOrderAsync(int orderId) => Task.Factory.StartNew(() => _bh.FinishOrder(orderId));

        public Task ArchiveOrderAsync(int orderId) => Task.Factory.StartNew(() => _bh.ArchiveOrder(orderId));

        public Task UpdateOrderInfoAsync(int orderId, string title, string description, uint price)
            => Task.Factory.StartNew(() => _bh.UpdateOrderInfo(orderId, title, description, price));

        public Task UpdateWorkerInfoAsync(string password, string fName, string mName, string lName)
            => Task.Factory.StartNew(() => _bh.UpdateWorkerInfo(password, fName, mName, lName));

        public Task<Order> GetOrderInfo(int orderId) => Task.Factory.StartNew(() => _bh.GetOrderInfo(orderId));

        public Task<Worker> GetWorkerInfoAsync() => Task.Factory.StartNew(() => _bh.GetWorkerInfo());
    }
}
