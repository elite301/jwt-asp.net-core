using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WCP.Auth;

namespace WCP.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public DateTime Birthday { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; } = null!;

        public IdentityUser? User { get; set; }
    }
}
