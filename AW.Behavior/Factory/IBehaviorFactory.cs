using AW.Data.DataBase;
using AW.Data.Models;

namespace AW.Behavior.Factory
{
    interface IBehaviorFactory
    {
        Basic.Behavior Factory(Worker worker, ApiDb db);
        Basic.Behavior Factory(string login, ApiDb db);
    }
}
