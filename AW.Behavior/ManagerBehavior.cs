using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using AW.Data.DataBase;
using AW.Data.Models;
using AW.Data.Models.Enums;
using AW.Behavior.Basic;

namespace AW.Behavior
{
    public sealed class ManagerBehavior: Basic.Behavior
    {
        public ManagerBehavior(Worker worker, ApiDb db) : base(worker, db) { }

        public override Order[] GetOrders()
        {
            return _db.GetAllOrders();
        }

        public override Worker[] GetWorkers()
        {
            return _db.GetAllWorkers().Where(x => x.Role == Role.Technician).ToArray();
        }

        public override int CreateOrder(string title, string description, uint price)
        {
            return _db.AddNewOrder(new Order {
                Title = title,
                Description = description,
                Price = price,
                Created = DateTime.Now,
                Updated = DateTime.Now,
                CreatorId = Worker.Id,
                Status = Status.Created
            });
        }

        public override void AcceptOrder(int orderId)
        {
            throw new SecurityException("Недостаточно прав");
        }

        public override void SetWorker(int orderId, int workerId)
        {
            var temp = _db.FindWorkerById(workerId);

            if (temp?.Role == Role.Manager)
                throw new ArgumentException();

            _db.SetWorkerToOrder(orderId, workerId);
        }

        public override void FinishOrder(int orderId)
        {
            throw new SecurityException("Недостаточно прав");
        }

        public override void ArchiveOrder(int orderId)
        {
            throw new SecurityException("Недостаточно прав");
        }

        public override void UpdateOrderInfo(int orderId, string title, string description, uint price)
        {
            _db.UpdateOrderInfo(new Order
            {
                Id = orderId,
                Title = title,
                Description = description,
                Price = price,
                Created = DateTime.Now,
                Updated = DateTime.Now,
                CreatorId = Worker.Id,
            });
        }
    }
}
