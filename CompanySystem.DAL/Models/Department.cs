namespace CompanySystem.BLL.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime CreateAt { get; set; }
    }
}
