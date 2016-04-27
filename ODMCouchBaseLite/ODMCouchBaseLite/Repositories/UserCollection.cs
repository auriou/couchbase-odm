using Couchbase.Lite;
using ODMCouchBaseLite.Base;
using ODMCouchBaseLite.Entities;

namespace ODMCouchBaseLite.Repositories
{
    public class UserCollection : DocumentBaseCollection<User>
    {
        public UserCollection(string name, Database database) : base(name, database)
        {
        }
    }
}