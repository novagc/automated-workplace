using System.IO;
using Xunit;

namespace AW.Tools.Tests
{
    public class ProviderJsonTests
    {
        [Fact]
        public void DeserializeJsonFileTest()
        {
            var temp = ProviderJson.DeserializeJsonFile<Data.DataBase.Config>(@$"../../../../db_example.json");
            Assert.NotNull(temp);
        }

        [Fact]
        public void SerializeToJsonFileTest()
        {
            var temp = new Data.DataBase.Config();
            temp.Host = "Vladislav";
            ProviderJson.SerializeToJsonFile<Data.DataBase.Config>(temp, $@"./temp.json");

            var temp_2 = ProviderJson.DeserializeJsonFile<Data.DataBase.Config>($@"./temp.json");
            Assert.Equal("Vladislav", temp_2.Host);

            File.Delete($@"./temp.json");
        }
    }
}
