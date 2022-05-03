using System.ComponentModel.DataAnnotations;
using Limbo.Entities.Abstract;

namespace Limbo.Entities.Concrete
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        [Required]
        public string Context { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Name { get; set; }
        public double Point { get; set; }
    }
}
