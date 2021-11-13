using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Core.Entities
{
    public class Product
    {

        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Rating { get; set; }

        public string ImageUrl { get; set; } = string.Empty;
    }

}
