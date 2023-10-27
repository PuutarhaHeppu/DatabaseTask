using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Specialist
    {
        [Key]
        public Guid Id { get; set; }
        public string Speciality { get; set; }

        public IEnumerable<Employee> Employees { get; set; } = new List<Employee>();
    }
}
