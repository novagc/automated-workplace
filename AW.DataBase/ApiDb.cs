using System;
using System.IO;
using System.Data;
using System.Linq;

using AW.Data.Models;
using AW.Data.Models.Enums;
using AW.Tools;
using Microsoft.EntityFrameworkCore;

namespace AW.Data.DataBase
{
    public class ApiDb
    {
        private readonly Config _config;

        public ApiDb(string configPath)
        {
            if(string.IsNullOrEmpty(configPath) || !File.Exists(configPath))
                throw new ArgumentException("Указан некорректный путь до файла настроек БД");

            _config = ProviderJson.DeserializeJsonFile<Config>(configPath);

            if (_config == null)
                throw new DataException("Не удалось считать файл настроект БД");

            using var ctx = new PostgresContext(_config);
            ctx.SaveChanges();
        }

        public Order[] GetAllOrders()
        {
            using var ctx = new PostgresContext(_config);
            return ctx.Orders.AsNoTracking().Where(x => x.Status != Status.Archived).ToArray();
        }

        public Worker[] GetAllWorkers()
        {
            using var ctx = new PostgresContext(_config);
            return ctx.Workers.ToArray();
        }

        public int AddNewWorker(Worker worker)
        {
            if (worker.Validate())
            {
                using var ctx = new PostgresContext(_config);
                ctx.Workers.Add(worker);
                ctx.SaveChanges();
                return worker.Id;
            }
            else
            {
                throw new ArgumentException("{eq");
            }
        }

        public int AddNewOrder(Order order)
        {
            if (order.Validate())
            {
                using var ctx = new PostgresContext(_config);

                order.Description ??= "";

                ctx.Orders.Add(order);
                ctx.SaveChanges();
                return order.Id;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void UpdateWorkerInfo(Worker worker)
        {
            if (worker.Validate())
            {
                using var ctx = new PostgresContext(_config);
                var temp = ctx.Workers.Find(worker.Id);

                temp.FirstName = worker.FirstName;
                temp.MiddleName = worker.MiddleName;
                temp.LastName = worker.LastName;
                temp.Password = string.IsNullOrEmpty(worker.Password) ? temp.Password : worker.Password;

                ctx.SaveChanges();
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void UpdateOrderInfo(Order order)
        {
            if (order.Validate())
            {
                using var ctx = new PostgresContext(_config);
                var temp = ctx.Orders.Find(order.Id);

                temp.Title = order.Title;
                temp.Description = order.Description;
                temp.Updated = DateTime.Now;
                temp.Price = order.Price;

                ctx.SaveChanges();
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void ChangeOrderStatus(int orderId, Status status)
        {
            using var ctx = new PostgresContext(_config);
            var temp = ctx.Orders.Find(orderId);
            
            if (temp != null)
            {
                temp.Status = status;
                ctx.SaveChanges();
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void SerWorkerToOrder(int orderId, int workerId)
        {
            using var ctx = new PostgresContext(_config);
            var tempOrder = ctx.Orders.Find(orderId);
            var tempWorker = ctx.Workers.Find(workerId);

            if(tempOrder == null || tempWorker == null)
                throw new ArgumentException();

            tempOrder.WorkerId = workerId;
            ctx.SaveChanges();
        }

        public Worker[] GetAllTechnician()
        {
            using var ctx = new PostgresContext(_config);
            return ctx.Workers.AsNoTracking().Where(x => x.Role == Role.Technician).ToArray();
        }

        public Order[] GetAllOrdersByCreator(int creatorId)
        {
            using var ctx = new PostgresContext(_config);
            return ctx.Orders
                .AsNoTracking()
                .Where(x => x.Status != Status.Archived)
                .Where(x => x.CreatorId == creatorId)
                .ToArray();
        }

        public Order[] GetAllOrdersByWorker(int workerId)
        {
            using var ctx = new PostgresContext(_config);
            return ctx.Orders
                .AsNoTracking()
                .Where(x => x.Status != Status.Archived)
                .Where(x => x.WorkerId == workerId)
                .ToArray();
        }

        public Worker FindWorkerByLogin(string login)
        {
            if (string.IsNullOrEmpty(login))
                throw new ArgumentException();

            using var ctx = new PostgresContext(_config);
            return ctx.Workers.AsNoTracking().FirstOrDefault(x => x.Login == login);
        }

        public Worker FindWorkerById(int workerId)
        {
            using var ctx = new PostgresContext(_config);
            return ctx.Workers.Find(workerId);
        }

        public Order FindOrderById(int orderId)
        {
            using var ctx = new PostgresContext(_config);
            return ctx.Orders.Find(orderId);
        }
    }
}
