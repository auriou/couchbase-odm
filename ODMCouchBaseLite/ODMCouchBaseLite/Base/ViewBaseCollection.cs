using Couchbase.Lite;

namespace ODMCouchBaseLite.Base
{
    public abstract class ViewBaseCollection<T> : BaseCollection<T> where T : BaseDocument, new()
    {
        protected ViewBaseCollection(string name, Database database) : base(name, database)
        {
        }
        public abstract void Map(T document, EmitDelegate emit);
        public abstract void Reduce();
    }
}