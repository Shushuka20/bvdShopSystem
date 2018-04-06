using Base;

namespace Data.Entities
{
    public class Sale : BaseObject
    {
        public string Title { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
