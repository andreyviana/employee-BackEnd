using System.ComponentModel.DataAnnotations.Schema;

namespace sampe_crud_backend.Model
{
    [Table("employee")]
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string? photoUrl { get; set; }

    }
}
