using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string EmpCity { get; set; }

        public string EmpAdd { get; set; }

        public string EmpMobile { get; set; }

        public string EmpEmail{ get; set; }
    }
}
