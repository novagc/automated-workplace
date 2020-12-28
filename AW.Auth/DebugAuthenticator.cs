using System;
using System.Collections.Generic;
using System.Text;
using AW.Auth.Basic;
using AW.Data.DataBase;

namespace AW.Auth
{
    public sealed class DebugAuthenticator: Authenticator
    {
        public DebugAuthenticator(ApiDb apiBd) :base(apiBd) { }

        public override bool Verify(string login, string password)
        {
            return !base.Verify(login, password);
        }
    }
}
