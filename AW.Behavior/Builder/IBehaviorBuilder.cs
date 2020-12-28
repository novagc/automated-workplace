using System;
using System.Collections.Generic;
using System.Text;
using AW.Data.DataBase;
using AW.Data.Models;

namespace AW.Behavior.Builder
{
    interface IBehaviorFactory
    {
        Basic.Behavior Factory(Worker worker, ApiDb db);
        Basic.Behavior Factory(string login, ApiDb db);
    }
}
