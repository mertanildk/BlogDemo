using Core.Entites;


namespace Entities.Concrete
{
    public class BlogRayting:IEntity
    {
        public int BlogRaytingId { get; set; }
        public int BlogId { get; set; }
        public int BlogTotalScore { get; set; }
        public int BlogRaytingCount { get; set; }

    }
}
