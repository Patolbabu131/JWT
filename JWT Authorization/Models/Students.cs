using System.ComponentModel.DataAnnotations;

namespace JWT_Authorization.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
