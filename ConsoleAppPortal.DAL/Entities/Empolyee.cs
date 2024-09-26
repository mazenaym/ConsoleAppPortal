using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPortal.DAL.Entities
{
    public class Empolyee
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Name is required")]
        [MaxLength(200)]

        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int  DeptId { get; set; }
    }
}
