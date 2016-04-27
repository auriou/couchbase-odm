using Couchbase.Lite;
using ODMCouchBaseLite.Base;
using ODMCouchBaseLite.Entities;
using ODMCouchBaseLite.Helpers;

namespace ODMCouchBaseLite.Repositories
{
    public class ViewUser : ViewBaseCollection<User>
    {
        public ViewUser(string name, Database database) : base(name, database)
        {
            var view = DB.GetExistingView(name);
            if (view == null)
            {
                view.SetMap((document, emit) => Map(DocumentHelper.GetObject<User>(document), emit), "1.0");
            }
        }
        public override void Map(User document, EmitDelegate emit)
        {
        }

        public override void Reduce()
        {
        }
    }
}