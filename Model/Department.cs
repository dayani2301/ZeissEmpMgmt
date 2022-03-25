using System.ComponentModel.DataAnnotations;

namespace ZeissEmpMgmt.Model
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
