using Limbo.Entities.Abstract;

namespace Limbo.Entities.Concrete
{
    public class Department:IEntity
    {
        public int Id { get; set; }
        public int UniversityId { get; set; }
        public string Name { get; set; }
        public double Point { get; set; }
    }
}
