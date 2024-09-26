using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPortal.DAL.Entities
{
    [Table("Deapartment")]
    public class Department
    {
        [Required]
        public int id { get; set; }
        public  string Name { get; set; }
        public List<Empolyee>Empolyees { get; set; }
    }
}
