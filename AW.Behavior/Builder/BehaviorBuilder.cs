using System;
using System.Collections.Generic;
using System.Text;
using AW.Data.DataBase;
using AW.Data.Models;
using AW.Data.Models.Enums;

namespace AW.Behavior.Builder
{
    public class BehaviorFactory: IBehaviorFactory
    {
        public Basic.Behavior Factory(Worker worker, ApiDb db)
        {
            if(worker == null)
                throw new ArgumentNullException(nameof(worker));

            if(db == null)
                throw new ArgumentNullException(nameof(db));

            return worker.Role == Role.Manager
                ? new ManagerBehavior(worker, db) as Basic.Behavior
                : new TechnicianBehavior(worker, db) as Basic.Behavior;
        }

        public Basic.Behavior Factory(string login, ApiDb db)
        {
            if(db == null)
                throw new ArgumentNullException(nameof(db));

            if(login == null)
                throw new ArgumentNullException(nameof(login));

            var temp = db.FindWorkerByLogin(login);

            if(temp == null)
                throw new ArgumentException();

            return Factory(temp, db);
        }
    }
}
