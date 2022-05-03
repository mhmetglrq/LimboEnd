using Limbo.Entities.Abstract;

namespace Limbo.Entities.Concrete
{
    public class University:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string City { get; set; }
        public double Point { get; set; }
        public string Logo { get; set; }
    }
}
