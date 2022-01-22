using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Mapper.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(16)]
        public string Name { get; set; }
        [Required]
        [MaxLength(16)]
        public string Brand { get; set; }
        [MaxLength(32)]
        public string Description { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public ICollection<People> Peoples { get; set; }

        public override string ToString()
        {
            return $"{Name} {Brand}";
        }
    }
}
