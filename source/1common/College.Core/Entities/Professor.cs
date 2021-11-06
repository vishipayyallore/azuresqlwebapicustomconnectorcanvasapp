using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace College.Core.Entities
{

    public class Professor
    {
        [Key]
        public Guid ProfessorId { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime Doj { get; set; }

        public string Teaches { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        public bool IsPhd { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Rating { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }

}
