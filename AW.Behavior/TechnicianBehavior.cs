using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using AW.Data.DataBase;
using AW.Data.Models;
using AW.Data.Models.Enums;

namespace AW.Behavior
{
    public class TechnicianBehavior: Basic.Behavior
    {
        public TechnicianBehavior(Worker worker, ApiDb db) :base(worker, db) { }

        public override Order[] GetOrders()
        {
            return _db.GetAllOrdersByWorker(Worker.Id);
        }

        public override Worker[] GetWorkers()
        {
            return new[] {Worker};
        }

        public override int CreateOrder(string title, string description, uint price)
        {
            return _db.AddNewOrder(new Order
            {
                Title = title,
                Description = description,
                Price = price,
                Created = DateTime.Now,
                Updated = DateTime.Now,
                CreatorId = Worker.Id,
                Status = Status.Created,
                WorkerId = Worker.Id
            });
        }

        public override void SetWorker(int orderId, int workerId)
        {
            throw new SecurityException("Недостаточно прав");
        }

        public override void AcceptOrder(int orderId)
        {
            _db.ChangeOrderStatus(orderId, Status.InWork);
        }

        public override void FinishOrder(int orderId)
        {
            _db.ChangeOrderStatus(orderId, Status.Finished);
        }

        public override void ArchiveOrder(int orderId)
        {
            _db.ChangeOrderStatus(orderId, Status.Archived);
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
