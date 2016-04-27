using ODMCouchBaseLite.Base;

namespace ODMCouchBaseLite.Entities
{
    public class User : BaseDocument
    {
        public string Name { get; set; }

        public int Old { get; set; }
    }
}