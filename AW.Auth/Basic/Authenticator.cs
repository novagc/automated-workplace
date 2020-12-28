using System;
using System.Diagnostics.CodeAnalysis;
using AW.Data.DataBase;

namespace AW.Auth.Basic
{
    public abstract class Authenticator
    {
        protected readonly ApiDb _db;

        protected Authenticator([NotNull] ApiDb db)
        {
            _db = db ?? throw new ArgumentException();
        }

        public virtual bool Verify(string login, string password)
        {
            return false;
        }
    }
}
