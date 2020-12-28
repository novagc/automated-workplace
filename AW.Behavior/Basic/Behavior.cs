using System;
using AW.Data.DataBase;
using AW.Data.Models;

namespace AW.Behavior.Basic
{
    public abstract class Behavior
    {
        protected Worker Worker { get; private set; }
        protected readonly ApiDb _db;

        protected Behavior(Worker worker, ApiDb db)
        {
            if (worker == null || db == null)
                throw new ArgumentException();

            Worker = worker;
            _db = db;
        }

        public abstract Order[] GetOrders();

        public abstract Worker[] GetWorkers();

        public abstract int CreateOrder(string title, string description, uint price);

        public abstract void SetWorker(int orderId, int workerId);

        public abstract void AcceptOrder(int orderId);

        public abstract void FinishOrder(int orderId);

        public abstract void ArchiveOrder(int orderId);

        public abstract void UpdateOrderInfo(int orderId, string title, string description, uint price);

        public virtual void UpdateWorkerInfo(string password, string fName, string mName, string lName)
        {
            _db.UpdateWorkerInfo(new Worker
            {
                Id = Worker.Id,
                FirstName = fName,
                MiddleName = mName,
                LastName = lName,

                Password = password
            });

            Worker = _db.FindWorkerById(Worker.Id);
        }

        public virtual Order GetOrderInfo(int orderId)
        {
            return _db.FindOrderById(orderId);
        }

        public virtual Worker GetWorkerInfo()
        {
            return Worker.Copy();
        }
    }
}
