
namespace OfferService.Domain
{
    public class Offer
    {
        public int id { get; set; }
        public int ownerId { get; set; }
        public int minCount { get; set; }
        public int count { get; set; }
        public decimal price { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }

    }
}
