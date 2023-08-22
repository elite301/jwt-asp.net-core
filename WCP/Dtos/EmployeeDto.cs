using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WCP.Models
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? Birthday { get; set; }
        public int? DepartmentId { get; set; }
    }
}
