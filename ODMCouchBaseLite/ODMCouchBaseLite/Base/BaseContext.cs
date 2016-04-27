using Couchbase.Lite;
using ODMCouchBaseLite.Base;

namespace ODMCouchBaseLite
{
    public abstract class BaseContext
    {
        protected string DataBaseName { get; set; }
        protected BaseContext(string namedb)
        {
            DataBaseName = namedb;
        }

        protected Database Database
        {
            get
            {
                return Manager.SharedInstance.GetExistingDatabase(DataBaseName);
            }
        }
    }
}