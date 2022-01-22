using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Mapper.Models
{
    public class People
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public int CarId { get; set; }
        public Car CarModel { get; set; }
    }
}
