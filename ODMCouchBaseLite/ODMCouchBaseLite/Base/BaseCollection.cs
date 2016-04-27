using Couchbase.Lite;

namespace ODMCouchBaseLite.Base
{
    public abstract class BaseCollection<T> where T : BaseDocument, new()
    {
        protected Database _database;
        protected string _name;
        public string Name { get { return _name; } }
        protected Database DB { get { return _database; } }

        protected BaseCollection()
        {
            
        }

        protected BaseCollection(string name, Database database)
        {
            Init(name, database);
        }

        public void Init(string name, Database database)
        {
            _name = name;
            _database = database;
        }
    }
}