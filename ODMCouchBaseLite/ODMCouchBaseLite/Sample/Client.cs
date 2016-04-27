using ODMCouchBaseLite.Entities;
using ODMCouchBaseLite.Repositories;

namespace ODMCouchBaseLite.Sample
{
    public class Client
    {
        public void Test()
        {
            var context = new SampleContext("mabase");
            var user = context.UserCollection.FindById("id");
            var name = user.Name;
        }
    }

    public class SampleContext : BaseContext
    {
        public SampleContext(string namedb) : base(namedb)
        {
            UserCollection = new UserCollection("User", Database);
        }
        public UserCollection UserCollection { get; private set; }

    }
}