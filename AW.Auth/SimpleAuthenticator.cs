using System;
using System.Collections.Generic;
using System.Text;
using AW.Auth.Basic;
using AW.Data.DataBase;

namespace AW.Auth
{
    public class SimpleAuthenticator: Authenticator
    {
        public SimpleAuthenticator(ApiDb apiDb) : base(apiDb) { }

        public override bool Verify(string login, string password)
        {
            var temp = _db.FindWorkerByLogin(login);

            return temp != null && temp.Password == password;
        }
    }
}
