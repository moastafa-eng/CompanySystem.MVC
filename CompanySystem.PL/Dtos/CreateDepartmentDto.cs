using System.ComponentModel.DataAnnotations;

namespace CompanySystem.PL.Dtos
{
    public class CreateDepartmentDto
    {
        [Required(ErrorMessage = "Code is required.")]
        public string Code { get; set; } = null!;

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Start date is required.")]
        public DateTime CreateAt { get; set; }
    }
}
