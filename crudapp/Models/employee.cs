using System.ComponentModel.DataAnnotations;

namespace crudapp.Models
{
    public class employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }

    }
}
