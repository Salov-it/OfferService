
namespace OfferService.persistance
{
    public class DbInit
    {
        public static void init(OfferContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
