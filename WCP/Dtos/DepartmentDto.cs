using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WCP.Models;

namespace WCP.Dtos
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<EmployeeDto> Employees { get; } = new List<EmployeeDto>();
    }
}
