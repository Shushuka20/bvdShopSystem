using System.Collections.Generic;

namespace Data.Entities
{
    public class Client : User
    {
        public string ClientProp { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}