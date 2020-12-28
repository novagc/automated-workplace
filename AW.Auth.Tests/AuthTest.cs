using System.Linq;
using System.IO;
using Xunit;

namespace AW.Auth.Tests
{
    public class AuthTest
    {
        [Fact]
        public void SimpleAutentificatorTest1()
        {
            var api = new Data.DataBase.ApiDb(@$"../../../../db_example.json");
            var auth = new SimpleAuthenticator(api);

            var temp = api.GetAllWorkers().First();

            Assert.True(auth.Verify(temp.Login, temp.Password));
        }

        [Fact]
        public void SimpleAutentificatorTest2()
        {
            var api = new Data.DataBase.ApiDb(@$"../../../../db_example.json");
            var auth = new SimpleAuthenticator(api);

            var temp = api.GetAllWorkers().First();

            Assert.False(auth.Verify(temp.Login + "99", temp.Password));
        }
    }
}
