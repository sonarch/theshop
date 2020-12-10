namespace SHOP.Infrastructure.Entities
{
    public class Category : GuidEntity
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }
    }
}
