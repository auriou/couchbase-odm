using System.Linq;
using System.Reflection;
using Couchbase.Lite;
using ODMCouchBaseLite.Helpers;

namespace ODMCouchBaseLite.Base
{
    public abstract class DocumentBaseCollection<T> : BaseCollection<T> where T : BaseDocument, new()
    {

        protected DocumentBaseCollection(string name, Database database) : base(name, database)
        {

        }

        public T FindById(string id)
        {
            var doc = DB.GetExistingDocument(id);
            var res = DocumentHelper.GetObject<T>(doc.Properties);
            return res;
        }

        public string Save(T document)
        {
            var doc = DB.GetExistingDocument(document.Key);
            if (doc == null)
            {
                doc = DB.GetDocument(document.Key);
            }
            var dict = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(p => p.Name != "Key")
                .ToDictionary(prop => prop.Name, prop => prop.GetValue(document, null));


            doc.PutProperties(dict);
            return document.Key;
        }

        #region extract object

        #endregion
    }
}